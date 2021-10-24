namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Belize country
    /// </summary>
    public class Belize : Country
    {
        /// <summary>
        /// get the Belize country instance
        /// </summary>
        public static Belize Instance = new Belize(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Belize", common: "Belize") },
                { "bjz", new CountryName(official: "Belize", common: "Belize") },
                { "spa", new CountryName(official: "Belice", common: "Belice") },
                { "ara", new CountryName(official: "بليز", common: "بليز") },
                { "ces", new CountryName(official: "Belize", common: "Belize") },
                { "cym", new CountryName(official: "Belîs", common: "Belîs") },
                { "deu", new CountryName(official: "Belize", common: "Belize") },
                { "est", new CountryName(official: "Belize", common: "Belize") },
                { "fin", new CountryName(official: "Belize", common: "Belize") },
                { "fra", new CountryName(official: "Belize", common: "Belize") },
                { "hrv", new CountryName(official: "Belize", common: "Belize") },
                { "hun", new CountryName(official: "Belize", common: "Belize") },
                { "ita", new CountryName(official: "Belize", common: "Belize") },
                { "jpn", new CountryName(official: "ベリーズ", common: "ベリーズ") },
                { "kor", new CountryName(official: "벨리즈", common: "벨리즈") },
                { "nld", new CountryName(official: "Belize", common: "Belize") },
                { "per", new CountryName(official: "بلیز", common: "بلیز") },
                { "pol", new CountryName(official: "Belize", common: "Belize") },
                { "por", new CountryName(official: "Belize", common: "Belize") },
                { "rus", new CountryName(official: "Белиз", common: "Белиз") },
                { "slk", new CountryName(official: "Belize", common: "Belize") },
                { "swe", new CountryName(official: "Belize", common: "Belize") },
                { "urd", new CountryName(official: "بیلیز", common: "بیلیز") },
                { "zho", new CountryName(official: "伯利兹", common: "伯利兹") },

            },
            cca2: "BZ",
            cca3: "BLZ",
            ccn3: "084",
            cioc: "BIZ",
            flag: "🇧🇿",
            region: Region.Americas,
            subregion: "Central America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"01", }),
            borders: new string[] { "GTM", "MEX",  },
            capital: new string[] { "Belmopan",  },
            altSpellings: new string[] { "BZ",  },
            tld: new string[] { ".bz",  },
            latlng: new double[] { 17.25, -88.75,  },
            timezones: new string[] { "UTC-06:00",  },
            languages: new Language[]
            {
                new Language(name: "Belizean Creole", iso6391: "", iso6392: "bjz"),
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "BZD", name: "Belize dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Belizean", female: "Belizean") },
                { "fra", new DemonymsGender(male: "Belizean", female: "Belizean") },
            }
        );

        /// <summary>
        /// create an instance of Belize country
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
        private Belize(
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
