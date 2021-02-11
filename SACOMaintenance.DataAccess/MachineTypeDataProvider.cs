using SACOMaintenance.BuisnessModels;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess
{
    public class MachineTypeDataProvider : IMachineType
    {
        public void AddEditStatus(Status status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MachineType> LoaddAllMachines()
        {
            throw new NotImplementedException();
        }

        public void ViewSingleStatus(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
