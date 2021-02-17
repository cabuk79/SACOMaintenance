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

        public AreaViewModel(IArea areaDataProvider)
        {
            //this.area = area;
            area = new Area();
            AreaDataProvider = areaDataProvider;
        }

        public void Load()
        {
            var areasList = AreaDataProvider.LoadAllAreas();
            areas.Clear();

            foreach(var areaItem in areasList)
            {
                areas.Add(areaItem);
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

        public Area newArea = new Area();

        public void SaveArea(Area area)
        {
            AreaDataProvider.UpdateArea(area);
        }

        public void AddNewArea()
        {
            AreaDataProvider.AddEditArea(newArea);
        }

        public IArea AreaDataProvider { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertychangedEvent([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
