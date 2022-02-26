namespace Countries.NET
{
    using Countries.NET.Enums;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// the service for accessing the countries data
    /// </summary>
    public interface ICountriesService
    {
        /// <summary>
        /// find the country with the given CCA2, CCA3, CCN3 or CIOC code.
        /// </summary>
        /// <param name="code">the code of the country to look for</param>
        /// <returns>the country or null if not found</returns>
        /// <remarks>the code is case sensitive, MA != ma</remarks>
        Country FindByCode(string code);

        /// <summary>
        /// find list of countries using the given currency
        /// </summary>
        /// <param name="currency">the currency</param>
        /// <returns>the list of countries using the given currency</returns>
        IEnumerable<Country> FindByCurrency(Currency currency);

        /// <summary>
        /// find list of countries using the given currency
        /// </summary>
        /// <param name="currencyCode">the currency code</param>
        /// <returns>the list of countries using the given language</returns>
        IEnumerable<Country> FindByCurrency(string currencyCode);

        /// <summary>
        /// find list of countries using the given language
        /// </summary>
        /// <param name="language">the language</param>
        /// <returns>the list of countries using the given language</returns>
        IEnumerable<Country> FindByLanguage(Language language);

        /// <summary>
        /// find list of countries using the given language
        /// </summary>
        /// <param name="ISO6392_LanguageCode">the ISO6392 (3 chars) language code</param>
        /// <returns>the list of countries using the given language</returns>
        IEnumerable<Country> FindByLanguage(string ISO6392_LanguageCode);

        /// <summary>
        /// find the country by the name
        /// </summary>
        /// <param name="name">the name of the country</param>
        /// <returns>the country instance, or null if not found</returns>
        Country FindByName(string name);

        /// <summary>
        /// find the country by the name
        /// </summary>
        /// <param name="name">the name of the country</param>
        /// <param name="languageCode">the language to check for</param>
        /// <returns>the country instance, or null if not found</returns>
        Country FindByName(string name, string languageCode);

        /// <summary>
        /// find list of countries in a given region
        /// </summary>
        /// <param name="region">the region to look by</param>
        /// <returns>the list of countries in the given region</returns>
        IEnumerable<Country> FindByRegion(Region region);

        /// <summary>
        /// get the list of all countries.
        /// </summary>
        /// <returns>list of all countries</returns>
        IEnumerable<Country> GetAll();

        /// <summary>
        /// get the list of all countries. projected to a new form invoking the given transform function.
        /// </summary>
        /// <returns>
        /// An System.Collections.Generic.IEnumerable`1 whose elements are the result of invoking the transform function on each element of source.
        /// </returns>
        IEnumerable<TResult> GetAll<TResult>(Func<Country, TResult> selector);

        /// <summary>
        /// get the list of countries as key-value, where the key is <see cref="Country.CCA2"/> and the value is the name.
        /// </summary>
        /// <returns>list of countries as key-value</returns>
        IEnumerable<KeyValuePair<string, string>> GetAsKeyValue();

        /// <summary>
        /// get the list of countries as key-value, where the key is <see cref="Country.CCA2"/> and the value is the name.
        /// </summary>
        /// <param name="languageCode">the language to get the name for.</param>
        /// <param name="useCommonName">true to use the common name instead of official name by default is true.</param>
        /// <returns>list of countries as key-value</returns>
        /// <exception cref="KeyNotFoundException">if the </exception>
        IEnumerable<KeyValuePair<string, string>> GetAsKeyValue(string languageCode, bool useCommonName = true);
    }
}