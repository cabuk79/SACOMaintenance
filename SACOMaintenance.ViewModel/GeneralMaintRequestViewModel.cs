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
        public IGeneralRequest _generalREquestDataProvider {get;}
        public GeneralRequest genralRequestInfo { get; set; }
        public int maintId { get; set; }
        public ObservableCollection<User> Users { get; set; } = new();
        public IUsers UsersDataProvider { get; set; }

        public GeneralMaintRequestViewModel(IPPE ppeDataProvider,
            IGeneralRequest generalRequestDataProvider, IUsers usersDataProvider)
        {
            PpeDataProvider = ppeDataProvider;
            _generalREquestDataProvider = generalRequestDataProvider;
            UsersDataProvider = usersDataProvider;
            LoadAllPPE();
            LoadAllUsers();
            //GetGeneralRequest(maintId);
        }

        private void LoadAllPPE()
        {
            ppeList = new ObservableCollection<PPE>(PpeDataProvider.LoadAllPPE());
        }

        public void LoadAllUsers()
        {
            Users = new ObservableCollection<User>(UsersDataProvider.GetAllUsers());
        }

        public void GetGeneralRequest(int maintId)
        {
            genralRequestInfo = _generalREquestDataProvider.GetSingalGeneralRequestInfo(maintId);
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
       
    }
}
