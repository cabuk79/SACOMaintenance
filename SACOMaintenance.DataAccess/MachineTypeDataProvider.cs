using SACOMaintenance.BuisnessModels;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SACOMaintenance.DataAccess
{
    public class MachineTypeDataProvider : IMachineType
    {
        public MachineTypeDataProvider()
        {
            SacoMaintenanceContext = new SACOMaintenanceContext();
        }

        public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditMachineType(MachineType machineType)
        {
            SacoMaintenanceContext.Add
            (
                new MachineType
                {
                    TypeName = machineType.TypeName,
                    Description = machineType.Description
                }
            );
            SacoMaintenanceContext.SaveChanges();
        }

        public IEnumerable<MachineType> LoadAllMachines()
        {
            var machines = SacoMaintenanceContext.MachineTypes.ToList();
            return machines;
        }

        public MachineType ViewSingleMachineType(int machineTypeId)
        {
            var machineType = SacoMaintenanceContext.MachineTypes.FirstOrDefault(i => i.Id == machineTypeId);
            return machineType;
        }
    }
}
