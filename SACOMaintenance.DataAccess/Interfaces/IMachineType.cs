using SACOMaintenance.BuisnessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IMachineType
    {
        IEnumerable<MachineType> LoaddAllMachines();
        void ViewSingleStatus(int Id);
        void AddEditStatus(Status status);
    }
}
