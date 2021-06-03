using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;

namespace PlannetRepository.DAL.Repositories
{
    public class WebRepository<T> : IRepository<T> where T : Entities.Entity
    {
        protected HttpClient client;
        protected string repositoryName;

        public WebRepository(string name)
        {
            client = HttpClientFactory.GetClient();
            repositoryName = name;
        }

        public async Task AddAsync(T item)
        {
            string content = JsonConvert.SerializeObject(item);
            HttpContent httpContent = new StringContent(content, Encoding.UTF8, "application/json"); 
            
            var response = await client.PostAsync($"/{repositoryName}", httpContent);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException("not updated");
            }
        }

        public async Task<IEnumerable<T>> FindAsync(Func<T, bool> predicate)
        {
            var all = await GetAllAsync();
            return all.Where(predicate ?? (item => true));
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            IEnumerable<T> ret = null;
            var response = await client.GetAsync($"/{repositoryName}");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                ret = JsonConvert.DeserializeObject<IEnumerable<T>>(json);
            }

            return ret;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            T ret = null;
            var response = await client.GetAsync($"/{repositoryName}/{id}");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                ret = JsonConvert.DeserializeObject<T>(json);
            }

            return ret;
        }

        public async Task RemoveAsync(int id)
        {
            var response = await client.DeleteAsync($"/{repositoryName}/{id}");
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException("not updated");
            }
        }
    }
}
