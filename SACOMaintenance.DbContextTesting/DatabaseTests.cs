using Microsoft.VisualStudio.TestTools.UnitTesting;
using SACOMaintenance.BuisnessModels;
using SACOMaintenance.Data;
using SACOMaintenance.DataAccess;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace SACOMaintenance.DbContextTesting
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void EnterManyToManyTableMaintReqInitation()
        {
            //using (var context = new SACOMaintenanceContext())
            //{
                //context.Database.EnsureDeleted();
                //context.Database.EnsureCreated();
            //}

            //Get PPE Items
            var PpeDataProvider = new PPEDataProvider();
            List<PPE> ppeItem = new List<PPE>();
            ppeItem = (List<PPE>)PpeDataProvider.LoadAllPPE();

            //Get Risk Items
            var riskDataProvider = new RiskDataProvider();
            List<Risk> maintRisks = new List<Risk>();
            maintRisks = (List<Risk>)riskDataProvider.LoadallRisks();

            //Add new maintenance request and add PPE item to List
            var maintInition = new MaintRequestInitiation();
            maintInition.RequestedById = 1;
            maintInition.AreaId = 1;
            maintInition.FactoryId = 1;
            maintInition.CompanyId = 1;
            maintInition.RequestDetails = "This is request one detail and it needs fixing";
            maintInition.DateRaised = DateTime.Now;
            maintInition.EquipmentId = 1;
            maintInition.RequestTypeId = 1;

            var maintInitiation = new MaintRequestInitiationDataProvider();
            maintInitiation.AddEditRequestInitiation(maintInition);
            var getMaint = maintInitiation.GetSingleRequestInitiation(1);

            getMaint.Risks.AddRange(maintRisks);
            getMaint.PPEEquipment.AddRange(ppeItem);

            maintInitiation.AddEditRequestInitiation(getMaint);
        }

        [TestMethod]
        public void EnterManyToManyTableMaintReqInitation2()
        {
            //using (var context = new SACOMaintenanceContext())
            //{
                //context.Database.EnsureDeleted();
                //context.Database.EnsureCreated();
            //}

            //Get PPE Items
            var PpeDataProvider = new PPEDataProvider();
            List<PPE> ppeItem = new List<PPE>();
            ppeItem = (List<PPE>)PpeDataProvider.LoadAllPPE();

            //Get Risk Items
            var riskDataProvider = new RiskDataProvider();
            List<Risk> maintRisks = new List<Risk>();
            maintRisks = (List<Risk>)riskDataProvider.LoadallRisks();

            //Add new maintenance request and add PPE item to List
            var maintInition = new MaintRequestInitiation();
            maintInition.RequestedById = 1;
            maintInition.AreaId = 1;
            maintInition.FactoryId = 1;
            maintInition.CompanyId = 1;
            maintInition.RequestDetails = "This is request one detail and it needs fixing";
            maintInition.DateRaised = DateTime.Now;
            maintInition.EquipmentId = 1;
            maintInition.RequestTypeId = 1;

            var maintInitiation = new MaintRequestInitiationDataProvider();
            maintInitiation.AddEditRequestInitiation(maintInition);
            var getMaint = maintInitiation.GetSingleRequestInitiation(2);

            getMaint.Risks.AddRange(maintRisks);
            getMaint.PPEEquipment.AddRange(ppeItem);

            maintInitiation.AddEditRequestInitiation(getMaint);
        }

        [TestMethod]
        public void CanInsertFactoryIntoDatabase()
        {
            using(var context = new SACOMaintenanceContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                var factory = new Factory();
                factory.FactoryName = "Factory testing";

                var factory1 = new Factory();
                factory1.FactoryName = "This is another factory";

                context.Factories.Add(factory);
                context.Factories.Add(factory1);
                context.SaveChanges();

                Assert.AreNotEqual(0, factory.Id);
            }
        }

        [TestMethod]
        public void CanInsertAreaIntoDatabase()
        {
            using (var context1 = new SACOMaintenanceContext())
            {
                context1.Database.EnsureDeleted();
                context1.Database.EnsureCreated();
            }
                var nameOfArea = "New area addition and testing";

                

                var area = new Area();
                area.AreaName = nameOfArea;

                AreaProvider areaProvider = new AreaProvider();
                areaProvider.AddEditArea(area);
               
                var foundArea = new Area();
                foundArea = areaProvider.FindAreaByName(nameOfArea);

                Assert.AreEqual(nameOfArea, foundArea.AreaName);
        }
    }
}
