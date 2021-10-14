using Microsoft.EntityFrameworkCore;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess
{
    public class StatusDataProvider : IStatus
    {
        private readonly SACOMaintenanceContext _statusDBContext;

        public StatusDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            //SacoMaintenanceContext = new SACOMaintenanceContext();
            _statusDBContext = sacoMaintenanceContext;
        }

        public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditStatus(Status status)
        {
            SacoMaintenanceContext.Add
            (
                new Status { StatusName = status.StatusName }
            );
        }

        public async Task<Status> GetSingleStatus(int Id)
        {
            var status = await SacoMaintenanceContext.Statuses.FirstOrDefaultAsync(i => i.Id == Id);
            return status;
        }

        //public IEnumerable<Status> LoadAllStatuses()
        public async Task<IEnumerable<Status>> LoadAllStatuses()
        {
            var statusList = await _statusDBContext.Statuses.ToListAsync();
            return statusList;
        }
    }
}
