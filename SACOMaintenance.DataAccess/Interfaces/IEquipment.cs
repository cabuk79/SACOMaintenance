using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IEquipment
    {
        IEnumerable<Equipment> LoadAllEquipments();
        IEnumerable<Equipment> LoadByArea(int areaId);
        IEnumerable<MaintRequestInitiation> GetMaintReqsForEquipment(int equipmentId); //get a list of the maint requests for the equipment
        Equipment ViewSingleEquipment(int Id);
        void AddEditEquipment(Equipment equipment);
        
    }
}
