using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IAuthorization
    {
        Task<IEnumerable<AuthorizationRequest>> LoadAuthRequestsByUserType(string UserId, string Type);
        Task<AuthorizationRequest> FindAuthorizationByReqAndUser(string userId, int maintReqId, string status);
        void AddNewAuthorization(AuthorizationRequest auth);
        void DeleteAuthorization(AuthorizationRequest auth);
    }
}
