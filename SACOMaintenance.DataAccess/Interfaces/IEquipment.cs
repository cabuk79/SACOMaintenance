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
        Task<List<Equipment>> LoadAllEquipments();
        Task<List<Equipment>> LoadByArea(int areaId);
        Task<List<MaintRequestInitiation>> GetMaintReqsForEquipment(int equipmentId); //get a list of the maint requests for the equipment
        Task<Equipment> ViewSingleEquipment(int Id);
        void AddEditEquipment(Equipment equipment);
        
    }
}
