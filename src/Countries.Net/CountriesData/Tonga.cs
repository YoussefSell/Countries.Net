namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Tonga country
    /// </summary>
    public class Tonga : Country
    {
        /// <summary>
        /// get the Tonga country instance
        /// </summary>
        public static Tonga Instance = new Tonga(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Kingdom of Tonga", common: "Tonga") },
                { "ton", new CountryName(official: "Kingdom of Tonga", common: "Tonga") },
                { "ara", new CountryName(official: "مملكة تونغا", common: "تونغا") },
                { "ces", new CountryName(official: "Království Tonga", common: "Tonga") },
                { "cym", new CountryName(official: "Kingdom of Tonga", common: "Tonga") },
                { "deu", new CountryName(official: "Königreich Tonga", common: "Tonga") },
                { "est", new CountryName(official: "Tonga Kuningriik", common: "Tonga") },
                { "fin", new CountryName(official: "Tongan kuningaskunta", common: "Tonga") },
                { "fra", new CountryName(official: "Royaume des Tonga", common: "Tonga") },
                { "hrv", new CountryName(official: "Kraljevina Tonga", common: "Tonga") },
                { "hun", new CountryName(official: "Tongai Királyság", common: "Tonga") },
                { "ita", new CountryName(official: "Regno di Tonga", common: "Tonga") },
                { "jpn", new CountryName(official: "トンガ王国", common: "トンガ") },
                { "kor", new CountryName(official: "통가 왕국", common: "통가") },
                { "nld", new CountryName(official: "Koninkrijk Tonga", common: "Tonga") },
                { "per", new CountryName(official: "پادشاهی تونگا", common: "تونگا") },
                { "pol", new CountryName(official: "Królestwo Tonga", common: "Tonga") },
                { "por", new CountryName(official: "Reino de Tonga", common: "Tonga") },
                { "rus", new CountryName(official: "Королевство Тонга", common: "Тонга") },
                { "slk", new CountryName(official: "Tongské kráľovstvo", common: "Tonga") },
                { "spa", new CountryName(official: "Reino de Tonga", common: "Tonga") },
                { "swe", new CountryName(official: "Konungariket Tonga", common: "Tonga") },
                { "urd", new CountryName(official: "مملکتِ ٹونگا", common: "ٹونگا") },
                { "zho", new CountryName(official: "汤加王国", common: "汤加") },
            },
            cca2: "TO",
            cca3: "TON",
            ccn3: "776",
            cioc: "TGA",
            flag: "🇹🇴",
            region: Region.Oceania,
            subregion: "Polynesia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"76", }),
            borders: new string[] {  },
            capital: new string[] { "Nuku'alofa",  },
            altSpellings: new string[] { "TO",  },
            tld: new string[] { ".to",  },
            latlng: new double[] { -20, -175,  },
            timezones: new string[] { "UTC+13:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Tongan", iso6391: "to", iso6392: "ton"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "TOP", name: "Tongan paʻanga", symbol: "T$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Tongan", female: "Tongan") },
                { "fra", new DemonymsGender(male: "Tongan", female: "Tongan") },
            }
        );

        /// <summary>
        /// create an instance of Tonga country
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
        private Tonga(
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
