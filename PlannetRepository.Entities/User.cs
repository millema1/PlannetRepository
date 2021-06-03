using System;
using System.Collections.Generic;
using System.Text;

namespace PlannetRepository.Entities
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IEnumerable<Training> Trainings { get; set; }

        public override string ToString()
        {
            return $"{Name} {LastName}";
        }
    }
}
