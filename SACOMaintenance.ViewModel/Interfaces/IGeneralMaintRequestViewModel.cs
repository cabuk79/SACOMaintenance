using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IGeneralMaintRequestViewModel
    {
        public MaintRequestInitiation reqInit { get; set; }
        ObservableCollection<PPE> ppeList { get; set; }
        public List<PPE> PPEItemsSelected { get; set; }
        public int maintId { get; set; }
        public GeneralRequest genralRequestInfo { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public AuthorizationRequest AuthrazationReq { get; set; }
        public AuthorizationRequest CompletedAuth { get; set; }
        public IUsers UsersDataProvider { get; set; }
        public IAuthorization AuthrizationDataProvider { get; }
        Task<GeneralRequest> GetGeneralRequest(int maintId);
        public Task LoadAllUsers();
        public void AddNewAuthrization(string status, string type);
        Task<AuthorizationRequest> LoadStartToworkAuth();
        public void RemoveAuthStartToWorkUser();
        public void SaveGeneralRequest(GeneralRequest request, string newEdit);
        public void SaveControlMeasuresTaken();
        Task<AuthorizationRequest> LoadCompletedUser();
        public Task<bool> LoadAllPPE();
        public bool UserCompletedRequest { get; set; }
        void SaveRequestSelectedPPE();


        public string UserAuthIdStartWork { get; set; }
        public string MaintenanceUserCompletedId { get; set; }
    }
}
