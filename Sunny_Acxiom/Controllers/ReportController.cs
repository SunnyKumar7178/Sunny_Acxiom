using Microsoft.AspNetCore.Mvc;
using Sunny_Acxiom.Models;
using Sunny_Acxiom.Data;

public class ReportController : Controller
{
    private readonly AppDbContext _context;

    public ReportController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        ViewBag.EmpCount = _context.Employees.Count();
        ViewBag.CustCount = _context.Customers.Count();

        var model = new ReportViewModel
        {
            Employees = _context.Employees.ToList(),
            Customers = _context.Customers.ToList()
        };

        return View(model);
    }

    public IActionResult DeleteEmployee(int id)
    {
        var emp = _context.Employees.Find(id);
        _context.Employees.Remove(emp);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult DeleteCustomer(int id)
    {
        var cust = _context.Customers.Find(id);
        _context.Customers.Remove(cust);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}

