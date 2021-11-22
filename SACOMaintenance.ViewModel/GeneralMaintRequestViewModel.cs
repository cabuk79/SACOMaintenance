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
        public ObservableCollection<PPE> ppeList { get; set; } = new();

        public MaintRequestInitiation reqInit { get; set; }
        public IPPE PpeDataProvider { get; }
        public IGeneralRequest _generalREquestDataProvider { get; }
        public IAuthorization AuthrizationDataProvider { get; }
        public IAuthorization AuthDataProvider { get; }
        public IMaintRequestInitiation MaintReqInitation { get; }
        public GeneralRequest genralRequestInfo { get; set; }
        public int maintId { get; set; }
        public ObservableCollection<User> Users { get; set; } = new();
        public IUsers UsersDataProvider { get; set; }
        public AuthorizationRequest AuthrazationReq { get; set; }
        public AuthorizationRequest CompletedAuth { get; set; }
        public List<PPE> PPEItemsSelected { get; set; } = new();
        public bool UserCompletedRequest { get; set; }

        public GeneralMaintRequestViewModel(IPPE ppeDataProvider,
            IGeneralRequest generalRequestDataProvider, IUsers usersDataProvider,
            IAuthorization authrizationDataProvider, IAuthorization authTwo, IMaintRequestInitiation maintReqInitation)
        {
            PpeDataProvider = ppeDataProvider;
            _generalREquestDataProvider = generalRequestDataProvider;
            UsersDataProvider = usersDataProvider;
            AuthrizationDataProvider = authrizationDataProvider;
            AuthDataProvider = authrizationDataProvider;
            AuthDataProvider = authTwo;
            MaintReqInitation = maintReqInitation;

            genralRequestInfo = new GeneralRequest();
            AuthrazationReq = new AuthorizationRequest();
            CompletedAuth = new AuthorizationRequest();
            //LoadAllPPE();
           // LoadAllUsers();
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


        public string MaintenanceUserCompletedId
        {
            get => genralRequestInfo.DetailOfWorkCompeltedUserId;
            set
            {
                if(genralRequestInfo.DetailOfWorkCompeltedUserId != value)
                {
                    genralRequestInfo.DetailOfWorkCompeltedUserId = value;
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

        public void LoadPPEItemsSelected()
        {
            var id = genralRequestInfo.MaintRequestInitiation.Id;

            
        }

        //Add new authrization request
        public void AddNewAuthrization(string status, string type)
        {
            AuthorizationRequest completedAuth = new AuthorizationRequest();

            completedAuth.MaintRequestInitiationId = maintId;
            completedAuth.Satus = status;
            completedAuth.AuthorizationType = type;

            if (type == "AuthorityToWork")
            {
                completedAuth.UserId = UserAuthIdStartWork;
                //Update the General ViewModel and table
                genralRequestInfo.AuthorityToWorkUserId = UserAuthIdStartWork;
                _generalREquestDataProvider.AddEditGeneralRequestInfo(genralRequestInfo.Id, genralRequestInfo, "Edit");
            }
            else if(type == "Completed")
            {
                completedAuth.UserId = MaintenanceUserCompletedId;
                //Update the General ViewModel and table
                genralRequestInfo.DetailOfWorkCompeltedUserId = MaintenanceUserCompletedId;
                _generalREquestDataProvider.AddEditGeneralRequestInfo(genralRequestInfo.Id, genralRequestInfo, "Edit");
            }
            else if (type == "SignOff")
            {
                completedAuth.UserId = MaintenanceUserCompletedId;
                //Update the General ViewModel and table
                genralRequestInfo.WorkCompletedSignOffUserId = genralRequestInfo.WorkCompletedSignOffUserId;             
                _generalREquestDataProvider.AddEditGeneralRequestInfo(genralRequestInfo.Id, genralRequestInfo, "Edit");
            }

            AuthrizationDataProvider.AddNewAuthorization(completedAuth);            
        }

        public async Task<AuthorizationRequest> LoadStartToworkAuth()
        {
            AuthrazationReq = await AuthrizationDataProvider.FindAuthorizationByReqAndUser(genralRequestInfo.AuthorityToWorkUserId, maintId); //(UserAuthIdStartWork, maintId);
            if(AuthrazationReq == null)
            {
                return AuthrazationReq = new AuthorizationRequest();
            }
            return AuthrazationReq;
        }

        public async Task<AuthorizationRequest> LoadCompletedUser()
        {
            CompletedAuth = await AuthDataProvider.FindAuthorizationByReqAndUser(MaintenanceUserCompletedId, maintId);
            if(CompletedAuth == null)
            {
                return CompletedAuth = new AuthorizationRequest();
            }
            return CompletedAuth;
        }

        //Loads all of the PPE and also put any PPE that have been selected into a list of SelectedItem
        //It is done like this so when the SquareCheckBox component does a contains it sees the objects in the ppeList and PPEItemsSelected as the same
        //otherwise it does not and ignores the contains
        public async Task<bool> LoadAllPPE()
        {
            var list = new ObservableCollection<PPE>(await PpeDataProvider.LoadAllPPE());
            ppeList.Clear();
            PPEItemsSelected.Clear();

            //loop through all of the PPE items
            foreach (var item in list)
            {
                ppeList.Add(item);

                //loop through each maintenance request linked to the PPE items
                foreach(var item2 in item.MaintRequestInitiations)
                {
                    //if the ppe item finds a maintenance request with the correct request Id then add it to the PPEItemsSelectedlist
                    if(item2.Id == reqInit.Id)
                    {
                        PPEItemsSelected.Add(item);
                    }
                }              
            }

            return true;
        }

        public async Task LoadAllUsers()
        {
            Users = new ObservableCollection<User>(await UsersDataProvider.GetAllUsers());
        }

        public async Task<GeneralRequest> GetGeneralRequest(int maintId)
        {
            var req = await _generalREquestDataProvider.GetSingalGeneralRequestInfo(maintId);
            genralRequestInfo = req;
            if(req.DetailOfWorkCompeltedUserId == "") { UserCompletedRequest = false; } else { UserCompletedRequest = true; }
            return genralRequestInfo;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }        
    }
}
