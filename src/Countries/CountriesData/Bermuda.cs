namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Bermuda country
    /// </summary>
    public class Bermuda : Country
    {
        /// <summary>
        /// get the Bermuda country instance
        /// </summary>
        public static Bermuda Instance = new Bermuda(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Bermuda", common: "Bermuda") },
                { "ara", new CountryName(official: "برمودا", common: "برمودا") },
                { "ces", new CountryName(official: "Bermudské ostrovy", common: "Bermudy") },
                { "cym", new CountryName(official: "Bermiwda", common: "Bermiwda") },
                { "deu", new CountryName(official: "Bermuda", common: "Bermuda") },
                { "est", new CountryName(official: "Bermuda", common: "Bermuda") },
                { "fin", new CountryName(official: "Bermuda", common: "Bermuda") },
                { "fra", new CountryName(official: "Bermudes", common: "Bermudes") },
                { "hrv", new CountryName(official: "Bermuda", common: "Bermudi") },
                { "hun", new CountryName(official: "Bermuda", common: "Bermuda") },
                { "ita", new CountryName(official: "Bermuda", common: "Bermuda") },
                { "jpn", new CountryName(official: "バミューダ", common: "バミューダ") },
                { "kor", new CountryName(official: "버뮤다", common: "버뮤다") },
                { "nld", new CountryName(official: "Bermuda", common: "Bermuda") },
                { "per", new CountryName(official: "جزایر برمودا", common: "برمودا") },
                { "pol", new CountryName(official: "Bermudy", common: "Bermudy") },
                { "por", new CountryName(official: "Bermudas", common: "Bermudas") },
                { "rus", new CountryName(official: "Бермудские острова", common: "Бермудские Острова") },
                { "slk", new CountryName(official: "Bermudy", common: "Bermudy") },
                { "spa", new CountryName(official: "Bermuda", common: "Bermudas") },
                { "swe", new CountryName(official: "Bermuda", common: "Bermuda") },
                { "urd", new CountryName(official: "برمودا", common: "برمودا") },
                { "zho", new CountryName(official: "百慕大", common: "百慕大") },
            },
            cca2: "BM",
            cca3: "BMU",
            ccn3: "060",
            cioc: "BER",
            flag: "🇧🇲",
            region: Region.Americas,
            subregion: "North America",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"441", }),
            borders: new string[] {  },
            capital: new string[] { "Hamilton",  },
            altSpellings: new string[] { "BM", "The Islands of Bermuda", "The Bermudas", "Somers Isles",  },
            tld: new string[] { ".bm",  },
            latlng: new double[] { 32.33333333, -64.75,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "BMD", name: "Bermudian dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Bermudian", female: "Bermudian") },
                { "fra", new DemonymsGender(male: "Bermudian", female: "Bermudian") },
            }
        );

        /// <summary>
        /// create an instance of Bermuda country
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
        private Bermuda(
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
