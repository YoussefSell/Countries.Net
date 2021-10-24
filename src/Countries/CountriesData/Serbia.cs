namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Serbia country
    /// </summary>
    public class Serbia : Country
    {
        /// <summary>
        /// get the Serbia country instance
        /// </summary>
        public static Serbia Instance = new Serbia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Serbia", common: "Serbia") },
                { "srp", new CountryName(official: "Република Србија", common: "Србија") },
                { "ara", new CountryName(official: "جمهورية صيربيا", common: "صيربيا") },
                { "ces", new CountryName(official: "Srbská republika", common: "Srbsko") },
                { "cym", new CountryName(official: "Republic of Serbia", common: "Serbia") },
                { "deu", new CountryName(official: "Republik Serbien", common: "Serbien") },
                { "est", new CountryName(official: "Serbia Vabariik", common: "Serbia") },
                { "fin", new CountryName(official: "Serbian tasavalta", common: "Serbia") },
                { "fra", new CountryName(official: "République de Serbie", common: "Serbie") },
                { "hrv", new CountryName(official: "Republika Srbija", common: "Srbija") },
                { "hun", new CountryName(official: "Szerb Köztársaság", common: "Szerbia") },
                { "ita", new CountryName(official: "Repubblica di Serbia", common: "Serbia") },
                { "jpn", new CountryName(official: "セルビア共和国", common: "セルビア") },
                { "kor", new CountryName(official: "세르비아 공화국", common: "세르비아") },
                { "nld", new CountryName(official: "Republiek Servië", common: "Servië") },
                { "per", new CountryName(official: "جمهوری صربستان", common: "صربستان") },
                { "pol", new CountryName(official: "Republika Serbii", common: "Serbia") },
                { "por", new CountryName(official: "República da Sérvia", common: "Sérvia") },
                { "rus", new CountryName(official: "Республика Сербия", common: "Сербия") },
                { "slk", new CountryName(official: "Srbská republika", common: "Srbsko") },
                { "spa", new CountryName(official: "República de Serbia", common: "Serbia") },
                { "swe", new CountryName(official: "Republiken Serbien", common: "Serbien") },
                { "urd", new CountryName(official: "جمہوریہ سربیا", common: "سربیا") },
                { "zho", new CountryName(official: "塞尔维亚共和国", common: "塞尔维亚") },
            },
            cca2: "RS",
            cca3: "SRB",
            ccn3: "688",
            cioc: "SRB",
            flag: "🇷🇸",
            region: Region.Europe,
            subregion: "Southeast Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"81", }),
            borders: new string[] { "BIH", "BGR", "HRV", "HUN", "UNK", "MKD", "MNE", "ROU",  },
            capital: new string[] { "Belgrade",  },
            altSpellings: new string[] { "RS", "Srbija", "Republic of Serbia", "Република Србија", "Republika Srbija",  },
            tld: new string[] { ".rs", ".срб",  },
            latlng: new double[] { 44, 21,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Serbian", iso6391: "sr", iso6392: "srp"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "RSD", name: "Serbian dinar", symbol: "дин."),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Serbian", female: "Serbian") },
                { "fra", new DemonymsGender(male: "Serbian", female: "Serbian") },
            }
        );

        /// <summary>
        /// create an instance of Serbia country
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
        private Serbia(
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
