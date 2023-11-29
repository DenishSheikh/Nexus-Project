using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus_Project.Models;

namespace Nexus_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : Controller
    {
        private Applicationdbcontext _context;

        public OrderController(Applicationdbcontext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Order Order)
        {
            var Orderr = new Order()
            {
                OrderId = Order.OrderId,
                CustomerId = Order.CustomerId,
                PlanId = Order.PlanId,
                OrderDate = Order.OrderDate,
                Status = Order.Status,
            };

            await _context.Order.AddAsync(Order);
            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var Orderlist = await _context.Order.ToListAsync();
            return Ok(Orderlist);
        }

        //[HttpGet]
        //[Route("{id : Guid}")]
        //public async Task<IActionResult> Get([FromRoute] Guid id)
        //{
        //    var Orderlist = await _context.Order.FindAsync(id);
        //    if (Orderlist == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(Orderlist);
        //}

    }
}
