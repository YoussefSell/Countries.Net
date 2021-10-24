namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Liberia country
    /// </summary>
    public class Liberia : Country
    {
        /// <summary>
        /// get the Liberia country instance
        /// </summary>
        public static Liberia Instance = new Liberia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Liberia", common: "Liberia") },
                { "ara", new CountryName(official: "جمهورية ليبيريا", common: "ليبيريا") },
                { "ces", new CountryName(official: "Liberijská republika", common: "Libérie") },
                { "cym", new CountryName(official: "Republic of Liberia", common: "Liberia") },
                { "deu", new CountryName(official: "Republik Liberia", common: "Liberia") },
                { "est", new CountryName(official: "Libeeria Vabariik", common: "Libeeria") },
                { "fin", new CountryName(official: "Liberian tasavalta", common: "Liberia") },
                { "fra", new CountryName(official: "République du Libéria", common: "Liberia") },
                { "hrv", new CountryName(official: "Republika Liberija", common: "Liberija") },
                { "hun", new CountryName(official: "Libériai Köztársaság", common: "Libéria") },
                { "ita", new CountryName(official: "Repubblica di Liberia", common: "Liberia") },
                { "jpn", new CountryName(official: "リベリア共和国", common: "リベリア") },
                { "kor", new CountryName(official: "라이베리아 공화국", common: "라이베리아") },
                { "nld", new CountryName(official: "Republiek Liberia", common: "Liberia") },
                { "per", new CountryName(official: "جمهوری لیبریا", common: "لیبـِریا") },
                { "pol", new CountryName(official: "Republika Liberii", common: "Liberia") },
                { "por", new CountryName(official: "República da Libéria", common: "Libéria") },
                { "rus", new CountryName(official: "Республика Либерия", common: "Либерия") },
                { "slk", new CountryName(official: "Libérijská republika", common: "Libéria") },
                { "spa", new CountryName(official: "República de Liberia", common: "Liberia") },
                { "swe", new CountryName(official: "Republiken Liberia", common: "Liberia") },
                { "urd", new CountryName(official: "جمہوریہ لائبیریا", common: "لائبیریا") },
                { "zho", new CountryName(official: "利比里亚共和国", common: "利比里亚") },
            },
            cca2: "LR",
            cca3: "LBR",
            ccn3: "430",
            cioc: "LBR",
            flag: "🇱🇷",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"31", }),
            borders: new string[] { "GIN", "CIV", "SLE",  },
            capital: new string[] { "Monrovia",  },
            altSpellings: new string[] { "LR", "Republic of Liberia",  },
            tld: new string[] { ".lr",  },
            latlng: new double[] { 6.5, -9.5,  },
            timezones: new string[] { "UTC",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "LRD", name: "Liberian dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Liberian", female: "Liberian") },
                { "fra", new DemonymsGender(male: "Liberian", female: "Liberian") },
            }
        );

        /// <summary>
        /// create an instance of Liberia country
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
        private Liberia(
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
