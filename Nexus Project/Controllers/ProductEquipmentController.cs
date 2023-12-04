using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus_Project.Models;

namespace Nexus_Project.Controllers
{
/*
    [ApiController]
    [Route("[controller]")]
    public class ProductEquipmentController : Controller
    {
        private Applicationdbcontext _context;

        public ProductEquipmentController(Applicationdbcontext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ProductEquipment ProductEquipment)
        {
            var ProductEquipmentt = new ProductEquipment()
            {
                ProductId = ProductEquipment.ProductId,
                ProductName = ProductEquipment.ProductName,
                
            };

            await _context.ProductEquipment.AddAsync(ProductEquipment);
            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var ProductEquipmentlist = await _context.ProductEquipment.ToListAsync();
            return Ok(ProductEquipmentlist);
        }

        //[HttpGet]
        //[Route("{id}")]
        //public async Task<IActionResult> Get([FromRoute] Guid id)
        //{
        //    var ProductEquipmentlist = await _context.ProductEquipment.FindAsync(id);
        //    if (ProductEquipmentlist == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(ProductEquipmentlist);
        //}

    }*/
}
