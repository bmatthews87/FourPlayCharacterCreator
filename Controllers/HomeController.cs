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

        private Character GetCharacterSession()
        {
            string characterString = HttpContext.Session.GetString("Character");
            Character character = JsonSerializer.Deserialize<Character>(characterString);
            return character;
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
                return RedirectToAction(nameof(Result));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Result()
        {
            Character character = GetCharacterSession();
            return View(character);
        }

        public IActionResult test()
        {
            Character character = GetCharacterSession();
            return View(character);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
