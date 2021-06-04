using PlannetRepository.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlannetRepository.DAL.Repositories
{
    interface ITrainingRepository: IRepository<Training>
    {
        Training GetBestTraining();

        Task<IEnumerable<Training>> GetTrainingsAsync(int start, int end);
    }
}
