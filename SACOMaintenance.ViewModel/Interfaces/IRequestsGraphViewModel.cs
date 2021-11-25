using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IRequestsGraphViewModel
    {
        public IMaintRequestInitiation MaintReqDataProvider { get; }
        public ObservableCollection<MaintRequestInitiation> MaintReqs { get; set; }
        public ObservableCollection<Priority> prios { get; set; }
        public int closedCount { get; set; }
        public int newCount { get; set; }
        public int onHoldCount { get; set; }

        Task GetRequestsByStatusCount();
        //public ObservableCollection<MaintRequestInitiation> GetRequestsByPriority();
        Task GetPriorties();
    }
}
