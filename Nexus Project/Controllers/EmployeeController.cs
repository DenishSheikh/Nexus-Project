using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nexus_Project.Models;
using Nexus_Project.Models.DTO;

namespace Nexus_Project.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmployeeController : Controller
    {
        private readonly Applicationdbcontext _context;
        private readonly IMapper mapper;

        public EmployeeController(Applicationdbcontext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetEmployee()
        {
            var employee = await _context.Employees.Include(a => a.RoleList).ToListAsync();
            return Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(EmployeeDto Employeepayloads)
        {
            var newemployee = mapper.Map<Employee>(Employeepayloads);
            _context.Employees.Add(newemployee);
            this._context.SaveChanges();

            return Created($"/(newemployee.Id)", newemployee);
        }


        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(EmployeeDto EmployeeDto)
        {
            var updateemployee = mapper.Map<Employee>(EmployeeDto);
            this._context.Employees.Update(updateemployee);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employeetodelete = await _context.Employees.Include(a => a.RoleList).
                Where(a => a.RoleId == id).FirstOrDefaultAsync();
            return Ok();
        }





    }
}