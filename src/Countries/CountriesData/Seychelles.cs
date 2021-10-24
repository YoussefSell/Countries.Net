namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Seychelles country
    /// </summary>
    public class Seychelles : Country
    {
        /// <summary>
        /// get the Seychelles country instance
        /// </summary>
        public static Seychelles Instance = new Seychelles(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Seychelles", common: "Seychelles") },
                { "crs", new CountryName(official: "Repiblik Sesel", common: "Sesel") },
                { "fra", new CountryName(official: "République des Seychelles", common: "Seychelles") },
                { "ara", new CountryName(official: "جمهورية سيشل", common: "سيشل") },
                { "ces", new CountryName(official: "Seychelská republika", common: "Seychely") },
                { "cym", new CountryName(official: "Republic of Seychelles", common: "Seychelles") },
                { "deu", new CountryName(official: "Republik der Seychellen", common: "Seychellen") },
                { "est", new CountryName(official: "Seišelli Vabariik", common: "Seišellid") },
                { "fin", new CountryName(official: "Seychellien tasavalta", common: "Seychellit") },
                { "hrv", new CountryName(official: "Republika Sejšeli", common: "Sejšeli") },
                { "hun", new CountryName(official: "Seychelle Köztársaság", common: "Seychelle-szigetek") },
                { "ita", new CountryName(official: "Repubblica delle Seychelles", common: "Seychelles") },
                { "jpn", new CountryName(official: "セイシェル共和国", common: "セーシェル") },
                { "kor", new CountryName(official: "세이셸 공화국", common: "세이셸") },
                { "nld", new CountryName(official: "Republiek der Seychellen", common: "Seychellen") },
                { "per", new CountryName(official: "جمهوری سیشل", common: "سیشل") },
                { "pol", new CountryName(official: "Republika Seszeli", common: "Seszele") },
                { "por", new CountryName(official: "República das Seychelles", common: "Seicheles") },
                { "rus", new CountryName(official: "Республика Сейшельские Острова", common: "Сейшельские Острова") },
                { "slk", new CountryName(official: "Seychelská republika", common: "Seychely") },
                { "spa", new CountryName(official: "República de las Seychelles", common: "Seychelles") },
                { "swe", new CountryName(official: "Republiken Seychellerna", common: "Seychellerna") },
                { "urd", new CountryName(official: "جمہوریہ سیچیلیس", common: "سیچیلیس") },
                { "zho", new CountryName(official: "塞舌尔共和国", common: "塞舌尔") },

            },
            cca2: "SC",
            cca3: "SYC",
            ccn3: "690",
            cioc: "SEY",
            flag: "🇸🇨",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"48", }),
            borders: new string[] {  },
            capital: new string[] { "Victoria",  },
            altSpellings: new string[] { "SC", "Republic of Seychelles", "Repiblik Sesel", "République des Seychelles",  },
            tld: new string[] { ".sc",  },
            latlng: new double[] { -4.58333333, 55.66666666,  },
            timezones: new string[] { "UTC+04:00",  },
            languages: new Language[]
            {
                new Language(name: "Seychellois Creole", iso6391: "", iso6392: "crs"),
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "SCR", name: "Seychellois rupee", symbol: "₨"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Seychellois", female: "Seychellois") },
                { "fra", new DemonymsGender(male: "Seychellois", female: "Seychellois") },
            }
        );

        /// <summary>
        /// create an instance of Seychelles country
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
        private Seychelles(
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
