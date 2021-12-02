namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Tunisia country
    /// </summary>
    public class Tunisia : Country
    {
        /// <summary>
        /// get the Tunisia country instance
        /// </summary>
        public static Tunisia Instance = new Tunisia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Tunisian Republic", common: "Tunisia") },
                { "ara", new CountryName(official: "الجمهورية التونسية", common: "تونس") },
                { "ces", new CountryName(official: "Tuniská republika", common: "Tunisko") },
                { "cym", new CountryName(official: "Tunisian Republic", common: "Tunisia") },
                { "deu", new CountryName(official: "Tunesische Republik", common: "Tunesien") },
                { "est", new CountryName(official: "Tuneesia Vabariik", common: "Tuneesia") },
                { "fin", new CountryName(official: "Tunisian tasavalta", common: "Tunisia") },
                { "fra", new CountryName(official: "République tunisienne", common: "Tunisie") },
                { "hrv", new CountryName(official: "Tuniski Republika", common: "Tunis") },
                { "hun", new CountryName(official: "Tunéziai Köztársaság", common: "Tunézia") },
                { "ita", new CountryName(official: "Repubblica tunisina", common: "Tunisia") },
                { "jpn", new CountryName(official: "チュニジア共和国", common: "チュニジア") },
                { "kor", new CountryName(official: "튀니지 공화국", common: "튀니지") },
                { "nld", new CountryName(official: "Republiek Tunesië", common: "Tunesië") },
                { "per", new CountryName(official: "جمهوری تونس", common: "تونس") },
                { "pol", new CountryName(official: "Republika Tunezyjska", common: "Tunezja") },
                { "por", new CountryName(official: "República da Tunísia", common: "Tunísia") },
                { "rus", new CountryName(official: "Тунисской Республики", common: "Тунис") },
                { "slk", new CountryName(official: "Tuniská republika", common: "Tunisko") },
                { "spa", new CountryName(official: "República de Túnez", common: "Túnez") },
                { "swe", new CountryName(official: "Republiken Tunisien", common: "Tunisien") },
                { "urd", new CountryName(official: "جمہوریہ تونس", common: "تونس") },
                { "zho", new CountryName(official: "突尼斯共和国", common: "突尼斯") },

            },
            cca2: "TN",
            cca3: "TUN",
            ccn3: "788",
            cioc: "TUN",
            flag: "🇹🇳",
            region: Region.Africa,
            subregion: "Northern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"16", }),
            borders: new string[] { "DZA", "LBY",  },
            capital: new string[] { "Tunis",  },
            altSpellings: new string[] { "TN", "Republic of Tunisia", "al-Jumhūriyyah at-Tūnisiyyah",  },
            tld: new string[] { ".tn",  },
            latlng: new double[] { 34, 9,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "TND", name: "Tunisian dinar", symbol: "د.ت"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Tunisian", female: "Tunisian") },
                { "fra", new DemonymsGender(male: "Tunisian", female: "Tunisian") },
            }
        );

        /// <summary>
        /// create an instance of Tunisia country
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
        private Tunisia(
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
