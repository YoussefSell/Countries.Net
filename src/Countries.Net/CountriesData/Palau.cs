namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Palau country
    /// </summary>
    public class Palau : Country
    {
        /// <summary>
        /// get the Palau country instance
        /// </summary>
        public static Palau Instance = new Palau(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Palau", common: "Palau") },
                { "pau", new CountryName(official: "Beluu er a Belau", common: "Belau") },
                { "ara", new CountryName(official: "جمهورية بالاو", common: "بالاو") },
                { "ces", new CountryName(official: "Republika Palau", common: "Palau") },
                { "cym", new CountryName(official: "Republic of Palau", common: "Palau") },
                { "deu", new CountryName(official: "Republik Palau", common: "Palau") },
                { "est", new CountryName(official: "Belau Vabariik", common: "Belau") },
                { "fin", new CountryName(official: "Palaun tasavalta", common: "Palau") },
                { "fra", new CountryName(official: "République des Palaos (Palau)", common: "Palaos (Palau)") },
                { "hrv", new CountryName(official: "Republika Palau", common: "Palau") },
                { "hun", new CountryName(official: "Palaui Köztársaság", common: "Palau") },
                { "ita", new CountryName(official: "Repubblica di Palau", common: "Palau") },
                { "jpn", new CountryName(official: "パラオ共和国", common: "パラオ") },
                { "kor", new CountryName(official: "팔라우 공화국", common: "팔라우") },
                { "nld", new CountryName(official: "Republiek van Palau", common: "Palau") },
                { "per", new CountryName(official: "جمهوری پالائو", common: "پالائو") },
                { "pol", new CountryName(official: "Republika Palau", common: "Palau") },
                { "por", new CountryName(official: "República de Palau", common: "Palau") },
                { "rus", new CountryName(official: "Республика Палау", common: "Палау") },
                { "slk", new CountryName(official: "Palauská republika", common: "Palau") },
                { "spa", new CountryName(official: "República de Palau", common: "Palau") },
                { "swe", new CountryName(official: "Republiken Palau", common: "Palau") },
                { "urd", new CountryName(official: "جمہوریہ پلاؤ", common: "پلاؤ") },
                { "zho", new CountryName(official: "帕劳共和国", common: "帕劳") },
            },
            cca2: "PW",
            cca3: "PLW",
            ccn3: "585",
            cioc: "PLW",
            flag: "🇵🇼",
            region: Region.Oceania,
            subregion: "Micronesia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"80", }),
            borders: new string[] {  },
            capital: new string[] { "Ngerulmud",  },
            altSpellings: new string[] { "PW", "Republic of Palau", "Beluu er a Belau",  },
            tld: new string[] { ".pw",  },
            latlng: new double[] { 7.5, 134.5,  },
            timezones: new string[] { "UTC+09:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Palauan", iso6391: "", iso6392: "pau"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "USD", name: "United States dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Palauan", female: "Palauan") },
                { "fra", new DemonymsGender(male: "Palauan", female: "Palauan") },
            }
        );

        /// <summary>
        /// create an instance of Palau country
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
        private Palau(
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
