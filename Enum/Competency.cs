using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FourPlayCharacterCreator
{
    public enum Competency
    {
        Alchemy = 1, //men
        [Display(Name = "Armed Combat")]
        ArmedCombat = 2, //phy
        [Display(Name = "Bypassing Traps and Alarms")]
        BypassingTrapsAndAlarms = 3, //ant
        [Display(Name = "Community Organization")]
        CommunityOrganization = 4, //soc
        [Display(Name = "Competitive Games")]
        CompetitiveGames = 5,//phy
        [Display(Name = "Confidence Games")]
        ConfidenceGames = 6, //ant
        Craftsmanship = 7, //phy
        Disguise = 8, //ant
        Engineering = 9, //men
        Entertainment = 10, //soc
        Evangelism = 11, //soc
        [Display(Name = "Evasion/Escape")]
        EvasionEscape = 12, //ant
        Exploring = 13,  //phy
        Hiding = 14, //ant
        History = 15, //men
        Lockpicking = 16, //ant
        Magic = 17, //men
        [Display(Name = "Manual Labor")]
        ManualLabor = 18, //phy
        Mercantilism = 19, //soc
        [Display(Name = "Mountain Climbing")]
        MountainClimbing = 20, //phy
        Naturalism = 21, //men
        Politics = 22, //soc
        Psionics = 23, //men
        [Display(Name = "Public Speaking")]
        PublicSpeaking = 24, //soc
        Smuggling = 25, //ant
        [Display(Name = "Social Drinking")]
        SocialDrinking = 26, //soc
        [Display(Name = "Social Engineering")]
        SocialEngineering = 27, //soc
        [Display(Name = "Sucker Punching")]
        SuckerPunching = 28, //ant
        [Display(Name = "Table Games")]
        TableGames = 29, //men
        Thievery = 30, //ant
        [Display(Name = "Unarmed Combat")]
        UnarmedCombat = 31, //phy
        Woodcraft = 32 //phy
    }
}
