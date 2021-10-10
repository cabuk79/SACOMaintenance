using Microsoft.EntityFrameworkCore;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess
{
    public class PlantRequestDataProvider : IPlantRequest
    {
        private readonly SACOMaintenanceContext _areaDBContext;
        public PlantRequestDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            //SacoMaintenanceContext = new SACOMaintenanceContext();
            _areaDBContext = sacoMaintenanceContext;
        }

        //public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditPlantRequestInfo(int maintReqId, PlantRequest plantRequest)
        {
            _areaDBContext.PlantRequests.Add
            (
                new PlantRequest 
                {
                    IsolationNitricAcid = plantRequest.IsolationNitricAcid,
                    IsolatedPhosphoricAcid = plantRequest.IsolatedPhosphoricAcid,
                    IsolatedSodiumHydroxide = plantRequest.IsolatedSodiumHydroxide,
                    IsolatedSulphuricAcid = plantRequest.IsolatedSulphuricAcid,
                    IsolatedOther = plantRequest.IsolatedOther,
                    DrainingLinesNitricAcid = plantRequest.DrainingLinesNitricAcid,
                    DrainingLinesSodiumHydroxide = plantRequest.DrainingLinesSodiumHydroxide,
                    DrainingLinesSulphuricAcid = plantRequest.DrainingLinesSulphuricAcid,
                    DrainingLinesOther = plantRequest.DrainingLinesOther,
                    IsolationsCompressedAir = plantRequest.IsolationsCompressedAir,
                    IsolationsElectrical = plantRequest.IsolationsElectrical,
                    IsolationsGas = plantRequest.IsolationsGas,
                    IsolationsMechanical = plantRequest.IsolationsMechanical,
                    IsolationsSteam = plantRequest.IsolationsSteam,
                    IsolationsWater = plantRequest.IsolationsWater,
                    IsolationsOther = plantRequest.IsolationsOther,
                    OtherPrecautions = plantRequest.OtherPrecautions,
                    AuthorisationToWorkUserId = plantRequest.AuthorisationToWorkUserId,
                    AuthorisationDatTime = plantRequest.AuthorisationDatTime,
                    ReceiptPersonDoingWorkUserId = plantRequest.ReceiptPersonDoingWorkUserId,
                    ReceiptCompanyId = plantRequest.ReceiptCompanyId,
                    ClearancePosition = plantRequest.ClearancePosition,
                    ClearanceDateTime = plantRequest.ClearanceDateTime,
                    MaintRequestId = plantRequest.MaintRequestId
                }
            );
            _areaDBContext.SaveChanges();
        }

        public void GetPlantRequestInfo(int maintReqId)
        {
            throw new NotImplementedException();
        }

        public async Task<PlantRequest> GetSignalPlantRequestInfo(int Id)
        {
            var plantRequest = await _areaDBContext.PlantRequests.FirstOrDefaultAsync(i => i.Id == Id);
            return plantRequest;
        }

        public async Task<PlantRequest> GetSinalPlantRequestInfo(int Id)
        {
            var plantRequest = await _areaDBContext.PlantRequests.FirstOrDefaultAsync(i => i.MaintRequestId == Id);
            return plantRequest;
        }
    }
}
