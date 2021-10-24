namespace Countries.Domain.Entities
{
    using Enums;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// the class that defines the country entity
    /// </summary>
    public abstract partial class Country
    {
        /// <summary>
        /// the name of the country
        /// </summary>
        public LocalizedCountryName Name { get; }

        /// <summary>
        /// code ISO 3166-1 alpha-2
        /// </summary>
        public string CCA2 { get; }

        /// <summary>
        /// code ISO 3166-1 alpha-3
        /// </summary>
        public string CCA3 { get; }

        /// <summary>
        /// code ISO 3166-1 numeric
        /// </summary>
        public string CCN3 { get; }

        /// <summary>
        /// code International Olympic Committee
        /// </summary>
        public string CIOC { get; }

        /// <summary>
        /// the country flag
        /// </summary>
        public string Flag { get; }

        /// <summary>
        /// region
        /// </summary>
        public Region Region { get; }

        /// <summary>
        /// subregion
        /// </summary>
        public string Subregion { get; }

        /// <summary>
        /// ISO 3166-1 independence status
        /// </summary>
        public bool Independent { get; }

        /// <summary>
        /// ISO 3166-1 assignment status
        /// </summary>
        public string Status { get; }

        /// <summary>
        /// UN Member status
        /// </summary>
        public bool UnMember { get; }

        /// <summary>
        /// landlocked status
        /// </summary>
        public bool Landlocked { get; }

        /// <summary>
        /// International Direct Dialing info
        /// </summary>
        public InternationalDirectDialingInfo IDD { get; }

        /// <summary>
        /// land borders
        /// </summary>
        public IEnumerable<string> Borders { get; }

        /// <summary>
        /// capital city(ies)
        /// </summary>
        public IEnumerable<string> Capital { get; }

        /// <summary>
        /// alternative spellings
        /// </summary>
        public IEnumerable<string> AltSpellings { get; }

        /// <summary>
        /// country top-level domain list
        /// </summary>
        public IEnumerable<string> TLD { get; }

        /// <summary>
        /// latitude and longitude
        /// </summary>
        public IEnumerable<double> Latlng { get; }

        /// <summary>
        /// the country time zones
        /// </summary>
        public IEnumerable<string> Timezones { get; }

        /// <summary>
        /// the country languages
        /// </summary>
        public IEnumerable<Language> Languages { get; }

        /// <summary>
        /// the country currencies
        /// </summary>
        public IEnumerable<Currency> Currencies { get; }

        /// <summary>
        /// name of residents, translated and genderized
        /// <para>key: three-letter ISO 639-3 language code</para>
        /// <para>value: genderized demonym object</para>
        /// </summary>
        public IDictionary<string, DemonymsGender> Demonyms { get; }
    }

    /// <summary>
    /// partial part for <see cref="Country"/>
    /// </summary>
    public abstract partial class Country
    {
        /// <summary>
        /// create an instance of <see cref="Country"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cca2"></param>
        /// <param name="cca3"></param>
        /// <param name="ccn3"></param>
        /// <param name="cioc"></param>
        /// <param name="flag"></param>
        /// <param name="region"></param>
        /// <param name="subregion"></param>
        /// <param name="independent"></param>
        /// <param name="status"></param>
        /// <param name="unMember"></param>
        /// <param name="landlocked"></param>
        /// <param name="idd"></param>
        /// <param name="borders"></param>
        /// <param name="capital"></param>
        /// <param name="altSpellings"></param>
        /// <param name="tld"></param>
        /// <param name="latlng"></param>
        /// <param name="timezones"></param>
        /// <param name="languages"></param>
        /// <param name="currencies"></param>
        /// <param name="demonyms"></param>
        protected Country(
            LocalizedCountryName name,
            string cca2,
            string cca3,
            string ccn3,
            string cioc,
            string flag,
            Region region,
            string subregion,
            bool independent,
            string status,
            bool unMember,
            bool landlocked,
            InternationalDirectDialingInfo idd,
            IEnumerable<string> borders,
            IEnumerable<string> capital,
            IEnumerable<string> altSpellings,
            IEnumerable<string> tld,
            IEnumerable<double> latlng,
            IEnumerable<string> timezones,
            IEnumerable<Language> languages,
            IEnumerable<Currency> currencies,
            IDictionary<string, DemonymsGender> demonyms)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            CCA2 = cca2 ?? throw new ArgumentNullException(nameof(cca2));
            CCA3 = cca3 ?? throw new ArgumentNullException(nameof(cca3));
            CCN3 = ccn3 ?? throw new ArgumentNullException(nameof(ccn3));
            CIOC = cioc ?? throw new ArgumentNullException(nameof(cioc));
            Flag = flag ?? throw new ArgumentNullException(nameof(flag));
            Region = region;
            Subregion = subregion ?? throw new ArgumentNullException(nameof(subregion));
            Independent = independent;
            Status = status ?? throw new ArgumentNullException(nameof(status));
            UnMember = unMember;
            Landlocked = landlocked;
            IDD = idd ?? throw new ArgumentNullException(nameof(idd));
            Borders = borders ?? throw new ArgumentNullException(nameof(borders));
            Capital = capital ?? throw new ArgumentNullException(nameof(capital));
            AltSpellings = altSpellings ?? throw new ArgumentNullException(nameof(altSpellings));
            TLD = tld ?? throw new ArgumentNullException(nameof(tld));
            Latlng = latlng ?? throw new ArgumentNullException(nameof(latlng));
            Timezones = timezones ?? throw new ArgumentNullException(nameof(timezones));
            Languages = languages ?? throw new ArgumentNullException(nameof(languages));
            Currencies = currencies ?? throw new ArgumentNullException(nameof(currencies));
            Demonyms = demonyms ?? throw new ArgumentNullException(nameof(demonyms));
        }
    }
}
