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
        IEnumerable<MaintRequestInitiation> LoadAllRequestInitations();
        MaintRequestInitiation GetSingleRequestInitiation(int Id);
        void AddEditRequestInitiation(MaintRequestInitiation maintRequestInitiation);
        ObservableCollection<MaintRequestInitiationRisk> risksDataList { get; set; }
        IEnumerable<MaintRequestInitiationRisk> LoadMaintRiskData(int maintReqId);
        IEnumerable<MaintRequestInitiation> LoadRequestInitiationWithEquipment();
        IEnumerable<MaintRequestInitiation> LoadNewRequests();
        IEnumerable<MaintRequestInitiation> LoadReqsAssignedOpen();
        IEnumerable<MaintRequestInitiation> LoadReqBasedOnStatus(int statusId);
        //IEnumerable<MaintRequestInitiationRisk> LoadMaintRiskData(int maintReqId);
        public IEnumerable<MaintRequestInitiation> LoadAllRequestsCurrentYear();

        public void LoadRiskLevel(int maintReqId);

        public void LoadRisksByMaintType(string maintType);
    }
}
