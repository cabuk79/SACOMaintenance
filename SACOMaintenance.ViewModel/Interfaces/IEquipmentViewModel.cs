using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IEquipmentViewModel
    {
        public Equipment equipment { get; set; }
        ObservableCollection<MaintRequestInitiation> maintReqsList { get; set; }
        IEquipment EquipmentDataProvider { get; }
        public void LoadAllEquipmentAndFactories(int EquipmentId);
        public void LoadEquipment(int EquipmentId);

        public int EquipmentId { get; set; }

    }
}
