using System;
using System.Collections.Generic;
using System.Text;

namespace PlannetRepository.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public abstract string ToString();
    }
}
