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
    public class IsolationMaintRequestInitiationDataProvider : IIsolationMaintRequestInitiation
    {
        private readonly SACOMaintenanceContext _maintenanceDBContext;

        public IsolationMaintRequestInitiationDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            _maintenanceDBContext = sacoMaintenanceContext;
        }

        public async Task<IEnumerable<Isolation>> LoadIsolationsByMaint(int Id)
        {
            var isolations = await _maintenanceDBContext.Isolations
                .Include(b => b.MaintRequestInitiations.Where(i => i.Id == Id))
                .ToListAsync();
            //var isolations = _maintenanceDBContext.IsolationMaintRequestInitiations
            //    .Where(i => i.MaintReqInitationListId == Id).ToList();

            return isolations;
        }

        public async Task<IEnumerable<int>> LoadAllIsolationsIds()
        {
            List<int> ids = new();
            var allIsolationIds = await _maintenanceDBContext.Isolations.ToListAsync();
            foreach(var item in allIsolationIds)
            {
                ids.Add(item.Id);
            }
            return ids;
        }
    }
}
