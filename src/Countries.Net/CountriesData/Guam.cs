namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Guam country
    /// </summary>
    public class Guam : Country
    {
        /// <summary>
        /// get the Guam country instance
        /// </summary>
        public static Guam Instance = new Guam(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Guam", common: "Guam") },
                { "cha", new CountryName(official: "Guåhån", common: "Guåhån") },
                { "spa", new CountryName(official: "Guam", common: "Guam") },
                { "ara", new CountryName(official: "غوام", common: "غوام") },
                { "ces", new CountryName(official: "Guam", common: "Guam") },
                { "cym", new CountryName(official: "Guam", common: "Guam") },
                { "deu", new CountryName(official: "Guam", common: "Guam") },
                { "est", new CountryName(official: "Guami ala", common: "Guam") },
                { "fin", new CountryName(official: "Guam", common: "Guam") },
                { "fra", new CountryName(official: "Guam", common: "Guam") },
                { "hrv", new CountryName(official: "Guam", common: "Guam") },
                { "hun", new CountryName(official: "Guam", common: "Guam") },
                { "ita", new CountryName(official: "Guam", common: "Guam") },
                { "jpn", new CountryName(official: "グアム", common: "グアム") },
                { "kor", new CountryName(official: "괌", common: "괌") },
                { "nld", new CountryName(official: "Guam", common: "Guam") },
                { "per", new CountryName(official: "گوآم", common: "گوآم") },
                { "pol", new CountryName(official: "Terytorium Guamu", common: "Guam") },
                { "por", new CountryName(official: "Guam", common: "Guam") },
                { "rus", new CountryName(official: "Гуам", common: "Гуам") },
                { "slk", new CountryName(official: "Guam", common: "Guam") },
                { "swe", new CountryName(official: "Guam", common: "Guam") },
                { "urd", new CountryName(official: "گوام", common: "گوام") },
                { "zho", new CountryName(official: "关岛", common: "关岛") },

            },
            cca2: "GU",
            cca3: "GUM",
            ccn3: "316",
            cioc: "GUM",
            flag: "🇬🇺",
            region: Region.Oceania,
            subregion: "Micronesia",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"671", }),
            borders: new string[] {  },
            capital: new string[] { "Hagåtña",  },
            altSpellings: new string[] { "GU", "Guåhån",  },
            tld: new string[] { ".gu",  },
            latlng: new double[] { 13.46666666, 144.78333333,  },
            timezones: new string[] { "UTC+10:00",  },
            languages: new Language[]
            {
                new Language(name: "Chamorro", iso6391: "", iso6392: "cha"),
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "USD", name: "United States dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Guamanian", female: "Guamanian") },
                { "fra", new DemonymsGender(male: "Guamanian", female: "Guamanian") },
            }
        );

        /// <summary>
        /// create an instance of Guam country
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
        private Guam(
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
