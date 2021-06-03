using System;

namespace PlannetRepository.Entities
{
    public class Training : Entity
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Title} - {Date} - {Score}";
        }
    }
}
