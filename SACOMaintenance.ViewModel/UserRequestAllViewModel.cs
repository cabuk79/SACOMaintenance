using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel
{
    public class UserRequestAllViewModel : INotifyPropertyChanged, IUserRequestsAll
    {
        public ObservableCollection<MaintRequestInitiation> Requests { get; set; } = new();
        public IMaintRequestInitiation _maintReqDataProvider { get; }

        public UserRequestAllViewModel(IMaintRequestInitiation maintReqDataProvider)
        {
            _maintReqDataProvider = maintReqDataProvider;
        }

        public async Task LoadAllRequestsForUser(string userId)
        {
            Requests = _maintReqDataProvider.LoadReqsByUser(userId);
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
