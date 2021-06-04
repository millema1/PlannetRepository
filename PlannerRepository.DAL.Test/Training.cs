using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Collections.Generic;
using Entities = PlannerRepository


namespace PlannerRepository.DAL.Test
{
    [TestClass]
    public class Training
    {
        [TestMethod]
        public async Task PagingTestAsync()
        {
            var trainingRep = new PlannetRepository.DAL.Repositories.TrainingRepository();
            
            IEnumerable<Training> trainings = await trainingRep.GetTrainingsAsync(2, 2);
            
            Assert.AreEqual(trainings)
        }
    }
}
