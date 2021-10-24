namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of SierraLeone country
    /// </summary>
    public class SierraLeone : Country
    {
        /// <summary>
        /// get the SierraLeone country instance
        /// </summary>
        public static SierraLeone Instance = new SierraLeone(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Sierra Leone", common: "Sierra Leone") },
                { "ara", new CountryName(official: "جمهورية سيراليون", common: "سيراليون") },
                { "ces", new CountryName(official: "Republika Sierra Leone", common: "Sierra Leone") },
                { "cym", new CountryName(official: "Republic of Sierra Leone", common: "Sierra Leone") },
                { "deu", new CountryName(official: "Republik Sierra Leone", common: "Sierra Leone") },
                { "est", new CountryName(official: "Sierra Leone Vabariik", common: "Sierra Leone") },
                { "fin", new CountryName(official: "Sierra Leonen tasavalta", common: "Sierra Leone") },
                { "fra", new CountryName(official: "République de Sierra Leone", common: "Sierra Leone") },
                { "hrv", new CountryName(official: "Republika Sijera Leone", common: "Sijera Leone") },
                { "hun", new CountryName(official: "Sierra Leone Köztársaság", common: "Sierra Leone") },
                { "ita", new CountryName(official: "Repubblica della Sierra Leone", common: "Sierra Leone") },
                { "jpn", new CountryName(official: "シエラレオネ共和国", common: "シエラレオネ") },
                { "kor", new CountryName(official: "시에라리온 공화국", common: "시에라리온") },
                { "nld", new CountryName(official: "Republiek Sierra Leone", common: "Sierra Leone") },
                { "per", new CountryName(official: "جمهوری سیرالئون", common: "سیرالئون") },
                { "pol", new CountryName(official: "Sierra Leone", common: "Sierra Leone") },
                { "por", new CountryName(official: "República da Serra Leoa", common: "Serra Leoa") },
                { "rus", new CountryName(official: "Республика Сьерра-Леоне", common: "Сьерра-Леоне") },
                { "slk", new CountryName(official: "Sierraleonská republika", common: "Sierra Leone") },
                { "spa", new CountryName(official: "República de Sierra Leona", common: "Sierra Leone") },
                { "swe", new CountryName(official: "Republiken Sierra Leone", common: "Sierra Leone") },
                { "urd", new CountryName(official: "جمہوریہ سیرالیون", common: "سیرالیون") },
                { "zho", new CountryName(official: "塞拉利昂共和国", common: "塞拉利昂") },
            },
            cca2: "SL",
            cca3: "SLE",
            ccn3: "694",
            cioc: "SLE",
            flag: "🇸🇱",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"32", }),
            borders: new string[] { "GIN", "LBR",  },
            capital: new string[] { "Freetown",  },
            altSpellings: new string[] { "SL", "Republic of Sierra Leone",  },
            tld: new string[] { ".sl",  },
            latlng: new double[] { 8.5, -11.5,  },
            timezones: new string[] { "UTC",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "SLL", name: "Sierra Leonean leone", symbol: "Le"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Sierra Leonean", female: "Sierra Leonean") },
                { "fra", new DemonymsGender(male: "Sierra Leonean", female: "Sierra Leonean") },
            }
        );

        /// <summary>
        /// create an instance of SierraLeone country
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
        private SierraLeone(
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
