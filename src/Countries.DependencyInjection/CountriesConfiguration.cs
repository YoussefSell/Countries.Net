namespace Microsoft.Extensions.DependencyInjection
{
    using Countries.NET;
    using Countries.NET.Exceptions;

    /// <summary>
    /// the DI registration configuration
    /// </summary>
    public class CountriesConfiguration
    {
        /// <summary>
        /// the default language
        /// </summary>
        public string DefaultLanguage { get; set; } = "eng";

        /// <summary>
        /// true to use the current culture info when retrieving the name of the country
        /// </summary>
        public bool UseCurrentCultureInfoForCountryName { get; set; } = false;

        /// <summary>
        /// true to return the Official Name when retrieving the name of the country
        /// </summary>
        public bool UserOfficialNameWhenRetrievingCountryName { get; set; } = true;

        /// <summary>
        /// if true an exception of type <see cref="TranslationNotFoundExceptionsException"/> will be thrown, if false null will be returned
        /// </summary>
        public bool ThrowIfNameNotFoundForALanguage { get; set; } = true;

        /// <summary>
        /// this option is used when checking equality of the country name, if set to `true` case will be ignored, if `false` the equality will be case sensitive.
        /// </summary>
        public bool IgnoreCaseOnNameEqualityCheck { get; set; } = true;

        /// <summary>
        /// apply the configuration
        /// </summary>
        internal void Apply()
        {
            WorldCountriesConfiguration.DefaultLanguage = DefaultLanguage;
            WorldCountriesConfiguration.IgnoreCaseOnNameEqualityCheck = IgnoreCaseOnNameEqualityCheck;
            WorldCountriesConfiguration.ThrowIfNameNotFoundForALanguage = ThrowIfNameNotFoundForALanguage;
            WorldCountriesConfiguration.UseCurrentCultureInfoForCountryName = UseCurrentCultureInfoForCountryName;
            WorldCountriesConfiguration.UserOfficialNameWhenRetrievingCountryName = UserOfficialNameWhenRetrievingCountryName;
        }
    }
}
