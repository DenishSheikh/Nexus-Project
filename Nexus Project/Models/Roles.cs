using System.ComponentModel.DataAnnotations;

namespace Nexus_Project.Models
{
    public class Roles
    {
         [Key]
      public Guid RolesId { get; set; }
     
        public string RolesName { get; set; }
    }
}
