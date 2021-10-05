using SACOMaintenance.Common.ModelDB;
using System.Collections.ObjectModel;
using SACOMaintenance.DataAccess.Interfaces;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IDashboardViewModel
    {
        #region properties

        public IMaintRequestInitiation MaintReqDataProvider { get; }
        public ObservableCollection<MaintRequestInitiation> MaintReqs { get; set; }
        public ObservableCollection<MaintRequestInitiation> MaintReqsAssignedOpen { get; set; }
        public ObservableCollection<MaintRequestInitiation> MaintReqsNew { get; set; }
        public ObservableCollection<MaintRequestInitiation> MaintReqCurrentYear { get; set; }
        public int yearStart { get; set; }
        //public int Id { get; set; }
        //public string MaintRequestDetails { get; set; }
        #endregion


        #region methods

        public void LoadMaintReqs();
        public void LoadAssignedOpenReqs();
        public void LoadNewReqs();
        public void LoadReqsCurrentYear();
        #endregion
    }
}
