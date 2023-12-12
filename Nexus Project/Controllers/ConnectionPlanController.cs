using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus_Project.Models;
using Nexus_Project.Models.DTO;

namespace Nexus_Project.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ConnectionPlanController : Controller
    {
        private readonly Applicationdbcontext _context;
        private readonly IMapper mapper;

        public ConnectionPlanController(Applicationdbcontext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetConnectionPlan()
        {
            var connectionplan = await _context.ConnectionPlan.ToListAsync();
            return Ok(connectionplan);
        }

        [HttpPost]
        public async Task<IActionResult> AddConnectionPlan(ConnectionPlanDto connectionplanpayloads)
        {
            var newconnectionplan = mapper.Map<ConnectionPlan>(connectionplanpayloads);
            _context.ConnectionPlan.Add(newconnectionplan);
            this._context.SaveChanges();

            return Created($"/(newConnectionPlan.Id)", newconnectionplan);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateConnectionPlan(ConnectionPlanDto connectionplanDto)
        {
            var updateconnectionplan = mapper.Map<ConnectionPlan>(connectionplanDto);
            this._context.ConnectionPlan.Update(updateconnectionplan);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteConnectionPlan(Guid id)
        {
            var ConnectionPlantodelete = await _context.ConnectionPlan.FirstOrDefaultAsync(x=>x.PlanId == id);
            return Ok();
        }





    }
}