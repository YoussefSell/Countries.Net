namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of SintMaarten country
    /// </summary>
    public class SintMaarten : Country
    {
        /// <summary>
        /// get the SintMaarten country instance
        /// </summary>
        public static SintMaarten Instance = new SintMaarten(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Sint Maarten", common: "Sint Maarten") },
                { "fra", new CountryName(official: "Saint-Martin", common: "Saint-Martin") },
                { "nld", new CountryName(official: "Sint Maarten", common: "Sint Maarten") },
                { "ara", new CountryName(official: "سينت مارتن", common: "سينت مارتن") },
                { "ces", new CountryName(official: "Svatý Martin", common: "Svatý Martin (Nizozemsko)") },
                { "cym", new CountryName(official: "Sint Maarten", common: "Sint Maarten") },
                { "deu", new CountryName(official: "Sint Maarten", common: "Sint Maarten") },
                { "est", new CountryName(official: "Sint Maarten", common: "Sint Maarten") },
                { "fin", new CountryName(official: "Sint Maarten", common: "Sint Maarten") },
                { "hrv", new CountryName(official: "Sveti Martin", common: "Sveti Martin") },
                { "hun", new CountryName(official: "Sint Maarten", common: "Sint Maarten") },
                { "ita", new CountryName(official: "Sint Maarten", common: "Sint Maarten") },
                { "jpn", new CountryName(official: "シントマールテン島", common: "シント・マールテン") },
                { "kor", new CountryName(official: "신트마르턴", common: "신트마르턴") },
                { "per", new CountryName(official: "سن مارتن", common: "سن مارتن") },
                { "pol", new CountryName(official: "Sint Maarten", common: "Sint Maarten") },
                { "por", new CountryName(official: "Sint Maarten", common: "São Martinho") },
                { "rus", new CountryName(official: "Синт-Маартен", common: "Синт-Мартен") },
                { "slk", new CountryName(official: "Sint Maarten", common: "Sint Maarten") },
                { "spa", new CountryName(official: "Sint Maarten", common: "Sint Maarten") },
                { "swe", new CountryName(official: "Sint Maarten", common: "Sint Maarten") },
                { "urd", new CountryName(official: "سنٹ مارٹن", common: "سنٹ مارٹن") },
                { "zho", new CountryName(official: "圣马丁岛", common: "圣马丁岛") },

            },
            cca2: "SX",
            cca3: "SXM",
            ccn3: "534",
            cioc: "",
            flag: "🇸🇽",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"721", }),
            borders: new string[] { "MAF",  },
            capital: new string[] { "Philipsburg",  },
            altSpellings: new string[] { "SX", "Sint Maarten (Dutch part)",  },
            tld: new string[] { ".sx",  },
            latlng: new double[] { 18.033333, -63.05,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
                new Language(name: "Dutch", iso6391: "nl", iso6392: "nld"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "ANG", name: "Netherlands Antillean guilder", symbol: "ƒ"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "St. Maartener", female: "St. Maartener") },
                { "fra", new DemonymsGender(male: "St. Maartener", female: "St. Maartener") },
            }
        );

        /// <summary>
        /// create an instance of SintMaarten country
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
        private SintMaarten(
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
