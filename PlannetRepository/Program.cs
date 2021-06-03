using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

namespace PlannetRepository
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var trainingRep = new DAL.Repositories.TrainingRepository();

            var all = await displayAll(trainingRep);

            Console.ReadLine();

            var train2 = await trainingRep.GetByIdAsync(2);
            Console.WriteLine(train2.Title);
            Console.ReadLine();

            var id = all.Max(item => item.Id) + 1;
            train2.Id = id;
            train2.Date = DateTime.Today.ToString("dd/MM/yyyy");
            await trainingRep.AddAsync(train2);

            await displayAll(trainingRep);
            Console.ReadLine();

            await trainingRep.RemoveAsync(train2.Id);

            await displayAll(trainingRep);
            Console.ReadLine();
        }

        static async Task<IEnumerable<T>> displayAll<T>(DAL.Repositories.IRepository<T> rep) where T: Entities.Entity
        {
            var all = await rep.GetAllAsync();
            foreach (var item in all)
            {
                Console.WriteLine(item.ToString());
            }
            return all;
        }
    }
}
