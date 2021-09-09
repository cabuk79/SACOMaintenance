using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SACOMaintenance.ViewModel
{
    public class DashboardViewModel : INotifyPropertyChanged, IDashboardViewModel
    {
        public ObservableCollection<MaintRequestInitiation> MaintReqs { get; set; } = new();
        public IMaintRequestInitiation MaintReqDataProvider { get; }
        public ObservableCollection<MaintRequestInitiation> MaintReqsAssignedOpen { get; set; } = new();
        public ObservableCollection<MaintRequestInitiation> MaintReqsNew { get; set; } = new();
        public ObservableCollection<MaintRequestInitiation> MaintReqCurrentYear { get; set; } = new();

        public event PropertyChangedEventHandler PropertyChanged;

        public DashboardViewModel(IMaintRequestInitiation maintReqDataProvider)
        {
            MaintReqDataProvider = maintReqDataProvider;
            //LoadMaintReqs();
        }

        public void LoadMaintReqs()
        {
            //var list = MaintReqDataProvider.LoadAllRequestInitations();
            var list = MaintReqDataProvider.LoadNewRequests();
            MaintReqs.Clear();

            foreach(var item in list)
            {
                MaintReqs.Add(item);
            }
        }

        public void LoadNewReqs()
        {
            var list = MaintReqDataProvider.LoadNewRequests();
            MaintReqsNew.Clear();

            foreach(var item in list)
            {
                MaintReqsNew.Add(item);
            }
        }

        public void LoadAssignedOpenReqs()
        {
            var list = MaintReqDataProvider.LoadReqsAssignedOpen();
            MaintReqsAssignedOpen.Clear();

            foreach(var item in list)
            {
                MaintReqsAssignedOpen.Add(item);
            }
        }

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void LoadReqsCurrentYear()
        {
            var list = MaintReqDataProvider.LoadAllRequestsCurrentYear();
            MaintReqCurrentYear.Clear();

            foreach(var item in list)
            {
                MaintReqCurrentYear.Add(item);
            }
        }
    }
}
