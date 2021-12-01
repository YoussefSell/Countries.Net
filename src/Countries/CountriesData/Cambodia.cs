namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Cambodia country
    /// </summary>
    public class Cambodia : Country
    {
        /// <summary>
        /// get the Cambodia country instance
        /// </summary>
        public static Cambodia Instance = new Cambodia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Kingdom of Cambodia", common: "Cambodia") },
                { "khm", new CountryName(official: "ព្រះរាជាណាចក្រកម្ពុជា", common: "Kâmpŭchéa") },
                { "ara", new CountryName(official: "مملكة كمبوديا", common: "كمبوديا") },
                { "ces", new CountryName(official: "Kambodžské království", common: "Kambodža") },
                { "cym", new CountryName(official: "Teyrnas Cambodia", common: "Cambodia") },
                { "deu", new CountryName(official: "Königreich Kambodscha", common: "Kambodscha") },
                { "est", new CountryName(official: "Kambodža Kuningriik", common: "Kambodža") },
                { "fin", new CountryName(official: "Kambodžan kuningaskunta", common: "Kambodža") },
                { "fra", new CountryName(official: "Royaume du Cambodge", common: "Cambodge") },
                { "hrv", new CountryName(official: "Kraljevina Kambodža", common: "Kambodža") },
                { "hun", new CountryName(official: "Kambodzsai Királyság", common: "Kambodzsa") },
                { "ita", new CountryName(official: "Regno di Cambogia", common: "Cambogia") },
                { "jpn", new CountryName(official: "カンボジア王国", common: "カンボジア") },
                { "kor", new CountryName(official: "캄보디아 왕국", common: "캄보디아") },
                { "nld", new CountryName(official: "Koninkrijk Cambodja", common: "Cambodja") },
                { "per", new CountryName(official: "پادشاهی کامبوج", common: "کامبوج") },
                { "pol", new CountryName(official: "Królestwo Kambodży", common: "Kambodża") },
                { "por", new CountryName(official: "Reino do Camboja", common: "Camboja") },
                { "rus", new CountryName(official: "Королевство Камбоджа", common: "Камбоджа") },
                { "slk", new CountryName(official: "Kamboǆské kráľovstvo", common: "Kamboǆa") },
                { "spa", new CountryName(official: "Reino de Camboya", common: "Camboya") },
                { "swe", new CountryName(official: "Konungariket Kambodja", common: "Kambodja") },
                { "urd", new CountryName(official: "مملکتِ کمبوڈیا", common: "کمبوڈیا") },
                { "zho", new CountryName(official: "柬埔寨王国", common: "柬埔寨") },
            },
            cca2: "KH",
            cca3: "KHM",
            ccn3: "116",
            cioc: "CAM",
            flag: "🇰🇭",
            region: Region.Asia,
            subregion: "South-Eastern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+8", suffixes: new string[] {"55", }),
            borders: new string[] { "LAO", "THA", "VNM",  },
            capital: new string[] { "Phnom Penh",  },
            altSpellings: new string[] { "KH", "Kingdom of Cambodia",  },
            tld: new string[] { ".kh",  },
            latlng: new double[] { 13, 105,  },
            timezones: new string[] { "UTC+07:00",  },
            languages: new Language[]
            {
                new Language(name: "Khmer", iso6391: "km", iso6392: "khm"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "KHR", name: "Cambodian riel", symbol: "៛"),
                new Currency(code: "USD", name: "United States dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Cambodian", female: "Cambodian") },
                { "fra", new DemonymsGender(male: "Cambodian", female: "Cambodian") },
            }
        );

        /// <summary>
        /// create an instance of Cambodia country
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
        private Cambodia(
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
