namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Malaysia country
    /// </summary>
    public class Malaysia : Country
    {
        /// <summary>
        /// get the Malaysia country instance
        /// </summary>
        public static Malaysia Instance = new Malaysia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Malaysia", common: "Malaysia") },
                { "msa", new CountryName(official: "مليسيا", common: "مليسيا") },
                { "ara", new CountryName(official: "ماليزيا", common: "ماليزيا") },
                { "ces", new CountryName(official: "Malajsie", common: "Malajsie") },
                { "cym", new CountryName(official: "Malaysia", common: "Malaysia") },
                { "deu", new CountryName(official: "Malaysia", common: "Malaysia") },
                { "est", new CountryName(official: "Malaisia", common: "Malaisia") },
                { "fin", new CountryName(official: "Malesia", common: "Malesia") },
                { "fra", new CountryName(official: "Fédération de Malaisie", common: "Malaisie") },
                { "hrv", new CountryName(official: "Malezija", common: "Malezija") },
                { "hun", new CountryName(official: "Malajzia", common: "Malajzia") },
                { "ita", new CountryName(official: "Malaysia", common: "Malesia") },
                { "jpn", new CountryName(official: "マレーシア", common: "マレーシア") },
                { "kor", new CountryName(official: "말레이시아", common: "말레이시아") },
                { "nld", new CountryName(official: "Maleisië", common: "Maleisië") },
                { "per", new CountryName(official: "فدراسیون مالزی", common: "مالزی") },
                { "pol", new CountryName(official: "Malezja", common: "Malezja") },
                { "por", new CountryName(official: "Malásia", common: "Malásia") },
                { "rus", new CountryName(official: "Малайзия", common: "Малайзия") },
                { "slk", new CountryName(official: "Malajzia", common: "Malajzia") },
                { "spa", new CountryName(official: "Malasia", common: "Malasia") },
                { "swe", new CountryName(official: "Malaysia", common: "Malaysia") },
                { "urd", new CountryName(official: "ملائیشیا", common: "ملائیشیا") },
                { "zho", new CountryName(official: "马来西亚", common: "马来西亚") },
            },
            cca2: "MY",
            cca3: "MYS",
            ccn3: "458",
            cioc: "MAS",
            flag: "🇲🇾",
            region: Region.Asia,
            subregion: "South-Eastern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"0", }),
            borders: new string[] { "BRN", "IDN", "THA",  },
            capital: new string[] { "Kuala Lumpur",  },
            altSpellings: new string[] { "MY",  },
            tld: new string[] { ".my",  },
            latlng: new double[] { 2.5, 112.5,  },
            timezones: new string[] { "UTC+08:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Malay", iso6391: "ms", iso6392: "msa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "MYR", name: "Malaysian ringgit", symbol: "RM"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Malaysian", female: "Malaysian") },
                { "fra", new DemonymsGender(male: "Malaysian", female: "Malaysian") },
            }
        );

        /// <summary>
        /// create an instance of Malaysia country
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
        private Malaysia(
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
