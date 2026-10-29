using Microsoft.AspNetCore.Mvc;
using CrimeRecordsSystem.Data;
using CrimeRecordsSystem.Models;

namespace CrimeRecordsSystem.Controllers
{
    public class AuthController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

       [HttpPost]
public IActionResult Login(string badgeNumber, string password)
{
    var officer = _context.Officers.FirstOrDefault(o => o.BadgeNumber == badgeNumber && o.Password == password);
    
    if (officer != null)
    {
        HttpContext.Session.SetString("OfficerId", officer.OfficerId.ToString());
        HttpContext.Session.SetString("OfficerName", officer.Name);
        
        // THIS IS THE FIX: Redirect to Home (Dashboard) instead of FIR
        return RedirectToAction("Index", "Home");
    }

    ViewBag.ErrorMessage = "Invalid Badge Number or Password.";
    return View();
}

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}