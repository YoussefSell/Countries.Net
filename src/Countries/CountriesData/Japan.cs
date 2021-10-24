namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Japan country
    /// </summary>
    public class Japan : Country
    {
        /// <summary>
        /// get the Japan country instance
        /// </summary>
        public static Japan Instance = new Japan(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Japan", common: "Japan") },
                { "jpn", new CountryName(official: "日本", common: "日本") },
                { "ara", new CountryName(official: "اليابان", common: "اليابان") },
                { "ces", new CountryName(official: "Japonsko", common: "Japonsko") },
                { "cym", new CountryName(official: "Japan", common: "Japan") },
                { "deu", new CountryName(official: "Japan", common: "Japan") },
                { "est", new CountryName(official: "Jaapan", common: "Jaapan") },
                { "fin", new CountryName(official: "Japani", common: "Japani") },
                { "fra", new CountryName(official: "Japon", common: "Japon") },
                { "hrv", new CountryName(official: "Japan", common: "Japan") },
                { "hun", new CountryName(official: "Japán", common: "Japán") },
                { "ita", new CountryName(official: "Giappone", common: "Giappone") },
                { "kor", new CountryName(official: "일본국", common: "일본") },
                { "nld", new CountryName(official: "Japan", common: "Japan") },
                { "per", new CountryName(official: "ژاپن", common: "ژاپن") },
                { "pol", new CountryName(official: "Japonia", common: "Japonia") },
                { "por", new CountryName(official: "Japão", common: "Japão") },
                { "rus", new CountryName(official: "Япония", common: "Япония") },
                { "slk", new CountryName(official: "Japonsko", common: "Japonsko") },
                { "spa", new CountryName(official: "Japón", common: "Japón") },
                { "swe", new CountryName(official: "Japan", common: "Japan") },
                { "urd", new CountryName(official: "جاپان", common: "جاپان") },
                { "zho", new CountryName(official: "日本国", common: "日本") },

            },
            cca2: "JP",
            cca3: "JPN",
            ccn3: "392",
            cioc: "JPN",
            flag: "🇯🇵",
            region: Region.Asia,
            subregion: "Eastern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+8", suffixes: new string[] {"1", }),
            borders: new string[] {  },
            capital: new string[] { "Tokyo",  },
            altSpellings: new string[] { "JP", "Nippon", "Nihon",  },
            tld: new string[] { ".jp", ".みんな",  },
            latlng: new double[] { 36, 138,  },
            timezones: new string[] { "UTC+09:00",  },
            languages: new Language[]
            {
                new Language(name: "Japanese", iso6391: "ja", iso6392: "jpn"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "JPY", name: "Japanese yen", symbol: "¥"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Japanese", female: "Japanese") },
                { "fra", new DemonymsGender(male: "Japanese", female: "Japanese") },
            }
        );

        /// <summary>
        /// create an instance of Japan country
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
        private Japan(
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
