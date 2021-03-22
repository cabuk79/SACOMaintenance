using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IMaintRequestFullViewModel
    {
        #region properties

        MaintRequestInitiation maintReqInitation { get; set; }
        ObservableCollection<MaintRequestInitiationRisk> RiskInfoList { get; set; }
        List<Risk> Risks { get; }
        IMaintRequestInitiation MaintReqDataProvider { get; }
        IRisk RiskDataProvider { get; }
        int maintReqId { get; set; }
        string maintReqDetails { get; set; }
        int? maintReqAreaId { get; set; }
        #endregion

        #region methods
        MaintRequestInitiation GetMaintReqInitation(int maintReqId);
        ObservableCollection<MaintRequestInitiationRisk> LoadRiskLevel(int maintReqId);
        //ObservableCollection<Risk> LoadRisks();
        #endregion
    }
}
