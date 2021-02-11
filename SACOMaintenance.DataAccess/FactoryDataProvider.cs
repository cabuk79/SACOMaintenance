using SACOMaintenance.BuisnessModels;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess
{
    public class FactoryDataProvider : IFactory
    {
        public FactoryDataProvider()
        {
            SacoMaintenanceContext = new SACOMaintenanceContext();
        }

        public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditFactory(Factory factory)
        {
            SacoMaintenanceContext.Factories.Add
            (
                new Factory
                {
                    FactoryName = factory.FactoryName
                }
            );
        }

        public IEnumerable<Factory> LoadAllFactories()
        {
            var factories = SacoMaintenanceContext.Factories.ToList();
            return factories;
        }

        public Factory ViewSingleFactory(int Id)
        {
            var factory = SacoMaintenanceContext.Factories.FirstOrDefault(i => i.Id == Id);
        }
    }
}
