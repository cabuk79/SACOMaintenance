using SACOMaintenance.Common.ModelDB;
using System.Collections.Generic;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IMachineType
    {
        IEnumerable<MachineType> LoadAllMachines();
        MachineType ViewSingleMachineType(int Id);
        void AddEditMachineType(MachineType machineType);
    }
}
