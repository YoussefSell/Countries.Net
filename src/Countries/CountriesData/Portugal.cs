namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Portugal country
    /// </summary>
    public class Portugal : Country
    {
        /// <summary>
        /// get the Portugal country instance
        /// </summary>
        public static Portugal Instance = new Portugal(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Portuguese Republic", common: "Portugal") },
                { "por", new CountryName(official: "República português", common: "Portugal") },
                { "ara", new CountryName(official: "الجمهورية البرتغالية", common: "البرتغال") },
                { "ces", new CountryName(official: "Portugalská republika", common: "Portugalsko") },
                { "cym", new CountryName(official: "Portuguese Republic", common: "Portugal") },
                { "deu", new CountryName(official: "Portugiesische Republik", common: "Portugal") },
                { "est", new CountryName(official: "Portugali Vabariik", common: "Portugal") },
                { "fin", new CountryName(official: "Portugalin tasavalta", common: "Portugali") },
                { "fra", new CountryName(official: "République portugaise", common: "Portugal") },
                { "hrv", new CountryName(official: "Portugalska Republika", common: "Portugal") },
                { "hun", new CountryName(official: "Portugál Köztársaság", common: "Portugália") },
                { "ita", new CountryName(official: "Repubblica portoghese", common: "Portogallo") },
                { "jpn", new CountryName(official: "ポルトガル共和国", common: "ポルトガル") },
                { "kor", new CountryName(official: "포르투갈 공화국", common: "포르투갈") },
                { "nld", new CountryName(official: "Portugese Republiek", common: "Portugal") },
                { "per", new CountryName(official: "جمهوری پرتغال", common: "پرتغال") },
                { "pol", new CountryName(official: "Republika Portugalska", common: "Portugalia") },
                { "rus", new CountryName(official: "Португальская Республика", common: "Португалия") },
                { "slk", new CountryName(official: "Portugalská republika", common: "Portugalsko") },
                { "spa", new CountryName(official: "República Portuguesa", common: "Portugal") },
                { "swe", new CountryName(official: "Republiken Portugal", common: "Portugal") },
                { "urd", new CountryName(official: "جمہوریہ پرتگال", common: "پرتگال") },
                { "zho", new CountryName(official: "葡萄牙共和国", common: "葡萄牙") },

            },
            cca2: "PT",
            cca3: "PRT",
            ccn3: "620",
            cioc: "POR",
            flag: "🇵🇹",
            region: Region.Europe,
            subregion: "Southern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"51", }),
            borders: new string[] { "ESP",  },
            capital: new string[] { "Lisbon",  },
            altSpellings: new string[] { "PT", "Portuguesa", "Portuguese Republic", "República Portuguesa",  },
            tld: new string[] { ".pt",  },
            latlng: new double[] { 39.5, -8,  },
            timezones: new string[] { "UTC-01:00", "UTC",  },
            languages: new Language[]
            {
                new Language(name: "Portuguese", iso6391: "pt", iso6392: "por"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Portuguese", female: "Portuguese") },
                { "fra", new DemonymsGender(male: "Portuguese", female: "Portuguese") },
            }
        );

        /// <summary>
        /// create an instance of Portugal country
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
        private Portugal(
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
