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
        public ObservableCollection<Priority> prios { get; set; } = new();

        public event PropertyChangedEventHandler PropertyChanged;

        public RequestsGraphViewModel(IMaintRequestInitiation requestDataProvider)
        {
            MaintReqDataProvider = requestDataProvider;
        }

      
        public async Task<int> GetRequestsByStatusCount(int statusId)
        {
            MaintReqs.Clear();
            MaintReqs = new ObservableCollection<MaintRequestInitiation>(await MaintReqDataProvider.LoadReqBasedOnStatus(statusId));
        

            //foreach(var item in maintRequests)
            //{
            //    MaintReqs.Add(item);
            //}

            return MaintReqs.Count;
        }

        public async Task GetPriorties()
        {
            prios.Clear();
            var list = new ObservableCollection<Priority>(await MaintReqDataProvider.LoadAllRequestsPriority());
            
            foreach(var item in list)
            {
                prios.Add(item);
            }
            
     
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
