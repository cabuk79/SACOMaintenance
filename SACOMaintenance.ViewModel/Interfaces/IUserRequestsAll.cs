using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SACOMaintenance.Common.ModelDB;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IUserRequestsAll
    {
        #region Properties

        ObservableCollection<MaintRequestInitiation> Requests { get; }
        ObservableCollection<MaintRequestInitiation> RequestsOpen { get; }

        #endregion

        #region Methods

        Task<ObservableCollection<MaintRequestInitiation>> LoadAllRequestsForUser(string userId);
        Task<ObservableCollection<MaintRequestInitiation>> LoadallRequestsForUserOpen(string userId);
        #endregion
    }
}
