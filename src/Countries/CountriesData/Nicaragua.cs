namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Nicaragua country
    /// </summary>
    public class Nicaragua : Country
    {
        /// <summary>
        /// get the Nicaragua country instance
        /// </summary>
        public static Nicaragua Instance = new Nicaragua(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Nicaragua", common: "Nicaragua") },
                { "spa", new CountryName(official: "República de Nicaragua", common: "Nicaragua") },
                { "ara", new CountryName(official: "جمهورية نيكاراغوا", common: "نيكاراغوا") },
                { "ces", new CountryName(official: "Republika Nikaragua", common: "Nikaragua") },
                { "cym", new CountryName(official: "Republic of Nicaragua", common: "Nicaragua") },
                { "deu", new CountryName(official: "Republik Nicaragua", common: "Nicaragua") },
                { "est", new CountryName(official: "Nicaragua Vabariik", common: "Nicaragua") },
                { "fin", new CountryName(official: "Nicaraguan tasavalta", common: "Nicaragua") },
                { "fra", new CountryName(official: "République du Nicaragua", common: "Nicaragua") },
                { "hrv", new CountryName(official: "Republika Nikaragva", common: "Nikaragva") },
                { "hun", new CountryName(official: "Nicaraguai Köztársaság", common: "Nicaragua") },
                { "ita", new CountryName(official: "Repubblica del Nicaragua", common: "Nicaragua") },
                { "jpn", new CountryName(official: "ニカラグア共和国", common: "ニカラグア") },
                { "kor", new CountryName(official: "니카라과 공화국", common: "니카라과") },
                { "nld", new CountryName(official: "Republiek Nicaragua", common: "Nicaragua") },
                { "per", new CountryName(official: "جمهوری نیکاراگوئه", common: "نیکاراگوئه") },
                { "pol", new CountryName(official: "Republika Nikaragui", common: "Nikaragua") },
                { "por", new CountryName(official: "República da Nicarágua", common: "Nicarágua") },
                { "rus", new CountryName(official: "Республика Никарагуа", common: "Никарагуа") },
                { "slk", new CountryName(official: "Nikaragujská republika", common: "Nikaragua") },
                { "swe", new CountryName(official: "Republiken Nicaragua", common: "Nicaragua") },
                { "urd", new CountryName(official: "جمہوریہ نکاراگوا", common: "نکاراگوا") },
                { "zho", new CountryName(official: "尼加拉瓜共和国", common: "尼加拉瓜") },

            },
            cca2: "NI",
            cca3: "NIC",
            ccn3: "558",
            cioc: "NCA",
            flag: "🇳🇮",
            region: Region.Americas,
            subregion: "Central America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"05", }),
            borders: new string[] { "CRI", "HND",  },
            capital: new string[] { "Managua",  },
            altSpellings: new string[] { "NI", "Republic of Nicaragua", "República de Nicaragua",  },
            tld: new string[] { ".ni",  },
            latlng: new double[] { 13, -85,  },
            timezones: new string[] { "UTC-06:00",  },
            languages: new Language[]
            {
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "NIO", name: "Nicaraguan córdoba", symbol: "C$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Nicaraguan", female: "Nicaraguan") },
                { "fra", new DemonymsGender(male: "Nicaraguan", female: "Nicaraguan") },
            }
        );

        /// <summary>
        /// create an instance of Nicaragua country
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
        private Nicaragua(
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
