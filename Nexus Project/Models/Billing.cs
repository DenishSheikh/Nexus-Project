using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nexus_Project.Models
{
    public class Billing
    {
        [Key]
        public Guid BillingId { get; set; }

      
        public Customer CustomerId { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
    }

    

}
