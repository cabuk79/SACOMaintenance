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
    public class PrioritiesDataProvider : IPriorities
    {
        private readonly SACOMaintenanceContext _sacoMaintContext;

        public PrioritiesDataProvider(SACOMaintenanceContext sacoMaintContext)
        {
            _sacoMaintContext = sacoMaintContext;
        }
        
        public ObservableCollection<Priority> LoadAllPriorities()
        {
            var priorities = new ObservableCollection<Priority>(_sacoMaintContext.Priorites.ToList());
            return priorities;
        }
    }
}
