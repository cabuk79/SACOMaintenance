using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IEnumerable<MaintRequestInitiation> GetMaintReqsForEquipment(int equipmentId)
        {
            var requests = _equipmentDBContext.MaintRequestInitiations.Where(e => e.EquipmentId == equipmentId).ToList();
            return requests;
        }

        public IEnumerable<Equipment> LoadAllEquipments()
        {
            var equipments = _equipmentDBContext.Equipment.ToList();
            return equipments;
        }

        public IEnumerable<Equipment> LoadByArea(int areaId)
        {
            var equipment = _equipmentDBContext.Equipment.Where(a => a.AreaId == areaId).ToList();
            return equipment;
        }

        public Equipment ViewSingleEquipment(int equipmentId)
        {
            var equipment = _equipmentDBContext.Equipment.FirstOrDefault(i => i.Id == equipmentId);
            return equipment;
        }
    }
}
