namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Niue country
    /// </summary>
    public class Niue : Country
    {
        /// <summary>
        /// get the Niue country instance
        /// </summary>
        public static Niue Instance = new Niue(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Niue", common: "Niue") },
                { "niu", new CountryName(official: "Niuē", common: "Niuē") },
                { "ara", new CountryName(official: "نييوي", common: "نييوي") },
                { "ces", new CountryName(official: "Niue", common: "Niue") },
                { "cym", new CountryName(official: "Niue", common: "Niue") },
                { "deu", new CountryName(official: "Niue", common: "Niue") },
                { "est", new CountryName(official: "Niue", common: "Niue") },
                { "fin", new CountryName(official: "Niue", common: "Niue") },
                { "fra", new CountryName(official: "Niue", common: "Niue") },
                { "hrv", new CountryName(official: "Niue", common: "Niue") },
                { "hun", new CountryName(official: "Niue", common: "Niue") },
                { "ita", new CountryName(official: "Niue", common: "Niue") },
                { "jpn", new CountryName(official: "ニウエ", common: "ニウエ") },
                { "kor", new CountryName(official: "니우에", common: "니우에") },
                { "nld", new CountryName(official: "Niue", common: "Niue") },
                { "per", new CountryName(official: "نیووی", common: "نیووی") },
                { "pol", new CountryName(official: "Niue", common: "Niue") },
                { "por", new CountryName(official: "Niue", common: "Niue") },
                { "rus", new CountryName(official: "Ниуэ", common: "Ниуэ") },
                { "slk", new CountryName(official: "Niue", common: "Niue") },
                { "spa", new CountryName(official: "Niue", common: "Niue") },
                { "swe", new CountryName(official: "Niue", common: "Niue") },
                { "urd", new CountryName(official: "نیووے", common: "نیووے") },
                { "zho", new CountryName(official: "纽埃", common: "纽埃") },
            },
            cca2: "NU",
            cca3: "NIU",
            ccn3: "570",
            cioc: "",
            flag: "🇳🇺",
            region: Region.Oceania,
            subregion: "Polynesia",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"83", }),
            borders: new string[] {  },
            capital: new string[] { "Alofi",  },
            altSpellings: new string[] { "NU",  },
            tld: new string[] { ".nu",  },
            latlng: new double[] { -19.03333333, -169.86666666,  },
            timezones: new string[] { "UTC-11:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Niuean", iso6391: "", iso6392: "niu"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "NZD", name: "New Zealand dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Niuean", female: "Niuean") },
                { "fra", new DemonymsGender(male: "Niuean", female: "Niuean") },
            }
        );

        /// <summary>
        /// create an instance of Niue country
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
        private Niue(
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
