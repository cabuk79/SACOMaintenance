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
        public IAuthorization AuthrizationDataProvider { get; }
        public GeneralRequest genralRequestInfo { get; set; }
        public int maintId { get; set; }
        public ObservableCollection<User> Users { get; set; } = new();
        public IUsers UsersDataProvider { get; set; }
        public AuthorizationRequest AuthrazationReq { get; set; }

        public GeneralMaintRequestViewModel(IPPE ppeDataProvider,
            IGeneralRequest generalRequestDataProvider, IUsers usersDataProvider,
            IAuthorization authrizationDataProvider)
        {
            PpeDataProvider = ppeDataProvider;
            _generalREquestDataProvider = generalRequestDataProvider;
            UsersDataProvider = usersDataProvider;
            AuthrizationDataProvider = authrizationDataProvider;

            genralRequestInfo = new GeneralRequest();
            AuthrazationReq = new AuthorizationRequest();
            LoadAllPPE();
            LoadAllUsers();
            //LoadStartToworkAuth();
            //GetGeneralRequest(maintId);
        }

        public string UserAuthIdStartWork 
        {
            get => genralRequestInfo.AuthorityToWorkUserId;
            set
            {
                if(genralRequestInfo.AuthorityToWorkUserId != value)
                {
                    genralRequestInfo.AuthorityToWorkUserId = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public void RemoveAuthStartToWorkUser()
        {       
            AuthrizationDataProvider.DeleteAuthorization(AuthrazationReq);
            UserAuthIdStartWork = "";
            AuthrazationReq = null;
            AuthrazationReq = new AuthorizationRequest();

            //Update General Request
            SaveGeneralRequest(genralRequestInfo, "Edit");          
        }

        public void SaveGeneralRequest(GeneralRequest request, string newEdit)
        {
            _generalREquestDataProvider.AddEditGeneralRequestInfo(maintId, genralRequestInfo, newEdit);
        }

        //Add new authrization request
        public void AddNewAuthrization()
        {
            AuthrazationReq.UserId = UserAuthIdStartWork;
            AuthrazationReq.MaintRequestInitiationId = maintId;
            AuthrazationReq.Satus = "Requested";
            AuthrazationReq.AuthorizationType = "StartWork";

            AuthrizationDataProvider.AddNewAuthorization(AuthrazationReq);
        }

        public void LoadStartToworkAuth()
        {
            AuthrazationReq = AuthrizationDataProvider.FindAuthorizationByReqAndUser(UserAuthIdStartWork, maintId);
            if(AuthrazationReq == null)
            {
                AuthrazationReq = new AuthorizationRequest();
            }
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
