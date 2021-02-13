using SACOMaintenance.BuisnessModels;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess
{
    public class StatusDataProvider : IStatus
    {
        public void AddEditStatus(Status status)
        {
            throw new NotImplementedException();
        }

        public Status GetSingleStatus(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Status> LoadAllStatuses()
        {
            throw new NotImplementedException();
        }
    }
}
