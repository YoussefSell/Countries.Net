namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Suriname country
    /// </summary>
    public class Suriname : Country
    {
        /// <summary>
        /// get the Suriname country instance
        /// </summary>
        public static Suriname Instance = new Suriname(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Suriname", common: "Suriname") },
                { "nld", new CountryName(official: "Republiek Suriname", common: "Suriname") },
                { "ara", new CountryName(official: "جمهورية سورينام", common: "سورينام") },
                { "ces", new CountryName(official: "Republika Surinam", common: "Surinam") },
                { "cym", new CountryName(official: "Republic of Suriname", common: "Suriname") },
                { "deu", new CountryName(official: "Republik Suriname", common: "Suriname") },
                { "est", new CountryName(official: "Suriname Vabariik", common: "Suriname") },
                { "fin", new CountryName(official: "Surinamen tasavalta", common: "Suriname") },
                { "fra", new CountryName(official: "République du Suriname", common: "Surinam") },
                { "hrv", new CountryName(official: "Republika Surinam", common: "Surinam") },
                { "hun", new CountryName(official: "Suriname Köztársaság", common: "Suriname") },
                { "ita", new CountryName(official: "Repubblica del Suriname", common: "Suriname") },
                { "jpn", new CountryName(official: "スリナム共和国", common: "スリナム") },
                { "kor", new CountryName(official: "수리남 공화국", common: "수리남") },
                { "per", new CountryName(official: "جمهوری سورینام", common: "سورینام") },
                { "pol", new CountryName(official: "Republika Surinamu", common: "Surinam") },
                { "por", new CountryName(official: "República do Suriname", common: "Suriname") },
                { "rus", new CountryName(official: "Республика Суринам", common: "Суринам") },
                { "slk", new CountryName(official: "Surinamská republika", common: "Surinam") },
                { "spa", new CountryName(official: "República de Suriname", common: "Surinam") },
                { "swe", new CountryName(official: "Republiken Surinam", common: "Surinam") },
                { "urd", new CountryName(official: "جمہوریہ سرینام", common: "سرینام") },
                { "zho", new CountryName(official: "苏里南共和国", common: "苏里南") },

            },
            cca2: "SR",
            cca3: "SUR",
            ccn3: "740",
            cioc: "SUR",
            flag: "🇸🇷",
            region: Region.Americas,
            subregion: "South America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"97", }),
            borders: new string[] { "BRA", "GUF", "GUY",  },
            capital: new string[] { "Paramaribo",  },
            altSpellings: new string[] { "SR", "Sarnam", "Sranangron", "Republic of Suriname", "Republiek Suriname",  },
            tld: new string[] { ".sr",  },
            latlng: new double[] { 4, -56,  },
            timezones: new string[] { "UTC-03:00",  },
            languages: new Language[]
            {
                new Language(name: "Dutch", iso6391: "nl", iso6392: "nld"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "SRD", name: "Surinamese dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Surinamer", female: "Surinamer") },
                { "fra", new DemonymsGender(male: "Surinamer", female: "Surinamer") },
            }
        );

        /// <summary>
        /// create an instance of Suriname country
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
        private Suriname(
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
