namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of IsleofMan country
    /// </summary>
    public class IsleofMan : Country
    {
        /// <summary>
        /// get the IsleofMan country instance
        /// </summary>
        public static IsleofMan Instance = new IsleofMan(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Isle of Man", common: "Isle of Man") },
                { "glv", new CountryName(official: "Ellan Vannin or Mannin", common: "Mannin") },
                { "ara", new CountryName(official: "جزيرة مان", common: "جزيرة مان") },
                { "ces", new CountryName(official: "Ostrov Man", common: "Ostrov Man") },
                { "cym", new CountryName(official: "Isle of Man", common: "Isle of Man") },
                { "deu", new CountryName(official: "Isle of Man", common: "Insel Man") },
                { "est", new CountryName(official: "Mani saar", common: "Mani saar") },
                { "fin", new CountryName(official: "Mansaari", common: "Mansaari") },
                { "fra", new CountryName(official: "Isle of Man", common: "Île de Man") },
                { "hrv", new CountryName(official: "Mana ostrvo", common: "Otok Man") },
                { "hun", new CountryName(official: "Man", common: "Man") },
                { "ita", new CountryName(official: "Isola di Man", common: "Isola di Man") },
                { "jpn", new CountryName(official: "マン島", common: "マン島") },
                { "kor", new CountryName(official: "맨섬", common: "맨섬") },
                { "nld", new CountryName(official: "Isle of Man", common: "Isle of Man") },
                { "per", new CountryName(official: "جزیرهٔ مَن", common: "جزیرهٔ مَن") },
                { "pol", new CountryName(official: "Wyspa Man", common: "Wyspa Man") },
                { "por", new CountryName(official: "Isle of Man", common: "Ilha de Man") },
                { "rus", new CountryName(official: "Остров Мэн", common: "Остров Мэн") },
                { "slk", new CountryName(official: "Ostrov Man", common: "Man") },
                { "spa", new CountryName(official: "Isla de Man", common: "Isla de Man") },
                { "swe", new CountryName(official: "Isle of Man", common: "Isle of Man") },
                { "urd", new CountryName(official: "آئل آف مین", common: "آئل آف مین") },
                { "zho", new CountryName(official: "马恩岛", common: "马恩岛") },
            },
            cca2: "IM",
            cca3: "IMN",
            ccn3: "833",
            cioc: "",
            flag: "🇮🇲",
            region: Region.Europe,
            subregion: "Northern Europe",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"4", }),
            borders: new string[] {  },
            capital: new string[] { "Douglas",  },
            altSpellings: new string[] { "IM", "Ellan Vannin", "Mann", "Mannin",  },
            tld: new string[] { ".im",  },
            latlng: new double[] { 54.25, -4.5,  },
            timezones: new string[] { "UTC+00:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Manx", iso6391: "gv", iso6392: "glv"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "GBP", name: "British pound", symbol: "£"),
                new Currency(code: "IMP", name: "Manx pound", symbol: "£"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Manx", female: "Manx") },
                { "fra", new DemonymsGender(male: "Manx", female: "Manx") },
            }
        );

        /// <summary>
        /// create an instance of IsleofMan country
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
        private IsleofMan(
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
