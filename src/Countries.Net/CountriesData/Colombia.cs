namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Colombia country
    /// </summary>
    public class Colombia : Country
    {
        /// <summary>
        /// get the Colombia country instance
        /// </summary>
        public static Colombia Instance = new Colombia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Colombia", common: "Colombia") },
                { "spa", new CountryName(official: "República de Colombia", common: "Colombia") },
                { "ara", new CountryName(official: "جمهورية كولومبيا", common: "كولومبيا") },
                { "ces", new CountryName(official: "Kolumbijská republika", common: "Kolumbie") },
                { "cym", new CountryName(official: "Gweriniaeth Colombia", common: "Colombia") },
                { "deu", new CountryName(official: "Republik Kolumbien", common: "Kolumbien") },
                { "est", new CountryName(official: "Colombia Vabariik", common: "Colombia") },
                { "fin", new CountryName(official: "Kolumbian tasavalta", common: "Kolumbia") },
                { "fra", new CountryName(official: "République de Colombie", common: "Colombie") },
                { "hrv", new CountryName(official: "Republika Kolumbija", common: "Kolumbija") },
                { "hun", new CountryName(official: "Kolumbiai Köztársaság", common: "Kolumbia") },
                { "ita", new CountryName(official: "Repubblica di Colombia", common: "Colombia") },
                { "jpn", new CountryName(official: "コロンビア共和国", common: "コロンビア") },
                { "kor", new CountryName(official: "콜롬비아 공화국", common: "콜롬비아") },
                { "nld", new CountryName(official: "Republiek Colombia", common: "Colombia") },
                { "per", new CountryName(official: "جمهوری کلمبیا", common: "کلمبیا") },
                { "pol", new CountryName(official: "Republika Kolumbii", common: "Kolumbia") },
                { "por", new CountryName(official: "República da Colômbia", common: "Colômbia") },
                { "rus", new CountryName(official: "Республика Колумбия", common: "Колумбия") },
                { "slk", new CountryName(official: "Kolumbijská republika", common: "Kolumbia") },
                { "swe", new CountryName(official: "Republiken Colombia", common: "Colombia") },
                { "urd", new CountryName(official: "جمہوریہ کولمبیا", common: "کولمبیا") },
                { "zho", new CountryName(official: "哥伦比亚共和国", common: "哥伦比亚") },

            },
            cca2: "CO",
            cca3: "COL",
            ccn3: "170",
            cioc: "COL",
            flag: "🇨🇴",
            region: Region.Americas,
            subregion: "South America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"7", }),
            borders: new string[] { "BRA", "ECU", "PAN", "PER", "VEN",  },
            capital: new string[] { "Bogotá",  },
            altSpellings: new string[] { "CO", "Republic of Colombia", "República de Colombia",  },
            tld: new string[] { ".co",  },
            latlng: new double[] { 4, -72,  },
            timezones: new string[] { "UTC-05:00",  },
            languages: new Language[]
            {
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "COP", name: "Colombian peso", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Colombian", female: "Colombian") },
                { "fra", new DemonymsGender(male: "Colombian", female: "Colombian") },
            }
        );

        /// <summary>
        /// create an instance of Colombia country
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
        private Colombia(
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
