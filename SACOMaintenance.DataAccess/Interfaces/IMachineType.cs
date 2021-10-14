using SACOMaintenance.Common.ModelDB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IMachineType
    {
        Task<IEnumerable<MachineType>> LoadAllMachines();
        Task<MachineType> ViewSingleMachineType(int Id);
        void AddEditMachineType(MachineType machineType);
    }
}
