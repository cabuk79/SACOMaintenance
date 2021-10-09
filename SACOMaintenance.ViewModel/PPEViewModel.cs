using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SACOMaintenance.ViewModel
{
    public class PPEViewModel : INotifyPropertyChanged, IPPEViewModel
    {
        public PPE ppe { get; set; } = new();

        public IPPE PPEDataProvider { get; }

        public PPEViewModel(IPPE ppeAreaProvider)
        {
            PPEDataProvider = ppeAreaProvider;
            LoadAllPPE();
        }

        public int Id 
        {
            get => ppe.Id;
            set
            {
                if (ppe.Id != value)
                {
                    ppe.Id = value;
                    RaisePropertychangedEvent();
                }
            }            
        }

        public string PPEName
        {
            get => ppe.PPEName;
            set
            {
                if(ppe.PPEName != value)
                {
                    ppe.PPEName = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public string IconLocation
        {
            get => ppe.IconFileLocation;
            set
            {
                if(ppe.IconFileLocation != value)
                {
                    ppe.IconFileLocation = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public ObservableCollection<PPE> PPEList { get; set; } = new();

        public event PropertyChangedEventHandler PropertyChanged;

        public async void LoadAllPPE()
        {
            var list = await PPEDataProvider.LoadAllPPE();
            PPEList.Clear();
            
            foreach(var item in list)
            {
                PPEList.Add(item);
            }
        }

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
