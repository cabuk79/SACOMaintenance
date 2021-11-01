using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SACOMaintenance.Common.ModelDB
{
    public class AuthorizationRequest
    {
        public int Id { get; set; }
        public int MaintRequestInitiationId { get; set; }
        public string UserId { get; set; }

        public string AuthorizationType { get; set; }
        public string Satus { get; set; }
        public DateTime RequestedDate { get; set; }
        public DateTime LastChaseDate { get; set; }
        public DateTime ConfirmationDate { get; set; }
        public string CommentRejection { get; set; }
        //[ForeignKey("MaintRequestInitiationId")]
        //public virtual MaintRequestInitiation MaintRequestInitiation { get; set; }
    }
}
