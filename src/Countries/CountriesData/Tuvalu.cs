namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Tuvalu country
    /// </summary>
    public class Tuvalu : Country
    {
        /// <summary>
        /// get the Tuvalu country instance
        /// </summary>
        public static Tuvalu Instance = new Tuvalu(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "tvl", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "ara", new CountryName(official: "توفالو", common: "توفالو") },
                { "ces", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "cym", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "deu", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "est", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "fin", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "fra", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "hrv", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "hun", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "ita", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "jpn", new CountryName(official: "ツバル", common: "ツバル") },
                { "kor", new CountryName(official: "투발루", common: "투발루") },
                { "nld", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "per", new CountryName(official: "تووالو", common: "تووالو") },
                { "pol", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "por", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "rus", new CountryName(official: "Тувалу", common: "Тувалу") },
                { "slk", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "spa", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "swe", new CountryName(official: "Tuvalu", common: "Tuvalu") },
                { "urd", new CountryName(official: "تووالو", common: "تووالو") },
                { "zho", new CountryName(official: "图瓦卢", common: "图瓦卢") },
            },
            cca2: "TV",
            cca3: "TUV",
            ccn3: "798",
            cioc: "TUV",
            flag: "🇹🇻",
            region: Region.Oceania,
            subregion: "Polynesia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"88", }),
            borders: new string[] {  },
            capital: new string[] { "Funafuti",  },
            altSpellings: new string[] { "TV",  },
            tld: new string[] { ".tv",  },
            latlng: new double[] { -8, 178,  },
            timezones: new string[] { "UTC+12:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Tuvaluan", iso6391: "", iso6392: "tvl"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "AUD", name: "Australian dollar", symbol: "$"),
                new Currency(code: "TVD", name: "Tuvaluan dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Tuvaluan", female: "Tuvaluan") },
                { "fra", new DemonymsGender(male: "Tuvaluan", female: "Tuvaluan") },
            }
        );

        /// <summary>
        /// create an instance of Tuvalu country
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
        private Tuvalu(
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
