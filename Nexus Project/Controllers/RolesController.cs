using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus_Project.Models;
using Nexus_Project.Models.DTO;

namespace Nexus_Project.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class RolesController : Controller
    {
        private readonly Applicationdbcontext _context;
        private readonly IMapper mapper;

        public RolesController(Applicationdbcontext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {
            var role = await _context.Roles.ToListAsync();
            return Ok(role);
        }

        [HttpPost]
        public async Task<IActionResult> AddRoles(RolesDto rolespayloads)
        {
            var newrole = mapper.Map<Roles>(rolespayloads);
            _context.Roles.Add(newrole);
            this._context.SaveChanges();

            return Created($"/(newroles.Id)", newrole);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateRoles(RolesDto RolesDto)
        {
            var updaterole = mapper.Map<Roles>(RolesDto);
            this._context.Roles.Update(updaterole);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteRoles(Guid id)
        {
            var rolestodelete = await _context.Roles.FirstOrDefaultAsync(a => a.RolesId == id);
            return Ok();
        }


    }
}

