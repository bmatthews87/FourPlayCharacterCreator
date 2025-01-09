using System.ComponentModel.DataAnnotations;

namespace FourPlayCharacterCreator
{
    public enum Spell
    {
        //Unknown
        [Display(Name = "Arcane Seeing")]
        ArcaneSeeing = 0,
        AstralRadiance = 1,
        Comet = 2,
        EldritchWaves = 3,
        MorphicAlteration = 4,
        Nebula = 5,
        Starstruck = 6,
        WordOfDread = 7,
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
