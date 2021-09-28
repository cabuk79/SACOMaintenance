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
    public class RequestsGraphViewModel : INotifyPropertyChanged, IRequestsGraphViewModel
    {
        public IMaintRequestInitiation MaintReqDataProvider { get; }

        public ObservableCollection<MaintRequestInitiation> MaintReqs { get; set; } = new();

        public event PropertyChangedEventHandler PropertyChanged;

        public RequestsGraphViewModel(IMaintRequestInitiation requestDataProvider)
        {
            MaintReqDataProvider = requestDataProvider;
        }

      
        public int GetRequestsByStatusCount(int statusId)
        {
            var maintRequests = MaintReqDataProvider.LoadReqBasedOnStatus(statusId);
            MaintReqs.Clear();

            foreach(var item in maintRequests)
            {
                MaintReqs.Add(item);
            }

            return MaintReqs.Count;
        }

        public ObservableCollection<Priority> GetPriorties()
        {
            var prios = new ObservableCollection<Priority>(MaintReqDataProvider.LoadAllRequestsPriority().ToList());
            return prios;
        }

        //public ObservableCollection<MaintRequestInitiation> GetRequestsByPriority()
        //{
        //    var requests = new ObservableCollection<MaintRequestInitiation>(MaintReqDataProvider.LoadAllRequestsPriority().ToList());
        //    return requests;
        //}

        //public int GetRequestsByPriority(int priorityId)
        //{
        //    var request = MaintReqDataProvider.LoadAllRequestsPriority(priorityId);
        //    return request.Count();
        //}

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
