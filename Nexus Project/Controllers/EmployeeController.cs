using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus_Project.Models;

namespace Nexus_Project.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : Controller
    {
        private Applicationdbcontext _context;

        public EmployeesController(Applicationdbcontext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Employee Employees)
        {
            var Employee = new Employee()
            {
                EmployeeId = Employees.EmployeeId,
                EmployeeName = Employees.EmployeeName,
                Role = Employees.Role,
                Username = Employees.Username,
                Password = Employees.Password,

            };

            await _context.Employees.AddAsync(Employees);
            await _context.SaveChangesAsync();

            return Ok();
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Employeeslist = await _context.Employees.ToListAsync();
            return Ok(Employeeslist);
        }

        //[HttpGet]
        //[Route("id : Guid")]
        //public async Task<IActionResult> GetEmployees([FromRoute] Guid id)
        //{
        //    var Employeeslist = await _context.Employees.FindAsync(id);
        //    if (Employeeslist == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(Employeeslist);
        //}

        //[HttpPut]
        //[Route("id:guid")]
        //public async Task<IActionResult> UpdateEmployees([FromBody] Guid Id,Employee UpdateEmp)
        //{
        //    var emplist = await _context.Employees.FindAsync(Id);
        //    if(emplist == null)
        //    {
        //        return NotFound();
        //    }
        //        emplist.EmployeeName = UpdateEmp.EmployeeName;
        //        emplist.Role = UpdateEmp.Role;
        //        emplist.Username = UpdateEmp.Username;
        //        emplist.Password = UpdateEmp.Password;

        //    await _context.SaveChangesAsync();
        //    return Ok(emplist);



        //}
        //[HttpDelete]
        //[Route("{id : Guid}")]
        //public async Task<IActionResult> DeleteEmployee ([FromRoute] Guid id)
        //{
        //    var Employeeslist = await _context.Employees.FindAsync(id);
        //    if (Employeeslist == null)
        //    {
        //        return NotFound();
        
        //    }
        //    _context.Employees.Remove(Employeeslist);
        //    _context.SaveChangesAsync();
        //    return Ok();
        //}
    }
}
