using System.ComponentModel.DataAnnotations;

namespace FourPlayCharacterCreator
{
    public enum PsionicDomain
    {
        Telepathy, //Telepath
        [Display(Name = "Faith Healing")]
        FaithHealing, //Psychic Surgeon
        Temporalism, //Shifter
        Psychokinesis //Shaper
    }
}
