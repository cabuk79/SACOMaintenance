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
        public ObservableCollection<AuthorizationRequest> SignOffRequest { get; set; } = new();

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
        public async Task UpdateAuthorisationAcceptReject(int AuthId, string Type, string CommentReason)
        {
            AuthorizationDataProvider.Update(AuthId, Type, CommentReason);
            //Authorisation = new ObservableCollection<AuthorizationRequest>(await AuthorizationDataProvider.FindAuthorizationByReqAndUser(UserId, MaintReqId));
        }

        public async Task GetSingleAuthRequest(int AuthId)
        {
            Authorisation = await AuthorizationDataProvider.FindAuthRequestById(AuthId);
        }

        public async Task MaintReqsNeedingApproval
            (string ApprovalType, string UserId, string Status)
        {
           if(ApprovalType == "AuthorityToWork")
            {
                AuthroizationsForUser = new ObservableCollection<AuthorizationRequest>
                    (await AuthorizationDataProvider.LoadAuthRequestsByUserType
                    (UserId, ApprovalType, Status));
            }

           if(ApprovalType == "SignOff")
            {
                SignOffRequest = new ObservableCollection<AuthorizationRequest>(await AuthorizationDataProvider.LoadAuthRequestsByUserType
                    (UserId, ApprovalType, Status));
            }
        }

        #endregion
    }
}
