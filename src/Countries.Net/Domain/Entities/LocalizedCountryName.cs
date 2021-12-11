namespace Countries.NET
{
    using Exceptions;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    /// <summary>
    /// defines the localized name of the country with Key is the language code, and value is the name
    /// </summary>
    public class LocalizedCountryName : Dictionary<string, CountryName>
    {
        /// <summary>
        /// check if the given name equals any of the names in the translation Dictionary
        /// </summary>
        /// <param name="name">the name to check for</param>
        /// <returns>true if equals, false if not</returns>
        public bool Equals(string name)
        {
            // if null return false
            if (name is null) return false;

            // check if any of country name equals the given name
            return this.Any(countryName =>
            {
                if (WorldCountriesConfiguration.IgnoreCaseOnNameEqualityCheck)
                {
                    var lowerCaseName = name.ToLower();

                    return countryName.Value.Common.ToLower().Contains(lowerCaseName)
                    || countryName.Value.Official.ToLower().Contains(lowerCaseName);
                }

                return countryName.Value.Common.Contains(name)
                    || countryName.Value.Official.Contains(name);
            });
        }

        /// <summary>
        /// check if the given name equals any of the names in the translation Dictionary
        /// </summary>
        /// <param name="name">the name to check for</param>
        /// <param name="languageCode">the language code.</param>
        /// <returns>true if equals, false if not</returns>
        /// <exception cref="ArgumentNullException">if the given language code is null</exception>
        /// <exception cref="ArgumentException">if the given language is not a valid 3 digit code.</exception>
        public bool Equals(string name, string languageCode)
            => Equals(name, languageCode, WorldCountriesConfiguration.IgnoreCaseOnNameEqualityCheck);

        /// <summary>
        /// check if the given name equals any of the names in the translation Dictionary
        /// </summary>
        /// <param name="name">the name to check for</param>
        /// <param name="languageCode">the language code.</param>
        /// <param name="ignoreCase">ignore case when performing the check</param>
        /// <returns>true if equals, false if not</returns>
        /// <exception cref="ArgumentNullException">if the given language code is null</exception>
        /// <exception cref="ArgumentException">if the given language is not a valid 3 digit code.</exception>
        public bool Equals(string name, string languageCode, bool ignoreCase)
        {
            // if null return false
            if (name is null) return false;

            // check if the language is null
            if (languageCode is null)
                throw new ArgumentNullException(nameof(languageCode));

            // check if the language is null
            if (languageCode.Length != 3)
                throw new ArgumentException("the language code must be a 3 letters code (ISO6392)", nameof(languageCode));

            // check if we have a name for the given language
            if (TryGetValue(languageCode.ToLower(), out CountryName countryName))
                return countryName.Equals(name, ignoreCase);

            return false;
        }

        /// <summary>
        /// get the country name translation for the given language.
        /// </summary>
        /// <param name="languageCode">the language code.</param>
        /// <param name="useOfficialName">true to return the official name, false to return common name, by default is true.</param>
        /// <returns>the country name</returns>
        /// <exception cref="TranslationNotFoundExceptionsException">if no name has been found for the given language.</exception>
        /// <exception cref="ArgumentNullException">if the given language is null.</exception>
        /// <exception cref="ArgumentException">if the given language is not a valid 3 digit code.</exception>
        public string GetName(string languageCode, bool useOfficialName)
        {
            // check if the language is null
            if (languageCode is null)
                throw new ArgumentNullException(nameof(languageCode));

            // check if the language is null
            if (languageCode.Length != 3)
                throw new ArgumentException("the language code must be a 3 letters code (ISO6392)", nameof(languageCode));

            // check if we have a name for the given language
            if (TryGetValue(languageCode.ToLower(), out CountryName name))
                return useOfficialName ? name.Official : name.Common;

            // check if we can throw an exception if no name has been found for the given language
            if (WorldCountriesConfiguration.ThrowIfNameNotFoundForALanguage)
                throw new TranslationNotFoundExceptionsException(languageCode);

            // return empty string
            return null;
        }

        /// <summary>
        /// get the country name translation for the given language.
        /// the name that will be returned will be based on what is configured in <see cref="WorldCountriesConfiguration.UserOfficialNameWhenRetrievingCountryName"/>
        /// </summary>
        /// <param name="languageCode">the language code.</param>
        /// <returns>the country name</returns>
        /// <exception cref="TranslationNotFoundExceptionsException">if no name has been found for the given language.</exception>
        /// <exception cref="ArgumentNullException">if the given language is null.</exception>
        /// <exception cref="ArgumentException">if the given language is not a valid 3 digit code.</exception>
        public string GetName(string languageCode)
         => GetName(languageCode, WorldCountriesConfiguration.UserOfficialNameWhenRetrievingCountryName);

        /// <summary>
        ///  get the country name for the default language specified at <see cref="WorldCountriesConfiguration.DefaultLanguage"/> 
        /// </summary>
        /// <returns>the country name</returns>
        /// <exception cref="TranslationNotFoundExceptionsException">if no name has been found for the given language</exception>
        /// <exception cref="ArgumentException">if the given language is not a valid 3 digit code.</exception>
        public string GetName() 
            => GetName(
                // check if we should use the current culture info for the language, or the default language
                languageCode: WorldCountriesConfiguration.UseCurrentCultureInfoForCountryName
                    ? CultureInfo.CurrentCulture.ThreeLetterISOLanguageName
                    : WorldCountriesConfiguration.DefaultLanguage,
                useOfficialName: WorldCountriesConfiguration.UserOfficialNameWhenRetrievingCountryName);

        /// <inheritdoc/>
        public static implicit operator string(LocalizedCountryName names)
            => names.GetName();

        /// <inheritdoc/>
        public override string ToString() => GetName();
    }
}
