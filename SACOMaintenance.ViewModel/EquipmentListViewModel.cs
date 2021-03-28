using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.ViewModel.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SACOMaintenance.DataAccess.Interfaces;

namespace SACOMaintenance.ViewModel
{
    public class EquipmentListViewModel : INotifyPropertyChanged, IEquipmentListViewModel
    {
        public ObservableCollection<Equipment> EquipmentList { get; set; } = new();

        public IEquipment EquipmentDataProvider { get; }
        public Equipment EquipmentSingle { get; set; } = new();

        public EquipmentListViewModel(IEquipment equipmentDataProvider)
        {
            EquipmentDataProvider = equipmentDataProvider;
            LoadAllEquipment();
        }

        public void LoadAllEquipment()
        {
            var equipList = EquipmentDataProvider.LoadAllEquipments();
            EquipmentList.Clear();

            foreach(var item in equipList)
            {
                EquipmentList.Add(item);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
