namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Paraguay country
    /// </summary>
    public class Paraguay : Country
    {
        /// <summary>
        /// get the Paraguay country instance
        /// </summary>
        public static Paraguay Instance = new Paraguay(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Paraguay", common: "Paraguay") },
                { "grn", new CountryName(official: "Tetã Paraguái", common: "Paraguái") },
                { "spa", new CountryName(official: "República de Paraguay", common: "Paraguay") },
                { "ara", new CountryName(official: "جمهورية باراغواي", common: "باراغواي") },
                { "ces", new CountryName(official: "Paraguayská republika", common: "Paraguay") },
                { "cym", new CountryName(official: "Republic of Paraguay", common: "Paraguay") },
                { "deu", new CountryName(official: "Republik Paraguay", common: "Paraguay") },
                { "est", new CountryName(official: "Paraguay Vabariik", common: "Paraguay") },
                { "fin", new CountryName(official: "Paraguayn tasavalta", common: "Paraguay") },
                { "fra", new CountryName(official: "République du Paraguay", common: "Paraguay") },
                { "hrv", new CountryName(official: "Republika Paragvaj", common: "Paragvaj") },
                { "hun", new CountryName(official: "Paraguayi Köztársaság", common: "Paraguay") },
                { "ita", new CountryName(official: "Repubblica del Paraguay", common: "Paraguay") },
                { "jpn", new CountryName(official: "パラグアイ共和国", common: "パラグアイ") },
                { "kor", new CountryName(official: "파라과이 공화국", common: "파라과이") },
                { "nld", new CountryName(official: "Republiek Paraguay", common: "Paraguay") },
                { "per", new CountryName(official: "جمهوری پاراگوئه", common: "پاراگوئه") },
                { "pol", new CountryName(official: "Republika Paragwaju", common: "Paragwaj") },
                { "por", new CountryName(official: "República do Paraguai", common: "Paraguai") },
                { "rus", new CountryName(official: "Республика Парагвай", common: "Парагвай") },
                { "slk", new CountryName(official: "Paraguajská republika", common: "Paraguaj") },
                { "swe", new CountryName(official: "Republiken Paraguay", common: "Paraguay") },
                { "urd", new CountryName(official: "جمہوریہ پیراگوئے", common: "پیراگوئے") },
                { "zho", new CountryName(official: "巴拉圭共和国", common: "巴拉圭") },

            },
            cca2: "PY",
            cca3: "PRY",
            ccn3: "600",
            cioc: "PAR",
            flag: "🇵🇾",
            region: Region.Americas,
            subregion: "South America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"95", }),
            borders: new string[] { "ARG", "BOL", "BRA",  },
            capital: new string[] { "Asunción",  },
            altSpellings: new string[] { "PY", "Republic of Paraguay", "República del Paraguay", "Tetã Paraguái",  },
            tld: new string[] { ".py",  },
            latlng: new double[] { -23, -58,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "Guaraní", iso6391: "gn", iso6392: "grn"),
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "PYG", name: "Paraguayan guaraní", symbol: "₲"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Paraguayan", female: "Paraguayan") },
                { "fra", new DemonymsGender(male: "Paraguayan", female: "Paraguayan") },
            }
        );

        /// <summary>
        /// create an instance of Paraguay country
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
        private Paraguay(
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
            : base(name, cca2, cca3, ccn3, cioc, flag, region, subregion, independent, status, unMember, landlocked, idd, borders, capital, altSpellings, tld, latlng, timezones, languages, currencies, demonyms) { }
    }
}
