namespace FourPlayCharacterCreator.Models
{
    public class Character
    {
        string Name { get; set; }

        //1 Nugget = d8
        //Each organ starts with 2 in each and distributes 6
        public int HeadNuggets { get; set; }
        public int TorsoNuggets { get; set; }
        public int LimbNuggets { get; set; }

        //Optional Package (Used to get groups of competencies
        public Package Package { get; set; }

        //Proclivities have competencies underneath them
        //Typically 2d8 Bonus. Mental = Head, Physical and Anti-Social use Limbs, Torso = None
        public Proclivity Proclivity { get; set; }

        //Typically d6 bonus
        List<Competency> Competencies { get; set; }

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
