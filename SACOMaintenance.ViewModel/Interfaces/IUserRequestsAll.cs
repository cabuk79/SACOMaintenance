using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SACOMaintenance.Common.ModelDB;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IUserRequestsAll
    {
        #region Properties

        ObservableCollection<MaintRequestInitiation> Requests { get; set; }

        #endregion

        #region Methods

        public Task LoadAllRequestsForUser(string userId);

        #endregion
    }
}
