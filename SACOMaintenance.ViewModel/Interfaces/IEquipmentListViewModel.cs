using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IEquipmentListViewModel
    {
        public Equipment EquipmentSingle { get; set; }
        public ObservableCollection<Equipment> EquipmentList { get; set; }
        public IEquipment EquipmentDataProvider { get; }

        public void LoadAllEquipment();
    }
}
