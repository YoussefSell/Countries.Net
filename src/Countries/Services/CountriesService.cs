namespace Countries
{
    using Domain.Entities;
    using Domain.Enums;
    using Domain.Exceptions;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// the service for accessing the countries data
    /// </summary>
    public partial class CountriesService : ICountriesService
    {
        /// <inheritdoc/>
        public IEnumerable<Country> GetAll() => Country.ALL;

        /// <inheritdoc/>
        public Country FindByCode(string code)
        {
            return GetAll().FirstOrDefault(country =>
                country.CCA2.Equals(code) ||
                country.CCA3.Equals(code) ||
                country.CCN3.Equals(code) ||
                country.CIOC.Equals(code)
            );
        }

        /// <inheritdoc/>
        public Country FindByName(string name)
        {
            return GetAll().FirstOrDefault(country =>
                country.Name.Equals(name)
            );
        }

        /// <inheritdoc/>
        public Country FindByName(string name, string languageCode)
        {
            return GetAll().FirstOrDefault(country =>
                country.Name.Equals(name, languageCode)
            );
        }

        /// <inheritdoc/>
        public IEnumerable<Country> FindByRegion(Region region)
            => GetAll().Where(country => country.Region == region);

        /// <inheritdoc/>
        public IEnumerable<Country> FindByLanguage(string ISO6392_LanguageCode)
            => GetAll().Where(country => country.Languages
                .Any(language => language.ISO6392
                    .Equals(ISO6392_LanguageCode, System.StringComparison.OrdinalIgnoreCase)));

        /// <inheritdoc/>
        public IEnumerable<Country> FindByLanguage(Language language)
            => GetAll().Where(country => country.Languages.Any(countryLanguage => countryLanguage == language));

        /// <inheritdoc/>
        public IEnumerable<Country> FindByCurrency(string currencyCode)
            => GetAll().Where(country => country.Currencies
                .Any(currency => currency.Code
                    .Equals(currencyCode, System.StringComparison.OrdinalIgnoreCase)));

        /// <inheritdoc/>
        public IEnumerable<Country> FindByCurrency(Currency currency)
            => GetAll().Where(country => country.Currencies.Any(countryCurrency => countryCurrency == currency));

        /// <inheritdoc/>
        public IEnumerable<KeyValuePair<string, string>> GetAsKeyValue()
            => GetAll().Select(country => new KeyValuePair<string, string>(key: country.CCA2, value: country.Name));

        /// <inheritdoc/>
        public IEnumerable<KeyValuePair<string, string>> GetAsKeyValue(string languageCode, bool useCommonName = true)
            => GetAll().Select(country =>
            {
                // get the name for the given language
                if (country.Name.TryGetValue(languageCode.ToLower(), out CountryName name))
                {
                    if (useCommonName)
                        return new KeyValuePair<string, string>(key: country.CCA2, value: name.Common);

                    return new KeyValuePair<string, string>(key: country.CCA2, value: name.Official);
                }

                throw new TranslationNotFoundExceptionsException(languageCode, country.CCA2);
            });
    }
}
