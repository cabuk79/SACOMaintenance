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
    public class FactoryViewModel : INotifyPropertyChanged, IFactoryViewModel
    {
        public Factory factory { get; set; } = new();

        public IFactory FactoryDataProvider { get; }

        public FactoryViewModel(IFactory factoryDataProvider)
        {
            this.FactoryDataProvider = factoryDataProvider;
            Load();
        }

        public ObservableCollection<Factory> factories { get; set; } = new();

        public int FactoryId
        {
            get => factory.Id;
            set
            {
                if(factory.Id != value)
                {
                    factory.Id = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public string FactoryName
        {
            get => factory.FactoryName;
            set
            {
                if(factory.FactoryName != value)
                {
                    factory.FactoryName = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        

        public event PropertyChangedEventHandler Propertychanged;

        public void AddNewFactory(Factory factory)
        {
            throw new NotImplementedException();
        }

        public void Load()
        {
            var factoryList = FactoryDataProvider.LoadAllFactories();
            factories.Clear();

            foreach(var factoryItem in factoryList)
            {
                factories.Add(factoryItem);
            }
        }

        public Factory LoadSingleFactory(int factoryId)
        {
            factory = FactoryDataProvider.ViewSingleFactory(factoryId);
            return factory;
        }

        public void UpdateFactory(Factory factory)
        {
            throw new NotImplementedException();
        }





        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
