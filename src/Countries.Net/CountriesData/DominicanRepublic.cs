namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of DominicanRepublic country
    /// </summary>
    public class DominicanRepublic : Country
    {
        /// <summary>
        /// get the DominicanRepublic country instance
        /// </summary>
        public static DominicanRepublic Instance = new DominicanRepublic(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Dominican Republic", common: "Dominican Republic") },
                { "spa", new CountryName(official: "República Dominicana", common: "República Dominicana") },
                { "ara", new CountryName(official: "جمهورية الدومينيكان", common: "جمهورية الدومينيكان") },
                { "ces", new CountryName(official: "Dominikánská republika", common: "Dominikánská republika") },
                { "cym", new CountryName(official: "Gweriniaeth Dominica", common: "Gweriniaeth Dominica") },
                { "deu", new CountryName(official: "Dominikanische Republik", common: "Dominikanische Republik") },
                { "est", new CountryName(official: "Dominikaani Vabariik", common: "Dominikaani Vabariik") },
                { "fin", new CountryName(official: "Dominikaaninen tasavalta", common: "Dominikaaninen tasavalta") },
                { "fra", new CountryName(official: "République Dominicaine", common: "République dominicaine") },
                { "hrv", new CountryName(official: "Dominikanska Republika", common: "Dominikanska Republika") },
                { "hun", new CountryName(official: "Dominikai Köztársaság", common: "Dominikai Köztársaság") },
                { "ita", new CountryName(official: "Repubblica Dominicana", common: "Repubblica Dominicana") },
                { "jpn", new CountryName(official: "ドミニカ共和国", common: "ドミニカ共和国") },
                { "kor", new CountryName(official: "도미니카 공화국", common: "도미니카 공화국") },
                { "nld", new CountryName(official: "Dominicaanse Republiek", common: "Dominicaanse Republiek") },
                { "per", new CountryName(official: "جمهوری دومینیکن", common: "جمهوری دومینیکن") },
                { "pol", new CountryName(official: "Republika Dominikańska", common: "Dominikana") },
                { "por", new CountryName(official: "República Dominicana", common: "República Dominicana") },
                { "rus", new CountryName(official: "Доминиканская Республика", common: "Доминиканская Республика") },
                { "slk", new CountryName(official: "Dominikánska republika", common: "Dominikánska republika") },
                { "swe", new CountryName(official: "Dominikanska republiken", common: "Dominikanska republiken") },
                { "urd", new CountryName(official: "جمہوریہ ڈومینیکن", common: "ڈومینیکن") },
                { "zho", new CountryName(official: "多明尼加共和国", common: "多明尼加") },

            },
            cca2: "DO",
            cca3: "DOM",
            ccn3: "214",
            cioc: "DOM",
            flag: "🇩🇴",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"809", "829", "849", }),
            borders: new string[] { "HTI",  },
            capital: new string[] { "Santo Domingo",  },
            altSpellings: new string[] { "DO",  },
            tld: new string[] { ".do",  },
            latlng: new double[] { 19, -70.66666666,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "DOP", name: "Dominican peso", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Dominican", female: "Dominican") },
                { "fra", new DemonymsGender(male: "Dominican", female: "Dominican") },
            }
        );

        /// <summary>
        /// create an instance of DominicanRepublic country
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
        private DominicanRepublic(
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
