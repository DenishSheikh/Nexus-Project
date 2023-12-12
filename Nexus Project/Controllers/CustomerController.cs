using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus_Project.Models;
using Nexus_Project.Models.DTO;

namespace Nexus_Project.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CustomerController : Controller
    {
        private readonly Applicationdbcontext _context;
        private readonly IMapper mapper;

        public CustomerController(Applicationdbcontext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetCustomer()
        {
            var customer = await _context.Customer.Include(a => a.RolesList).ToListAsync();
            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(CustomerDto Customerpayloads)
        {
            var newcustomer = mapper.Map<Customer>(Customerpayloads);
            _context.Customer.Add(newcustomer);
            this._context.SaveChanges();

            return Created($"/(newcustomer.Id)", newcustomer);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateCustomer(CustomerDto CustomerDto)
        {
            var updatecustomer = mapper.Map<Customer>(CustomerDto);
            this._context.Customer.Update(updatecustomer);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var Customertodelete = await _context.Customer.Include(a => a.RolesList).
                Where(a => a.CustomerId == id).FirstOrDefaultAsync();
            return Ok();
        }





    }
}