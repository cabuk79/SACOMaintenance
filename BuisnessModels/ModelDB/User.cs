using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class User : IdentityUser
    {
        //public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Comment { get; set; }
        //public string UserName { get; set; }
        //public string Email { get; set; }
        public List<MaintRequestInitiation> MaintRequestInitiation { get; set; } = new List<MaintRequestInitiation>();
    }
}
