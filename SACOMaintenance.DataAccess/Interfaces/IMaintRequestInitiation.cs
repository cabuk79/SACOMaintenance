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
        Task<List<MaintRequestInitiation>> LoadAllRequestInitations();
        Task<MaintRequestInitiation> GetSingleRequestInitiation(int Id);
        public int AddEditRequestInitiation(MaintRequestInitiation maintRequestInitiation);
        ObservableCollection<MaintRequestInitiationRisk> risksDataList { get; set; }
        Task<List<MaintRequestInitiationRisk>> LoadMaintRiskData(int maintReqId);
        Task<List<MaintRequestInitiation>> LoadRequestInitiationWithEquipment();
        Task<List<MaintRequestInitiation>> LoadNewRequests();
        Task<List<MaintRequestInitiation>> LoadReqsAssignedOpen();
        Task<List<MaintRequestInitiation>> LoadReqBasedOnStatus(int statusId);
        Task<List<MaintRequestInitiation>> LoadReqsByUserOpen(string userId);
        Task<List<Priority>> LoadAllRequestsPriority();
        Task<List<MaintRequestInitiation>> LoadReqsByUser(string userId);
        //IEnumerable<MaintRequestInitiationRisk> LoadMaintRiskData(int maintReqId);
        Task<List<MaintRequestInitiation>> LoadAllRequestsCurrentYear();

        public void LoadRiskLevel(int maintReqId);

        public void LoadRisksByMaintType(string maintType);
        public void UpdateMaintReq(MaintRequestInitiation maintReqToUpdate);
        public void UpdateRiskRecords(ObservableCollection<MaintRequestInitiationRisk> risksUpdate);
        public void UpdateIsolationsRecords(List<string> isolationsChosen, int maintId, List<int> allIsolationId);
        //public void UpdateRecords(ObservableCollection<MaintRequestInitiationRisk> risksUpdate);
    }
}
