using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.ViewModel.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SACOMaintenance.DataAccess.Interfaces;

namespace SACOMaintenance.ViewModel
{
    public class EquipmentViewModel : INotifyPropertyChanged, IEquipmentViewModel
    {
        public Equipment equipment { get; set; } = new();
        public ObservableCollection<MaintRequestInitiation> maintReqsList { get; set; } = new();

        public IEquipment EquipmentDataProvider { get; }
        public int EquipmentId 
        { 
            get => equipment.Id; 
            set
            {
                if(equipment.Id != value)
                {
                    equipment.Id = value;
                    RaisePropertychangedEvent();
                }
            } 
        }

        public EquipmentViewModel(IEquipment equipmentDataProvider)
        {
            EquipmentDataProvider = equipmentDataProvider;
           //LoadEquipment(EquipmentId);
            //LoadAllEquipmentAndFactories(EquipmentId);
        }

        public async void LoadEquipment(int EquipmentId)
        {
            equipment = await EquipmentDataProvider.ViewSingleEquipment(EquipmentId);
        }

        public async void LoadAllEquipmentAndFactories(int equipmentId)
        {
            var equipmentList = EquipmentDataProvider
                .ViewSingleEquipment(EquipmentId);

            //Load all the maintenance request for the chosen piece of equipment
            var requestsList = new ObservableCollection<MaintRequestInitiation>(await  EquipmentDataProvider
                .GetMaintReqsForEquipment(EquipmentId));

            maintReqsList.Clear();

            foreach(var reqItem in requestsList)
            {
                maintReqsList.Add(reqItem);
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
