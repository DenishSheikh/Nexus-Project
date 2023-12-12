using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nexus_Project.Models
{
    public class Customer
    {
       [Key]
       public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        //[ForeignKey("ProductEquipmentId:Guid"
        //public ProductEquipment ProductEquipmentId { get; set; }
        public int RoleId { get; set; }
        public Roles Roles { get; set; }
        public List<Roles> RolesList { get; set; }




    }

}
