using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using NexusAuth.Model;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NexusAuth.Controllers
{
    [ApiController]
    [Route("Auth/controller]")]
    public class AuthanticationController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AuthanticationController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var userExist = await _userManager.FindByNameAsync(model.UserName);
            if (userExist == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Responce { Status = "Error", Message = "User Already Exists!" });

            }
            ApplicationUser user = new ApplicationUser()
            {
                Email = model.EmailAddress,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.UserName,
                PasswordHash = model.Password
            };

            var result = await _userManager.CreateAsync(user);

            if (result.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Responce { Status = "Error", Message = "User Creation Failed!" });
            }

            return Ok(new Responce { Status = "200" });
        }


        //[HttpPost]
        //[Route("register-admin")]

        //public async Task<IActionResult> RegisterAdmin([FromBody] RegisterModel model)
        //{
        //    var userExist = await _userManager.FindByNameAsync(model.UserName);
        //    if(userExist !=null)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, new Responce
        //        {Status = "Error", Message = "User Already Exist" });
        //    }

        //    ApplicationUser user = new ApplicationUser();
        //    {
        //       user.Email = model.EmailAddress;
        //        user.UserName = model.UserName;
        //        user.PasswordHash = model.Password;
        //        user.SecurityStamp = Guid.NewGuid().ToString();
        //    };

        //    var result = await _userManager.CreateAsync(user);
        //    if (!result.Succeeded)
        //    {
        //        return StatusCode(StatusCodes.Status500InternalServerError, new Responce
        //        { Status = "Error", Message = "User Creation Failed" });

        //        if (!await _roleManager.RoleExistsAsync(UserRoles.Admin))
        //            await _roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //      if (!await _roleManager.RoleExistsAsync(UserRoles.Admin))
        //            await _roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));

        //        if (!await _roleManager.RoleExistsAsync(UserRoles.Admin))
        //            await _roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
        //        {
        //            await _userManager.AddToRoleAsync(user, UserRoles.Admin);
        //        }



        //    }
        //    return Ok(new Responce { Status = "Success",Message="User Created Success"});
        //}

        [HttpPost]
        [Route("login")]

        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);
            var checkpass = await _userManager.CheckPasswordAsync(user, model.Password);
            if (user != null && checkpass!=null )
            {
                var userRole = await _userManager.GetRolesAsync(user);

                var authClaim = new List<Claim>()

                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

                foreach (var userR in userRole)
                {
                    authClaim.Add(new Claim(ClaimTypes.Role, userR));
                }

                var authSigninKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes
                    (_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["ValidIssure"],
                    audience: _configuration["ValidAudience"],
                    expires: DateTime.Now.AddDays(1),
                    claims: authClaim,
                    signingCredentials: new SigningCredentials(authSigninKey, SecurityAlgorithms.HmacSha256));

                return Ok(
                    new
                    {
                        Token = new JwtSecurityTokenHandler().WriteToken(token),
                        expiration = token.ValidTo
                        userRole = userRole });

                    }
            );
                return Unauthorized(
                new
                {
                    user = user,
                    checkpass= checkpass,
                });

            }



        }


    }
}
