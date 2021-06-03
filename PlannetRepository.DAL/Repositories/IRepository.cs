using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PlannetRepository.DAL.Repositories
{
    public interface IRepository<T> where T: class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindAsync(Func<T, bool> predicate);
        Task AddAsync(T item);
        Task RemoveAsync(int id);
        
        //... altri metodi a piacere che ricorrono nelle attività (e.g. AddRange, RemoveRange, Single, ....)
    }
}
