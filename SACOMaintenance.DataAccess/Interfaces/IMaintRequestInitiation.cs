using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.DataAccess.Interfaces
{
    public interface IMaintRequestInitiation
    {
        Task<IEnumerable<MaintRequestInitiation>> LoadAllRequestInitations();
        public MaintRequestInitiation GetSingleRequestInitiation(int Id);
        public int AddEditRequestInitiation(MaintRequestInitiation maintRequestInitiation);
        ObservableCollection<MaintRequestInitiationRisk> risksDataList { get; set; }
        Task<IEnumerable<MaintRequestInitiationRisk>> LoadMaintRiskData(int maintReqId);
        Task<IEnumerable<MaintRequestInitiation>> LoadRequestInitiationWithEquipment();
        Task<IEnumerable<MaintRequestInitiation>> LoadNewRequests();
        Task<IEnumerable<MaintRequestInitiation>> LoadReqsAssignedOpen();
        Task<IEnumerable<MaintRequestInitiation>> LoadReqBasedOnStatus(); //(int statusId);
        Task<IEnumerable<MaintRequestInitiation>> LoadReqsByUserOpen(string userId);
        Task<IEnumerable<Priority>> LoadAllRequestsPriority();
        Task<IEnumerable<MaintRequestInitiation>> LoadReqsByUser(string userId);
        //IEnumerable<MaintRequestInitiationRisk> LoadMaintRiskData(int maintReqId);
        Task<IEnumerable<MaintRequestInitiation>> LoadAllRequestsCurrentYear();

        public void LoadRiskLevel(int maintReqId);
        Task<IEnumerable<MaintRequestInitiation>> LoadReqBasedOnStatusId(int statusId);

        //Task<IEnumerable<Risk>> LoadRisksByMaintType(string maintType);
        //public void LoadRisksByMaintType(string maintType);
        public void UpdateMaintReq(MaintRequestInitiation maintReqToUpdate);
        public void UpdateRiskRecords(ObservableCollection<MaintRequestInitiationRisk> risksUpdate);
        public void UpdateIsolationsRecords(List<string> isolationsChosen, int maintId, List<int> allIsolationId);
        public void UpdateRequestStatus(int statusId, int requestId);
        //public void UpdateRecords(ObservableCollection<MaintRequestInitiationRisk> risksUpdate);
    }
}
