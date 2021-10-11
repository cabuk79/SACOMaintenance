using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IGeneralRequest
    {
        void GetGeneralRequestInfo(int maintReqId);
        void AddEditGeneralRequestInfo(int maintReqId, GeneralRequest generalRequest, string newEdit);
        Task<GeneralRequest> GetSingalGeneralRequestInfo(int Id);
    }
}
