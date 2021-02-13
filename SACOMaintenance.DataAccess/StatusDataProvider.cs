using SACOMaintenance.BuisnessModels;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SACOMaintenance.DataAccess
{
    public class StatusDataProvider : IStatus
    {
        public StatusDataProvider()
        {
            SacoMaintenanceContext = new SACOMaintenanceContext();
        }

        public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditStatus(Status status)
        {
            SacoMaintenanceContext.Add
            (
                new Status { StatusName = status.StatusName }
            );
        }

        public Status GetSingleStatus(int Id)
        {
            var status = SacoMaintenanceContext.Statuses.FirstOrDefault(i => i.Id == Id);
            return status;
        }

        public IEnumerable<Status> LoadAllStatuses()
        {
            var statusList = SacoMaintenanceContext.Statuses.ToList();
            return statusList;
        }
    }
}
