namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Barbados country
    /// </summary>
    public class Barbados : Country
    {
        /// <summary>
        /// get the Barbados country instance
        /// </summary>
        public static Barbados Instance = new Barbados(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Barbados", common: "Barbados") },
                { "ara", new CountryName(official: "باربادوس", common: "باربادوس") },
                { "ces", new CountryName(official: "Barbados", common: "Barbados") },
                { "cym", new CountryName(official: "Barbados", common: "Barbados") },
                { "deu", new CountryName(official: "Barbados", common: "Barbados") },
                { "est", new CountryName(official: "Barbados", common: "Barbados") },
                { "fin", new CountryName(official: "Barbados", common: "Barbados") },
                { "fra", new CountryName(official: "Barbade", common: "Barbade") },
                { "hrv", new CountryName(official: "Barbados", common: "Barbados") },
                { "hun", new CountryName(official: "Barbados", common: "Barbados") },
                { "ita", new CountryName(official: "Barbados", common: "Barbados") },
                { "jpn", new CountryName(official: "バルバドス", common: "バルバドス") },
                { "kor", new CountryName(official: "바베이도스", common: "바베이도스") },
                { "nld", new CountryName(official: "Barbados", common: "Barbados") },
                { "per", new CountryName(official: "باربادوس", common: "باربادوس") },
                { "pol", new CountryName(official: "Barbados", common: "Barbados") },
                { "por", new CountryName(official: "Barbados", common: "Barbados") },
                { "rus", new CountryName(official: "Барбадос", common: "Барбадос") },
                { "slk", new CountryName(official: "Barbados", common: "Barbados") },
                { "spa", new CountryName(official: "Barbados", common: "Barbados") },
                { "swe", new CountryName(official: "Barbados", common: "Barbados") },
                { "urd", new CountryName(official: "بارباڈوس", common: "بارباڈوس") },
                { "zho", new CountryName(official: "巴巴多斯", common: "巴巴多斯") },
            },
            cca2: "BB",
            cca3: "BRB",
            ccn3: "052",
            cioc: "BAR",
            flag: "🇧🇧",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"246", }),
            borders: new string[] {  },
            capital: new string[] { "Bridgetown",  },
            altSpellings: new string[] { "BB",  },
            tld: new string[] { ".bb",  },
            latlng: new double[] { 13.16666666, -59.53333333,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "BBD", name: "Barbadian dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Barbadian", female: "Barbadian") },
                { "fra", new DemonymsGender(male: "Barbadian", female: "Barbadian") },
            }
        );

        /// <summary>
        /// create an instance of Barbados country
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
        private Barbados(
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
