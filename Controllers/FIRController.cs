using Microsoft.AspNetCore.Mvc;
using CrimeRecordsSystem.Data;
using CrimeRecordsSystem.Models;

namespace CrimeRecordsSystem.Controllers
{
    public class FIRController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FIRController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Simple authentication check using Session
            if (HttpContext.Session.GetString("OfficerId") == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View(_context.FIRs.ToList());
        }

       [HttpGet]
public IActionResult Create()
{
    // Protect the route using Session
    if (HttpContext.Session.GetString("OfficerId") == null)
    {
        return RedirectToAction("Login", "Auth");
    }
    return View();
}

[HttpPost]
[ValidateAntiForgeryToken]
public IActionResult Create(FIR model)
{
    // 1. Securely attach the logged-in officer to this FIR
    var officerIdString = HttpContext.Session.GetString("OfficerId");
    if (string.IsNullOrEmpty(officerIdString))
    {
        return RedirectToAction("Login", "Auth");
    }
    model.OfficerId = int.Parse(officerIdString);

    // 2. Force the validator to ignore the missing Officer object
    ModelState.Remove("InvestigatingOfficer");

    // 3. Save to MySQL
    if (ModelState.IsValid)
    {
        _context.FIRs.Add(model);
        _context.SaveChanges();
        return RedirectToAction("Index"); 
    }

    // If validation fails, return the form so the red error messages show up
    return View(model);
}
    }
}