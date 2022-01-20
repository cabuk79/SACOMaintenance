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
        private readonly SACOMaintenanceContext _requestInitationDBContext2;

        public MaintRequestInitiationDataProvider(SACOMaintenanceContext sacoMaintenanceContext,
            SACOMaintenanceContext sacoMaintenanceContext2)
        {
            _requestInitationDBContext = sacoMaintenanceContext;
            _requestInitationDBContext2 = sacoMaintenanceContext2;
        }

        //IEnumerable<Risk> riskList { get; set; }

        ObservableCollection<MaintRequestInitiationRisk> risksDataList { get; set; }
        ObservableCollection<Risk> listOfRisks { get; set; } = new();
        ObservableCollection<MaintRequestInitiationRisk> IMaintRequestInitiation.risksDataList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private void LoadRisksBasedOnMaintenanceType()
        {
            listOfRisks = new ObservableCollection<Risk>(_requestInitationDBContext.Risks
                .AsNoTracking()
                .Where(type => type.MaintRequestType == "Both").ToList());
        }

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
                PriorityId = (int)maintRequestInitiation.PriorityId, //set the default value to new
                DepartmentId = (int)maintRequestInitiation.DepartmentId
            };

            _requestInitationDBContext.MaintRequestInitiations.Add(newRequest); 
            _requestInitationDBContext.SaveChanges();
            _requestInitationDBContext.Entry(newRequest).State = EntityState.Detached;


            //Get all the risks for the request type either General or Plant
            var riskType = ""; 
            if(newRequest.RequestTypeId == 1) { riskType = "Plant"; } else { riskType = "Both"; }
           
            LoadRisksBasedOnMaintenanceType();

            //Loop through the risks and add them into the maintreqrisk link table
            foreach (var item in listOfRisks)
            {
                var newRisk = new MaintRequestInitiationRisk();
                newRisk.MaintRequestInitiationId = newRequest.Id;
                newRisk.RiskId = item.Id;
                newRisk.Level = "L";
 
                _requestInitationDBContext.MaintRequestInitiationRisk.Add(newRisk);
                _requestInitationDBContext.SaveChanges();
                _requestInitationDBContext.Entry(newRisk).State = EntityState.Detached;
            }

            //Create a General Maintenance Record in the database
            AddNewRecordToGeneralRequests(newRequest.Id);

            return newRequest.Id;
        }

        //Method to create a new record in the GeneralRequest table
        private void AddNewRecordToGeneralRequests(int reqId)
        {
            var GenReq = new GeneralRequest();
            GenReq.MaintRequestId = reqId;
            _requestInitationDBContext.GeneralRequests.Add(GenReq);
            _requestInitationDBContext.SaveChanges();
            _requestInitationDBContext.Entry(GenReq).State = EntityState.Detached;
        }

        

       

        /// <summary>
        /// Updates the status of the maintenance request
        /// </summary>
        /// <param name="statusId">The ID of the staus to update the request to</param>
        /// <param name="requestId">The ID of the maintenance request to Update</param>
        public void UpdateRequestStatus(int statusId, int requestId)
        {
            var foundRequest = _requestInitationDBContext.MaintRequestInitiations
                .AsNoTracking()
                .Where(id => id.Id == requestId).FirstOrDefault();

            foundRequest.StatusId = statusId;
            _requestInitationDBContext.Update(foundRequest);
            _requestInitationDBContext.SaveChanges();
            _requestInitationDBContext.Entry(foundRequest).State = EntityState.Detached;
        }

        public void UpdateRiskRecords(ObservableCollection<MaintRequestInitiationRisk> risksUpdate)
        {
            //loop through eash risk to update in risksUpdate then update
            foreach (var item in risksUpdate)
            {

                _requestInitationDBContext.Update(item);
                _requestInitationDBContext.SaveChanges();
                _requestInitationDBContext.Entry(item).State = EntityState.Detached;
            }
        }

        public void UpdateIsolationsRecords(List<Isolation> IsolationsSelected)//, MaintRequestInitiation maintReqId)
        {
            foreach(var isolationItem in IsolationsSelected)
            {
                isolationItem.MaintRequestInitiations.Clear();
            }
            //delete all isolations for the maintenance request
            //get the maint request
            var req = _requestInitationDBContext.MaintRequestInitiations
                .Where(i => i.Id == 133)
                .Include(iso => iso.Isolations)
                .Single();

            //req.Isolations.Clear();
            //maintReqId.Isolations.Clear();
            //maintReqId.Isolations.Clear();
            //loop through the isolations selected and add to the maintenance request
            //foreach (var item in req.Isolations)
            //{
            req.Isolations.Clear();
            _requestInitationDBContext.SaveChanges();
            //}

            var req2 = _requestInitationDBContext.MaintRequestInitiations
                .Where(i => i.Id == 133)
                .Include(iso => iso.Isolations)
                .Single();

            req2.Isolations.AddRange(IsolationsSelected);

            _requestInitationDBContext.SaveChanges();
            //_requestInitationDBContext.Update(req);
            //_requestInitationDBContext.Update(req);
            //_requestInitationDBContext.SaveChanges();
            //_requestInitationDBContext.SaveChanges();
            //_requestInitationDBContext.Entry(req).State = EntityState.Detached;
        }

        //public void UpdateIsolationsRecords(MaintRequestInitiation reqinit,
        //    List<string> isolationsChosen, int maintId, List<int> allIsolationId)  //add the isolations full list to remove them all then use IsolationsChosen to add them
        //{

        //    foreach (var item in allIsolationId)
        //    {
        //        var isolationsWithRequest = _requestInitationDBContext.Isolations
        //            .Include(b => b.MaintRequestInitiations.Where(i => i.Id == maintId))
        //            .Single(s => s.Id == item);

        //        if (isolationsWithRequest.MaintRequestInitiations.Count > 0)
        //        {
        //            var req = isolationsWithRequest.MaintRequestInitiations[0];

        //            isolationsWithRequest.MaintRequestInitiations.Remove(req);

        //            _requestInitationDBContext.SaveChanges();
        //        }
        //    }
        //}
        
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
                .Include(u => u.Users)
                .FirstOrDefault();

            _requestInitationDBContext.Entry(maintReqInitiation).State = EntityState.Detached;

            return maintReqInitiation;
        }

        //TODO: issues
        public void UpdateMaintReq(int idReq, MaintRequestInitiation maintReqToUpdate)
        {      
            var foundRequest = _requestInitationDBContext.MaintRequestInitiations
                .AsNoTracking()
                .Where(id => id.Id == idReq).FirstOrDefault();

            //foundRequest.RequestDetails = maintReqToUpdate.RequestDetails;
            foundRequest.Risks = maintReqToUpdate.Risks;

            _requestInitationDBContext.Update(foundRequest);
            _requestInitationDBContext.SaveChanges();
            _requestInitationDBContext.Entry(foundRequest).State = EntityState.Detached;
        }

        //public IEnumerable<MaintRequestInitiation> LoadAllRequestInitations()
        public async Task<IEnumerable<MaintRequestInitiation>> LoadAllRequestInitations()
        {
            //var maintReqInitationList = _requestInitationDBContext.MaintRequestInitiations
            //    .Include(e => e.Equipment)
            //    .Include(s => s.Status)
            //    .ToList();
            //return maintReqInitationList;
            var list = await _requestInitationDBContext.MaintRequestInitiations
                .AsNoTracking()
                .Include(e => e.Equipment)
                .Include(s => s.Status)
                .Include(u => u.Users)
                .ToListAsync();

            _requestInitationDBContext.Entry(list).State = EntityState.Detached;

            return list;

        }

        public async Task<IEnumerable<MaintRequestInitiation>> LoadReqBasedOnStatus() //(int statusId)
        {
            //var maintReqInitationListStatus = _requestInitationDBContext.MaintRequestInitiations
            //    .Include(e => e.Equipment)
            //    .Include(s => s.Status).Where(si => si.StatusId == statusId)
            //    .ToList();
            //return maintReqInitationListStatus;
            var list = await _requestInitationDBContext.MaintRequestInitiations
                .AsNoTracking()
                .Include(e => e.Equipment)
                .Include(s => s.Status) //.Where(si => si.StatusId == statusId)
                .ToListAsync();

            _requestInitationDBContext.Entry(list).State = EntityState.Detached;

            return list;
        }

        public async Task<IEnumerable<MaintRequestInitiation>> LoadReqBasedOnStatusId(int statusId)
        {
            //var maintReqInitationListStatus = _requestInitationDBContext.MaintRequestInitiations
            //    .Include(e => e.Equipment)
            //    .Include(s => s.Status).Where(si => si.StatusId == statusId)
            //    .ToList();
            //return maintReqInitationListStatus;
            var list =  await _requestInitationDBContext.MaintRequestInitiations
                .AsNoTracking()
                .Include(e => e.Equipment)
                .Include(s => s.Status).Where(si => si.StatusId == statusId)
                .ToListAsync();

            _requestInitationDBContext.Entry(list).State = EntityState.Detached;

            return list;
        }

        //public IEnumerable<MaintRequestInitiation> LoadRequestInitiationWithEquipment()
        public async Task<IEnumerable<MaintRequestInitiation>> LoadRequestInitiationWithEquipment() 
        {
            //var maintReqInitationListEquip = _requestInitationDBContext.MaintRequestInitiations
            //    .Include(e => e.Equipment)
            //    .Include(s => s.Status)
            //    .ToList();
            //return maintReqInitationListEquip;
            var list =  await _requestInitationDBContext.MaintRequestInitiations
                .AsNoTracking()
                .Include(e => e.Equipment)
                .Include(s => s.Status)
                .Include(u => u.Users)
                .ToListAsync();

            _requestInitationDBContext.Entry(list).State = EntityState.Detached;

            return list;
        }

        //public IEnumerable<Priority> LoadAllRequestsPriority()
        public async Task<IEnumerable<Priority>> LoadAllRequestsPriority()
        {
        //var requestsPrio = _requestContext.Priorites.ToList();
        //return requestsPrio;
            var list =  await _requestInitationDBContext.Priorites
                .AsNoTracking()
                .Include(m => m.MaintRes)
                .ToListAsync();

            _requestInitationDBContext.Entry(list).State = EntityState.Detached;

            return list;
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
                .AsNoTracking()
                .Where(u => u.UserId == userId)
                .Include(e => e.Equipment)
                .Include(s => s.Status)
                .Include(u => u.Users)
                .ToListAsync();

            _requestInitationDBContext.Entry(list).State = EntityState.Detached;

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

            var list = await _requestInitationDBContext.MaintRequestInitiations
                .AsNoTracking()
                .Where(u => u.UserId == userId && u.StatusId != 3)
                .Include(e => e.Equipment)
                .Include(s => s.Status)
                .Include(u => u.Users)
                .ToListAsync();

            _requestInitationDBContext.Entry(list).State = EntityState.Detached;

            return list;
        }

        //public IEnumerable<MaintRequestInitiation> LoadNewRequests()
        public async Task<IEnumerable<MaintRequestInitiation>> LoadNewRequests()
        {
            //var maintReqInitationListNew = _requestInitationDBContext.MaintRequestInitiations.Where(s => s.StatusId == 7)
            //    .Include(e => e.Equipment)
            //    .Include(s => s.Status)
            //    .ToList();
            //return maintReqInitationListNew;

            var list =  await _requestInitationDBContext.MaintRequestInitiations.Where(s => s.StatusId == 1)
                .AsNoTracking()
                .Include(e => e.Equipment)
                .Include(s => s.Status)
                .ToListAsync();

            _requestInitationDBContext.Entry(list).State = EntityState.Detached;

            return list;
        }

        //public IEnumerable<MaintRequestInitiation> LoadAllRequestsCurrentYear()
        public async Task<IEnumerable<MaintRequestInitiation>> LoadAllRequestsCurrentYear()
        {
            var currentYear = DateTime.Now.Year;

            //var maintReqInitationListCurrentYear = _requestInitationDBContext.MaintRequestInitiations.Where(d => d.DateRaised.Year == currentYear).ToList();
            //return maintReqInitationListCurrentYear;

            var list = await _requestInitationDBContext.MaintRequestInitiations
                .AsNoTracking()
                .Where(d => d.DateRaised.Year == currentYear).ToListAsync();

            _requestInitationDBContext.Entry(list).State = EntityState.Detached;

            return list;
        }

        //public IEnumerable<MaintRequestInitiation> LoadReqsAssignedOpen()
        public async Task<IEnumerable<MaintRequestInitiation>> LoadReqsAssignedOpen()
        {
            //var maintReqInitationListAssignedOpen = _requestInitationDBContext.MaintRequestInitiations.Where(s => s.StatusId == 8)
            //    .Include(e => e.Equipment)
            //    .Include(s => s.Status)
            //    .ToList();
            //return maintReqInitationListAssignedOpen;

            var list = await _requestInitationDBContext.MaintRequestInitiations.Where(s => s.StatusId == 2)  //TOD: workout this maybe do it on name?
                .AsNoTracking()
                .Include(e => e.Equipment)
                .Include(s => s.Status)
                .ToListAsync();

            _requestInitationDBContext.Entry(list).State = EntityState.Detached;

            return list;
        }

        //public IEnumerable<MaintRequestInitiationRisk> LoadMaintRiskData(int maintReqId)
        public async Task<IEnumerable<MaintRequestInitiationRisk>> LoadMaintRiskData(int maintReqId)
        {
            //var riskDataLinks = _requestInitationDBContext.MaintRequestInitiationRisk
            //    .Where(i => i.MaintRequestInitiationId == maintReqId).ToList();

            //return riskDataLinks;

            var list =  await _requestInitationDBContext.MaintRequestInitiationRisk
                .AsNoTracking()
                .Where(i => i.MaintRequestInitiationId == maintReqId).ToListAsync();
            
            //_requestInitationDBContext.Entry(list).State = EntityState.Detached;

            return list;
        }

        //Get the Risks for the type of request it is General or Plant
        //public void LoadRisksByMaintType (string maintType)
        //{
        //    //if(maintType == "Plant")
        //    //{
        //    //    //return await _requestInitationDBContext.Risks.ToListAsync();
        //    //    riskList = new ObservableCollection<Risk>((IEnumerable<Risk>)_requestInitationDBContext.Risks.Where(type => type.MaintRequestType == maintType).ToListAsync());
        //    //}
        //    //else
        //    //{
        //    //    //return
        //    risksDataList = _requestInitationDBContext.Risks.Where(type => type.MaintRequestType == maintType).ToList();
        //    //return risks;
        //    //}
        //}

        public void LoadRiskLevel(int maintReqId)
        {
            throw new NotImplementedException();
        }

        
    }
}
