using SACOMaintenance.BuisnessModels;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SACOMaintenance.DataAccess
{
    public class MaintRequestInitiationDataProvider : IMaintRequestInitiation
    {
        public MaintRequestInitiationDataProvider()
        {
            SacoMaintenanceContext = new SACOMaintenanceContext();
        }

        public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditRequestInitiation(MaintRequestInitiation maintRequestInitiation)
        {
            SacoMaintenanceContext.MaintRequestInitiations.Add
            (
                new MaintRequestInitiation
                {
                    DateRaised = maintRequestInitiation.DateRaised,
                    CompanyId = maintRequestInitiation.CompanyId,
                    FactoryId = maintRequestInitiation.FactoryId,
                    AreaId = maintRequestInitiation.AreaId,
                    EquipmentId = maintRequestInitiation.EquipmentId,
                    RequestedById = maintRequestInitiation.RequestedById,
                    RequestDetails = maintRequestInitiation.RequestDetails,
                    RequestTypeId = maintRequestInitiation.RequestTypeId,
                    Status = maintRequestInitiation.Status
                }
            );
            SacoMaintenanceContext.SaveChanges();
        }

        public MaintRequestInitiation GetSingleRequestInitiation(int Id)
        {
            var maintReqInitiation = SacoMaintenanceContext.MaintRequestInitiations.Where(i => i.Id == Id)
                .Include(e => e.Equipment)
                .FirstOrDefault();
            return maintReqInitiation;
        }

        public IEnumerable<MaintRequestInitiation> LoadAllRequestInitations()
        {
            var maintReqInitationList = SacoMaintenanceContext.MaintRequestInitiations
                .Include(e => e.Equipment)
                .ToList();
            return maintReqInitationList;
        }
    }
}
