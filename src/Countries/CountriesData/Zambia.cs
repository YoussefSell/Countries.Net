namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Zambia country
    /// </summary>
    public class Zambia : Country
    {
        /// <summary>
        /// get the Zambia country instance
        /// </summary>
        public static Zambia Instance = new Zambia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Zambia", common: "Zambia") },
                { "ara", new CountryName(official: "جمهورية زامبيا", common: "زامبيا") },
                { "ces", new CountryName(official: "Zambijská republika", common: "Zambie") },
                { "cym", new CountryName(official: "Republic of Zambia", common: "Zambia") },
                { "deu", new CountryName(official: "Republik Sambia", common: "Sambia") },
                { "est", new CountryName(official: "Sambia Vabariik", common: "Sambia") },
                { "fin", new CountryName(official: "Sambian tasavalta", common: "Sambia") },
                { "fra", new CountryName(official: "République de Zambie", common: "Zambie") },
                { "hrv", new CountryName(official: "Republika Zambija", common: "Zambija") },
                { "hun", new CountryName(official: "Zambiai Köztársaság", common: "Zambia") },
                { "ita", new CountryName(official: "Repubblica di Zambia", common: "Zambia") },
                { "jpn", new CountryName(official: "ザンビア共和国", common: "ザンビア") },
                { "kor", new CountryName(official: "잠비아 공화국", common: "잠비아") },
                { "nld", new CountryName(official: "Republiek Zambia", common: "Zambia") },
                { "per", new CountryName(official: "جمهوری زامبیا", common: "زامبیا") },
                { "pol", new CountryName(official: "Republika Zambii", common: "Zambia") },
                { "por", new CountryName(official: "República da Zâmbia", common: "Zâmbia") },
                { "rus", new CountryName(official: "Республика Замбия", common: "Замбия") },
                { "slk", new CountryName(official: "Zambijská republika", common: "Zambia") },
                { "spa", new CountryName(official: "República de Zambia", common: "Zambia") },
                { "swe", new CountryName(official: "Republiken Zambia", common: "Zambia") },
                { "urd", new CountryName(official: "جمہوریہ زیمبیا", common: "زیمبیا") },
                { "zho", new CountryName(official: "赞比亚共和国", common: "赞比亚") },
            },
            cca2: "ZM",
            cca3: "ZMB",
            ccn3: "894",
            cioc: "ZAM",
            flag: "🇿🇲",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"60", }),
            borders: new string[] { "AGO", "BWA", "COD", "MWI", "MOZ", "NAM", "TZA", "ZWE",  },
            capital: new string[] { "Lusaka",  },
            altSpellings: new string[] { "ZM", "Republic of Zambia",  },
            tld: new string[] { ".zm",  },
            latlng: new double[] { -15, 30,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "ZMW", name: "Zambian kwacha", symbol: "ZK"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Zambian", female: "Zambian") },
                { "fra", new DemonymsGender(male: "Zambian", female: "Zambian") },
            }
        );

        /// <summary>
        /// create an instance of Zambia country
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
        private Zambia(
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
