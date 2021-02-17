using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.BuisnessModels
{
    public class Area
    {
        public int Id { get; set; }
        public string AreaName { get; set; }
        public string CommentsNotes { get; set; }
        public int FactoryId { get; set; } //FK to the factory table
    }
}
