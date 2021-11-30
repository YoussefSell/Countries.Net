namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Argentina country
    /// </summary>
    public class Argentina : Country
    {
        /// <summary>
        /// get the Argentina country instance
        /// </summary>
        public static Argentina Instance = new Argentina(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Argentine Republic", common: "Argentina") },
                { "grn", new CountryName(official: "Argentine Republic", common: "Argentina") },
                { "spa", new CountryName(official: "República Argentina", common: "Argentina") },
                { "ara", new CountryName(official: "جمهورية الأرجنتين", common: "الأرجنتين") },
                { "ces", new CountryName(official: "Argentinská republika", common: "Argentina") },
                { "cym", new CountryName(official: "Gweriniaeth yr Ariannin", common: "Ariannin") },
                { "deu", new CountryName(official: "Argentinische Republik", common: "Argentinien") },
                { "est", new CountryName(official: "Argentina Vabariik", common: "Argentina") },
                { "fin", new CountryName(official: "Argentiinan tasavalta", common: "Argentiina") },
                { "fra", new CountryName(official: "République argentine", common: "Argentine") },
                { "hrv", new CountryName(official: "Argentinski Republika", common: "Argentina") },
                { "hun", new CountryName(official: "Argentin Köztársaság", common: "Argentína") },
                { "ita", new CountryName(official: "Repubblica Argentina", common: "Argentina") },
                { "jpn", new CountryName(official: "アルゼンチン共和国", common: "アルゼンチン") },
                { "kor", new CountryName(official: "아르헨티나 공화국", common: "아르헨티나") },
                { "nld", new CountryName(official: "Argentijnse Republiek", common: "Argentinië") },
                { "per", new CountryName(official: "جمهوری آرژانتین", common: "آرژانتین") },
                { "pol", new CountryName(official: "Republika Argentyńska", common: "Argentyna") },
                { "por", new CountryName(official: "República Argentina", common: "Argentina") },
                { "rus", new CountryName(official: "Аргентинская Республика", common: "Аргентина") },
                { "slk", new CountryName(official: "Argentínska republika", common: "Argentína") },
                { "swe", new CountryName(official: "Republiken Argentina", common: "Argentina") },
                { "urd", new CountryName(official: "جمہوریہ ارجنٹائن", common: "ارجنٹائن") },
                { "zho", new CountryName(official: "阿根廷共和国", common: "阿根廷") },

            },
            cca2: "AR",
            cca3: "ARG",
            ccn3: "032",
            cioc: "ARG",
            flag: "🇦🇷",
            region: Region.Americas,
            subregion: "South America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"4", }),
            borders: new string[] { "BOL", "BRA", "CHL", "PRY", "URY",  },
            capital: new string[] { "Buenos Aires",  },
            altSpellings: new string[] { "AR", "Argentine Republic", "República Argentina",  },
            tld: new string[] { ".ar",  },
            latlng: new double[] { -34, -64,  },
            timezones: new string[] { "UTC-03:00",  },
            languages: new Language[]
            {
                new Language(name: "Guaraní", iso6391: "gn", iso6392: "grn"),
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "ARS", name: "Argentine peso", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Argentine", female: "Argentine") },
                { "fra", new DemonymsGender(male: "Argentine", female: "Argentine") },
            }
        );

        /// <summary>
        /// create an instance of Argentina country
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
        private Argentina(
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
