namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Gibraltar country
    /// </summary>
    public class Gibraltar : Country
    {
        /// <summary>
        /// get the Gibraltar country instance
        /// </summary>
        public static Gibraltar Instance = new Gibraltar(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Gibraltar", common: "Gibraltar") },
                { "ara", new CountryName(official: "جبل طارق", common: "جبل طارق") },
                { "ces", new CountryName(official: "Gibraltar", common: "Gibraltar") },
                { "cym", new CountryName(official: "Gibraltar", common: "Gibraltar") },
                { "deu", new CountryName(official: "Gibraltar", common: "Gibraltar") },
                { "est", new CountryName(official: "Gibraltar", common: "Gibraltar") },
                { "fin", new CountryName(official: "Gibraltar", common: "Gibraltar") },
                { "fra", new CountryName(official: "Gibraltar", common: "Gibraltar") },
                { "hrv", new CountryName(official: "Gibraltar", common: "Gibraltar") },
                { "hun", new CountryName(official: "Gibraltár", common: "Gibraltár") },
                { "ita", new CountryName(official: "Gibilterra", common: "Gibilterra") },
                { "jpn", new CountryName(official: "ジブラルタル", common: "ジブラルタル") },
                { "kor", new CountryName(official: "지브롤터", common: "지브롤터") },
                { "nld", new CountryName(official: "Gibraltar", common: "Gibraltar") },
                { "per", new CountryName(official: "جبل طارق", common: "جبل طارق") },
                { "pol", new CountryName(official: "Gibraltar", common: "Gibraltar") },
                { "por", new CountryName(official: "Gibraltar", common: "Gibraltar") },
                { "rus", new CountryName(official: "Гибралтар", common: "Гибралтар") },
                { "slk", new CountryName(official: "Gibraltár", common: "Gibraltár") },
                { "spa", new CountryName(official: "Gibraltar", common: "Gibraltar") },
                { "swe", new CountryName(official: "Gibraltar", common: "Gibraltar") },
                { "urd", new CountryName(official: "جبل الطارق", common: "جبل الطارق") },
                { "zho", new CountryName(official: "直布罗陀", common: "直布罗陀") },
            },
            cca2: "GI",
            cca3: "GIB",
            ccn3: "292",
            cioc: "",
            flag: "🇬🇮",
            region: Region.Europe,
            subregion: "Southern Europe",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"50", }),
            borders: new string[] { "ESP",  },
            capital: new string[] { "Gibraltar",  },
            altSpellings: new string[] { "GI",  },
            tld: new string[] { ".gi",  },
            latlng: new double[] { 36.13333333, -5.35,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "GIP", name: "Gibraltar pound", symbol: "£"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Gibraltar", female: "Gibraltar") },
                { "fra", new DemonymsGender(male: "Gibraltar", female: "Gibraltar") },
            }
        );

        /// <summary>
        /// create an instance of Gibraltar country
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
        private Gibraltar(
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
