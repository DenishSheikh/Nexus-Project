using Microsoft.EntityFrameworkCore;

namespace Nexus_Project.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int PlanId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }


    }

}
