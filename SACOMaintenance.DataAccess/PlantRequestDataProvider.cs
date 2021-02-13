using SACOMaintenance.BuisnessModels;
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
        public PlantRequestDataProvider()
        {
            SacoMaintenanceContext = new SACOMaintenanceContext();
        }

        public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditPlantRequestInfo(int maintReqId, PlantRequest plantRequest)
        {
            SacoMaintenanceContext.PlantRequests.Add
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
            SacoMaintenanceContext.SaveChanges();
        }

        public void GetPlantRequestInfo(int maintReqId)
        {
            
        }

        public PlantRequest GetSignalPlantRequestInfo(int Id)
        {
            var plantRequest = SacoMaintenanceContext.PlantRequests.FirstOrDefault(i => i.Id == Id);
            return plantRequest;
        }
    }
}
