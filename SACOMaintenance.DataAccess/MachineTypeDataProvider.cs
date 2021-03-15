using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SACOMaintenance.DataAccess
{
    public class MachineTypeDataProvider : IMachineType
    {
        private readonly SACOMaintenanceContext _machineTypeDBContext;

        public MachineTypeDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            _machineTypeDBContext = sacoMaintenanceContext;
        }

    
        //public SACOMaintenanceContext _sacoMaintenanceContext { get; }

        public void AddEditMachineType(MachineType machineType)
        {
            _machineTypeDBContext.Add
            (
                new MachineType
                {
                    TypeName = machineType.TypeName,
                    Description = machineType.Description
                }
            );
            _machineTypeDBContext.SaveChanges();
        }

        public IEnumerable<MachineType> LoadAllMachines()
        {
            var machines = _machineTypeDBContext.MachineTypes.ToList();
            return machines;
        }

        public MachineType ViewSingleMachineType(int machineTypeId)
        {
            var machineType = _machineTypeDBContext.MachineTypes.FirstOrDefault(i => i.Id == machineTypeId);
            return machineType;
        }
    }
}
