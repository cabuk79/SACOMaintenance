using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel
{
    public class AreaViewModel : INotifyPropertyChanged, IAreaViewModel
    {
        

        public AreaModel area { get; set; }
        public ObservableCollection<AreaModel> areas { get; } = new();
        public ObservableCollection<Factory> factories { get; } = new();
        public IArea AreaDataProvider { get; }
        public AreaViewModel(IArea areaDataProvider, IFactory factoryDataProvider)
        {
            //this.area = area;
            area = new AreaModel();
            AreaDataProvider = areaDataProvider;
            this.factoryDataProvider = factoryDataProvider;
            Load(); 
        }

        public async void Load()
        {
            var areasList = new ObservableCollection<AreaModel>(await AreaDataProvider.LoadAllAreas());
            areas.Clear();

            foreach (var areaItem in areasList)
            {
                areas.Add(areaItem);
            }

            var factoriesList = new ObservableCollection<Factory>(await factoryDataProvider.LoadAllFactories());            
            factories.Clear();

            foreach (var factoryItem in factoriesList)
            {
                factories.Add(factoryItem);
            }
        }

        public async Task<AreaModel> LoadSingleArea(int areaId)
        {
            area = await AreaDataProvider.LoadSingleArea(areaId);
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

        public int FactoryId
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
