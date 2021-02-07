using SACOMaintenance.BuisnessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IStatus
    {
        IEnumerable<Status> LoadAllStatuses();
        void GetSingleStatus(int Id);
        void AddEditStatus(Status status);
    }
}
