using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlannetRepository.DAL.Repositories
{
    public class FileRepository<T> : IRepository<T> where T : class
    {
        public Task AddAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindAsync(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
