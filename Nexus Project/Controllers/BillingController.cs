using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus_Project.Models;

namespace Nexus_Project.Controllers
{
   [ApiController]
    [Route("[Controller]")]
    public class BillingController : Controller
    {
        private Applicationdbcontext _context;

        public BillingController(Applicationdbcontext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Billing billing)
        {
            var Billing = new Billing()
            {
               BillingId = Guid.NewGuid(),
                Amount = billing.Amount,
                IsPaid = billing.IsPaid

            };

            await _context.Billings.AddAsync(Billing);
            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var billinglist = await _context.Billings.ToListAsync();
            return Ok(billinglist);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var billinglist = await _context.Billings.FindAsync(id);
            if (billinglist == null)
            {
                return NotFound();
            }
            return Ok(billinglist);
        }

    }
}
