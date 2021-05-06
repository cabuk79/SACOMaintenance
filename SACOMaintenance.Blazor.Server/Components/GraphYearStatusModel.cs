using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SACOMaintenance.Blazor.Server.Components
{
    public class GraphYearStatusModel
    {
        public string Year { get; set; }
        public string Month { get; set; }
        public int Count { get; set; }
    }
}
