using System.Diagnostics;
using FourPlayCharacterCreator.Models;
using Microsoft.AspNetCore.Mvc;

namespace FourPlayCharacterCreator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(IFormCollection collection)
        {
            HttpContext.Session.SetString("Proclivity", collection["Proclivity"].ToString());
            try
            {
                return RedirectToAction(nameof(Result));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Result()
        {
            ViewBag.Result = HttpContext.Session.GetString("Proclivity");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
