using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using SACOMaintenance.ViewModel.Interfaces;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace SACOMaintenance.ViewModel
{
    public class PlantMaintReqModelView : INotifyPropertyChanged, IPlantMaintReqViewModel
    {
        public PlantRequest plantRequest { get; set; } = new();

        public IPlantRequest PlantDataProvider { get; set; }

        public PlantMaintReqModelView(IPlantRequest plantDataProvider)
        {
            PlantDataProvider = plantDataProvider;
        }

        public int Id 
        {
            get => plantRequest.Id;
            set
            {
                if(plantRequest.Id != value)
                {
                    plantRequest.Id = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public bool IsolationNitricAcid
        {
            get => plantRequest.IsolationNitricAcid;
            set
            {
                if (plantRequest.IsolationNitricAcid != value)
                {
                    plantRequest.IsolationNitricAcid = value;
                    RaisePropertychangedEvent();
                }
            }
        }
        public bool IsolatedPhosphoricAcid
        {
            get => plantRequest.IsolatedPhosphoricAcid;
            set
            {
                if (plantRequest.IsolatedPhosphoricAcid != value)
                {
                    plantRequest.IsolatedPhosphoricAcid = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public bool IsolatedSodiumHyrodzide
        {
            get => plantRequest.IsolatedSodiumHydroxide;
            set
            {
                if (plantRequest.IsolatedSodiumHydroxide != value)
                {
                    plantRequest.IsolatedSodiumHydroxide = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public bool IsolatedSulphuricAcid
        {
            get => plantRequest.IsolatedSulphuricAcid;
            set
            {
                if (plantRequest.IsolatedSulphuricAcid != value)
                {
                    plantRequest.IsolatedSulphuricAcid = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public string IsolatedOther
        {
            get => plantRequest.IsolatedOther;
            set
            {
                if (plantRequest.IsolatedOther != value)
                {
                    plantRequest.IsolatedOther = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public bool DrainingLinedNitricAcid
        {
            get => plantRequest.DrainingLinesNitricAcid;
            set
            {
                if (plantRequest.DrainingLinesNitricAcid != value)
                {
                    plantRequest.DrainingLinesNitricAcid = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public bool DrainingLinedPhosphoricAcicd
        {
               get => plantRequest.DrainingLinesPhosphoricAcid;
            set
            {
                if (plantRequest.DrainingLinesPhosphoricAcid != value)
                {
                    plantRequest.DrainingLinesPhosphoricAcid = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public bool DrainingLinedSodiumHydroxide
        {
            get => plantRequest.DrainingLinesSodiumHydroxide;
            set
            {
                if (plantRequest.DrainingLinesSodiumHydroxide != value)
                {
                    plantRequest.DrainingLinesSodiumHydroxide = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public bool DrainingLinesSulphuricAcid
        {
            get => plantRequest.DrainingLinesSulphuricAcid;
            set
            {
                if (plantRequest.DrainingLinesSulphuricAcid != value)
                {
                    plantRequest.DrainingLinesSulphuricAcid = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public string DrainingLinesOther
        {
            get => plantRequest.DrainingLinesOther;
            set
            {
                if (plantRequest.DrainingLinesOther != value)
                {
                    plantRequest.DrainingLinesOther = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public bool IsolationsCompressedAir
        {
            get => plantRequest.IsolationsCompressedAir;
            set
            {
                if (plantRequest.IsolationsCompressedAir != value)
                {
                    plantRequest.IsolationsCompressedAir = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public bool IsolationsElectrical
        {
            get => plantRequest.IsolationsElectrical;
            set
            {
                if (plantRequest.IsolationsElectrical != value)
                {
                    plantRequest.IsolationsElectrical = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public bool IsolationsGas
        {
            get => plantRequest.IsolationsGas;
            set
            {
                if (plantRequest.IsolationsGas != value)
                {
                    plantRequest.IsolationsGas = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public bool IsolationsMechanical
        {
            get => plantRequest.IsolationsMechanical;
            set
            {
                if (plantRequest.IsolationsMechanical != value)
                {
                    plantRequest.IsolationsMechanical = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public bool IsolationsSteam
        {
            get => plantRequest.IsolationsSteam;
            set
            {
                if (plantRequest.IsolationsSteam != value)
                {
                    plantRequest.IsolationsSteam = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public bool IsolationsWater
        {
            get => plantRequest.IsolationsWater;
            set
            {
                if (plantRequest.IsolationsWater != value)
                {
                    plantRequest.IsolationsWater = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public string IsolationsOther
        {
            get => plantRequest.IsolationsOther;
            set
            {
                if (plantRequest.IsolationsOther != value)
                {
                    plantRequest.IsolationsOther = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        public string OtherPrecations
        {
            get => plantRequest.OtherPrecautions;
            set
            {
                if (plantRequest.OtherPrecautions != value)
                {
                    plantRequest.OtherPrecautions = value;
                    RaisePropertychangedEvent();
                }
            }
        }

        

        public event PropertyChangedEventHandler PropertyChanged;

        public void LoadAll(int id)
        {
            plantRequest = PlantDataProvider.GetSinalPlantRequestInfo(id);
        }

        private void RaisePropertychangedEvent([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
