using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nexus_Project.Models
{
    public class Customer
    {
       [Key]
       public Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public ProductEquipment ProductEquipmentId { get; set; }


    }

}
