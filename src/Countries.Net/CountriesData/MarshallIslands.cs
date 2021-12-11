namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of MarshallIslands country
    /// </summary>
    public class MarshallIslands : Country
    {
        /// <summary>
        /// get the MarshallIslands country instance
        /// </summary>
        public static MarshallIslands Instance = new MarshallIslands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of the Marshall Islands", common: "Marshall Islands") },
                { "mah", new CountryName(official: "Republic of the Marshall Islands", common: "M̧ajeļ") },
                { "ara", new CountryName(official: "جمهورية جزر مارشال", common: "جزر مارشال") },
                { "ces", new CountryName(official: "Republika Marshallovy ostrovy", common: "Marshallovy ostrovy") },
                { "cym", new CountryName(official: "Republic of the Marshall Islands", common: "Marshall Islands") },
                { "deu", new CountryName(official: "Republik Marshallinseln", common: "Marshallinseln") },
                { "est", new CountryName(official: "Marshalli Saarte Vabariik", common: "Marshalli Saared") },
                { "fin", new CountryName(official: "Marshallinsaarten tasavalta", common: "Marshallinsaaret") },
                { "fra", new CountryName(official: "République des Îles Marshall", common: "Îles Marshall") },
                { "hrv", new CountryName(official: "Republika Maršalovi Otoci", common: "Maršalovi Otoci") },
                { "hun", new CountryName(official: "Marshall-szigetek", common: "Marshall-szigetek") },
                { "ita", new CountryName(official: "Repubblica delle Isole Marshall", common: "Isole Marshall") },
                { "jpn", new CountryName(official: "マーシャル諸島共和国", common: "マーシャル諸島") },
                { "kor", new CountryName(official: "마셜 제도 공화국", common: "마셜 제도") },
                { "nld", new CountryName(official: "Republiek van de Marshall-eilanden", common: "Marshalleilanden") },
                { "per", new CountryName(official: "جمهوری جزایر مارشال", common: "جزایر مارشال") },
                { "pol", new CountryName(official: "Republika Wysp Marshalla", common: "Wyspy Marshalla") },
                { "por", new CountryName(official: "República das Ilhas Marshall", common: "Ilhas Marshall") },
                { "rus", new CountryName(official: "Республика Маршалловы острова", common: "Маршалловы Острова") },
                { "slk", new CountryName(official: "Republika Marshallových ostrovov", common: "Marshallove ostrovy") },
                { "spa", new CountryName(official: "República de las Islas Marshall", common: "Islas Marshall") },
                { "swe", new CountryName(official: "Republiken Marshallöarna", common: "Marshallöarna") },
                { "urd", new CountryName(official: "جمہوریہ جزائر مارشل", common: "جزائر مارشل") },
                { "zho", new CountryName(official: "马绍尔群岛共和国", common: "马绍尔群岛") },
            },
            cca2: "MH",
            cca3: "MHL",
            ccn3: "584",
            cioc: "MHL",
            flag: "🇲🇭",
            region: Region.Oceania,
            subregion: "Micronesia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"92", }),
            borders: new string[] {  },
            capital: new string[] { "Majuro",  },
            altSpellings: new string[] { "MH", "Republic of the Marshall Islands", "Aolepān Aorōkin M̧ajeļ",  },
            tld: new string[] { ".mh",  },
            latlng: new double[] { 9, 168,  },
            timezones: new string[] { "UTC+12:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Marshallese", iso6391: "", iso6392: "mah"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "USD", name: "United States dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Marshallese", female: "Marshallese") },
                { "fra", new DemonymsGender(male: "Marshallese", female: "Marshallese") },
            }
        );

        /// <summary>
        /// create an instance of MarshallIslands country
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
        private MarshallIslands(
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
