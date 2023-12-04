using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nexus_Project.Models
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }

        public Customer CustomerId { get; set; }
        public ConnectionPlan PlanId { get; set; }

        public DateTime OrderDate { get; set; }
        public string Status { get; set; }


    }

}
