namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Niger country
    /// </summary>
    public class Niger : Country
    {
        /// <summary>
        /// get the Niger country instance
        /// </summary>
        public static Niger Instance = new Niger(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Niger", common: "Niger") },
                { "fra", new CountryName(official: "République du Niger", common: "Niger") },
                { "ara", new CountryName(official: "جمهورية النيجر", common: "النيجر") },
                { "ces", new CountryName(official: "Nigerská republika", common: "Niger") },
                { "cym", new CountryName(official: "Republic of Niger", common: "Niger") },
                { "deu", new CountryName(official: "Republik Niger", common: "Niger") },
                { "est", new CountryName(official: "Nigeri Vabariik", common: "Niger") },
                { "fin", new CountryName(official: "Nigerin tasavalta", common: "Niger") },
                { "hrv", new CountryName(official: "Republika Niger", common: "Niger") },
                { "hun", new CountryName(official: "Nigeri Köztársaság", common: "Niger") },
                { "ita", new CountryName(official: "Repubblica del Niger", common: "Niger") },
                { "jpn", new CountryName(official: "ニジェール共和国", common: "ニジェール") },
                { "kor", new CountryName(official: "니제르 공화국", common: "니제르") },
                { "nld", new CountryName(official: "Republiek Niger", common: "Niger") },
                { "per", new CountryName(official: "جمهوری نیجر", common: "نیجر") },
                { "pol", new CountryName(official: "Republika Nigru", common: "Niger") },
                { "por", new CountryName(official: "República do Níger", common: "Níger") },
                { "rus", new CountryName(official: "Республика Нигер", common: "Нигер") },
                { "slk", new CountryName(official: "Nigérská republika", common: "Niger") },
                { "spa", new CountryName(official: "República de Níger", common: "Níger") },
                { "swe", new CountryName(official: "Republiken Niger", common: "Niger") },
                { "urd", new CountryName(official: "جمہوریہ نائجر", common: "نائجر") },
                { "zho", new CountryName(official: "尼日尔共和国", common: "尼日尔") },

            },
            cca2: "NE",
            cca3: "NER",
            ccn3: "562",
            cioc: "NIG",
            flag: "🇳🇪",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"27", }),
            borders: new string[] { "DZA", "BEN", "BFA", "TCD", "LBY", "MLI", "NGA",  },
            capital: new string[] { "Niamey",  },
            altSpellings: new string[] { "NE", "Nijar",  },
            tld: new string[] { ".ne",  },
            latlng: new double[] { 16, 8,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XOF", name: "West African CFA franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Nigerien", female: "Nigerien") },
                { "fra", new DemonymsGender(male: "Nigerien", female: "Nigerien") },
            }
        );

        /// <summary>
        /// create an instance of Niger country
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
        private Niger(
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
