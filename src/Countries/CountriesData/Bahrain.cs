namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Bahrain country
    /// </summary>
    public class Bahrain : Country
    {
        /// <summary>
        /// get the Bahrain country instance
        /// </summary>
        public static Bahrain Instance = new Bahrain(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Kingdom of Bahrain", common: "Bahrain") },
                { "ara", new CountryName(official: "مملكة البحرين", common: "‏البحرين") },
                { "ces", new CountryName(official: "Království Bahrajn", common: "Bahrajn") },
                { "cym", new CountryName(official: "Teyrnas Bahrein", common: "Bahrain") },
                { "deu", new CountryName(official: "Königreich Bahrain", common: "Bahrain") },
                { "est", new CountryName(official: "Bahreini Kuningriik", common: "Bahrein") },
                { "fin", new CountryName(official: "Bahrainin kuningaskunta", common: "Bahrain") },
                { "fra", new CountryName(official: "Royaume de Bahreïn", common: "Bahreïn") },
                { "hrv", new CountryName(official: "Kraljevina Bahrein", common: "Bahrein") },
                { "hun", new CountryName(official: "Bahreini Királyság", common: "Bahrein") },
                { "ita", new CountryName(official: "Regno del Bahrain", common: "Bahrein") },
                { "jpn", new CountryName(official: "バーレーン王国", common: "バーレーン") },
                { "kor", new CountryName(official: "바레인 왕국", common: "바레인") },
                { "nld", new CountryName(official: "Koninkrijk Bahrein", common: "Bahrein") },
                { "per", new CountryName(official: "پادشاهی بحرین", common: "بحرین") },
                { "pol", new CountryName(official: "Królestwo Bahrajnu", common: "Bahrajn") },
                { "por", new CountryName(official: "Reino do Bahrein", common: "Bahrein") },
                { "rus", new CountryName(official: "Королевство Бахрейн", common: "Бахрейн") },
                { "slk", new CountryName(official: "Bahrajnské kráľovstvo", common: "Bahrajn") },
                { "spa", new CountryName(official: "Reino de Bahrein", common: "Bahrein") },
                { "swe", new CountryName(official: "Konungariket Bahrain", common: "Bahrain") },
                { "urd", new CountryName(official: "مملکتِ بحرین", common: "بحرین") },
                { "zho", new CountryName(official: "巴林王国", common: "巴林") },

            },
            cca2: "BH",
            cca3: "BHR",
            ccn3: "048",
            cioc: "BRN",
            flag: "🇧🇭",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"73", }),
            borders: new string[] {  },
            capital: new string[] { "Manama",  },
            altSpellings: new string[] { "BH", "Kingdom of Bahrain", "Mamlakat al-Baḥrayn",  },
            tld: new string[] { ".bh",  },
            latlng: new double[] { 26, 50.55,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "BHD", name: "Bahraini dinar", symbol: ".د.ب"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Bahraini", female: "Bahraini") },
                { "fra", new DemonymsGender(male: "Bahraini", female: "Bahraini") },
            }
        );

        /// <summary>
        /// create an instance of Bahrain country
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
        private Bahrain(
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
