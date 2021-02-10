using Microsoft.VisualStudio.TestTools.UnitTesting;
using SACOMaintenance.BuisnessModels;
using SACOMaintenance.Data;

namespace SACOMaintenance.DbContextTesting
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void CanInsertFactoryIntoDatabase()
        {
            using(var context = new SACOMaintenanceContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var factory = new Factory();
                factory.FactoryName = "Factory testing";

                var factory1 = new Factory();
                factory1.FactoryName = "This is another factory";

                context.Factories.Add(factory);
                context.Factories.Add(factory1);
                context.SaveChanges();

                Assert.AreNotEqual(0, factory.Id);
            }
        }
    }
}
