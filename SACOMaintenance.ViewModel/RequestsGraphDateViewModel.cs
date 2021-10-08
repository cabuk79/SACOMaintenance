using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel
{
    public class RequestsGraphDateViewModel : INotifyPropertyChanged, IRequestsGraphDateViewModel
    {
        public IMaintRequestInitiation MaintReqDataProvider { get; }

        public IEnumerable<MaintRequestInitiation> MaintReqs { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public RequestsGraphDateViewModel(IMaintRequestInitiation requestDataProvider)
        {
            MaintReqDataProvider = requestDataProvider;
        }

        public async void GetRequests()
        {
            MaintReqs = new ObservableCollection<MaintRequestInitiation>(await MaintReqDataProvider.LoadAllRequestInitations());
        }

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
