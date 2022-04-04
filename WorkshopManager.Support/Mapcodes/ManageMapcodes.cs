namespace WorkshopManager.Support.Mapcodes
{
    public static class ManageMapcodes
    {
        private static string FormatMapcode(string value)
        {
            return value.Replace(" ", "_").ToUpper();
        }

        public static string GenerateNewMapcode(string prefix, string value)
        {
            return FormatMapcode(string.Concat(prefix, " ", value));
        }
    }
}
