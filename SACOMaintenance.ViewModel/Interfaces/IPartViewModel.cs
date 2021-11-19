using SACOMaintenance.Common.ModelDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IPartViewModel
    {
        ObservableCollection<Part> parts { get; set; }
        public Task LoadAllParts();
        public void LoadSinglePart(int Id);
        public Part SelectedPart { get; set; }
        ObservableCollection<Supplier> suppliers { get; set; }
    }
}
