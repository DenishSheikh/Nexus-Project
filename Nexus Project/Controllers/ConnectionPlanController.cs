using Microsoft.AspNetCore.Mvc;
using Nexus_Project.Models;

namespace Nexus_Project.Controllers
{
  
   

        [ApiController]
        [Route("[Controller]")]
        public class ConnectionPlanController : Controller
        {
            private Applicationdbcontext _context;

            public ConnectionPlanController(Applicationdbcontext context)
            {
                _context = context;
            }
            [HttpPost]
            public async Task<IActionResult> Add([FromBody] ConnectionPlan Connectionplan)
            {
                var ConnectionPlan = new ConnectionPlan();
                {
                   

                }

                await _context.ConnectionPlan.AddAsync(ConnectionPlan);
                await _context.SaveChangesAsync();

                return Ok();
            }

            [HttpGet]

            public async Task<IActionResult> Get()
            {
                var ConnectionPlanlist = await _context.ConnectionPlan.ToListAsync();
                return Ok(ConnectionPlanlist);
            }

            [HttpGet]
            [Route("{id : Guid}")]
            public async Task<IActionResult> Get([FromRoute] Guid id)
            {
                var ConnectionPlanlist = await _context.ConnectionPlan.FindAsync(id);
                if (ConnectionPlanlist == null)
                {
                    return NotFound();
                }
                return Ok(ConnectionPlanlist);
            }

        }
    }
