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
        public ActionResult Index(string date)
        {
            var id = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employee.FirstOrDefault(e => e.IdentityUserId == id);
            if (employee is null)
            {
                return RedirectToAction("Create");
            }
            string dayString = date ?? DateTime.Today.DayOfWeek.ToString();
            return View(DaySelect(dayString));
        }
        //public ActionResult Index(string day)
        //{
        //    return View(DaySelect(day));
        //}
        public ActionResult PickComplete(int id) 
        {
            //charge customer
            var customer = _context.Customer.Where(c => c.AddressId == id).SingleOrDefault();
            customer.AccountBalance += 21;
            _context.Update(customer);

            //mark as completed
            CompletedDates completed = new CompletedDates();
            completed.AddressId = id;
            completed.Date = DateTime.Today;
           
            _context.Add(completed);
            _context.SaveChanges();
            return RedirectToAction("Index");
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
        public ActionResult Create()
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
        public IQueryable<JoinCustomerAddress> DaySelect(string dayOfWeek)
        {
            var id = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var employee = _context.Employee.FirstOrDefault(e => e.IdentityUserId == id);
            IQueryable<CompletedDates> completed;
            IQueryable<JoinCustomerAddress> dayCustomerfilter;
            var joinCustomerAddresses = from s in _context.Customer
                                        join st in _context.Address on s.AddressId equals st.Id into st2
                                        from st in st2.DefaultIfEmpty()
                                        select new JoinCustomerAddress { CustomerVM = s, AddressVM = st };

          if(dayOfWeek == DateTime.Today.DayOfWeek.ToString())
            {
                //completed table filtering only for todays dates. so to check if a complete pickup is done it only needs to search for the address ID below
                completed = _context.CompletedDates.Where(c => c.Date == DateTime.Today);
                dayCustomerfilter = joinCustomerAddresses
                    //filters today is in a suspended period or if is a one time pickup. the one tiem pickup is ment to override a suspention period
                    // in the case a customer doesn't want weekly pickup and only scheduled pickups
                    .Where(c => c.CustomerVM.SuspendStart > DateTime.Today || c.CustomerVM.SuspendEnd < DateTime.Today || c.CustomerVM.OneTimePickUp == DateTime.Today)
                    //filters for the day of the week
                    .Where(c => c.CustomerVM.PickUpDay == dayOfWeek)
                    //filters zipcode
                    .Where(c => c.AddressVM.ZipCode == employee.ZipCode)
                    //filters against a completed table for the address ID
                    .Where(c => !completed.Any(f => f.AddressId == c.AddressVM.Id));
            }
            else 
            { 
                // this is an option for an employee to there routes for who is getting pickups. this doesn't take in account suspended deliveries
                completed = _context.CompletedDates;
                dayCustomerfilter = joinCustomerAddresses
                    .Where(c => c.CustomerVM.PickUpDay == dayOfWeek)
                    .Where(c => c.AddressVM.ZipCode == employee.ZipCode);
            }
            return dayCustomerfilter;
        }

       
        private bool EmployeeExists(int id)
        {
            return _context.Employee.Any(e => e.Id == id);
        }
    }
}
