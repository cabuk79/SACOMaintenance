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
        public ObservableCollection<MaintRequestInitiation> Requests { get; } = new();
        public ObservableCollection<MaintRequestInitiation> RequestsOpen { get; } = new();
        public IMaintRequestInitiation _maintReqDataProvider { get; }

        public UserRequestAllViewModel(IMaintRequestInitiation maintReqDataProvider)
        {
            _maintReqDataProvider = maintReqDataProvider;
        }

        public async Task<ObservableCollection<MaintRequestInitiation>> LoadAllRequestsForUser(string userId)
        {
            var list = await _maintReqDataProvider.LoadReqsByUser(userId);
            Requests.Clear();

            foreach(var item in list)
            {
                Requests.Add(item);
            }

            return Requests;
        }

        public async Task<ObservableCollection<MaintRequestInitiation>> LoadallRequestsForUserOpen(string userId)
        {
            var list = await _maintReqDataProvider.LoadReqsByUserOpen(userId);
            RequestsOpen.Clear();

            foreach(var item in list)
            {
                RequestsOpen.Add(item);
            }

            return RequestsOpen;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
