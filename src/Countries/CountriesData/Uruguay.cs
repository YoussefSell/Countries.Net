namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Uruguay country
    /// </summary>
    public class Uruguay : Country
    {
        /// <summary>
        /// get the Uruguay country instance
        /// </summary>
        public static Uruguay Instance = new Uruguay(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Oriental Republic of Uruguay", common: "Uruguay") },
                { "spa", new CountryName(official: "República Oriental del Uruguay", common: "Uruguay") },
                { "ara", new CountryName(official: "جمهورية الأوروغواي الشرقية", common: "الأوروغواي") },
                { "ces", new CountryName(official: "Uruguayská východní republika", common: "Uruguay") },
                { "cym", new CountryName(official: "Oriental Republic of Uruguay", common: "Uruguay") },
                { "deu", new CountryName(official: "Republik Östlich des Uruguay", common: "Uruguay") },
                { "est", new CountryName(official: "Uruguay Idavabariik", common: "Uruguay") },
                { "fin", new CountryName(official: "Uruguayn itäinen tasavalta", common: "Uruguay") },
                { "fra", new CountryName(official: "République orientale de l'Uruguay", common: "Uruguay") },
                { "hrv", new CountryName(official: "Orijentalna Republika Urugvaj", common: "Urugvaj") },
                { "hun", new CountryName(official: "Uruguayi Keleti Köztársaság", common: "Uruguay") },
                { "ita", new CountryName(official: "Repubblica Orientale dell'Uruguay", common: "Uruguay") },
                { "jpn", new CountryName(official: "ウルグアイ東方共和国", common: "ウルグアイ") },
                { "kor", new CountryName(official: "우루과이 동방 공화국", common: "우루과이") },
                { "nld", new CountryName(official: "Oosterse Republiek Uruguay", common: "Uruguay") },
                { "per", new CountryName(official: "جمهوری اروگوئه", common: "اروگوئه") },
                { "pol", new CountryName(official: "Wschodnia Republika Urugwaju", common: "Urugwaj") },
                { "por", new CountryName(official: "República Oriental do Uruguai", common: "Uruguai") },
                { "rus", new CountryName(official: "Восточной Республики Уругвай", common: "Уругвай") },
                { "slk", new CountryName(official: "Uruguajská východná republika", common: "Uruguaj") },
                { "swe", new CountryName(official: "Republiken Uruguay", common: "Uruguay") },
                { "urd", new CountryName(official: "جمہوریہ شرقیہ یوراگوئے", common: "یوراگوئے") },
                { "zho", new CountryName(official: "乌拉圭东岸共和国", common: "乌拉圭") },

            },
            cca2: "UY",
            cca3: "URY",
            ccn3: "858",
            cioc: "URU",
            flag: "🇺🇾",
            region: Region.Americas,
            subregion: "South America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"98", }),
            borders: new string[] { "ARG", "BRA",  },
            capital: new string[] { "Montevideo",  },
            altSpellings: new string[] { "UY", "Oriental Republic of Uruguay", "República Oriental del Uruguay",  },
            tld: new string[] { ".uy",  },
            latlng: new double[] { -33, -56,  },
            timezones: new string[] { "UTC-03:00",  },
            languages: new Language[]
            {
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "UYU", name: "Uruguayan peso", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Uruguayan", female: "Uruguayan") },
                { "fra", new DemonymsGender(male: "Uruguayan", female: "Uruguayan") },
            }
        );

        /// <summary>
        /// create an instance of Uruguay country
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
        private Uruguay(
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
