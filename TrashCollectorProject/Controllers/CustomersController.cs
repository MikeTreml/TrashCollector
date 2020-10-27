using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Geocoding;
using Geocoding.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollectorProject.Data;
using TrashCollectorProject.Models;

namespace TrashCollectorProject.Controllers
{
    //[Authorize(Roles = "Customer")]
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
            var customers = _context.Customer;
            var id = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var customer = customers.Where(c => c.IdentityUserId == id).SingleOrDefault();
           
            if (customer == null)
            {
                return RedirectToAction(nameof(Create));

            }


            return View(customer);
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
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
           
           
            if (ModelState.IsValid)
            {
                try
                {
                    customer.IdentityUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                    _context.Update(customer);
                    await _context.SaveChangesAsync();

                    var customerAddress = _context.Address.Where(a => a.Id == customer.AddressId).SingleOrDefault();
                    IGeocoder geocoder = new GoogleGeocoder() { ApiKey = APIKeys.GOOGLE_API_KEY };
                    IEnumerable<Geocoding.Address> addresses = await geocoder.GeocodeAsync(customerAddress.AddressLine1 + " " + customerAddress.City + " " + customerAddress.State + " " + customerAddress.ZipCode);
                    customerAddress.Latitude = addresses.First().Coordinates.Latitude;
                    customerAddress.Longitude = addresses.First().Coordinates.Longitude;
                    _context.Update(customerAddress);
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
            if (customer.Id == 0)
            {
                return RedirectToAction("Create", customer);

            }
            return View("Index");
        }
        
        

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.Id == id);
        }

    }
}
