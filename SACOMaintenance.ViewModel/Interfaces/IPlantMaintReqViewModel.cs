using SACOMaintenance.Common.ModelDB;
using SACOMaintenance.DataAccess.Interfaces;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

//TDDO: create view model class of this
namespace SACOMaintenance.ViewModel.Interfaces
{
    public interface IPlantMaintReqViewModel
    {
        #region properties

        public PlantRequest plantRequest { get; set; }
        IPlantRequest PlantDataProvider { get; }

        public int Id { get; set; }
        public bool IsolationNitricAcid { get; set; }
        public bool IsolatedPhosphoricAcid { get; set; }
        public bool IsolatedSodiumHyrodzide {get;set;}
        public bool IsolatedSulphuricAcid { get; set; }
        public string IsolatedOther { get; set; }
        public bool DrainingLinedNitricAcid { get; set; }
        public bool DrainingLinedPhosphoricAcicd { get; set; }
        public bool DrainingLinedSodiumHydroxide { get; set; }
        public bool DrainingLinesSulphuricAcid { get; set; }
        public string DrainingLinesOther { get; set; }
        public bool IsolationsCompressedAir { get; set; }
        public bool IsolationsElectrical { get; set; }
        public bool IsolationsGas { get; set; }
        public bool IsolationsMechanical { get; set; }
        public bool IsolationsSteam { get; set; }
        public bool IsolationsWater { get; set; }
        public string IsolationsOther { get; set; }
        public string OtherPrecations { get; set; }

        #endregion


        #region methods

        public void LoadAll(int id);

        #endregion

    }
}
