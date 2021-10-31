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
        public ObservableCollection<AuthorizationRequest> AuthroizationsForUser { get; set; } = new();

        #endregion

        #region Methods

        public RequestAuthorisation(IAuthorization authorizationDataProvider)
        {
            AuthorizationDataProvider = authorizationDataProvider;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="AuthId">This is the authrisation ID for the records to set apporved or rjected</param>
        /// <param name="AuthType">This is the type which is approved or rejected</param>
        public async Task UpdateAuthorisationAcceptReject(int AuthId, string Type)
        {
            //Authorisation = new ObservableCollection<AuthorizationRequest>(await AuthorizationDataProvider.FindAuthorizationByReqAndUser(UserId, MaintReqId));
        }

        public async Task MaintReqsNeedingApproval
            (string ApprovalType, string UserId, string Status)
        {
            //TODO: complete the authorasation component for general user dashboard
            AuthroizationsForUser = new ObservableCollection<AuthorizationRequest>
                (await AuthorizationDataProvider.LoadAuthRequestsByUserType
                (UserId, ApprovalType, Status));
        }

        #endregion
    }
}
