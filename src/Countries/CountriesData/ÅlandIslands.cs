namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of ÅlandIslands country
    /// </summary>
    public class ÅlandIslands : Country
    {
        /// <summary>
        /// get the ÅlandIslands country instance
        /// </summary>
        public static ÅlandIslands Instance = new ÅlandIslands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Åland Islands", common: "Åland Islands") },
                { "swe", new CountryName(official: "Landskapet Åland", common: "Åland") },
                { "ara", new CountryName(official: "جزر أولاند", common: "جزر أولاند") },
                { "ces", new CountryName(official: "Ålandské ostrovy", common: "Ålandy") },
                { "cym", new CountryName(official: "Åland Islands", common: "Åland Islands") },
                { "deu", new CountryName(official: "Åland-Inseln", common: "Åland") },
                { "est", new CountryName(official: "Ahvenamaa maakond", common: "Ahvenamaa") },
                { "fin", new CountryName(official: "Ahvenanmaan maakunta", common: "Ahvenanmaa") },
                { "fra", new CountryName(official: "Ahvenanmaa", common: "Ahvenanmaa") },
                { "hrv", new CountryName(official: "Aland Islands", common: "Ålandski otoci") },
                { "hun", new CountryName(official: "Åland-szigetek", common: "Åland-szigetek") },
                { "ita", new CountryName(official: "Isole Åland", common: "Isole Aland") },
                { "jpn", new CountryName(official: "オーランド諸島", common: "オーランド諸島") },
                { "kor", new CountryName(official: "올란드 제도", common: "올란드 제도") },
                { "nld", new CountryName(official: "Åland eilanden", common: "Ålandeilanden") },
                { "per", new CountryName(official: "جزایر الند", common: "جزایر الند") },
                { "pol", new CountryName(official: "Wyspy Alandzkie", common: "Wyspy Alandzkie") },
                { "por", new CountryName(official: "Ilhas Åland", common: "Alândia") },
                { "rus", new CountryName(official: "Аландские острова", common: "Аландские острова") },
                { "slk", new CountryName(official: "Alandské ostrovy", common: "Alandy") },
                { "spa", new CountryName(official: "Islas Åland", common: "Alandia") },
                { "urd", new CountryName(official: "جزائر اولند", common: "جزائر اولند") },
                { "zho", new CountryName(official: "奥兰群岛", common: "奥兰群岛") },

            },
            cca2: "AX",
            cca3: "ALA",
            ccn3: "248",
            cioc: "",
            flag: "🇦🇽",
            region: Region.Europe,
            subregion: "Northern Europe",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"5818", }),
            borders: new string[] {  },
            capital: new string[] { "Mariehamn",  },
            altSpellings: new string[] { "AX", "Aaland", "Aland", "Ahvenanmaa",  },
            tld: new string[] { ".ax",  },
            latlng: new double[] { 60.116667, 19.9,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Swedish", iso6391: "sv", iso6392: "swe"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Ålandish", female: "Ålandish") },
                { "fra", new DemonymsGender(male: "Ålandish", female: "Ålandish") },
            }
        );

        /// <summary>
        /// create an instance of ÅlandIslands country
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
        private ÅlandIslands(
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
