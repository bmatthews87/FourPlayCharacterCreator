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
        Entertainment = 9, //soc
        Evangelism = 10, //soc
        [Display(Name = "Evasion/Escape")]
        EvasionEscape = 11, //ant
        Exploring = 12,  //phy
        Hiding = 13, //ant
        History = 14, //men
        Lockpicking = 15, //ant
        Magic = 16, //men
        ManualLabor = 17, //phy
        Mercantilism = 18, //soc
        [Display(Name = "Mountain Climbing")]
        MountainClimbing = 19, //phy
        Naturalism = 20, //men
        Politics = 21, //soc
        Psionics = 22, //men
        [Display(Name = "Public Speaking")]
        PublicSpeaking = 23, //soc
        Smuggling = 24, //ant
        [Display(Name = "Social Drinking")]
        SocialDrinking = 25, //soc
        [Display(Name = "Social Engineering")]
        SocialEngineering = 26, //soc
        [Display(Name = "Table Games")]
        SuckerPunching = 27, //ant
        TableGames = 28, //men
        Thievery = 29, //ant
        UnarmedCombat = 30, //phy
        Woodcraft = 31 //phy
    }
}
