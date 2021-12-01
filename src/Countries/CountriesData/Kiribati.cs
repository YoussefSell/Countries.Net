namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Kiribati country
    /// </summary>
    public class Kiribati : Country
    {
        /// <summary>
        /// get the Kiribati country instance
        /// </summary>
        public static Kiribati Instance = new Kiribati(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Independent and Sovereign Republic of Kiribati", common: "Kiribati") },
                { "gil", new CountryName(official: "Ribaberiki Kiribati", common: "Kiribati") },
                { "ara", new CountryName(official: "جمهورية كيريباتي", common: "كيريباتي") },
                { "ces", new CountryName(official: "Republika Kiribati", common: "Kiribati") },
                { "cym", new CountryName(official: "Independent and Sovereign Republic of Kiribati", common: "Kiribati") },
                { "deu", new CountryName(official: "Republik Kiribati", common: "Kiribati") },
                { "est", new CountryName(official: "Kiribati Vabariik", common: "Kiribati") },
                { "fin", new CountryName(official: "Kiribatin tasavalta", common: "Kiribati") },
                { "fra", new CountryName(official: "République de Kiribati", common: "Kiribati") },
                { "hrv", new CountryName(official: "Samostalne i suverene Republike Kiribati", common: "Kiribati") },
                { "hun", new CountryName(official: "Kiribati Köztársaság", common: "Kiribati") },
                { "ita", new CountryName(official: "Repubblica indipendente e sovrano di Kiribati", common: "Kiribati") },
                { "jpn", new CountryName(official: "キリバスの独立と主権共和国", common: "キリバス") },
                { "kor", new CountryName(official: "키리바시 공화국", common: "키리바시") },
                { "nld", new CountryName(official: "Onafhankelijke en soevereine republiek Kiribati", common: "Kiribati") },
                { "per", new CountryName(official: "جمهوری کیریباتی", common: "کیریباتی") },
                { "pol", new CountryName(official: "Republika Kiribati", common: "Kiribati") },
                { "por", new CountryName(official: "Independente e soberano República de Kiribati", common: "Kiribati") },
                { "rus", new CountryName(official: "Независимой и суверенной Республики Кирибати", common: "Кирибати") },
                { "slk", new CountryName(official: "Kiribatská republika", common: "Kiribati") },
                { "spa", new CountryName(official: "República Independiente y Soberano de Kiribati", common: "Kiribati") },
                { "swe", new CountryName(official: "Republiken Kiribati", common: "Kiribati") },
                { "urd", new CountryName(official: "سلطنت آزاد جمہوریہ کیریباتی", common: "کیریباتی") },
                { "zho", new CountryName(official: "基里巴斯共和国", common: "基里巴斯") },
            },
            cca2: "KI",
            cca3: "KIR",
            ccn3: "296",
            cioc: "KIR",
            flag: "🇰🇮",
            region: Region.Oceania,
            subregion: "Micronesia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"86", }),
            borders: new string[] {  },
            capital: new string[] { "South Tarawa",  },
            altSpellings: new string[] { "KI", "Republic of Kiribati", "Ribaberiki Kiribati",  },
            tld: new string[] { ".ki",  },
            latlng: new double[] { 1.41666666, 173,  },
            timezones: new string[] { "UTC+12:00", "UTC+13:00", "UTC+14:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Gilbertese", iso6391: "", iso6392: "gil"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "AUD", name: "Australian dollar", symbol: "$"),
                new Currency(code: "KID", name: "Kiribati dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "I-Kiribati", female: "I-Kiribati") },
                { "fra", new DemonymsGender(male: "I-Kiribati", female: "I-Kiribati") },
            }
        );

        /// <summary>
        /// create an instance of Kiribati country
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
        private Kiribati(
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
