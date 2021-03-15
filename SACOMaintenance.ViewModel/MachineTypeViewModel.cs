using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
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

        public void LoadAllMachineTypes()
        {
            var machineList = MachineTypeDataProvider.LoadAllMachines();
            machinesTypes.Clear();

            foreach(var machineTypeItem in machineList)
            {
                machinesTypes.Add(machineTypeItem);
            }
        }

        public MachineType LoadSingleMachineType(int machineTypeId)
        {
            machineType = MachineTypeDataProvider.ViewSingleMachineType(machineTypeId);
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
