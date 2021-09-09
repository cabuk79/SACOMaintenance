using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IOrderViewModel
    {
        ObservableCollection<Order> Orders { get; }
        void LoadAllOrders();
    }
}
