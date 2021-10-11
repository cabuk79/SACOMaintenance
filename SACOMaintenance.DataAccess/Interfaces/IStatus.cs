using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IStatus
    {
        //IEnumerable<Status> LoadAllStatuses();
        Task<List<Status>> LoadAllStatuses();
        Task<Status> GetSingleStatus(int Id);
        void AddEditStatus(Status status);
    }
}
