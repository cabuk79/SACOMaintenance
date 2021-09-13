using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Model for the grpah for maintenance requests total by year
/// </summary>

namespace Models.DTO
{
    public class YearMaintenanceRequestModel
    {
        public int YearName { get; set; }
        public int YearNumber { get; set; }
    }
}
