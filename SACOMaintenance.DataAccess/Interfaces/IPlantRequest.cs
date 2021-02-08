using SACOMaintenance.BuisnessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IPlantRequest
    {
        void GetPlantRequestInfo(int maintReqId);
        void AddEditPlantRequestInfo(int maintReqId, PlantRequest generalRequest);
        void GetSinalPlantRequestInfo(int Id);
    }
}
