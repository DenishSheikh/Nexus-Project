namespace Nexus_Project.Models.DTO
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; } 
        public int RoleId { get; set; }
        public Roles Roles { get; set; }
        

    }
}
