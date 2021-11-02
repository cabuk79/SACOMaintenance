using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SACOMaintenance.DataAccess
{
    public class AuthorizationDataProvider : IAuthorization
    {
        private readonly SACOMaintenanceContext _sacoContext;

        public AuthorizationRequest authorizationRequest { get; set; }
        public MaintRequestInitiation maintReq { get; set; }

        public AuthorizationDataProvider(SACOMaintenanceContext sacoContext)
        {
            _sacoContext = sacoContext;
        }
    
        public async Task<IEnumerable<AuthorizationRequest>> LoadAuthRequestsByUserType(string UserId, string Type, string Status)
        {
            var authorisations = await _sacoContext.AuthorizationRequests
                                        .Where(u => u.UserId == UserId 
                                                && u.Satus == Status
                                                && u.AuthorizationType == Type)
                                        .ToListAsync();
            return authorisations;
        }

        public async Task<AuthorizationRequest> FindAuthRequestById(int Id)
        {
            var auth = await _sacoContext.AuthorizationRequests
                .FirstOrDefaultAsync(i => i.Id == Id);

            return auth;
        }

        public async Task<AuthorizationRequest> FindAuthorizationByReqAndUser(string userId, int maintReqId)
        {
            var auth = await _sacoContext.AuthorizationRequests
                            .FirstOrDefaultAsync(i => i.UserId == userId && i.MaintRequestInitiationId == maintReqId);

            return auth;
        }

        public void AddNewAuthorization(AuthorizationRequest auth)
        {
            _sacoContext.AuthorizationRequests.Add
            (
                new AuthorizationRequest
                { 
                    UserId = auth.UserId,
                    MaintRequestInitiationId = auth.MaintRequestInitiationId,
                    AuthorizationType = auth.AuthorizationType,
                    Satus = auth.Satus
                }
            );

            _sacoContext.SaveChanges();
        }

        public void DeleteAuthorization(AuthorizationRequest auth)
        {
            _sacoContext.AuthorizationRequests.Remove(auth);
            _sacoContext.SaveChanges();
        }

        public void Update(int AuthId, string Type, string CommentReason)
        {
            var getAuth = _sacoContext.AuthorizationRequests.FirstOrDefault(i => i.Id == AuthId);

            getAuth.Satus = Type;
            getAuth.CommentRejection = CommentReason;
            getAuth.ConfirmationDate = DateTime.Now;

            _sacoContext.Update<AuthorizationRequest>(getAuth);
            _sacoContext.SaveChanges();
        }
    }
}
