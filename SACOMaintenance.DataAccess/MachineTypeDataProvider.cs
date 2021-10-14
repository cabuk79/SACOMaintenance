using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

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

        public async Task<IEnumerable<MachineType>> LoadAllMachines()
        {
            var machines = await _machineTypeDBContext.MachineTypes
                .Include(eq => eq.EquipmentList)
                .ToListAsync();
            return machines;
        }

        public async Task<MachineType> ViewSingleMachineType(int machineTypeId)
        {
            var machineType = await _machineTypeDBContext.MachineTypes.FirstOrDefaultAsync(i => i.Id == machineTypeId);
            return machineType;
        }
    }
}
