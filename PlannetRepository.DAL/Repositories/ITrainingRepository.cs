using PlannetRepository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlannetRepository.DAL.Repositories
{
    interface ITrainingRepository: IRepository<Training>
    {
        Training GetBestTraining();
    }
}
