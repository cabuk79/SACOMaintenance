using Microsoft.EntityFrameworkCore;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess
{
    public class IsolationDataProvider : IIsolations
    {
        private readonly SACOMaintenanceContext _maintenanceDBContext;
        
        public IsolationDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            _maintenanceDBContext = sacoMaintenanceContext;
        }

        public async Task<IEnumerable<Isolation>> LoadAllIsolations()
        {
            var isolations = await _maintenanceDBContext.Isolations.ToListAsync();
            return isolations;
        }
    }
}
