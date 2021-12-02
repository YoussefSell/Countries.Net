namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Cuba country
    /// </summary>
    public class Cuba : Country
    {
        /// <summary>
        /// get the Cuba country instance
        /// </summary>
        public static Cuba Instance = new Cuba(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Cuba", common: "Cuba") },
                { "spa", new CountryName(official: "República de Cuba", common: "Cuba") },
                { "ara", new CountryName(official: "جمهورية كوبا", common: "كوبا") },
                { "ces", new CountryName(official: "Kubánská republika", common: "Kuba") },
                { "cym", new CountryName(official: "Gweriniaeth Ciwba", common: "Ciwba") },
                { "deu", new CountryName(official: "Republik Kuba", common: "Kuba") },
                { "est", new CountryName(official: "Kuuba Vabariik", common: "Kuuba") },
                { "fin", new CountryName(official: "Kuuban tasavalta", common: "Kuuba") },
                { "fra", new CountryName(official: "République de Cuba", common: "Cuba") },
                { "hrv", new CountryName(official: "Republika Kuba", common: "Kuba") },
                { "hun", new CountryName(official: "Kubai Köztársaság", common: "Kuba") },
                { "ita", new CountryName(official: "Repubblica di Cuba", common: "Cuba") },
                { "jpn", new CountryName(official: "キューバ共和国", common: "キューバ") },
                { "kor", new CountryName(official: "쿠바 공화국", common: "쿠바") },
                { "nld", new CountryName(official: "Republiek Cuba", common: "Cuba") },
                { "per", new CountryName(official: "جمهوری کوبا", common: "کوبا") },
                { "pol", new CountryName(official: "Republika Kuby", common: "Kuba") },
                { "por", new CountryName(official: "República de Cuba", common: "Cuba") },
                { "rus", new CountryName(official: "Республика Куба", common: "Куба") },
                { "slk", new CountryName(official: "Kubánska republika", common: "Kuba") },
                { "swe", new CountryName(official: "Republiken Kuba", common: "Kuba") },
                { "urd", new CountryName(official: "جمہوریہ کیوبا", common: "کیوبا") },
                { "zho", new CountryName(official: "古巴共和国", common: "古巴") },

            },
            cca2: "CU",
            cca3: "CUB",
            ccn3: "192",
            cioc: "CUB",
            flag: "🇨🇺",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"3", }),
            borders: new string[] {  },
            capital: new string[] { "Havana",  },
            altSpellings: new string[] { "CU", "Republic of Cuba", "República de Cuba",  },
            tld: new string[] { ".cu",  },
            latlng: new double[] { 21.5, -80,  },
            timezones: new string[] { "UTC-05:00",  },
            languages: new Language[]
            {
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "CUC", name: "Cuban convertible peso", symbol: "$"),
                new Currency(code: "CUP", name: "Cuban peso", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Cuban", female: "Cuban") },
                { "fra", new DemonymsGender(male: "Cuban", female: "Cuban") },
            }
        );

        /// <summary>
        /// create an instance of Cuba country
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
        private Cuba(
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
