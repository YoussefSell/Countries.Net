namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Greenland country
    /// </summary>
    public class Greenland : Country
    {
        /// <summary>
        /// get the Greenland country instance
        /// </summary>
        public static Greenland Instance = new Greenland(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Greenland", common: "Greenland") },
                { "kal", new CountryName(official: "Kalaallit Nunaat", common: "Kalaallit Nunaat") },
                { "ara", new CountryName(official: "جرينلاند", common: "جرينلاند") },
                { "ces", new CountryName(official: "Grónsko", common: "Grónsko") },
                { "cym", new CountryName(official: "Greenland", common: "Greenland") },
                { "deu", new CountryName(official: "Grönland", common: "Grönland") },
                { "est", new CountryName(official: "Gröönimaa", common: "Gröönimaa") },
                { "fin", new CountryName(official: "Groönlanti", common: "Groönlanti") },
                { "fra", new CountryName(official: "Groenland", common: "Groenland") },
                { "hrv", new CountryName(official: "Grenland", common: "Grenland") },
                { "hun", new CountryName(official: "Grönland", common: "Grönland") },
                { "ita", new CountryName(official: "Groenlandia", common: "Groenlandia") },
                { "jpn", new CountryName(official: "グリーンランド", common: "グリーンランド") },
                { "kor", new CountryName(official: "그린란드", common: "그린란드") },
                { "nld", new CountryName(official: "Groenland", common: "Groenland") },
                { "per", new CountryName(official: "گروئنلند", common: "گرینلند") },
                { "pol", new CountryName(official: "Grenlandia", common: "Grenlandia") },
                { "por", new CountryName(official: "Groenlândia", common: "Gronelândia") },
                { "rus", new CountryName(official: "Гренландия", common: "Гренландия") },
                { "slk", new CountryName(official: "Grónsko", common: "Grónsko") },
                { "spa", new CountryName(official: "Groenlandia", common: "Groenlandia") },
                { "swe", new CountryName(official: "Grönland", common: "Grönland") },
                { "urd", new CountryName(official: "گرین لینڈ", common: "گرین لینڈ") },
                { "zho", new CountryName(official: "格陵兰", common: "格陵兰") },
            },
            cca2: "GL",
            cca3: "GRL",
            ccn3: "304",
            cioc: "",
            flag: "🇬🇱",
            region: Region.Americas,
            subregion: "North America",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"99", }),
            borders: new string[] {  },
            capital: new string[] { "Nuuk",  },
            altSpellings: new string[] { "GL", "Grønland",  },
            tld: new string[] { ".gl",  },
            latlng: new double[] { 72, -40,  },
            timezones: new string[] { "UTC-04:00", "UTC-03:00", "UTC-01:00", "UTC+00:00",  },
            languages: new Language[]
            {
                new Language(name: "Greenlandic", iso6391: "kl", iso6392: "kal"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "DKK", name: "krone", symbol: "kr."),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Greenlandic", female: "Greenlandic") },
                { "fra", new DemonymsGender(male: "Greenlandic", female: "Greenlandic") },
            }
        );

        /// <summary>
        /// create an instance of Greenland country
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
        private Greenland(
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
