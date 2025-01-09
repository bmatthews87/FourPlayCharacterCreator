namespace FourPlayCharacterCreator
{
    public static class Common
    {
        public static EnumType StringToEnum<EnumType>(object someValue)
        {
            return (EnumType)Enum.Parse(typeof(EnumType), someValue.ToString());
        }
    }
}
