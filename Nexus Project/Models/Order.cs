using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nexus_Project.Models
{
    public class Order
    {
        [Key]
        public Guid  OrderId { get; set; }
        
        public Guid PlanId { get; set; }
        [ForeignKey("PlanId")]
        public ConnectionPlan Plan { get; set; }
        public List<ConnectionPlan> ConnectionList { get; set; }

        public DateTime OrderDate { get; set; }
        public string Status { get; set; }


    }

}
