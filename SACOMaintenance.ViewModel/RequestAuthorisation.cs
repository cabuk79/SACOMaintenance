using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;

namespace SACOMaintenance.ViewModel
{
    public class RequestAuthorisation : IRequestAuthorisation
    {


        #region Properties

        public IAuthorization AuthorizationDataProvider { get; }

        public AuthorizationRequest Authorisation { get; set; }

        #endregion

        #region Methods

        public RequestAuthorisation(IAuthorization authorizationDataProvider)
        {
            AuthorizationDataProvider = authorizationDataProvider;
        }

        public async void UpdateAuthorisation(string UserId, int MaintReqId)
        {
            //Authorisation = new ObservableCollection<AuthorizationRequest>(await AuthorizationDataProvider.FindAuthorizationByReqAndUser(UserId, MaintReqId));
        }

        public async Task<ObservableCollection<AuthorizationRequest>> MaintReqsNeedingApproval
            (string ApprovalType, string UserId, string Status)
        {
            //TODO: complete the authorasation component for generla user dahsboard
            return null;
        }

        #endregion
    }
}
