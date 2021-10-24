namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Anguilla country
    /// </summary>
    public class Anguilla : Country
    {
        /// <summary>
        /// get the Anguilla country instance
        /// </summary>
        public static Anguilla Instance = new Anguilla(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Anguilla", common: "Anguilla") },
                { "ara", new CountryName(official: "أنغويلا", common: "أنغويلا") },
                { "ces", new CountryName(official: "Anguilla", common: "Anguilla") },
                { "cym", new CountryName(official: "Anguilla", common: "Anguilla") },
                { "deu", new CountryName(official: "Anguilla", common: "Anguilla") },
                { "est", new CountryName(official: "Anguilla", common: "Anguilla") },
                { "fin", new CountryName(official: "Anguilla", common: "Anguilla") },
                { "fra", new CountryName(official: "Anguilla", common: "Anguilla") },
                { "hrv", new CountryName(official: "Anguilla", common: "Angvila") },
                { "hun", new CountryName(official: "Anguilla", common: "Anguilla") },
                { "ita", new CountryName(official: "Anguilla", common: "Anguilla") },
                { "jpn", new CountryName(official: "アングィラ", common: "アンギラ") },
                { "kor", new CountryName(official: "앵귈라", common: "앵귈라") },
                { "nld", new CountryName(official: "Anguilla", common: "Anguilla") },
                { "per", new CountryName(official: "آنگویلا", common: "آنگویلا") },
                { "pol", new CountryName(official: "Anguilla", common: "Anguilla") },
                { "por", new CountryName(official: "Anguilla", common: "Anguilla") },
                { "rus", new CountryName(official: "Ангилья", common: "Ангилья") },
                { "slk", new CountryName(official: "Anguilla", common: "Anguilla") },
                { "spa", new CountryName(official: "Anguila", common: "Anguilla") },
                { "swe", new CountryName(official: "Anguilla", common: "Anguilla") },
                { "urd", new CountryName(official: "اینگویلا", common: "اینگویلا") },
                { "zho", new CountryName(official: "安圭拉", common: "安圭拉") },
            },
            cca2: "AI",
            cca3: "AIA",
            ccn3: "660",
            cioc: "",
            flag: "🇦🇮",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"264", }),
            borders: new string[] {  },
            capital: new string[] { "The Valley",  },
            altSpellings: new string[] { "AI",  },
            tld: new string[] { ".ai",  },
            latlng: new double[] { 18.25, -63.16666666,  },
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
                { "eng", new DemonymsGender(male: "Anguillian", female: "Anguillian") },
                { "fra", new DemonymsGender(male: "Anguillian", female: "Anguillian") },
            }
        );

        /// <summary>
        /// create an instance of Anguilla country
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
        private Anguilla(
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
