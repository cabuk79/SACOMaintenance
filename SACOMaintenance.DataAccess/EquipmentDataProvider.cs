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
        public EquipmentDataProvider()
        {
            //SacoMaintenanceContext = new SACOMaintenanceContext();
        }

        public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditEquipment(Equipment equipment)
        {
            SacoMaintenanceContext.Equipment.Add
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
            SacoMaintenanceContext.SaveChanges();
        }

        public IEnumerable<Equipment> LoadAllEquipments()
        {
            var equipments = SacoMaintenanceContext.Equipment.ToList();
            return equipments;
        }

        public Equipment ViewSingleEquipment(int equipmentId)
        {
            var equipment = SacoMaintenanceContext.Equipment.FirstOrDefault(i => i.Id == equipmentId);
            return equipment;
        }
    }
}
