namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Curaçao country
    /// </summary>
    public class Curaçao : Country
    {
        /// <summary>
        /// get the Curaçao country instance
        /// </summary>
        public static Curaçao Instance = new Curaçao(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Country of Curaçao", common: "Curaçao") },
                { "nld", new CountryName(official: "Land Curaçao", common: "Curaçao") },
                { "pap", new CountryName(official: "Pais Kòrsou", common: "Pais Kòrsou") },
                { "ara", new CountryName(official: "دولة كوراساو", common: "كوراساو") },
                { "ces", new CountryName(official: "Autonomní země Curaçao", common: "Curaçao") },
                { "cym", new CountryName(official: "Country of Curaçao", common: "Curaçao") },
                { "deu", new CountryName(official: "Land Curaçao", common: "Curaçao") },
                { "est", new CountryName(official: "Curaçao", common: "Curaçao") },
                { "fin", new CountryName(official: "Curaçao", common: "Curaçao") },
                { "fra", new CountryName(official: "Pays de Curaçao", common: "Curaçao") },
                { "hun", new CountryName(official: "Curaçao", common: "Curaçao") },
                { "ita", new CountryName(official: "Paese di Curaçao", common: "Curaçao") },
                { "kor", new CountryName(official: "퀴라소", common: "퀴라소") },
                { "per", new CountryName(official: "کوراسائو", common: "کوراسائو") },
                { "pol", new CountryName(official: "Curaçao", common: "Curaçao") },
                { "por", new CountryName(official: "País de Curaçao", common: "ilha da Curação") },
                { "rus", new CountryName(official: "Страна Кюрасао", common: "Кюрасао") },
                { "slk", new CountryName(official: "Curacao", common: "Curacao") },
                { "spa", new CountryName(official: "País de Curazao", common: "Curazao") },
                { "swe", new CountryName(official: "Curaçao", common: "Curaçao") },
                { "urd", new CountryName(official: "مملکتِ کیوراساؤ", common: "کیوراساؤ") },
                { "zho", new CountryName(official: "库拉索", common: "库拉索") },

            },
            cca2: "CW",
            cca3: "CUW",
            ccn3: "531",
            cioc: "",
            flag: "🇨🇼",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"99", }),
            borders: new string[] {  },
            capital: new string[] { "Willemstad",  },
            altSpellings: new string[] { "CW", "Curacao", "Kòrsou", "Country of Curaçao", "Land Curaçao", "Pais Kòrsou",  },
            tld: new string[] { ".cw",  },
            latlng: new double[] { 12.116667, -68.933333,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Dutch", iso6391: "nl", iso6392: "nld"),
                new Language(name: "Papiamento", iso6391: "pap", iso6392: "pap"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "ANG", name: "Netherlands Antillean guilder", symbol: "ƒ"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Curaçaoan", female: "Curaçaoan") },
                { "fra", new DemonymsGender(male: "Curaçaoan", female: "Curaçaoan") },
            }
        );

        /// <summary>
        /// create an instance of Curaçao country
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
        private Curaçao(
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
