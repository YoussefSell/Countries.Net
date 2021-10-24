namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Nauru country
    /// </summary>
    public class Nauru : Country
    {
        /// <summary>
        /// get the Nauru country instance
        /// </summary>
        public static Nauru Instance = new Nauru(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Nauru", common: "Nauru") },
                { "nau", new CountryName(official: "Republic of Nauru", common: "Nauru") },
                { "ara", new CountryName(official: "جمهورية ناورو", common: "ناورو") },
                { "ces", new CountryName(official: "Republika Nauru", common: "Nauru") },
                { "cym", new CountryName(official: "Republic of Nauru", common: "Nauru") },
                { "deu", new CountryName(official: "Republik Nauru", common: "Nauru") },
                { "est", new CountryName(official: "Nauru Vabariik", common: "Nauru") },
                { "fin", new CountryName(official: "Naurun tasavalta", common: "Nauru") },
                { "fra", new CountryName(official: "République de Nauru", common: "Nauru") },
                { "hrv", new CountryName(official: "Republika Nauru", common: "Nauru") },
                { "hun", new CountryName(official: "Naurui Köztársaság", common: "Nauru") },
                { "ita", new CountryName(official: "Repubblica di Nauru", common: "Nauru") },
                { "jpn", new CountryName(official: "ナウル共和国", common: "ナウル") },
                { "kor", new CountryName(official: "나우루 공화국", common: "나우루") },
                { "nld", new CountryName(official: "Republiek Nauru", common: "Nauru") },
                { "per", new CountryName(official: "جمهوری نائورو", common: "نائورو") },
                { "pol", new CountryName(official: "Republika Nauru", common: "Nauru") },
                { "por", new CountryName(official: "República de Nauru", common: "Nauru") },
                { "rus", new CountryName(official: "Республика Науру", common: "Науру") },
                { "slk", new CountryName(official: "Naurská republika", common: "Nauru") },
                { "spa", new CountryName(official: "República de Nauru", common: "Nauru") },
                { "swe", new CountryName(official: "Republiken Nauru", common: "Nauru") },
                { "urd", new CountryName(official: "جمہوریہ ناورو", common: "ناورو") },
                { "zho", new CountryName(official: "瑙鲁共和国", common: "瑙鲁") },
            },
            cca2: "NR",
            cca3: "NRU",
            ccn3: "520",
            cioc: "NRU",
            flag: "🇳🇷",
            region: Region.Oceania,
            subregion: "Micronesia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"74", }),
            borders: new string[] {  },
            capital: new string[] { "Yaren",  },
            altSpellings: new string[] { "NR", "Naoero", "Pleasant Island", "Republic of Nauru", "Ripublik Naoero",  },
            tld: new string[] { ".nr",  },
            latlng: new double[] { -0.53333333, 166.91666666,  },
            timezones: new string[] { "UTC+12:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Nauru", iso6391: "", iso6392: "nau"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "AUD", name: "Australian dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Nauruan", female: "Nauruan") },
                { "fra", new DemonymsGender(male: "Nauruan", female: "Nauruan") },
            }
        );

        /// <summary>
        /// create an instance of Nauru country
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
        private Nauru(
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
