namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Namibia country
    /// </summary>
    public class Namibia : Country
    {
        /// <summary>
        /// get the Namibia country instance
        /// </summary>
        public static Namibia Instance = new Namibia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Namibia", common: "Namibia") },
                { "afr", new CountryName(official: "Republiek van Namibië", common: "Namibië") },
                { "deu", new CountryName(official: "Republik Namibia", common: "Namibia") },
                { "her", new CountryName(official: "Republic of Namibia", common: "Namibia") },
                { "hgm", new CountryName(official: "Republic of Namibia", common: "Namibia") },
                { "kwn", new CountryName(official: "Republic of Namibia", common: "Namibia") },
                { "loz", new CountryName(official: "Republic of Namibia", common: "Namibia") },
                { "ndo", new CountryName(official: "Republic of Namibia", common: "Namibia") },
                { "tsn", new CountryName(official: "Lefatshe la Namibia", common: "Namibia") },
                { "ara", new CountryName(official: "جمهورية ناميبيا", common: "ناميبيا") },
                { "ces", new CountryName(official: "Namibijská republika", common: "Namibie") },
                { "cym", new CountryName(official: "Republic of Namibia", common: "Namibia") },
                { "est", new CountryName(official: "Namiibia Vabariik", common: "Namiibia") },
                { "fin", new CountryName(official: "Namibian tasavalta", common: "Namibia") },
                { "fra", new CountryName(official: "République de Namibie", common: "Namibie") },
                { "hrv", new CountryName(official: "Republika Namibija", common: "Namibija") },
                { "hun", new CountryName(official: "Namíbiai Köztársaság", common: "Namíbia") },
                { "ita", new CountryName(official: "Repubblica di Namibia", common: "Namibia") },
                { "jpn", new CountryName(official: "ナミビア共和国", common: "ナミビア") },
                { "kor", new CountryName(official: "나미비아 공화국", common: "나미비아") },
                { "nld", new CountryName(official: "Republiek Namibië", common: "Namibië") },
                { "per", new CountryName(official: "جمهوری نامیبیا", common: "نامیبیا") },
                { "pol", new CountryName(official: "Republika Namibii", common: "Namibia") },
                { "por", new CountryName(official: "República da Namíbia", common: "Namíbia") },
                { "rus", new CountryName(official: "Республика Намибия", common: "Намибия") },
                { "slk", new CountryName(official: "Namíbijská republika", common: "Namíbia") },
                { "spa", new CountryName(official: "República de Namibia", common: "Namibia") },
                { "swe", new CountryName(official: "Republiken Namibia", common: "Namibia") },
                { "urd", new CountryName(official: "جمہوریہ نمیبیا", common: "نمیبیا") },
                { "zho", new CountryName(official: "纳米比亚共和国", common: "纳米比亚") },

            },
            cca2: "NA",
            cca3: "NAM",
            ccn3: "516",
            cioc: "NAM",
            flag: "🇳🇦",
            region: Region.Africa,
            subregion: "Southern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"64", }),
            borders: new string[] { "AGO", "BWA", "ZAF", "ZMB",  },
            capital: new string[] { "Windhoek",  },
            altSpellings: new string[] { "NA", "Namibië", "Republic of Namibia",  },
            tld: new string[] { ".na",  },
            latlng: new double[] { -22, 17,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Afrikaans", iso6391: "af", iso6392: "afr"),
                new Language(name: "German", iso6391: "de", iso6392: "deu"),
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Herero", iso6391: "hz", iso6392: "her"),
                new Language(name: "Khoekhoe", iso6391: "", iso6392: "hgm"),
                new Language(name: "Kwangali", iso6391: "", iso6392: "kwn"),
                new Language(name: "Lozi", iso6391: "", iso6392: "loz"),
                new Language(name: "Ndonga", iso6391: "ng", iso6392: "ndo"),
                new Language(name: "Tswana", iso6391: "tn", iso6392: "tsn"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "NAD", name: "Namibian dollar", symbol: "$"),
                new Currency(code: "ZAR", name: "South African rand", symbol: "R"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Namibian", female: "Namibian") },
                { "fra", new DemonymsGender(male: "Namibian", female: "Namibian") },
            }
        );

        /// <summary>
        /// create an instance of Namibia country
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
        private Namibia(
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
