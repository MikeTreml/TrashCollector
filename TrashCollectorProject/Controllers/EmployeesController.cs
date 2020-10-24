using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollectorProject.Data;
using TrashCollectorProject.Models;

namespace TrashCollectorProject.Controllers
{
   // [Authorize(Roles = "Employee")]
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            var id = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employee.FirstOrDefault(e => e.IdentityUserId == id);
           
            if (employee is null)
            {
                return RedirectToAction("Create");
            }
            var customers = _context.Customer;
            var address = _context.Address;
            var joinCustomerAddresses = from s in customers
                                   join st in address on s.AddressId equals st.Id into st2
                                   from st in st2.DefaultIfEmpty()
                                   select new JoinCustomerAddress { CustomerVM = s, AddressVM = st };
            
            var completed = _context.CompletedDates.Where(c => c.Date == DateTime.Today);
            string todayOfWeek = DateTime.Today.DayOfWeek.ToString();

            //var customerList = customers.Where(c => c.SuspendStart > DateTime.Today || c.SuspendEnd < DateTime.Today || c.OneTimePickUp == DateTime.Today);
            //var dayCustomerfilter = customers
            //    .Where(c => c.SuspendStart > DateTime.Today || c.SuspendEnd < DateTime.Today || c.OneTimePickUp == DateTime.Today)
            //    .Where(c => c.PickUpDay == todayOfWeek)
            //    .Where(c => c.Address.ZipCode == employee.ZipCode);

            var dayCustomerfilter = joinCustomerAddresses
               .Where(c => !completed.Any(f => f.AddressId == c.AddressVM.Id));
           


            return View(dayCustomerfilter);
        }

        //GET: Employees/Details/5
        public async Task<IActionResult> CustomerDetails(int? id)
        {

            
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .Include(e => e.Identity)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            var address = _context.Address.Where(h => h.Id == customer.AddressId).SingleOrDefault();
            ViewBag.latitude = address.Latitude;
            ViewBag.longitude = address.Longitude;

            return View(customer);
        }

        //GET: Employees/Create
        public async Task<IActionResult> Create()
        {
            ViewData["IdentityUserId"] = new SelectList(_context.Set<Employee>(), "ID", "ID");
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
               
                employee.IdentityUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier); ;
                _context.Add(employee);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit()
        {
            
            // ViewData["IdentityUserId"] = new SelectList(_context.Set<Customer>(), "ID", "ID");

            return View();
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,ZipCode,IdentityUserId")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        //// GET: Employees/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var employee = await _context.Employee
        //        .Include(e => e.Identity)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(employee);
        //}

        //// POST: Employees/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var employee = await _context.Employee.FindAsync(id);
        //    _context.Employee.Remove(employee);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.Id == id);
        }
    }
}
