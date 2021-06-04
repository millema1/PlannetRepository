﻿using Newtonsoft.Json;
using PlannetRepository.Entities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PlannetRepository.DAL.Repositories
{
    public class TrainingRepository : WebRepository<Training>, ITrainingRepository
    {
        public TrainingRepository() : base ("trainings")
        {

        }

        public async Task UpdateAsync(Training item)
        {
            string content = JsonConvert.SerializeObject(item);
            HttpContent httpContent = new StringContent(content, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"/{repositoryName}/{item.Id}", httpContent);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException("not updated");
            }
        }

        public Training GetBestTraining()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Training>> GetTrainingsAsync(int page, int numElem)
        {
            IEnumerable<Training> ret = null;
            var response = await client.GetAsync($"/{repositoryName}?_page={page}&_limit={numElem}");
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                ret = JsonConvert.DeserializeObject<IEnumerable<Training>>(json);
            }

            return ret;
        }
    }
}
