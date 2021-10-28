using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SACOMaintenance.Common.ModelDB;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IRequestAuthorisation
    {
        #region Properties
        
        public AuthorizationRequest Authorisation { get; set; }

        #endregion

        #region Methods

        public void UpdateAuthorisation(string UserId, int MaintReqId);

        public Task<ObservableCollection<AuthorizationRequest>> MaintReqsNeedingApproval(string ApprovalType, string UserId, string Status); 

        #endregion
    }
}
