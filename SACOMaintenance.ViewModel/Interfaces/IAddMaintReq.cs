using System.Collections.ObjectModel;
using System.Threading.Tasks;
using SACOMaintenance.Common.ModelDB;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IAddMaintReq
    {
        ObservableCollection<Priority> Priorities { get; set; }
        ObservableCollection<Department> Departments { get; set; }
        //ObservableCollection<Factory> Factories { get; set; }
        //ObservableCollection<AreaModel> Areas { get; set; }
        //ObservableCollection<Equipment> Equipments { get; set; }
        //ObservableCollection<Company> Companies { get; set; }

        //public MaintRequestInitiation MaintReq { get; set; }

        //public int NewAddedMaintId { get; set; }
        //public int CompanyId { get; set; }
        //public int FactoryId { get; set; }
        //public int AreaId { get; set; }
        //public int EquipmentId { get; set; }
        //public int PriorityId { get; set; }

        ////Task<ObservableCollection<Priority>> LoadPriorities();
        public void LoadPriorities();
        public void LoadDepartments();
        //Task<ObservableCollection<Company>> LoadCompanies();
        //Task<ObservableCollection<Factory>> LoadFactories();
        //// Task<ObservableCollection<AreaModel>> LoadAreasByFactory();
        //void LoadAreasByFactory();
        //Task<ObservableCollection<Equipment>> LoadEquipmentByArea();
    }
}
