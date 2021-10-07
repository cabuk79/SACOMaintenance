using System;

namespace SACOMaintenance.Common.ModelDB
{
    public class UserAssignedReq
    {
        public int MaintRequestInitiationId { get; set; }
        public string UserId { get; set; }
        public DateTime UserAddedDate { get; set; }
    }
}
