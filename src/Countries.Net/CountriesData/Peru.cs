namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Peru country
    /// </summary>
    public class Peru : Country
    {
        /// <summary>
        /// get the Peru country instance
        /// </summary>
        public static Peru Instance = new Peru(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Peru", common: "Peru") },
                { "aym", new CountryName(official: "Piruw Suyu", common: "Piruw") },
                { "que", new CountryName(official: "Piruw Ripuwlika", common: "Piruw") },
                { "spa", new CountryName(official: "República del Perú", common: "Perú") },
                { "ara", new CountryName(official: "جمهورية بيرو", common: "بيرو") },
                { "ces", new CountryName(official: "Peruánská republika", common: "Peru") },
                { "cym", new CountryName(official: "Republic of Peru", common: "Peru") },
                { "deu", new CountryName(official: "Republik Peru", common: "Peru") },
                { "est", new CountryName(official: "Peruu Vabariik", common: "Peruu") },
                { "fin", new CountryName(official: "Perun tasavalta", common: "Peru") },
                { "fra", new CountryName(official: "République du Pérou", common: "Pérou") },
                { "hrv", new CountryName(official: "Republika Peru", common: "Peru") },
                { "hun", new CountryName(official: "Perui Köztársaság", common: "Peru") },
                { "ita", new CountryName(official: "Repubblica del Perù", common: "Perù") },
                { "jpn", new CountryName(official: "ペルー共和国", common: "ペルー") },
                { "kor", new CountryName(official: "페루 공화국", common: "페루") },
                { "nld", new CountryName(official: "Republiek Peru", common: "Peru") },
                { "per", new CountryName(official: "جمهوری پرو", common: "پرو") },
                { "pol", new CountryName(official: "Republika Peru", common: "Peru") },
                { "por", new CountryName(official: "República do Peru", common: "Perú") },
                { "rus", new CountryName(official: "Республика Перу", common: "Перу") },
                { "slk", new CountryName(official: "Peruánska republika", common: "Peru") },
                { "swe", new CountryName(official: "Republiken Peru", common: "Peru") },
                { "urd", new CountryName(official: "جمہوریہ پیرو", common: "پیرو") },
                { "zho", new CountryName(official: "秘鲁共和国", common: "秘鲁") },

            },
            cca2: "PE",
            cca3: "PER",
            ccn3: "604",
            cioc: "PER",
            flag: "🇵🇪",
            region: Region.Americas,
            subregion: "South America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"1", }),
            borders: new string[] { "BOL", "BRA", "CHL", "COL", "ECU",  },
            capital: new string[] { "Lima",  },
            altSpellings: new string[] { "PE", "Republic of Peru", "República del Perú",  },
            tld: new string[] { ".pe",  },
            latlng: new double[] { -10, -76,  },
            timezones: new string[] { "UTC-05:00",  },
            languages: new Language[]
            {
                new Language(name: "Aymara", iso6391: "", iso6392: "aym"),
                new Language(name: "Quechua", iso6391: "quz", iso6392: "que"),
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "PEN", name: "Peruvian sol", symbol: "S/ "),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Peruvian", female: "Peruvian") },
                { "fra", new DemonymsGender(male: "Peruvian", female: "Peruvian") },
            }
        );

        /// <summary>
        /// create an instance of Peru country
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
        private Peru(
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
