using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FourPlayCharacterCreator
{
    public enum Competency
    {
        Alchemy, //men
        [Display(Name = "Armed Combat")]
        ArmedCombat, //phy
        [Display(Name = "Bypassing Traps and Alarms")]
        BypassingTrapsAndAlarms, //ant
        [Display(Name = "Community Organization")]
        CommunityOrganization, //soc
        [Display(Name = "Competitive Games")]
        CompetitiveGames,//phy
        [Display(Name = "Confidence Games")]
        ConfidenceGames, //ant
        Craftsmanship, //phy
        Disguise, //ant
        Engineering, //men
        Entertainment, //soc
        Evangelism, //soc
        [Display(Name = "Evasion/Escape")]
        EvasionEscape, //ant
        Exploring,  //phy
        Hiding, //ant
        History, //men
        Lockpicking, //ant
        Magic, //men
        ManualLabor, //phy
        Mercantilism, //soc
        MountainClimbing, //phy
        Naturalism, //men
        Politics, //soc
        Psionics, //men
        PublicSpeaking, //soc
        Smuggling, //ant
        SocialDrinking, //soc
        SocialEngineering, //soc
        SuckerPunching, //ant
        TableGames, //men
        Thievery, //ant
        UnarmedCombat, //phy
        Woodcraft //phy
    }
}
