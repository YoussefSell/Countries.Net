namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Gambia country
    /// </summary>
    public class Gambia : Country
    {
        /// <summary>
        /// get the Gambia country instance
        /// </summary>
        public static Gambia Instance = new Gambia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of the Gambia", common: "Gambia") },
                { "ara", new CountryName(official: "جمهورية غامبيا", common: "غامبيا") },
                { "ces", new CountryName(official: "Gambijská republika", common: "Gambie") },
                { "cym", new CountryName(official: "Republic of the Gambia", common: "Gambia") },
                { "deu", new CountryName(official: "Republik Gambia", common: "Gambia") },
                { "est", new CountryName(official: "Gambia Vabariik", common: "Gambia") },
                { "fin", new CountryName(official: "Gambian tasavalta", common: "Gambia") },
                { "fra", new CountryName(official: "République de Gambie", common: "Gambie") },
                { "hrv", new CountryName(official: "Republika Gambija", common: "Gambija") },
                { "hun", new CountryName(official: "Gambiai Köztársaság", common: "Gambia") },
                { "ita", new CountryName(official: "Repubblica del Gambia", common: "Gambia") },
                { "jpn", new CountryName(official: "ガンビア共和国", common: "ガンビア") },
                { "kor", new CountryName(official: "감비아 공화국", common: "감비아") },
                { "nld", new CountryName(official: "Republiek Gambia", common: "Gambia") },
                { "per", new CountryName(official: "جمهوری گامبیا", common: "گامبیا") },
                { "pol", new CountryName(official: "Republika Gambii", common: "Gambia") },
                { "por", new CountryName(official: "República da Gâmbia", common: "Gâmbia") },
                { "rus", new CountryName(official: "Республика Гамбия", common: "Гамбия") },
                { "slk", new CountryName(official: "Gambijská republika", common: "Gambia") },
                { "spa", new CountryName(official: "República de Gambia", common: "Gambia") },
                { "swe", new CountryName(official: "Republiken Gambia", common: "Gambia") },
                { "urd", new CountryName(official: "جمہوریہ گیمبیا", common: "گیمبیا") },
                { "zho", new CountryName(official: "冈比亚共和国", common: "冈比亚") },
            },
            cca2: "GM",
            cca3: "GMB",
            ccn3: "270",
            cioc: "GAM",
            flag: "🇬🇲",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"20", }),
            borders: new string[] { "SEN",  },
            capital: new string[] { "Banjul",  },
            altSpellings: new string[] { "GM", "Republic of the Gambia",  },
            tld: new string[] { ".gm",  },
            latlng: new double[] { 13.46666666, -16.56666666,  },
            timezones: new string[] { "UTC+00:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "GMD", name: "dalasi", symbol: "D"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Gambian", female: "Gambian") },
                { "fra", new DemonymsGender(male: "Gambian", female: "Gambian") },
            }
        );

        /// <summary>
        /// create an instance of Gambia country
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
        private Gambia(
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
