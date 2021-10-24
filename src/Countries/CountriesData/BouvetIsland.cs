namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of BouvetIsland country
    /// </summary>
    public class BouvetIsland : Country
    {
        /// <summary>
        /// get the BouvetIsland country instance
        /// </summary>
        public static BouvetIsland Instance = new BouvetIsland(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Bouvet Island", common: "Bouvet Island") },
                { "nor", new CountryName(official: "Bouvetøya", common: "Bouvetøya") },
                { "ara", new CountryName(official: "جزر بوفيه", common: "جزر بوفيه") },
                { "ces", new CountryName(official: "Bouvetův ostrov", common: "Bouvetův ostrov") },
                { "cym", new CountryName(official: "Bouvet Island", common: "Bouvet Island") },
                { "deu", new CountryName(official: "Bouvetinsel", common: "Bouvetinsel") },
                { "est", new CountryName(official: "Bouvet’ saar", common: "Bouvet’ saar") },
                { "fin", new CountryName(official: "Bouvet'nsaari", common: "Bouvet'nsaari") },
                { "fra", new CountryName(official: "Île Bouvet", common: "Île Bouvet") },
                { "hrv", new CountryName(official: "Bouvet Island", common: "Otok Bouvet") },
                { "hun", new CountryName(official: "Bouvet-sziget", common: "Bouvet-sziget") },
                { "ita", new CountryName(official: "Isola Bouvet", common: "Isola Bouvet") },
                { "jpn", new CountryName(official: "ブーヴェ島", common: "ブーベ島") },
                { "kor", new CountryName(official: "부베 섬", common: "부베 섬") },
                { "nld", new CountryName(official: "Bouvet Island", common: "Bouveteiland") },
                { "per", new CountryName(official: "جزیرهٔ بووه", common: "جزیرهٔ بووه") },
                { "pol", new CountryName(official: "Wyspa Bouveta", common: "Wyspa Bouveta") },
                { "por", new CountryName(official: "Ilha Bouvet", common: "Ilha Bouvet") },
                { "rus", new CountryName(official: "Остров Буве", common: "Остров Буве") },
                { "slk", new CountryName(official: "Bouvetov ostrov", common: "Bouvetov ostrov") },
                { "spa", new CountryName(official: "Isla Bouvet", common: "Isla Bouvet") },
                { "swe", new CountryName(official: "Bouvetön", common: "Bouvetön") },
                { "urd", new CountryName(official: "جزیرہ بووہ", common: "جزیرہ بووہ") },
                { "zho", new CountryName(official: "布维岛", common: "布维岛") },
            },
            cca2: "BV",
            cca3: "BVT",
            ccn3: "074",
            cioc: "",
            flag: "🇧🇻",
            region: Region.Antarctic,
            subregion: "",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"7", }),
            borders: new string[] {  },
            capital: new string[] {  },
            altSpellings: new string[] { "BV", "Bouvetøya", "Bouvet-øya",  },
            tld: new string[] { ".bv",  },
            latlng: new double[] { -54.43333333, 3.4,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Norwegian", iso6391: "", iso6392: "nor"),
            },
            currencies: new Currency[]
            {
                
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                
            }
        );

        /// <summary>
        /// create an instance of BouvetIsland country
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
        private BouvetIsland(
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
