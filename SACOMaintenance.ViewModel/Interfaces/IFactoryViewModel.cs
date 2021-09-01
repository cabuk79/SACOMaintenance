using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IFactoryViewModel
    {
        public Factory factory { get; set; }
        IFactory FactoryDataProvider { get; }
        ObservableCollection<Factory> factories { get; set; }

        //public ObservableCollection<Equipment> areasList { get; set; }

        public int FactoryId { get; }
        public string FactoryName { get; set; }



        void AddNewFactory(Factory factory);
        void Load();
        void UpdateFactory(Factory factory);
        Factory LoadSingleFactory(int factoryId);

        event PropertyChangedEventHandler Propertychanged;
    }
}
