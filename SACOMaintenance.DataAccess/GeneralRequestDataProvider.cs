using Microsoft.EntityFrameworkCore;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess
{
    public class GeneralRequestDataProvider : IGeneralRequest
    {
        public GeneralRequestDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            _sacoMaintenanceContext = sacoMaintenanceContext;
        }

        private readonly SACOMaintenanceContext _sacoMaintenanceContext;

        public void AddEditGeneralRequestInfo(int maintReqId, GeneralRequest generalRequest, string newEdit)
        {
            if(newEdit == "New")
            {
                _sacoMaintenanceContext.GeneralRequests.Add
                            (
                                new GeneralRequest
                                {
                                    MaintRequestId = maintReqId,
                                    AuthorityToWorkUserId = generalRequest.AuthorityToWorkUserId,
                                    AuthorityToWorkDateTime = generalRequest.AuthorityToWorkDateTime,
                                    DetailOfWorkCompleted = generalRequest.DetailOfWorkCompleted,
                                    DetailOfWorkCompeltedUserId = generalRequest.DetailOfWorkCompeltedUserId,
                                    DetailOfWorkCompeltedDateTime = generalRequest.DetailOfWorkCompeltedDateTime,
                                    WorkCompletedYesNo = generalRequest.WorkCompletedYesNo,
                                    WorkCompletedDetails = generalRequest.WorkCompletedDetails,
                                    SignOffDetails = generalRequest.SignOffDetails,
                                    WorkCompletedSignOffYesNo = generalRequest.WorkCompletedSignOffYesNo,
                                    WorkCompletedSignOffUserId = generalRequest.WorkCompletedSignOffUserId,
                                    WorkCompletedSignOffDateTime = generalRequest.WorkCompletedSignOffDateTime
                                }
                            );
            }
            else if(newEdit == "Edit")
            {
                _sacoMaintenanceContext.Update(generalRequest);
            }
            
            _sacoMaintenanceContext.SaveChanges();
        }

        public void GetGeneralRequestInfo(int maintReqId)
        {
            
        }

        public async Task<GeneralRequest> GetSingalGeneralRequestInfo(int maintReqId)
        {
            var generalRequest = await _sacoMaintenanceContext.GeneralRequests
                .Include(p => p.MaintRequestInitiation.PPEEquipment)               
                .FirstOrDefaultAsync(i => i.MaintRequestId == maintReqId);
            return generalRequest;


            //.Include(pp => pp.MaintRequestInitiation.PPEEquipment)
        }
    }
}
