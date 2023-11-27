using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Nexus_Project.Models
{
    public class ProductEquipment
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }

}
