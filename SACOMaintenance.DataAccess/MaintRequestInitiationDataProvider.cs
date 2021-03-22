using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace SACOMaintenance.DataAccess
{
    public class MaintRequestInitiationDataProvider : IMaintRequestInitiation
    {
        private readonly SACOMaintenanceContext _requestInitationDBContext;

        public MaintRequestInitiationDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            //SacoMaintenanceContext = new SACOMaintenanceContext();
            _requestInitationDBContext = sacoMaintenanceContext;
        }

        //public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditRequestInitiation(MaintRequestInitiation maintRequestInitiation)
        {
            _requestInitationDBContext.MaintRequestInitiations.Add
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
            _requestInitationDBContext.SaveChanges();
        }

        public MaintRequestInitiation GetSingleRequestInitiation(int Id)
        {
            var maintReqInitiation = _requestInitationDBContext.MaintRequestInitiations
                .Where(i => i.Id == Id)
                .Include(e => e.Equipment)
                .Include(c => c.Company)
                .Include(a => a.Area)
                .Include(f => f.Factory)
                .Include(p => p.PPEEquipment)
                .Include(r => r.Risks)
                .FirstOrDefault();
            return maintReqInitiation;
        }

        public IEnumerable<MaintRequestInitiation> LoadAllRequestInitations()
        {
            var maintReqInitationList = _requestInitationDBContext.MaintRequestInitiations
                .Include(e => e.Equipment)
                .ToList();
            return maintReqInitationList;
        }

       

        public IEnumerable<MaintRequestInitiation> LoadRequestInitiationWithEquipment()
        {
            var maintReqInitationList = _requestInitationDBContext.MaintRequestInitiations
                .Include(e => e.Equipment)
                .ToList();
            return maintReqInitationList;
        }

        ObservableCollection<MaintRequestInitiationRisk> IMaintRequestInitiation.LoadMaintRiskData(int maintReqId)
        {
            ObservableCollection<MaintRequestInitiationRisk> listInfo =
                new ObservableCollection<MaintRequestInitiationRisk>(_requestInitationDBContext.Set<MaintRequestInitiationRisk>()
                .Where(mr => mr.MaintRequestInitiationId == maintReqId).ToList());

            return listInfo;
        }
    }
}
