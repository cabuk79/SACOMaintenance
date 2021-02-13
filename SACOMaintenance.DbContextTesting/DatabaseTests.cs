using Microsoft.VisualStudio.TestTools.UnitTesting;
using SACOMaintenance.BuisnessModels;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess;

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

                var nameOfArea = "New area addition and testing";

                var area = new Area();
                area.AreaName = nameOfArea;

                AreaProvider areaProvider = new AreaProvider();

                areaProvider.AddEditArea(area);
               
                var foundArea = new Area();
                foundArea = areaProvider.FindAreaByName(nameOfArea);

                Assert.AreEqual(nameOfArea, foundArea.AreaName);
            }
        }
    }
}
