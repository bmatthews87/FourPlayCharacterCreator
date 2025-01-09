using System.ComponentModel.DataAnnotations;

namespace FourPlayCharacterCreator.Models
{
    public class Character
    {
        public Character()
        {
            this.Competencies = new List<Competency>();
            this.Spells = new List<Spell>();
            this.PsionicSpells = new List<PsionicSpell>();
            HeadNuggets = 2;
            TorsoNuggets = 2;
            LimbNuggets = 2;
        }

        string Name { get; set; }

        //1 Nugget = d8
        //Each organ starts with 2 in each and distributes 6
        [Range(2, 20, ErrorMessage = "Must be at least 2 Nuggets")]
        public int HeadNuggets { get; set; }

        [Range(2, 20, ErrorMessage = "Must be at least 2 Nuggets")]
        public int TorsoNuggets { get; set; }

        [Range(2, 20, ErrorMessage = "Must be at least 2 Nuggets")]
        public int LimbNuggets { get; set; }

        //Optional Package (Used to get groups of competencies
        public Package Package { get; set; }

        //Proclivities have competencies underneath them
        //Typically 2d8 Bonus. Mental = Head, Physical and Anti-Social use Limbs, Torso = None
        public Proclivity Proclivity { get; set; }

        //Typically d6 bonus
        public List<Competency> Competencies { get; set; }

        public MagicDomain MagicDomain { get; set; }
        public List<Spell> Spells { get; set; }
        public PsionicDomain PsionicDomain { get; set; }
        public List<PsionicSpell> PsionicSpells { get; set; }

        public void ShowStats()
        {
            Console.WriteLine(Name);
            Console.WriteLine(HeadNuggets);
        }
    }
}
