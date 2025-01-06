using System.Diagnostics;
using System.Text.Json;
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

        #region Step 1) Choose Proclivity
        public IActionResult Index()
        {
            //if we haven't already defined a character session, make one here
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("Character")))
            {
                Character c = new Character();
                HttpContext.Session.SetString("Character", JsonSerializer.Serialize(c));
            }

            Character character = GetCharacterSession();

            return View(character);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(IFormCollection collection)
        {
            //get current character session
            Character character = GetCharacterSession();

            //set character values
            character.Proclivity = (Proclivity)Enum.Parse(typeof(Proclivity), collection["Proclivity"].ToString());

            //save character
            HttpContext.Session.SetString("Character", JsonSerializer.Serialize(character));

            try
            {
                return RedirectToAction(nameof(Package));
            }
            catch
            {
                return View();
            }
        }
        #endregion

        #region Step2) Choose Package or Custom Character
        public IActionResult Package()
        {
            Character character = GetCharacterSession();
            return View(character);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Package(IFormCollection collection)
        {
            //get current character session
            Character character = GetCharacterSession();

            //set character values
            character.Package = (Package)Enum.Parse(typeof(Package), collection["Package"].ToString());

            //save character
            HttpContext.Session.SetString("Character", JsonSerializer.Serialize(character));

            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #region Utility
        private Character GetCharacterSession()
        {
            string characterString = HttpContext.Session.GetString("Character");
            Character character = JsonSerializer.Deserialize<Character>(characterString);
            return character;
        }
        #endregion
    }
}
