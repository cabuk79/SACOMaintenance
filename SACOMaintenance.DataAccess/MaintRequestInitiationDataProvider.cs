using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace SACOMaintenance.DataAccess
{
    public class MaintRequestInitiationDataProvider : IMaintRequestInitiation
    {
        private readonly SACOMaintenanceContext _requestInitationDBContext;
    
        public MaintRequestInitiationDataProvider(SACOMaintenanceContext sacoMaintenanceContext)
        {
            _requestInitationDBContext = sacoMaintenanceContext;
    }

        ObservableCollection<Risk> riskList { get; set; } = new();

        IEnumerable<MaintRequestInitiationRisk> risksDataList { get; set; }
        ObservableCollection<MaintRequestInitiationRisk> IMaintRequestInitiation.risksDataList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int AddEditRequestInitiation(MaintRequestInitiation maintRequestInitiation)
        {
            MaintRequestInitiation newRequest = new MaintRequestInitiation
            {
                DateRaised = DateTime.Now,
                CompanyId = maintRequestInitiation.CompanyId, //maintRequestInitiation.CompanyId,
                FactoryId = maintRequestInitiation.FactoryId,
                AreaId = maintRequestInitiation.AreaId,
                EquipmentId = maintRequestInitiation.EquipmentId,
                UserId = maintRequestInitiation.UserId, //maintRequestInitiation.RequestedById,
                RequestDetails = maintRequestInitiation.RequestDetails,
                RequestTypeId = maintRequestInitiation.RequestTypeId,
                StatusId = 1,
                PriorityId = (int)maintRequestInitiation.PriorityId //set the default value to new
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
                newRisk.H = false;
                newRisk.M = false;
                newRisk.L = false;

                _requestInitationDBContext.Add(newRisk);
                _requestInitationDBContext.SaveChanges();
            }

            return newRequest.Id;
        }

        public void UpdateMaintReq(MaintRequestInitiation maintReqToUpdate)
        {
            _requestInitationDBContext.Update(maintReqToUpdate);          
        }

        public void UpdateRiskRecords(ObservableCollection<MaintRequestInitiationRisk> risksUpdate)
        {
            //loop through eash risk to update in risksUpdate then update
            foreach(var item in risksUpdate)
            {
                //find the record
                var foundItem = _requestInitationDBContext.MaintRequestInitiationRisk
                    .Where(ri => ri.RiskId == item.RiskId && ri.MaintRequestInitiationId == item.MaintRequestInitiationId).FirstOrDefault();

                foundItem.H = item.H;
                foundItem.M = item.M;
                foundItem.L = item.L;

                _requestInitationDBContext.Update(foundItem);
                _requestInitationDBContext.SaveChanges();
            }
        }

        public void UpdateIsolationsRecords(List<string> isolationsChosen, int maintId, List<int> allIsolationId)  //add the isolations full list to remove them all then use IsolationsChosen to add them
        {
            foreach(var item in allIsolationId)
            {
                var isolationsWithRequest = _requestInitationDBContext.Isolations
                    .Include(b => b.MaintRequestInitiations.Where(i => i.Id == maintId))
                    .Single(s => s.Id == item);

                if(isolationsWithRequest.MaintRequestInitiations.Count > 0)
                {
                    var req = isolationsWithRequest.MaintRequestInitiations[0];

                    isolationsWithRequest.MaintRequestInitiations.Remove(req);

                    _requestInitationDBContext.SaveChanges();
                }                
            }  
        }

        //Load a single request with all of the Navigvation properties populated
        public MaintRequestInitiation GetSingleRequestInitiation(int Id)
        {
            var maintReqInitiation = _requestInitationDBContext.MaintRequestInitiations
                .AsNoTracking()
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

        
        //public IEnumerable<MaintRequestInitiation> LoadAllRequestInitations()
        public async Task<IEnumerable<MaintRequestInitiation>> LoadAllRequestInitations()
        {
            //var maintReqInitationList = _requestInitationDBContext.MaintRequestInitiations
            //    .Include(e => e.Equipment)
            //    .Include(s => s.Status)
            //    .ToList();
            //return maintReqInitationList;
            return await _requestInitationDBContext.MaintRequestInitiations
                .Include(e => e.Equipment)
                .Include(s => s.Status)
                .ToListAsync();
        }

        public async Task<IEnumerable<MaintRequestInitiation>> LoadReqBasedOnStatus(int statusId)
        {
            //var maintReqInitationListStatus = _requestInitationDBContext.MaintRequestInitiations
            //    .Include(e => e.Equipment)
            //    .Include(s => s.Status).Where(si => si.StatusId == statusId)
            //    .ToList();
            //return maintReqInitationListStatus;
            return await _requestInitationDBContext.MaintRequestInitiations
                .Include(e => e.Equipment)
                .Include(s => s.Status).Where(si => si.StatusId == statusId)
                .ToListAsync();
        }

        //public IEnumerable<MaintRequestInitiation> LoadRequestInitiationWithEquipment()
        public async Task<IEnumerable<MaintRequestInitiation>> LoadRequestInitiationWithEquipment() 
        {
            //var maintReqInitationListEquip = _requestInitationDBContext.MaintRequestInitiations
            //    .Include(e => e.Equipment)
            //    .Include(s => s.Status)
            //    .ToList();
            //return maintReqInitationListEquip;
            return await _requestInitationDBContext.MaintRequestInitiations
                .Include(e => e.Equipment)
                .Include(s => s.Status)
                .ToListAsync();
        }

        //public IEnumerable<Priority> LoadAllRequestsPriority()
        public async Task<IEnumerable<Priority>> LoadAllRequestsPriority()
    {
        //var requestsPrio = _requestContext.Priorites.ToList();
        //return requestsPrio;
        return await _requestInitationDBContext.Priorites.ToListAsync();
        }

        //public IEnumerable<MaintRequestInitiation> LoadReqsByUser(string userId)
        public async Task<IEnumerable<MaintRequestInitiation>> LoadReqsByUser(string userId)
        {
            //var maintReqsByUserAll = _requestInitationDBContext.MaintRequestInitiations
            //    .Where(u => u.UserId == userId)
            //    .Include(e => e.Equipment)
            //    .Include(s => s.Status)
            //    .Include(u => u.Users)
            //    .ToList();
            //return maintReqsByUserAll; 

            var list =  await _requestInitationDBContext.MaintRequestInitiations
                .Where(u => u.UserId == userId)
                .Include(e => e.Equipment)
                .Include(s => s.Status)
                .Include(u => u.Users)
                .ToListAsync();

            return list;
        }

        //public IEnumerable<MaintRequestInitiation> LoadReqsByUserOpen(string userId)
        public async Task<IEnumerable<MaintRequestInitiation>> LoadReqsByUserOpen(string userId)
        {
            //var maintReqsByUserStatus = _requestInitationDBContext.MaintRequestInitiations
            //    .Where(u => u.UserId == userId && u.StatusId != 3)
            //    .Include(e => e.Equipment)
            //    .Include(s => s.Status)
            //    .Include(u => u.Users)
            //    .ToList();
            //return maintReqsByUserStatus;

            return await _requestInitationDBContext.MaintRequestInitiations
                .Where(u => u.UserId == userId && u.StatusId != 3)
                .Include(e => e.Equipment)
                .Include(s => s.Status)
                .Include(u => u.Users)
                .ToListAsync();
        }

        //public IEnumerable<MaintRequestInitiation> LoadNewRequests()
        public async Task<IEnumerable<MaintRequestInitiation>> LoadNewRequests()
        {
            //var maintReqInitationListNew = _requestInitationDBContext.MaintRequestInitiations.Where(s => s.StatusId == 7)
            //    .Include(e => e.Equipment)
            //    .Include(s => s.Status)
            //    .ToList();
            //return maintReqInitationListNew;

            return await _requestInitationDBContext.MaintRequestInitiations.Where(s => s.StatusId == 7)
                .Include(e => e.Equipment)
                .Include(s => s.Status)
                .ToListAsync();
        }

        //public IEnumerable<MaintRequestInitiation> LoadAllRequestsCurrentYear()
        public async Task<IEnumerable<MaintRequestInitiation>> LoadAllRequestsCurrentYear()
        {
            var currentYear = DateTime.Now.Year;

            //var maintReqInitationListCurrentYear = _requestInitationDBContext.MaintRequestInitiations.Where(d => d.DateRaised.Year == currentYear).ToList();
            //return maintReqInitationListCurrentYear;

            return await _requestInitationDBContext.MaintRequestInitiations.Where(d => d.DateRaised.Year == currentYear).ToListAsync();
        }

        //public IEnumerable<MaintRequestInitiation> LoadReqsAssignedOpen()
        public async Task<IEnumerable<MaintRequestInitiation>> LoadReqsAssignedOpen()
        {
            //var maintReqInitationListAssignedOpen = _requestInitationDBContext.MaintRequestInitiations.Where(s => s.StatusId == 8)
            //    .Include(e => e.Equipment)
            //    .Include(s => s.Status)
            //    .ToList();
            //return maintReqInitationListAssignedOpen;

            return await _requestInitationDBContext.MaintRequestInitiations.Where(s => s.StatusId == 8)  //TOD: workout this maybe do it on name?
                .Include(e => e.Equipment)
                .Include(s => s.Status)
                .ToListAsync();
        }

        //public IEnumerable<MaintRequestInitiationRisk> LoadMaintRiskData(int maintReqId)
        public async Task<IEnumerable<MaintRequestInitiationRisk>> LoadMaintRiskData(int maintReqId)
        {
            //var riskDataLinks = _requestInitationDBContext.MaintRequestInitiationRisk
            //    .Where(i => i.MaintRequestInitiationId == maintReqId).ToList();

            //return riskDataLinks;

            return await _requestInitationDBContext.MaintRequestInitiationRisk
                .Where(i => i.MaintRequestInitiationId == maintReqId).ToListAsync();
        }

        //Get the Risks for the type of request it is General or Plant
        public async Task<IEnumerable<Risk>> LoadRisksByMaintType (string maintType)
        {
            if(maintType == "Plant")
            {
                return await _requestInitationDBContext.Risks.ToListAsync();
            }
            else
            {
                return await _requestInitationDBContext.Risks.Where(type => type.MaintRequestType == maintType).ToListAsync();
            }
        }

        public void LoadRiskLevel(int maintReqId)
        {
            throw new NotImplementedException();
        }

        
    }
}
