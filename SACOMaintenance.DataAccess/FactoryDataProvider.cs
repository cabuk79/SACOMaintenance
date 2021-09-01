using Microsoft.EntityFrameworkCore;
using SACOMaintenance.Common.ModelDB;
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
        private readonly SACOMaintenanceContext _factoryDBContext;

        public FactoryDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            //SacoMaintenanceContext = new SACOMaintenanceContext();
            _factoryDBContext = sacoMaintenanceContext;
        }

        //public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditFactory(Factory factory)
        {
            _factoryDBContext.Factories.Add
            (
                new Factory
                {
                    FactoryName = factory.FactoryName
                }
            );

            _factoryDBContext.SaveChanges();
        }

        public IEnumerable<Factory> LoadAllFactories()
        {
            var factories = _factoryDBContext.Factories.ToList();
            return factories;
        }

        public Factory ViewSingleFactory(int Id)
        {
            var factory = _factoryDBContext.Factories
                .Where(i => i.Id == Id)
                .Include(a => a.Areas)
                .FirstOrDefault();
            return factory;

        }
    }
}
