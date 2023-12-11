namespace Nexus_Project.Models.DTO
{
    public class EmployeeDto
    {
        public Guid EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public Roles Roles { get; set; }

    }
}
