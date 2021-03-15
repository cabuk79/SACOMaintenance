using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IMaintRequestFullViewModel
    {
        #region properties

        MaintRequestInitiation maintReqInitation { get; set; }
        IMaintRequestInitiation MaintReqDataProvider { get; }
        int maintReqId { get; set; }
        string maintReqDetails { get; set; }
        int? maintReqAreaId { get; set; }
        #endregion

        #region methods
        MaintRequestInitiation GetMaintReqInitation(int maintReqId);
        #endregion
    }
}
