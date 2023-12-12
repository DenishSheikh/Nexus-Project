using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus_Project.Models;
using Nexus_Project.Models.DTO;

namespace Nexus_Project.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class OrderController : Controller
    {
        private readonly Applicationdbcontext _context;
        private readonly IMapper mapper;

        public OrderController(Applicationdbcontext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetOrder()
        {
            var order = await _context.Order.Include(a => a.ConnectionList).ToListAsync();
            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrder(OrderDto Orderpayloads)
        {
            var neworder = mapper.Map<Order>(Orderpayloads);
            _context.Order.Add(neworder);
            this._context.SaveChanges();

            return Created($"/(neworder.Id)", neworder);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateOrder(OrderDto OrderDto)
        {
            var updateorder = mapper.Map<Order>(OrderDto);
            this._context.Order.Update(updateorder);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteOrder(Guid id)
        {
            var ordertodelete = await _context.Order.Include(a => a.ConnectionList).
                Where(a => a.PlanId == id).FirstOrDefaultAsync();
            return Ok();
        }





    }
}