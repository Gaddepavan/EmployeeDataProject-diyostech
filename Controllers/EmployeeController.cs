using Employedataproject.Dbconnect;
using Employedataproject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Employedataproject.Controllers
{
    public class EmployeeController : Controller
    {
  
    
            private readonly Contextclass _context;

            public EmployeeController(Contextclass context)
            {
                _context = context;
            }

            [HttpGet]
            public async Task<IActionResult> Index()
            {
                var employees = await _context.emp.ToListAsync();
                return View(employees);
            }

            [HttpPost]
            public async Task<IActionResult> Insert(Employee employee)
            {
                await _context.emp.AddAsync(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            [HttpPost]
            public async Task<IActionResult> Delete(int id)
            {
                var employee = await _context.emp.FindAsync(id);
                if (employee != null)
                {
                    _context.emp.Remove(employee);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction("Index");
            }

            [HttpPost]
            public async Task<IActionResult> Update(Employee employee)
            {
                _context.emp.Update(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }


        }
}
