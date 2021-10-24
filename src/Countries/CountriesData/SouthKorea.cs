namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of SouthKorea country
    /// </summary>
    public class SouthKorea : Country
    {
        /// <summary>
        /// get the SouthKorea country instance
        /// </summary>
        public static SouthKorea Instance = new SouthKorea(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Korea", common: "South Korea") },
                { "kor", new CountryName(official: "대한민국", common: "한국") },
                { "ara", new CountryName(official: "جمهورية كوريا", common: "كوريا الجنوبية") },
                { "ces", new CountryName(official: "Korejská republika", common: "Jižní Korea") },
                { "cym", new CountryName(official: "Republic of Korea", common: "South Korea") },
                { "deu", new CountryName(official: "Republik Korea", common: "Südkorea") },
                { "est", new CountryName(official: "Korea Vabariik", common: "Lõuna-Korea") },
                { "fin", new CountryName(official: "Korean tasavalta", common: "Etelä-Korea") },
                { "fra", new CountryName(official: "République de Corée", common: "Corée du Sud") },
                { "hrv", new CountryName(official: "Republika Koreja", common: "Južna Koreja") },
                { "hun", new CountryName(official: "Koreai Köztársaság", common: "Dél-Korea") },
                { "ita", new CountryName(official: "Repubblica di Corea", common: "Corea del Sud") },
                { "jpn", new CountryName(official: "大韓民国", common: "韓国") },
                { "nld", new CountryName(official: "Republiek Korea", common: "Zuid-Korea") },
                { "per", new CountryName(official: "جمهوری کره", common: "کرهٔ جنوبی") },
                { "pol", new CountryName(official: "Republika Korei", common: "Korea Południowa") },
                { "por", new CountryName(official: "República da Coreia", common: "Coreia do Sul") },
                { "rus", new CountryName(official: "Республика Корея", common: "Южная Корея") },
                { "slk", new CountryName(official: "Kórejská republika", common: "Južná Kórea") },
                { "spa", new CountryName(official: "República de Corea", common: "Corea del Sur") },
                { "swe", new CountryName(official: "Republiken Korea", common: "Sydkorea") },
                { "urd", new CountryName(official: "جمہوریہ کوریا ", common: "جنوبی کوریا") },
                { "zho", new CountryName(official: "大韩民国", common: "韩国") },

            },
            cca2: "KR",
            cca3: "KOR",
            ccn3: "410",
            cioc: "KOR",
            flag: "🇰🇷",
            region: Region.Asia,
            subregion: "Eastern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+8", suffixes: new string[] {"2", }),
            borders: new string[] { "PRK",  },
            capital: new string[] { "Seoul",  },
            altSpellings: new string[] { "KR", "Korea, Republic of", "Republic of Korea", "남한", "남조선",  },
            tld: new string[] { ".kr", ".한국",  },
            latlng: new double[] { 37, 127.5,  },
            timezones: new string[] { "UTC+09:00",  },
            languages: new Language[]
            {
                new Language(name: "Korean", iso6391: "ko", iso6392: "kor"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "KRW", name: "South Korean won", symbol: "₩"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "South Korean", female: "South Korean") },
                { "fra", new DemonymsGender(male: "South Korean", female: "South Korean") },
            }
        );

        /// <summary>
        /// create an instance of SouthKorea country
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
        private SouthKorea(
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
