using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

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

        public Status GetSingleStatus(int Id)
        {
            var status = SacoMaintenanceContext.Statuses.FirstOrDefault(i => i.Id == Id);
            return status;
        }

        //public IEnumerable<Status> LoadAllStatuses()
        public IEnumerable<Status> LoadAllStatuses()
        {
            var statusList = _statusDBContext.Statuses.ToList();
            return statusList;
        }
    }
}
