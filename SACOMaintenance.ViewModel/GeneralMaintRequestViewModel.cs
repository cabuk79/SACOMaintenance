using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.ViewModel.Interfaces;
using SACOMaintenance.DataAccess.Interfaces;

namespace SACOMaintenance.ViewModel
{
    public class GeneralMaintRequestViewModel : INotifyPropertyChanged, IGeneralMaintRequestViewModel
    {
        public ObservableCollection<PPE> ppeList { get; set; }

        public IPPE PpeDataProvider { get; }

        public GeneralMaintRequestViewModel(IPPE ppeDataProvider)
        {
            PpeDataProvider = ppeDataProvider;
            LoadAllPPE();
        }

        private void LoadAllPPE()
        {
            ppeList = new ObservableCollection<PPE>(PpeDataProvider.LoadAllPPE());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
