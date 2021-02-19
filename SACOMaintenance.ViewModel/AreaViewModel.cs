using SACOMaintenance.BuisnessModels;
using SACOMaintenance.DataAccess.Interfaces;
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
    public class AreaViewModel : INotifyPropertyChanged
    {
        private Area area;
        public ObservableCollection<Area> areas { get; } = new();
        public ObservableCollection<Factory> factories { get; } = new();

        public AreaViewModel(IArea areaDataProvider, IFactory factoryDataProvider)
        {
            //this.area = area;
            area = new Area();
            AreaDataProvider = areaDataProvider;
            this.factoryDataProvider = factoryDataProvider;
        }

        public void Load()
        {
            var areasList = AreaDataProvider.LoadAllAreas();
            areas.Clear();

            foreach(var areaItem in areasList)
            {
                areas.Add(areaItem);
            }

            var factoriesList = factoryDataProvider.LoadAllFactories();
            factories.Clear();

            foreach(var factoryItem in factoriesList)
            {
                factories.Add(factoryItem);
            }
        }

        public string AreaName
        {
            get => area.AreaName;
            set
            {
                if (area.AreaName != value)
                {
                    area.AreaName = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public int FactoryId
        {
            get => area.FactoryId;
            set
            {
                if(area.FactoryId != value)
                {
                    area.FactoryId = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public bool AreaExists { get; set; }

        public Area newArea = new Area();
        private readonly IFactory factoryDataProvider;

        public void SaveArea(Area area)
        {          
            AreaDataProvider.UpdateArea(area);
        }

        public void AddNewArea(Area areaToAdd) //string areaName)
        {
            Area areaExists = AreaDataProvider.FindAreaByName(areaToAdd.AreaName); // areaName);

            if(areaExists == null)
            {
                AreaExists = false;
                AreaDataProvider.AddEditArea(newArea);                             
            }
            else
            {
                AreaExists = true;
            }            
        }

        public IArea AreaDataProvider { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
