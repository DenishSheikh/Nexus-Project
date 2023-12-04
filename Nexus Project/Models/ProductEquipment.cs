using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nexus_Project.Models
{
    public class ProductEquipment
    {
        [Key]
        public Guid ProductEquipmentId { get; set; }
        public string ProductEquipmentName { get; set; }
    }

}
