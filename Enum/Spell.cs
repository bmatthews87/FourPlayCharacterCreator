using System.ComponentModel.DataAnnotations;

namespace FourPlayCharacterCreator
{
    public enum Spell
    {
        //Unknown
        [Display(Name = "Arcane Seeing")]
        ArcaneSeeing,
        AstralRadiance,
        Comet,
        EldritchWaves,
        MorphicAlteration,
        Nebula,
        Starstruck,
        WordOfDread,
        //Sky
        Applefall,
        CelestialGlory,
        ColdSnap,
        Heliotrope,
        MoonShadow,
        ShiningSpear,
        Vortex,
        Wings,
        //Surface
        Caterwaul,
        Greenwand,
        HealingHerb,
        Quicksand,
        Rathole,
        Skullvisit,
        Swamplight,
        Vegetation,
        //Underworld,
        Demonomania,
        ItchTwitch,
        Magmatron,
        ShadowSpy,
        SquirmingDarkness,
        Terrorismus,
        Vault,
        Yirn
    }
}
