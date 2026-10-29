using Microsoft.AspNetCore.Mvc;
using CrimeRecordsSystem.Data;
using CrimeRecordsSystem.Models;

namespace CrimeRecordsSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Secure the dashboard
            if (HttpContext.Session.GetString("OfficerId") == null)
            {
                return RedirectToAction("Login", "Auth");
            }

            // Calculate statistics for the dashboard
            var totalFirs = _context.FIRs.Count();
            var activeCases = _context.FIRs.Count(f => f.Status == "Under Investigation");
            var closedCases = _context.FIRs.Count(f => f.Status == "Closed");
            var chargeSheetCases = _context.FIRs.Count(f => f.Status == "Charge Sheet Filed");
            var totalCriminals = _context.Criminals.Count();

            ViewBag.TotalFirs = totalFirs;
            ViewBag.ActiveCases = activeCases;
            ViewBag.ClosedCases = closedCases;
            ViewBag.ChargeSheetCases = chargeSheetCases;
            ViewBag.TotalCriminals = totalCriminals;
            ViewBag.OfficerName = HttpContext.Session.GetString("OfficerName");

            return View();
        }
    }
}