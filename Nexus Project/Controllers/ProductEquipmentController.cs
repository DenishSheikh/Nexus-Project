using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus_Project.Models;

namespace Nexus_Project.Controllers
{

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
                ProductEquipmentId = ProductEquipment.ProductEquipmentId,
                ProductEquipmentName = ProductEquipment.ProductEquipmentName,
                
            };

            await _context.ProductEquipment.AddAsync(ProductEquipmentt);
            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var ProductEquipmentlist = await _context.ProductEquipment.ToListAsync();
            return Ok(ProductEquipmentlist);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get([FromRoute] Guid id)
        {
            var ProductEquipmentlist = await _context.ProductEquipment.FindAsync(id);
            if (ProductEquipmentlist == null)
            {
                return NotFound();
            }
            return Ok(ProductEquipmentlist);
        }

        [HttpPut]
        [Route("{id}")]

        public async Task<IActionResult> Update([FromRoute] Guid id, ProductEquipment updateproductequipment)
        {
            var ProductEquipmentlist = await _context.ProductEquipment.FindAsync(id);

            if (ProductEquipmentlist == null)
            {
                return NotFound(id);
            }
            ProductEquipmentlist.ProductEquipmentId = updateproductequipment.ProductEquipmentId;
            ProductEquipmentlist.ProductEquipmentName = updateproductequipment.ProductEquipmentName;

            await _context.SaveChangesAsync();
            return Ok(ProductEquipmentlist);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var ProductEquipmentlist = await _context.ProductEquipment.FindAsync(id);
            if (ProductEquipmentlist == null)
            {
                return NotFound();
            }

            _context.ProductEquipment.Remove(ProductEquipmentlist);
            await _context.SaveChangesAsync();
            return Ok(ProductEquipmentlist);
        }
    }
}
