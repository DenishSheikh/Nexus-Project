using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus_Project.Models;

namespace Nexus_Project.Controllers
{
  /*  [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private Applicationdbcontext _context;

        public CustomerController(Applicationdbcontext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Customer Customer)
        {
            var Customerr = new Customer()
            {
                CustomerId=Customer.CustomerId,
                CustomerName=Customer.CustomerName,
            };

            await _context.Customer.AddAsync(Customer);
            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Customerlist = await _context.Customer.ToListAsync();
            return Ok(Customerlist);
        }

        //[HttpGet]
        //[Route("{id : Guid}")]
        //public async Task<IActionResult> Get([FromRoute] Guid id)
        //{
        //    var Customerlist = await _context.Customer.FindAsync(id);
        //    if (Customerlist == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(Customerlist);
        //}

    }*/
}
