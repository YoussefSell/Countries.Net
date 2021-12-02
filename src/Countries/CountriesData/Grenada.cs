namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Grenada country
    /// </summary>
    public class Grenada : Country
    {
        /// <summary>
        /// get the Grenada country instance
        /// </summary>
        public static Grenada Instance = new Grenada(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Grenada", common: "Grenada") },
                { "ara", new CountryName(official: "غرينادا", common: "غرينادا") },
                { "ces", new CountryName(official: "Grenada", common: "Grenada") },
                { "cym", new CountryName(official: "Grenada", common: "Grenada") },
                { "deu", new CountryName(official: "Grenada", common: "Grenada") },
                { "est", new CountryName(official: "Grenada", common: "Grenada") },
                { "fin", new CountryName(official: "Grenada", common: "Grenada") },
                { "fra", new CountryName(official: "Grenade", common: "Grenade") },
                { "hrv", new CountryName(official: "Grenada", common: "Grenada") },
                { "hun", new CountryName(official: "Grenada", common: "Grenada") },
                { "ita", new CountryName(official: "Grenada", common: "Grenada") },
                { "jpn", new CountryName(official: "グレナダ", common: "グレナダ") },
                { "kor", new CountryName(official: "그레나다", common: "그레나다") },
                { "nld", new CountryName(official: "Grenada", common: "Grenada") },
                { "per", new CountryName(official: "گرنادا", common: "گرنادا") },
                { "pol", new CountryName(official: "Grenada", common: "Grenada") },
                { "por", new CountryName(official: "Grenada", common: "Granada") },
                { "rus", new CountryName(official: "Гренада", common: "Гренада") },
                { "slk", new CountryName(official: "Grenada", common: "Grenada") },
                { "spa", new CountryName(official: "Granada", common: "Grenada") },
                { "swe", new CountryName(official: "Grenada", common: "Grenada") },
                { "urd", new CountryName(official: "گریناڈا", common: "گریناڈا") },
                { "zho", new CountryName(official: "格林纳达", common: "格林纳达") },
            },
            cca2: "GD",
            cca3: "GRD",
            ccn3: "308",
            cioc: "GRN",
            flag: "🇬🇩",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"473", }),
            borders: new string[] {  },
            capital: new string[] { "St. George's",  },
            altSpellings: new string[] { "GD",  },
            tld: new string[] { ".gd",  },
            latlng: new double[] { 12.11666666, -61.66666666,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XCD", name: "Eastern Caribbean dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Grenadian", female: "Grenadian") },
                { "fra", new DemonymsGender(male: "Grenadian", female: "Grenadian") },
            }
        );

        /// <summary>
        /// create an instance of Grenada country
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
        private Grenada(
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
