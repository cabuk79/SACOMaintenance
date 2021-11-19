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
    public class PartViewModel : INotifyPropertyChanged, IPartViewModel
    {
        public ObservableCollection<Part> parts { get; set; } = new();

        public IPart PartDataProvider { get; }
        public Part SelectedPart { get; set; }
        public ObservableCollection<Supplier> suppliers { get; set; } = new();

        public PartViewModel(IPart partDataProvider)
        {
            PartDataProvider = partDataProvider;
        }

        public async Task LoadAllParts()
        {
            var partsList = new ObservableCollection<Part>(await PartDataProvider.LoadAllPArts());
            parts.Clear();

            foreach(var partItem in partsList)
            {
                parts.Add(partItem);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async void LoadSinglePart(int Id)
        {
            SelectedPart = await PartDataProvider.GetSinglePartAndSuppliers(Id);
            var allSuppliers = new ObservableCollection<Supplier>(await PartDataProvider.LoadAllSuppliers());
            suppliers.Clear();

            foreach(var supplierItem in allSuppliers)
            {
                suppliers.Add(supplierItem);
            }
        }
    }
}
