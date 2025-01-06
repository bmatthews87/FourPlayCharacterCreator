using System.ComponentModel.DataAnnotations;

namespace FourPlayCharacterCreator
{
    public enum Proclivity
    {
        Physical,
        Mental,
        Social,
        [Display(Name = "Anti Social")]
        AntiSocial
    }
}
