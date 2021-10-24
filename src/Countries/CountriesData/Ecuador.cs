namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Ecuador country
    /// </summary>
    public class Ecuador : Country
    {
        /// <summary>
        /// get the Ecuador country instance
        /// </summary>
        public static Ecuador Instance = new Ecuador(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Ecuador", common: "Ecuador") },
                { "spa", new CountryName(official: "República del Ecuador", common: "Ecuador") },
                { "ara", new CountryName(official: "جمهورية الإكوادور", common: "الإكوادور") },
                { "ces", new CountryName(official: "Ekvádorská republika", common: "Ekvádor") },
                { "cym", new CountryName(official: "Gweriniaeth Ecwador", common: "Ecwador") },
                { "deu", new CountryName(official: "Republik Ecuador", common: "Ecuador") },
                { "est", new CountryName(official: "Ecuadori Vabariik", common: "Ecuador") },
                { "fin", new CountryName(official: "Ecuadorin tasavalta", common: "Ecuador") },
                { "fra", new CountryName(official: "République de l'Équateur", common: "Équateur") },
                { "hrv", new CountryName(official: "Republika Ekvador", common: "Ekvador") },
                { "hun", new CountryName(official: "Ecuadori Köztársaság", common: "Ecuador") },
                { "ita", new CountryName(official: "Repubblica dell'Ecuador", common: "Ecuador") },
                { "jpn", new CountryName(official: "エクアドル共和国", common: "エクアドル") },
                { "kor", new CountryName(official: "에콰도르 공화국", common: "에콰도르") },
                { "nld", new CountryName(official: "Republiek Ecuador", common: "Ecuador") },
                { "per", new CountryName(official: "جمهوری اکوادور", common: "اکوادور") },
                { "pol", new CountryName(official: "Ekwador", common: "Ekwador") },
                { "por", new CountryName(official: "República do Equador", common: "Equador") },
                { "rus", new CountryName(official: "Республика Эквадор", common: "Эквадор") },
                { "slk", new CountryName(official: "Ekvádorská republika", common: "Ekvádor") },
                { "swe", new CountryName(official: "Republiken Ecuador", common: "Ecuador") },
                { "urd", new CountryName(official: "جمہوریہ ایکوڈور", common: "ایکواڈور") },
                { "zho", new CountryName(official: "厄瓜多尔共和国", common: "厄瓜多尔") },

            },
            cca2: "EC",
            cca3: "ECU",
            ccn3: "218",
            cioc: "ECU",
            flag: "🇪🇨",
            region: Region.Americas,
            subregion: "South America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"93", }),
            borders: new string[] { "COL", "PER",  },
            capital: new string[] { "Quito",  },
            altSpellings: new string[] { "EC", "Republic of Ecuador", "República del Ecuador",  },
            tld: new string[] { ".ec",  },
            latlng: new double[] { -2, -77.5,  },
            timezones: new string[] { "UTC-06:00", "UTC-05:00",  },
            languages: new Language[]
            {
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "USD", name: "United States dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Ecuadorean", female: "Ecuadorean") },
                { "fra", new DemonymsGender(male: "Ecuadorean", female: "Ecuadorean") },
            }
        );

        /// <summary>
        /// create an instance of Ecuador country
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
        private Ecuador(
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
