using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IRequestInitiationListViewModel
    {
        #region Properties

        public Status currentStatus { get; set; }
        public IEnumerable<MaintRequestInitiation> filteredMaintRequests { get; set; }
        ObservableCollection<MaintRequestInitiation> requests { get; }
        ObservableCollection<Equipment> equipment { get; }
        public ObservableCollection<Status> statusList { get; set; }
        public int StatusId { get; set; }
        public int MaintReqId { get; set; }

        //int RequestId { get; }
        //string RequestDetails { get; }
        //DateTime DateRaised { get; }

        #endregion

        #region Methods

        Task LoadRequests();
        void LoadNewRequests();
        Task LoadReqsByStatusId(int statusId);
        void ExportList();

        #endregion
    }
}
