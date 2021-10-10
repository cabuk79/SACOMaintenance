using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SACOMaintenance.DataAccess
{
    public class EquipmentDataProvider : IEquipment
    {
        private readonly SACOMaintenanceContext _equipmentDBContext;
        public EquipmentDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            //SacoMaintenanceContext = new SACOMaintenanceContext();
            _equipmentDBContext = sacoMaintenanceContext;
        }

        //public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditEquipment(Equipment equipment)
        {
            _equipmentDBContext.Equipment.Add
            (
                new Equipment 
                { 
                    Name = equipment.Name,
                    Description = equipment.Description,
                    Comments = equipment.Comments,
                    MachineTypeId = equipment.MachineTypeId,
                    SerialIdentifierNumber = equipment.SerialIdentifierNumber
                }
            );
            _equipmentDBContext.SaveChanges();
        }

        public async Task<List<MaintRequestInitiation>> GetMaintReqsForEquipment(int equipmentId)
        {
            var requests = await _equipmentDBContext.MaintRequestInitiations.Where(e => e.EquipmentId == equipmentId).ToListAsync();
            return requests;
        }

        public async Task<List<Equipment>> LoadAllEquipments()
        {
            var equipments = await _equipmentDBContext.Equipment
                .Include(mt => mt.MachineType)
                .ToListAsync();
            return equipments;
        }

        public async Task<List<Equipment>> LoadByArea(int areaId)
        {
            var equipment = await _equipmentDBContext.Equipment.Where(a => a.AreaId == areaId).ToListAsync();
            return equipment;
        }

        public async Task<Equipment> ViewSingleEquipment(int equipmentId)
        {
            var equipment = await _equipmentDBContext.Equipment
                .Where(i => i.Id == equipmentId)
                .Include(p => p.Parts)
                .FirstOrDefaultAsync();
            return equipment;
        }
    }
}
