using SACOMaintenance.BuisnessModels;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Linq;

namespace SACOMaintenance.DataAccess
{
    public class GeneralRequestDataProvider : IGeneralRequest
    {
        public GeneralRequestDataProvider()
        {
            SacoMaintenanceContext = new SACOMaintenanceContext();
        }

        public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditGeneralRequestInfo(int maintReqId, GeneralRequest generalRequest)
        {
            SacoMaintenanceContext.GeneralRequests.Add
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
            SacoMaintenanceContext.SaveChanges();
        }

        public void GetGeneralRequestInfo(int maintReqId)
        {
            
        }

        public GeneralRequest GetSingalGeneralRequestInfo(int maintReqId)
        {
            var generalRequest = SacoMaintenanceContext.GeneralRequests.FirstOrDefault(i => i.MaintRequestId == maintReqId);
            return generalRequest;
        }
    }
}
