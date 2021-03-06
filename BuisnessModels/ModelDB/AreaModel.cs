﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class AreaModel
    {
        public int Id { get; set; }
        public string AreaName { get; set; }
        public string CommentsNotes { get; set; }
        public int? FactoryId { get; set; } //FK to the factory table
        //public Factory Factory { get; set; }

        public List<MaintRequestInitiation> MaintReqInitations = new List<MaintRequestInitiation>();

        //public List<Equipment> Equipment = new List<Equipment>();
    }
}
