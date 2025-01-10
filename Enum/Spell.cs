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
        Applefall = 8,
        CelestialGlory = 9,
        ColdSnap = 10,
        Heliotrope = 11,
        MoonShadow = 12,
        ShiningSpear = 13,
        Vortex = 14,
        Wings = 15,
        //Surface
        Caterwaul = 16,
        Greenwand = 17,
        HealingHerb = 18,
        Quicksand = 19,
        Rathole = 20,
        Skullvisit = 21,
        Swamplight = 22,
        Vegetation = 23,
        //Underworld
        Demonomania = 24,
        ItchTwitch = 25,
        Magmatron = 26,
        ShadowSpy = 27,
        SquirmingDarkness = 28,
        Terrorismus = 29,
        Vault = 30,
        Yirn = 31
    }
}
