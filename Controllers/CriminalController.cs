using Microsoft.AspNetCore.Mvc;
using CrimeRecordsSystem.Data;
using CrimeRecordsSystem.Models;

namespace CrimeRecordsSystem.Controllers
{
    public class CriminalController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CriminalController(ApplicationDbContext context)
        {
            _context = context;
        }

        // READ: Display all criminals
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("OfficerId") == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View(_context.Criminals.ToList());
        }

        // CREATE: Show Form
        [HttpGet]
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("OfficerId") == null)
            {
                return RedirectToAction("Login", "Auth");
            }
            return View();
        }

        // CREATE: Save Data
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Criminal model)
        {
            if (ModelState.IsValid)
            {
                _context.Criminals.Add(model);
                _context.SaveChanges();
                
                TempData["SuccessMessage"] = "Criminal profile successfully added to the database.";
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}