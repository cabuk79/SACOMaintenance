using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IMachineTypeViewModel
    {
        #region Properties
        public MachineType machineType { get; set; }
        IMachineType MachineTypeDataProvider { get; }
        ObservableCollection<MachineType> machinesTypes { get; set; }
        public int MachineTypeId { get; }
        public string MachineTypeName { get; set; }
        public string MachineTypeDescription { get; set; }
        #endregion

        #region Methods
        void AddNewMachineType(MachineType machineType);
        void LoadAllMachineTypes();
        MachineType LoadSingleMachineType(int machineTypeId);
        void UpdateMachineType(MachineType machineType);
        #endregion

        event PropertyChangedEventHandler Propertychanged;
    }
}
