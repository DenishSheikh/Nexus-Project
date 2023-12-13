using System.ComponentModel.DataAnnotations;

namespace NexusAuth.Model
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name Is Required")]

        public string? UserName  { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is Required ")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Password Is Required")]
        public string Password { get; set; }


    }
}
