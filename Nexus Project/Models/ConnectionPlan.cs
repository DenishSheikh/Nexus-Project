using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nexus_Project.Models
{
    public class ConnectionPlan
    {
        [Key]
        public Guid PlanId { get; set; }
        public string PlanName { get; set; }
        public string Description { get; set; }
        public decimal Charges { get; set; }


    }

}
