namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Azerbaijan country
    /// </summary>
    public class Azerbaijan : Country
    {
        /// <summary>
        /// get the Azerbaijan country instance
        /// </summary>
        public static Azerbaijan Instance = new Azerbaijan(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Azerbaijan", common: "Azerbaijan") },
                { "aze", new CountryName(official: "Azərbaycan Respublikası", common: "Azərbaycan") },
                { "rus", new CountryName(official: "Азербайджанская Республика", common: "Азербайджан") },
                { "ara", new CountryName(official: "جمهورية أذربيجان", common: "أذربيجان") },
                { "ces", new CountryName(official: "Ázerbájdžánská republika", common: "Ázerbájdžán") },
                { "cym", new CountryName(official: "Gweriniaeth Aserbaijan", common: "Aserbaijan") },
                { "deu", new CountryName(official: "Republik Aserbaidschan", common: "Aserbaidschan") },
                { "est", new CountryName(official: "Aserbaidžaani Vabariik", common: "Aserbaidžaan") },
                { "fin", new CountryName(official: "Azerbaidzanin tasavalta", common: "Azerbaidzan") },
                { "fra", new CountryName(official: "République d'Azerbaïdjan", common: "Azerbaïdjan") },
                { "hrv", new CountryName(official: "Republika Azerbajdžan", common: "Azerbajdžan") },
                { "hun", new CountryName(official: "Azerbajdzsán", common: "Azerbajdzsán") },
                { "ita", new CountryName(official: "Repubblica dell'Azerbaigian", common: "Azerbaijan") },
                { "jpn", new CountryName(official: "アゼルバイジャン共和国", common: "アゼルバイジャン") },
                { "kor", new CountryName(official: "아제르바이잔 공화국", common: "아제르바이잔") },
                { "nld", new CountryName(official: "Republiek Azerbeidzjan", common: "Azerbeidzjan") },
                { "per", new CountryName(official: "جمهوری آذربایجان", common: "جمهوری آذربایجان") },
                { "pol", new CountryName(official: "Republika Azerbejdżanu", common: "Azerbejdżan") },
                { "por", new CountryName(official: "República do Azerbaijão", common: "Azerbeijão") },
                { "slk", new CountryName(official: "Azerbajǆanská republika", common: "AzerbajǇan") },
                { "spa", new CountryName(official: "República de Azerbaiyán", common: "Azerbaiyán") },
                { "swe", new CountryName(official: "Republiken Azerbajdzjan", common: "Azerbajdzjan") },
                { "urd", new CountryName(official: "جمہوریہ آذربائیجان", common: "آذربائیجان") },
                { "zho", new CountryName(official: "阿塞拜疆共和国", common: "阿塞拜疆") },

            },
            cca2: "AZ",
            cca3: "AZE",
            ccn3: "031",
            cioc: "AZE",
            flag: "🇦🇿",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"94", }),
            borders: new string[] { "ARM", "GEO", "IRN", "RUS", "TUR",  },
            capital: new string[] { "Baku",  },
            altSpellings: new string[] { "AZ", "Republic of Azerbaijan", "Azərbaycan Respublikası",  },
            tld: new string[] { ".az",  },
            latlng: new double[] { 40.5, 47.5,  },
            timezones: new string[] { "UTC+04:00",  },
            languages: new Language[]
            {
                new Language(name: "Azerbaijani", iso6391: "az", iso6392: "aze"),
                new Language(name: "Russian", iso6391: "ru", iso6392: "rus"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "AZN", name: "Azerbaijani manat", symbol: "₼"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Azerbaijani", female: "Azerbaijani") },
                { "fra", new DemonymsGender(male: "Azerbaijani", female: "Azerbaijani") },
            }
        );

        /// <summary>
        /// create an instance of Azerbaijan country
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
        private Azerbaijan(
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
