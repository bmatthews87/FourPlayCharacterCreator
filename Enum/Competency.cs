using System.ComponentModel;

namespace FourPlayCharacterCreator
{
    public enum Competency
    {
        Alchemy, //men
        [Description("Armed Combat")]
        ArmedCombat, //phy
        [Description("Bypassing Traps and Alarms")]
        BypassingTrapsAndAlarms, //ant
        [Description("Community Organization")]
        CommunityOrganization, //soc
        [Description("Competitive Games")]
        CompetitiveGames,//phy
        [Description("Confidence Games")]
        ConfidenceGames, //ant
        Craftsmanship, //phy
        Disguise, //ant
        Engineering, //men
        Entertainment, //soc
        Evangelism, //soc
        [Description("Evasion/Escape")]
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
