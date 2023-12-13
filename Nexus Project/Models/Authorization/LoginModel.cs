using System.ComponentModel.DataAnnotations;

namespace NexusAuth.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name Is Required")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        public string? Password { get; set; }   




    }
}
