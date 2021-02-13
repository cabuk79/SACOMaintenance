using SACOMaintenance.BuisnessModels;
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
        public void AddEditEquipment(Equipment equipment)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Equipment> LoadAllEquipments()
        {
            throw new NotImplementedException();
        }

        public Equipment ViewSingleEquipment(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
