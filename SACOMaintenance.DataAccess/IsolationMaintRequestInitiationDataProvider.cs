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

        public List<Isolation> LoadIsolationsByMaint(int Id)
        {
            var isolations = _maintenanceDBContext.Isolations
                .Include(b => b.MaintRequestInitiations.Where(i => i.Id == Id))
                .ToList();
            //var isolations = _maintenanceDBContext.IsolationMaintRequestInitiations
            //    .Where(i => i.MaintReqInitationListId == Id).ToList();

            return isolations;
        }

        public List<int> LoadAllIsolationsIds()
        {
            List<int> ids = new();
            var allIsolationIds = _maintenanceDBContext.Isolations.ToList();
            foreach(var item in allIsolationIds)
            {
                ids.Add(item.Id);
            }
            return ids;
        }
    }
}
