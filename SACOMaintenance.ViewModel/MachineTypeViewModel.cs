using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;

namespace SACOMaintenance.ViewModel
{
    public class MachineTypeViewModel : INotifyPropertyChanged, IMachineTypeViewModel
    {
        public MachineType machineType { get; set; } = new();

        public IMachineType MachineTypeDataProvider { get; }

        public ObservableCollection<MachineType> machinesTypes { get; set; } = new();

        public MachineTypeViewModel(IMachineType machineTypeDataProvider)
        {
            MachineTypeDataProvider = machineTypeDataProvider;
            LoadAllMachineTypes();
        }


        public int MachineTypeId
        {
            get => machineType.Id;
            set
            { 
                if(machineType.Id != value)
                {
                    machineType.Id = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public string MachineTypeName
        {
            get => machineType.TypeName;
            set
            {
                if(machineType.TypeName != value)
                {
                    machineType.TypeName = value;
                    RaisePropertychangedEvent();
                }
            }
        }
        public string MachineTypeDescription
        {
            get => machineType.Description;
            set
            {
                if(machineType.Description != value)
                {
                    machineType.Description = value;
                    RaisePropertychangedEvent();
                }
            }
        }
            
        public event PropertyChangedEventHandler PropertyChanged;
        public event PropertyChangedEventHandler Propertychanged;

        public void AddNewMachineType(MachineType machineType)
        {
            throw new NotImplementedException();
        }

        public async void LoadAllMachineTypes()
        {
            var machineList = new ObservableCollection<MachineType>(await MachineTypeDataProvider.LoadAllMachines());
            machinesTypes.Clear();

            foreach(var machineTypeItem in machineList)
            {
                machinesTypes.Add(machineTypeItem);
            }
        }

        public async Task<MachineType> LoadSingleMachineType(int machineTypeId)
        {
            machineType = await MachineTypeDataProvider.ViewSingleMachineType(machineTypeId);
            return machineType;
        }

        public void UpdateMachineType(MachineType machineType)
        {
            throw new NotImplementedException();
        }

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
