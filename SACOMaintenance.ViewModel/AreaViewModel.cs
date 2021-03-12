using SACOMaintenance.Common.ModelDB;
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
    public class AreaViewModel : INotifyPropertyChanged, IAreaViewModel
    {
        

        public AreaModel area { get; set; }
        public ObservableCollection<AreaModel> areas { get; } = new();
        public ObservableCollection<Factory> factories { get; } = new();

        public AreaViewModel(IArea areaDataProvider, IFactory factoryDataProvider)
        {
            //this.area = area;
            area = new AreaModel();
            AreaDataProvider = areaDataProvider;
            this.factoryDataProvider = factoryDataProvider;
            Load(); 
        }

        public void Load()
        {
            var areasList = AreaDataProvider.LoadAllAreas();
            areas.Clear();

            foreach (var areaItem in areasList)
            {
                areas.Add(areaItem);
            }

            var factoriesList = factoryDataProvider.LoadAllFactories();
            factories.Clear();

            foreach (var factoryItem in factoriesList)
            {
                factories.Add(factoryItem);
            }
        }

        AreaModel IAreaViewModel.LoadSingleArea(int areaId)
        {
            area = AreaDataProvider.LoadSingleArea(areaId);
            return area;
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

        public int AreaId
        {
            get => area.Id;
            set
            {
                if(area.Id != value)
                {
                    area.Id = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public string CommentsNotes
        {
            get => area.CommentsNotes;
            set
            {
                if (area.CommentsNotes != value);
                {
                    area.CommentsNotes = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public int? FactoryId
        {
            get => area.FactoryId;
            set
            {
                if (area.FactoryId != value)
                {
                    area.FactoryId = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public bool AreaExists { get; set; }

        public AreaModel newArea = new AreaModel();
        private readonly IFactory factoryDataProvider;

        public void SaveArea(AreaModel area)
        {
            AreaDataProvider.UpdateArea(area);
        }

        public void AddNewArea(AreaModel areaToAdd) //string areaName)
        {
            AreaModel areaExists = AreaDataProvider.FindAreaByName(areaToAdd.AreaName); // areaName);

            if (areaExists == null)
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

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
