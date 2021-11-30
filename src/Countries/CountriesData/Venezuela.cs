namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Venezuela country
    /// </summary>
    public class Venezuela : Country
    {
        /// <summary>
        /// get the Venezuela country instance
        /// </summary>
        public static Venezuela Instance = new Venezuela(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Bolivarian Republic of Venezuela", common: "Venezuela") },
                { "spa", new CountryName(official: "República Bolivariana de Venezuela", common: "Venezuela") },
                { "ara", new CountryName(official: "جمهورية فنزويلا البوليفارية", common: "فنزويلا") },
                { "ces", new CountryName(official: "Bolívarská republika Venezuela", common: "Venezuela") },
                { "cym", new CountryName(official: "Bolivarian Republic of Venezuela", common: "Venezuela") },
                { "deu", new CountryName(official: "Bolivarische Republik Venezuela", common: "Venezuela") },
                { "est", new CountryName(official: "Venezuela Bolívari Vabariik", common: "Venezuela") },
                { "fin", new CountryName(official: "Venezuelan bolivariaainen tasavalta", common: "Venezuela") },
                { "fra", new CountryName(official: "République bolivarienne du Venezuela", common: "Venezuela") },
                { "hrv", new CountryName(official: "BOLIVARIJANSKA Republika Venezuela", common: "Venezuela") },
                { "hun", new CountryName(official: "Venezuelai Bolivári Köztársaság", common: "Venezuela") },
                { "ita", new CountryName(official: "Repubblica Bolivariana del Venezuela", common: "Venezuela") },
                { "jpn", new CountryName(official: "ベネズエラ·ボリバル共和国", common: "ベネズエラ・ボリバル共和国") },
                { "kor", new CountryName(official: "베네수엘라 볼리바르 공화국", common: "베네수엘라") },
                { "nld", new CountryName(official: "Bolivariaanse Republiek Venezuela", common: "Venezuela") },
                { "per", new CountryName(official: "جمهوری بولیواری ونزوئلا", common: "ونزوئلا") },
                { "pol", new CountryName(official: "Boliwariańska Republika Wenezueli", common: "Wenezuela") },
                { "por", new CountryName(official: "República Bolivariana da Venezuela", common: "Venezuela") },
                { "rus", new CountryName(official: "Боливарианская Республика Венесуэла", common: "Венесуэла") },
                { "slk", new CountryName(official: "Venezuelská bolívarovská republika", common: "Venezuela") },
                { "swe", new CountryName(official: "Bolivarianska republiken Venezuela", common: "Venezuela") },
                { "urd", new CountryName(official: "جمہوریہ وینیزویلا", common: "وینیزویلا") },
                { "zho", new CountryName(official: "委内瑞拉玻利瓦尔共和国", common: "委内瑞拉") },

            },
            cca2: "VE",
            cca3: "VEN",
            ccn3: "862",
            cioc: "VEN",
            flag: "🇻🇪",
            region: Region.Americas,
            subregion: "South America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"8", }),
            borders: new string[] { "BRA", "COL", "GUY",  },
            capital: new string[] { "Caracas",  },
            altSpellings: new string[] { "VE", "Bolivarian Republic of Venezuela", "Venezuela, Bolivarian Republic of", "República Bolivariana de Venezuela",  },
            tld: new string[] { ".ve",  },
            latlng: new double[] { 8, -66,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "VES", name: "Venezuelan bolívar soberano", symbol: "Bs.S."),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Venezuelan", female: "Venezuelan") },
                { "fra", new DemonymsGender(male: "Venezuelan", female: "Venezuelan") },
            }
        );

        /// <summary>
        /// create an instance of Venezuela country
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
        private Venezuela(
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
