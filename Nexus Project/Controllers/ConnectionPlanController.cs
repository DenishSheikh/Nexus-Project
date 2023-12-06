using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus_Project.Models;

namespace Nexus_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConnectionPlanController : Controller
    {
        private Applicationdbcontext _context;

        public ConnectionPlanController(Applicationdbcontext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ConnectionPlan ConnectionPlan)
        {
            var ConnPlan = new ConnectionPlan()
            {
                PlanId = ConnectionPlan.PlanId,
                PlanName = ConnectionPlan.PlanName,
                Description = ConnectionPlan.Description,
                Charges = ConnectionPlan.Charges,


            };

            await _context.ConnectionPlan.AddAsync(ConnPlan);
            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var ConnectionPlanlist = await _context.ConnectionPlan.ToListAsync();
            return Ok(ConnectionPlanlist);
        }

        //[HttpGet]
        //[Route("{id : Guid}")]
        //public async Task<IActionResult> Get([FromRoute] Guid id)
        //{
        //    var ConnectionPlan = await _context.ConnectionPlan.FindAsync(id);
        //    if (ConnectionPlan == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(ConnectionPlan);
        //}

    }

    }
    