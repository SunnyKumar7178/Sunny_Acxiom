using Microsoft.AspNetCore.Mvc;
using Sunny_Acxiom.Data;
using System.Linq;

namespace Sunny_Acxiom.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext _context;

        public SearchController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Results(string query)
        {
            if (string.IsNullOrEmpty(query))
                return View();

            var employees = _context.Employees
                .Where(e =>
                    e.E_Name.Contains(query) ||
                    e.E_Email.Contains(query) ||
                    e.Department.Contains(query) ||
                    e.Emp_Id.ToString().Contains(query))
                .ToList();

            var customers = _context.Customers
                .Where(c =>
                    c.C_Name.Contains(query) ||
                    c.C_Email.Contains(query) ||
                    c.City.Contains(query) ||
                    c.Phone_Number.Contains(query) ||
                    c.Customer_Id.ToString().Contains(query))
                .ToList();

            ViewBag.Query = query;
            ViewBag.EmpResults = employees;
            ViewBag.CustResults = customers;

            return View();
        }
    }
}
