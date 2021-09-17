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
    public class PrioritiesDataProvider : IPriorities
    {
        private readonly SACOMaintenanceContext _sacoMaintContext;

        public PrioritiesDataProvider(SACOMaintenanceContext sacoMaintContext)
        {
            _sacoMaintContext = sacoMaintContext;
        }
        
        public IEnumerable<Priority> LoadAllPriorities()
        {
            var priorities = _sacoMaintContext.Priorites.ToList();
            return priorities;
        }
    }
}
