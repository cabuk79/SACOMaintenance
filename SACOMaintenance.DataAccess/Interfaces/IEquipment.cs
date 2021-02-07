using SACOMaintenance.BuisnessModels;
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
        void ViewSingleEquipment(int Id);
        void AddEditEquipment(Equipment equipment);
    }
}
