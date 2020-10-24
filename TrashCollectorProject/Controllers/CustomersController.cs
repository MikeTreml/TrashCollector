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
   // [Authorize(Roles = "Customer")]
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public IActionResult Index()
        {
            var id = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = _context.Customer.Where(c => c.IdentityUserId == id).SingleOrDefault();
            //ViewData["AddressID"] = _context.Address.Where(h => h.Id == customer.Id).SingleOrDefault();
            //ViewData["IdentityUserId"] = new SelectList(_context.Set<Customer>(), "ID", "ID");
            //var applicationDbContext = _context.Customer.Include(c => c.Identity);
            //var customer = await _context.Customer.Include(c => c.Identity).FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return RedirectToAction("Create");
               //return NotFound();
            }

            return View(customer);
        }

        //// GET: Customers/Details/5
        //public async Task<IActionResult> Details()
        //{
        //    var id = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
        //    var customer = _context.Customer.Where(h => h.IdentityUserId == id).SingleOrDefault();
        //    //var applicationDbContext = _context.Customer.Include(c => c.Identity);
        //    //var customer = await _context.Customer.Include(c => c.Identity).FirstOrDefaultAsync(m => m.Id == id);
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(customer);
        //}

        // GET: Customers/Create
        public ActionResult Create()
        {
            //ViewData["AddressID"] = new SelectList(_context.Set<Address>(), "AddressID", "AddressID");
            //ViewData["IdentityUserId"] = new SelectList(_context.Set<Customer>(), "ID", "ID");
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.IdentityUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                customer.AccountBalance = 0;

                //add cordinate tool here 
                _context.Add(customer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
                //return RedirectToAction("View", "Customers");
            }
            
            ViewData["AddressID"] = _context.Address.Where(h => h.Id == customer.Id).SingleOrDefault();
            //ViewData["IdentityUserId"] = new SelectList(_context.Set<Customer>(), "ID", "ID");

            return View();
        }

        // GET: Customers/Edit/5
        public ActionResult Edit()
        {

            var id = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var person = _context.Customer.Where(h => h.IdentityUserId == id).SingleOrDefault();
            var address = _context.Address.Where(h => h.Id == person.AddressId).SingleOrDefault();
            ViewData["AddressID"] = address;
           // ViewData["IdentityUserId"] = new SelectList(_context.Set<Customer>(), "ID", "ID");

            return View(person);
        }

        // POST: Customers/Edit/5
       //This edit is to apply changes that were made.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Customer customer)
        {
            if (customer.Id == 0)
            {
                return RedirectToAction("Create", customer);
                
            }
            // ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", customer.IdentityUserId);
            //ViewData["AddressID"] = new SelectList(_context.Set<Address>(), "AddressID", "AddressID", customer.AddressId);
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
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
            return View(customer);
        }
        
        //// GET: Customers/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var customer = await _context.Customer
        //        .Include(c => c.Identity)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (customer == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(customer);
        //}

        //// POST: Customers/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var customer = await _context.Customer.FindAsync(id);
        //    _context.Customer.Remove(customer);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.Id == id);
        }

    }
}
