using System;
using car_heap.Core.Models;

namespace car_heap.Controllers.Resources
{
    public class OrderResource
    {
        public string IdentityId { get; set; }

        public int VehicleId { get; set; }

        public string Comment { get; set; }

        public KeyValuePairResource Status { get; set; }

        public DateTime DateRequested { get; set; }

        public DateTime DateExpired { get; set; }
    }
}