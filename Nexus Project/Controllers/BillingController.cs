
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus_Project.Models;
using Nexus_Project.Models.DTO;

namespace Nexus_Project.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class BillingController : Controller
    {
        private readonly Applicationdbcontext _context;
        private readonly  IMapper mapper;

        public BillingController(Applicationdbcontext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetCustomer()
        {
            var billing = await _context.Billings.Include(a => a.CustomerList).ToListAsync();
            return Ok(billing);
        }

        [HttpPost]
        public async Task<IActionResult> AddBilling(BillingDto billingpayloads)
        {
            var newbilling = mapper.Map<Billing>(billingpayloads);
            _context.Billings.Add(newbilling);
            this._context.SaveChanges();

            return Created($"/(newbilling.Id)", newbilling);
        }


        [HttpPut]
        public async Task<IActionResult>UpdateBilling (BillingDto BillingDto)
        {
            var updatebilling = mapper.Map<Billing>(BillingDto);
            this._context.Billings.Update(updatebilling);
            _context.SaveChanges();
            return Ok();
        }

       [HttpDelete]
       public async Task<IActionResult>DeleteBilling(int id)
        {
            var billingtodelete = await _context.Billings.Include(a => a.CustomerList).
                Where(a => a.CustomerId == id).FirstOrDefaultAsync();
            return Ok();
        }





    }
}   
           

    
        //[HttpPost]
        //public async Task<IActionResult> Add([FromBody] Billing billing)
        //{
        //    var Billing = new Billing()
        //    {
        //        BillingId = Guid.NewGuid(),
        //        Amount = billing.Amount,
        //        IsPaid = billing.IsPaid

        //    };

        //    await _context.Billings.AddAsync(Billing);
        //    await _context.SaveChangesAsync();

        //    return Ok();
        //}


        //[HttpGet]

        //public async Task<IActionResult> Get()
        //{
        //    var billinglist = await _context.Billings.ToListAsync();
        //    return Ok(billinglist);
        //}

        //[HttpGet]
        //[Route("{id}")]
        //public async Task<IActionResult> Get([FromRoute] Guid id)
        //{
        //    var billinglist = await _context.Billings.FindAsync(id);
        //    if (billinglist == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(billinglist);
        //}

        //[HttpPut]
        //[Route("{id}")]

        //public async Task<IActionResult> UpdateBilling([FromRoute] Guid id, Billing updatebilling)
        //{
        //    var billinglist = await _context.Billings.FindAsync(id);

        //    if (billinglist == null)
        //    {
        //        return NotFound(id);
        //    }
        //    billinglist.Amount = updatebilling.Amount;
        //    billinglist.IsPaid = updatebilling.IsPaid;

        //    await _context.SaveChangesAsync();
        //    return Ok(billinglist);
        //}

        //[HttpDelete]
        //[Route("{id}")]
        //public async Task<IActionResult> DeleteBilling([FromRoute] Guid id)
        //{
        //    var billinglist = await _context.Billings.FindAsync(id);
        //    if (billinglist == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Billings.Remove(billinglist);
        //    await _context.SaveChangesAsync();
        //    return Ok(billinglist);
        //}


