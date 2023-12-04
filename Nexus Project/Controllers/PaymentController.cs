using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus_Project.Models;

namespace Nexus_Project.Controllers
{/*
    [ApiController]
    [Route("[controller]")]
    public class PaymentController : Controller
    {
        private Applicationdbcontext _context;

        public   PaymentController(Applicationdbcontext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Payment Payment)
        {
            var Paymentt = new Payment()
            {
            PaymentId  = Payment.PaymentId,
            CustomerId = Payment.CustomerId,
            AmountPaid = Payment.AmountPaid,
            PaymentDate = Payment.PaymentDate,

            };

            await _context.Payment.AddAsync(Payment);
            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var Paymentlist = await _context.ConnectionPlan.ToListAsync();
            return Ok(Paymentlist);
        }

        //[HttpGet]
        //[Route("{id : Guid}")]
        //public async Task<IActionResult> Get([FromRoute] Guid id)
        //{
        //    var Payment = await _context.Payment.FindAsync(id);
        //    if (Payment == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(Payment);
        //}

    }*/
}
