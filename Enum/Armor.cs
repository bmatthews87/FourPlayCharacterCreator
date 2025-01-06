using System.ComponentModel.DataAnnotations;

namespace FourPlayCharacterCreator
{
    public enum Armor
    {
        //Light (2d4)
        Padded,
        Leather,
        //Medium (3d4)
        [Display(Name = "Chain Mail")]
        ChainMail,
        Scale,
        //Heavy (4d4)
        Plate,
        //Misc
        Shield //add 1d4
    }
}
