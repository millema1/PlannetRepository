using PlannetRepository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlannetRepository.DAL.Repositories
{
    interface IUserRepository : IRepository<User>
    {
        bool Subscribe(User item, int trainingId);
    }
}
