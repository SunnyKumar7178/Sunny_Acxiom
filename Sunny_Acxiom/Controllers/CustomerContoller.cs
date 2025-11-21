using Microsoft.AspNetCore.Mvc;
using Sunny_Acxiom.Models;
using Microsoft.EntityFrameworkCore;
using Sunny_Acxiom.Data;

namespace Sunny_Acxiom.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext _context;

        public CustomerController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Customer
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customers.ToListAsync());
        }

        // GET: Customer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public async Task<IActionResult> Create(Customer cust)
        {
            if (ModelState.IsValid)
            {
                _context.Customers.Add(cust);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cust);
        }

        // GET: Customer/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var cust = await _context.Customers.FindAsync(id);
            if (cust == null)
                return NotFound();

            return View(cust);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(Customer cust)
        {
            if (ModelState.IsValid)
            {
                _context.Update(cust);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cust);
        }

        // GET: Customer/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var cust = await _context.Customers.FindAsync(id);
            if (cust == null)
                return NotFound();

            return View(cust);
        }

        // GET: Customer/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var cust = await _context.Customers.FindAsync(id);
            if (cust == null)
                return NotFound();

            return View(cust);
        }

        // POST: DeleteConfirmed
        [HttpPost, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cust = await _context.Customers.FindAsync(id);
            if (cust != null)
            {
                _context.Customers.Remove(cust);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}

