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

        IEnumerable<MaintRequestInitiationRisk> risksDataList { get; set; }
        ObservableCollection<MaintRequestInitiationRisk> IMaintRequestInitiation.risksDataList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //public SACOMaintenanceContext SacoMaintenanceContext { get; }

        public void AddEditRequestInitiation(MaintRequestInitiation maintRequestInitiation)
        {
            MaintRequestInitiation newRequest = new MaintRequestInitiation
            {
                DateRaised = DateTime.Now,
                CompanyId = maintRequestInitiation.CompanyId, //maintRequestInitiation.CompanyId,
                FactoryId = maintRequestInitiation.FactoryId,
                AreaId = maintRequestInitiation.AreaId,
                EquipmentId = maintRequestInitiation.EquipmentId,
                RequestedById = 1, //maintRequestInitiation.RequestedById,
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
            //Get all isolations from the table and loop through, remove any that are not in the isolations chosen and then loop through and
            //add the ones chosen

            //Get all Isolations where the maintenance id is equal to the maintenance id passed

            foreach(var item in allIsolationId)
            {
                var isolationsWithRequest = _requestInitationDBContext.Isolations
                    .Include(b => b.MaintRequestInitiation.Where(i => i.Id == maintId))
                    .Single(s => s.Id == item);

                if(isolationsWithRequest.MaintRequestInitiation.Count > 0)
                {
                    var req = isolationsWithRequest.MaintRequestInitiation[0];

                    isolationsWithRequest.MaintRequestInitiation.Remove(req);

                    _requestInitationDBContext.SaveChanges();
                }                
            }

            //loop through the isolationsChosen and add to the table the many-to-many relationships
            foreach(var item in isolationsChosen)
            {
                var newIsolationRequest = new IsolationMaintRequestInitiation
                {
                    IsolationId = Convert.ToInt32(item),
                    MaintReqInitationListId = maintId
                };
                _requestInitationDBContext.Add(newIsolationRequest);
                _requestInitationDBContext.SaveChanges();
            }
            




            //var isolationsWithRequest = _requestInitationDBContext.Isolations
            //    .Include(b => b.MaintRequestInitiation.Where(i => i.Id == maintId))
            //    .ToList();

            //var itemCount = isolationsWithRequest.Count;

            //foreach(var item in isolationsWithRequest)
            //{
                
                
                
            //}

            //for (int i = 0; i < itemCount; i++)
            //{
            //    var req = isolationsWithRequest.
            //}    




            //find if there is a record and if so then delete otherwise add
            //foreach(var item in isolationsChosen)
            //{
            //    var foundItem = _requestInitationDBContext.IsolationMaintRequestInitiations
            //                    .Where(i => i.MaintReqInitationListId == maintId && i.IsolationId == Convert.ToInt32(item)).FirstOrDefault();

            //    if(foundItem == null)
            //    {
            //        IsolationMaintRequestInitiation newReqIsolation = new IsolationMaintRequestInitiation();
            //        newReqIsolation.IsolationId = Convert.ToInt32(item);
            //        newReqIsolation.MaintReqInitationListId = maintId;

            //        _requestInitationDBContext.IsolationMaintRequestInitiations.Add(newReqIsolation);
            //    }
            //}
            //_requestInitationDBContext.SaveChanges();   
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

        public IEnumerable<MaintRequestInitiationRisk> LoadMaintRiskData(int maintReqId)
        {
            var riskDataLinks = _requestInitationDBContext.MaintRequestInitiationRisk
                .Where(i => i.MaintRequestInitiationId == maintReqId).ToList();

            return riskDataLinks;
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

        //void IMaintRequestInitiation.LoadMaintRiskData(int maintReqId)
        //{
        //    throw new NotImplementedException();
        //}

        public void LoadRiskLevel(int maintReqId)
        {
            throw new NotImplementedException();
        }
    }
}
