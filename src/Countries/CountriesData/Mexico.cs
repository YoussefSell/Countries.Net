namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Mexico country
    /// </summary>
    public class Mexico : Country
    {
        /// <summary>
        /// get the Mexico country instance
        /// </summary>
        public static Mexico Instance = new Mexico(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "United Mexican States", common: "Mexico") },
                { "spa", new CountryName(official: "Estados Unidos Mexicanos", common: "México") },
                { "ara", new CountryName(official: "الولايات المتحدة المكسيكية", common: "المسكيك") },
                { "ces", new CountryName(official: "Spojené státy mexické", common: "Mexiko") },
                { "cym", new CountryName(official: "United Mexican States", common: "Mexico") },
                { "deu", new CountryName(official: "Vereinigte Mexikanische Staaten", common: "Mexiko") },
                { "est", new CountryName(official: "Mehhiko Ühendriigid", common: "Mehhiko") },
                { "fin", new CountryName(official: "Meksikon yhdysvallat", common: "Meksiko") },
                { "fra", new CountryName(official: "États-Unis du Mexique", common: "Mexique") },
                { "hrv", new CountryName(official: "Sjedinjene Meksičke Države", common: "Meksiko") },
                { "hun", new CountryName(official: "Mexikói Egyesült Államok", common: "Mexikó") },
                { "ita", new CountryName(official: "Stati Uniti del Messico", common: "Messico") },
                { "jpn", new CountryName(official: "メキシコ合衆国", common: "メキシコ") },
                { "kor", new CountryName(official: "멕시코 합중국", common: "멕시코") },
                { "nld", new CountryName(official: "Verenigde Mexicaanse Staten", common: "Mexico") },
                { "per", new CountryName(official: "ایالات متحد مکزیک", common: "مکزیک") },
                { "pol", new CountryName(official: "Meksykańskie Stany Zjednoczone", common: "Meksyk") },
                { "por", new CountryName(official: "Estados Unidos Mexicanos", common: "México") },
                { "rus", new CountryName(official: "Мексиканские Соединённые Штаты", common: "Мексика") },
                { "slk", new CountryName(official: "Spojené štášy mexické", common: "Mexiko") },
                { "swe", new CountryName(official: "Mexikos förenta stater", common: "Mexiko") },
                { "urd", new CountryName(official: "ریاستہائے متحدہ میکسیکو", common: "میکسیکو") },
                { "zho", new CountryName(official: "墨西哥合众国", common: "墨西哥") },

            },
            cca2: "MX",
            cca3: "MEX",
            ccn3: "484",
            cioc: "MEX",
            flag: "🇲🇽",
            region: Region.Americas,
            subregion: "North America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"2", }),
            borders: new string[] { "BLZ", "GTM", "USA",  },
            capital: new string[] { "Mexico City",  },
            altSpellings: new string[] { "MX", "Mexicanos", "United Mexican States", "Estados Unidos Mexicanos",  },
            tld: new string[] { ".mx",  },
            latlng: new double[] { 23, -102,  },
            timezones: new string[] { "UTC-08:00", "UTC-07:00", "UTC-06:00",  },
            languages: new Language[]
            {
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "MXN", name: "Mexican peso", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Mexican", female: "Mexican") },
                { "fra", new DemonymsGender(male: "Mexican", female: "Mexican") },
            }
        );

        /// <summary>
        /// create an instance of Mexico country
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
        private Mexico(
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
