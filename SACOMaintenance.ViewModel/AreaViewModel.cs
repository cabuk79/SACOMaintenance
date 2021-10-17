using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel
{
    public class AreaViewModel : INotifyPropertyChanged, IAreaViewModel
    {

        public AreaModel Area { get; set; } = new();
        public ObservableCollection<AreaModel> areas { get; } = new();
        public ObservableCollection<Factory> factories { get; } = new();


        public string AreaName { get; set; }
        //{
        //    get => Area.AreaName;
        //    set
        //    {
        //        if (Area.AreaName != value)
        //        {
        //            Area.AreaName = value;
        //            RaisePropertychangedEvent();
        //        }
        //    }
        //}

        public int AreaId
        {
            get => Area.Id;
            set
            {
                if (Area.Id != value)
                {
                    Area.Id = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public string CommentsNotes
        {
            get => Area.CommentsNotes;
            set
            {
                if (Area.CommentsNotes != value) ;
                {
                    Area.CommentsNotes = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public int FactoryId
        {
            get => Area.FactoryId;
            set
            {
                if (Area.FactoryId != value)
                {
                    Area.FactoryId = value;
                    RaisePropertychangedEvent();
                }
            }
        }


        public IArea AreaDataProvider { get; }
        public IFactory FactoryDataProvider { get; }
        public IArea AreaDataProviderSingle { get; }


        public AreaViewModel(IArea areaDataProvider, IFactory factoryDataProvider, IArea areaDataProviderSingle)
        {           
            AreaDataProvider = areaDataProvider;
            FactoryDataProvider = factoryDataProvider;
            AreaDataProviderSingle = areaDataProviderSingle;
        }


        //public async void Load()
        public async Task Load()
        {
            var areasList = new ObservableCollection<AreaModel>(await AreaDataProvider.LoadAllAreas());
            areas.Clear();

            foreach (var areaItem in areasList)
            {
                areas.Add(areaItem);
            }

            var factoriesList = new ObservableCollection<Factory>(await FactoryDataProvider.LoadAllFactories());            
            factories.Clear();

            foreach (var factoryItem in factoriesList)
            {
                factories.Add(factoryItem);
            }
        }

        public async Task LoadSingleArea(int areaId)
        {
            Area = await AreaDataProviderSingle.LoadSingleArea(areaId);
            AreaName = Area.AreaName;
        }
     
        public bool AreaExists { get; set; }

        public AreaModel newArea = new AreaModel();

        public void SaveArea(AreaModel area)
        {
            AreaDataProvider.UpdateArea(area);
        }

        public async void AddNewArea(AreaModel areaToAdd) //string areaName)
        {
            AreaModel areaExists = await AreaDataProvider.FindAreaByName(areaToAdd.AreaName); // areaName);

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

        
        

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



       


        
    }
}
