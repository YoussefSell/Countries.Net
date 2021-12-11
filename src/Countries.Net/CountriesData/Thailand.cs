namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Thailand country
    /// </summary>
    public class Thailand : Country
    {
        /// <summary>
        /// get the Thailand country instance
        /// </summary>
        public static Thailand Instance = new Thailand(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Kingdom of Thailand", common: "Thailand") },
                { "tha", new CountryName(official: "ราชอาณาจักรไทย", common: "ประเทศไทย") },
                { "ara", new CountryName(official: "مملكة تايلند", common: "تايلند") },
                { "ces", new CountryName(official: "Thajské království", common: "Thajsko") },
                { "cym", new CountryName(official: "Kingdom of Thailand", common: "Thailand") },
                { "deu", new CountryName(official: "Königreich Thailand", common: "Thailand") },
                { "est", new CountryName(official: "Tai Kuningriik", common: "Tai") },
                { "fin", new CountryName(official: "Thaimaan kuningaskunta", common: "Thaimaa") },
                { "fra", new CountryName(official: "Royaume de Thaïlande", common: "Thaïlande") },
                { "hrv", new CountryName(official: "Kraljevina Tajland", common: "Tajland") },
                { "hun", new CountryName(official: "Thaiföldi Királyság", common: "Thaiföld") },
                { "ita", new CountryName(official: "Regno di Thailandia", common: "Tailandia") },
                { "jpn", new CountryName(official: "タイ王国", common: "タイ") },
                { "kor", new CountryName(official: "타이 왕국", common: "태국") },
                { "nld", new CountryName(official: "Koninkrijk Thailand", common: "Thailand") },
                { "per", new CountryName(official: "پادشاهی تایلند", common: "تایلند") },
                { "pol", new CountryName(official: "Królestwo Tajlandii", common: "Tajlandia") },
                { "por", new CountryName(official: "Reino da Tailândia", common: "Tailândia") },
                { "rus", new CountryName(official: "Королевство Таиланд", common: "Таиланд") },
                { "slk", new CountryName(official: "Thajské kráľovstvo", common: "Thajsko") },
                { "spa", new CountryName(official: "Reino de Tailandia", common: "Tailandia") },
                { "swe", new CountryName(official: "Konungariket Thailand", common: "Thailand") },
                { "urd", new CountryName(official: "مملکتِ تھائی لینڈ", common: "تھائی لینڈ") },
                { "zho", new CountryName(official: "泰王国", common: "泰国") },
            },
            cca2: "TH",
            cca3: "THA",
            ccn3: "764",
            cioc: "THA",
            flag: "🇹🇭",
            region: Region.Asia,
            subregion: "South-Eastern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"6", }),
            borders: new string[] { "MMR", "KHM", "LAO", "MYS",  },
            capital: new string[] { "Bangkok",  },
            altSpellings: new string[] { "TH", "Prathet", "Thai", "Kingdom of Thailand", "ราชอาณาจักรไทย", "Ratcha Anachak Thai",  },
            tld: new string[] { ".th", ".ไทย",  },
            latlng: new double[] { 15, 100,  },
            timezones: new string[] { "UTC+07:00",  },
            languages: new Language[]
            {
                new Language(name: "Thai", iso6391: "th", iso6392: "tha"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "THB", name: "Thai baht", symbol: "฿"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Thai", female: "Thai") },
                { "fra", new DemonymsGender(male: "Thai", female: "Thai") },
            }
        );

        /// <summary>
        /// create an instance of Thailand country
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
        private Thailand(
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
