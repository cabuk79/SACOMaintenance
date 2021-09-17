using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System;

namespace SACOMaintenance.DataAccess
{
    public class MaintRequestInitiationDataProvider : IMaintRequestInitiation
    {
        private readonly SACOMaintenanceContext _requestInitationDBContext;

        public MaintRequestInitiationDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            //SacoMaintenanceContext = new SACOMaintenanceContext();
            _requestInitationDBContext = sacoMaintenanceContext;
            //ObservableCollection<Risk> riskList = new ObservableCollection<Risk>();
    }

        //public IQueryable<Risk> riskList { get; set; }
        ObservableCollection<Risk> riskList { get; set; }

        //public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditRequestInitiation(MaintRequestInitiation maintRequestInitiation)
        {
            MaintRequestInitiation newRequest = new MaintRequestInitiation
            {
                DateRaised = DateTime.Now,
                CompanyId = 1, //maintRequestInitiation.CompanyId,
                FactoryId = maintRequestInitiation.FactoryId,
                AreaId = maintRequestInitiation.AreaId,
                EquipmentId = maintRequestInitiation.EquipmentId,
                RequestedById = 1, //maintRequestInitiation.RequestedById,
                RequestDetails = maintRequestInitiation.RequestDetails,
                RequestTypeId = maintRequestInitiation.RequestTypeId,
                StatusId = 1 //set the default value to new
            };

            _requestInitationDBContext.MaintRequestInitiations.Add(newRequest); 
            _requestInitationDBContext.SaveChanges();

            //Get all the risks for the request type either General or Plant
            var riskType = ""; 
            if(newRequest.RequestTypeId == 1) { riskType = "Plant"; } else { riskType = "Both"; }
            LoadRisksByMaintType(riskType);

            //Loop through the risks and add them into the maintreqrisk link table
            var newRisk = new MaintRequestInitiationRisk();
            foreach (var item in riskList)
            {
                newRisk.MaintRequestInitiationId = newRequest.Id;
                newRisk.RiskId = item.Id;
                newRisk.RiskLevel = "";

                _requestInitationDBContext.Add(newRisk);
                _requestInitationDBContext.SaveChanges();
            }
        }

        //Load a single request with all of the Navigvation properties populated
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
                .Include(s => s.Status)
                .ToList();
            return maintReqInitationList;
        }

        public IEnumerable<MaintRequestInitiation> LoadReqBasedOnStatus(int statusId)
        {
            var maintReqInitationList = _requestInitationDBContext.MaintRequestInitiations
                .Include(e => e.Equipment)
                .Include(s => s.Status).Where(si => si.StatusId == statusId)
                .ToList();
            return maintReqInitationList;
        }

        public IEnumerable<MaintRequestInitiation> LoadRequestInitiationWithEquipment()
        {
            var maintReqInitationList = _requestInitationDBContext.MaintRequestInitiations
                .Include(e => e.Equipment)
                .Include(s => s.Status)
                .ToList();
            return maintReqInitationList;
        }

        public IEnumerable<MaintRequestInitiation> LoadNewRequests()
        {
            var maintReqInitationList = _requestInitationDBContext.MaintRequestInitiations.Where(s => s.StatusId == 7)
                .Include(e => e.Equipment)
                .Include(s => s.Status)
                .ToList();
            return maintReqInitationList;
        }

        public IEnumerable<MaintRequestInitiation> LoadAllRequestsCurrentYear()
        {
            var currentYear = DateTime.Now.Year;

            var maintReqInitationList = _requestInitationDBContext.MaintRequestInitiations.Where(d => d.DateRaised.Year == currentYear).ToList();
            return maintReqInitationList;
        }

        public IEnumerable<MaintRequestInitiation> LoadReqsAssignedOpen()
        {
            var maintReqInitationList = _requestInitationDBContext.MaintRequestInitiations.Where(s => s.StatusId == 8)
                .Include(e => e.Equipment)
                .Include(s => s.Status)
                .ToList();
            return maintReqInitationList;
        }


        //public ObservableCollection<Risk> LoadRisksByMaintType(string maintType)
        //{
        //    ObservableCollection<Risk> riskList =
        //        new ObservableCollection<Risk>(
        //            _requestInitationDBContext.Risks
        //            .Where(type => type.MaintRequestType == maintType)
        //            );

        //    return riskList;
        //}

        ObservableCollection<MaintRequestInitiationRisk> IMaintRequestInitiation.LoadMaintRiskData(int maintReqId)
        {
            ObservableCollection<MaintRequestInitiationRisk> listInfo =
                new ObservableCollection<MaintRequestInitiationRisk>(_requestInitationDBContext.Set<MaintRequestInitiationRisk>()
                .Where(mr => mr.MaintRequestInitiationId == maintReqId).ToList());

            return listInfo;
        }

        //Get the Risks for the type of request it is General or Plant
        public void LoadRisksByMaintType(string maintType)
        {
            if(maintType == "Plant")
            {
                riskList = new ObservableCollection<Risk>(_requestInitationDBContext.Risks.ToList());
            }
            else
            {
                riskList = new ObservableCollection<Risk>(_requestInitationDBContext.Risks.Where(type => type.MaintRequestType == maintType).ToList());
            }
        }

        
    }
}
