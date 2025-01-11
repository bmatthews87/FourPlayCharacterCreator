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
            //Ensure we have a Blank Character
            Character c = new Character();
            HttpContext.Session.SetString("Character", JsonSerializer.Serialize(c));

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

        #region Step 2) Choose Package or Custom Character
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
            character.Package = Common.StringToEnum<Package>(collection["Package"]);
            character.Competencies.Add(Common.StringToEnum<Competency>(collection["Competency1"]));
            character.Competencies.Add(Common.StringToEnum<Competency>(collection["Competency2"]));
            character.Competencies.Add(Common.StringToEnum<Competency>(collection["Competency3"]));
            character.Competencies.Add(Common.StringToEnum<Competency>(collection["Competency4"]));

            //save character
            HttpContext.Session.SetString("Character", JsonSerializer.Serialize(character));

            try
            {
                return RedirectToAction(nameof(DistributeDice));
            }
            catch
            {
                return View();
            }
        }
        #endregion

        #region Step 3) Distribute Dice
        public IActionResult DistributeDice()
        {
            Character character = GetCharacterSession();
            return View(character);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DistributeDice(IFormCollection collection)
        {
            //get current character session
            Character character = GetCharacterSession();

            //set character values
            character.RemainingNuggets = int.Parse(collection["RemainingNuggets"]);
            character.HeadNuggets = int.Parse(collection["HeadNuggets"]);
            character.TorsoNuggets = int.Parse(collection["TorsoNuggets"]);
            character.LimbNuggets = int.Parse(collection["LimbNuggets"]);

            //save character
            HttpContext.Session.SetString("Character", JsonSerializer.Serialize(character));

            try
            {
                return RedirectToAction(nameof(Spells));
            }
            catch
            {
                return View();
            }
        }
        #endregion

        #region Step 4) Spells
        public IActionResult Spells()
        {
            Character character = GetCharacterSession();
            return View(character);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Spells(IFormCollection collection)
        {
            //get current character session
            Character character = GetCharacterSession();

            //get the spellcaster type selected 
            character.SpellcasterType = Common.StringToEnum<SpellcasterType>(collection["SpellcasterType"]);

            //set character values based on spell type
            if (character.SpellcasterType == SpellcasterType.Magic)
            {
                character.MagicDomain = Common.StringToEnum<MagicDomain>(collection["MagicDomain"]);
                character.Spells.Add(Common.StringToEnum<Spell>(collection["Spell1"]));
                character.Spells.Add(Common.StringToEnum<Spell>(collection["Spell2"]));
                character.Spells.Add(Common.StringToEnum<Spell>(collection["Spell3"]));
                character.Spells.Add(Common.StringToEnum<Spell>(collection["Spell4"]));

                HttpContext.Session.SetString("Character", JsonSerializer.Serialize(character));
            }
            else if (character.SpellcasterType == SpellcasterType.Psionics)
            {
                character.PsionicDomain = Common.StringToEnum<PsionicDomain>(collection["PsionicDomain"]);
                character.PsionicSpells.Add(Common.StringToEnum<PsionicSpell>(collection["PsionicSpell1"]));
                character.PsionicSpells.Add(Common.StringToEnum<PsionicSpell>(collection["PsionicSpell2"]));
                character.PsionicSpells.Add(Common.StringToEnum<PsionicSpell>(collection["PsionicSpell3"]));
                character.PsionicSpells.Add(Common.StringToEnum<PsionicSpell>(collection["PsionicSpell4"]));

                HttpContext.Session.SetString("Character", JsonSerializer.Serialize(character));
            }

            try
            {
                return RedirectToAction(nameof(Result));
            }
            catch
            {
                return View();
            }
        }
        #endregion

        public IActionResult Result()
        {
            Character character = GetCharacterSession();
            return View(character);
        }


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
