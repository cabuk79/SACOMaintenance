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

        [TestMethod]
        public void CanInsertAreaIntoDatabase()
        {
            using (var context1 = new SACOMaintenanceContext())
            {
                context1.Database.EnsureDeleted();
                context1.Database.EnsureCreated();

                var area = new Area();
                area.AreaName = "New area addition";

                var area1 = new Area();
                area1.AreaName = "This is another area";

                context1.Areas.Add(area);
                context1.Areas.Add(area1);
                context1.SaveChanges();

                Assert.AreNotEqual(0, area.Id);
            }
        }
    }
}
