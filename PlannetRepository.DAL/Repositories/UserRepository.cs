using PlannetRepository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlannetRepository.DAL.Repositories
{
    class UserRepository : WebRepository<User>, IUserRepository
    {
        public UserRepository() : base("signedUps")
        {

        }

        public bool Subscribe(User item, int trainingId)
        {
            throw new NotImplementedException();
        }
    }
}
