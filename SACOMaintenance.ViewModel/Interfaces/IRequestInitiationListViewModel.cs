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

        ObservableCollection<MaintRequestInitiation> requests { get; }
        ObservableCollection<Equipment> equipment { get; }

        //int RequestId { get; }
        //string RequestDetails { get; }
        //DateTime DateRaised { get; }

        #endregion

        #region Methods

        void LoadRequests();

        #endregion
    }
}
