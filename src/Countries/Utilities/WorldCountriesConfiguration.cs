namespace Countries
{
    /// <summary>
    /// the configuration of the WorldCountries services
    /// </summary>
    public static class WorldCountriesConfiguration
    {
        /// <summary>
        /// the default language
        /// </summary>
        public static string DefaultLanguage = "eng";

        /// <summary>
        /// true to use the current culture info when retrieving the name of the country
        /// </summary>
        public static bool UseCurrentCultureInfoForCountryName = false;

        /// <summary>
        /// true to return the Official Name when retrieving the name of the country
        /// </summary>
        public static bool UserOfficialNameWhenRetrievingCountryName = true;

        /// <summary>
        /// if true an exception of type <see cref="Domain.Exceptions.TranslationNotFoundExceptionsException"/> will be thrown, if false null will be returned
        /// </summary>
        public static bool ThrowIfNameNotFoundForALanguage = true;

        /// <summary>
        /// this option is used when checking equality of the country name, if set to `true` case will be ignored, if `false` the equality will be case sensitive.
        /// </summary>
        public static bool IgnoreCaseOnNameEqualityCheck = true;

        /// <summary>
        /// reset the options to there original configuration
        /// </summary>
        public static void Reset()
        {
            DefaultLanguage = "eng";
            UseCurrentCultureInfoForCountryName = false;
            UserOfficialNameWhenRetrievingCountryName = true;
            ThrowIfNameNotFoundForALanguage = true;
            IgnoreCaseOnNameEqualityCheck = true;
        }
    }
}
