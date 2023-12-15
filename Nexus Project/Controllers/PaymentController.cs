using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus_Project.Models;

namespace Nexus_Project.Controllers
{
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

        [HttpGet("{Guid}")]  
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var Payment = await _context.Payment.FindAsync(id);
            if (Payment == null)
            {
                return NotFound();
            }
            return Ok(Payment);
        }

        [HttpPut]
        [Route("{id}")]

        public async Task<IActionResult> Update([FromRoute] Guid id, Payment updatepayment)
        {
            var paymentlist = await _context.Payment.FindAsync(id);

            if (paymentlist == null)
            {
                return NotFound(id);
            }
            paymentlist.PaymentId = updatepayment.PaymentId;
            paymentlist.AmountPaid = updatepayment.AmountPaid;
            paymentlist.PaymentDate = updatepayment.PaymentDate;

            await _context.SaveChangesAsync();
            return Ok(paymentlist);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteBilling([FromRoute] Guid id)
        {
            var paymentlist = await _context.Payment.FindAsync(id);
            if (paymentlist == null)
            {
                return NotFound();
            }

            _context.Payment.Remove(paymentlist);
            await _context.SaveChangesAsync();
            return Ok(paymentlist);
        }


    }
}
