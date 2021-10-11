using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IAreaViewModel
    {
        public AreaModel area { get; set; }
        IArea AreaDataProvider { get; }
        bool AreaExists { get; set; }
        string AreaName { get; set; }
        string CommentsNotes { get; set; }
        ObservableCollection<AreaModel> areas { get; }
        ObservableCollection<Factory> factories { get; }
        int FactoryId { get; set; }

        event PropertyChangedEventHandler PropertyChanged;

        void AddNewArea(AreaModel areaToAdd);
        void Load();
        void SaveArea(AreaModel area);
       Task<AreaModel> LoadSingleArea(int areaId);
    }
}