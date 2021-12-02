namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Zimbabwe country
    /// </summary>
    public class Zimbabwe : Country
    {
        /// <summary>
        /// get the Zimbabwe country instance
        /// </summary>
        public static Zimbabwe Instance = new Zimbabwe(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Zimbabwe", common: "Zimbabwe") },
                { "bwg", new CountryName(official: "Republic of Zimbabwe", common: "Zimbabwe") },
                { "kck", new CountryName(official: "Republic of Zimbabwe", common: "Zimbabwe") },
                { "khi", new CountryName(official: "Republic of Zimbabwe", common: "Zimbabwe") },
                { "ndc", new CountryName(official: "Republic of Zimbabwe", common: "Zimbabwe") },
                { "nde", new CountryName(official: "Republic of Zimbabwe", common: "Zimbabwe") },
                { "nya", new CountryName(official: "Republic of Zimbabwe", common: "Zimbabwe") },
                { "sna", new CountryName(official: "Republic of Zimbabwe", common: "Zimbabwe") },
                { "sot", new CountryName(official: "Republic of Zimbabwe", common: "Zimbabwe") },
                { "toi", new CountryName(official: "Republic of Zimbabwe", common: "Zimbabwe") },
                { "tsn", new CountryName(official: "Republic of Zimbabwe", common: "Zimbabwe") },
                { "tso", new CountryName(official: "Republic of Zimbabwe", common: "Zimbabwe") },
                { "ven", new CountryName(official: "Republic of Zimbabwe", common: "Zimbabwe") },
                { "xho", new CountryName(official: "Republic of Zimbabwe", common: "Zimbabwe") },
                { "zib", new CountryName(official: "Republic of Zimbabwe", common: "Zimbabwe") },
                { "ara", new CountryName(official: "جمهورية زيمبابوي", common: "زيمبابوي") },
                { "ces", new CountryName(official: "Zimbabwská republika", common: "Zimbabwe") },
                { "cym", new CountryName(official: "Republic of Zimbabwe", common: "Zimbabwe") },
                { "deu", new CountryName(official: "Republik Simbabwe", common: "Simbabwe") },
                { "est", new CountryName(official: "Zimbabwe Vabariik", common: "Zimbabwe") },
                { "fin", new CountryName(official: "Zimbabwen tasavalta", common: "Zimbabwe") },
                { "fra", new CountryName(official: "République du Zimbabwe", common: "Zimbabwe") },
                { "hrv", new CountryName(official: "Republika Zimbabve", common: "Zimbabve") },
                { "hun", new CountryName(official: "Zimbabwei Köztársaság", common: "Zimbabwe") },
                { "ita", new CountryName(official: "Repubblica dello Zimbabwe", common: "Zimbabwe") },
                { "jpn", new CountryName(official: "ジンバブエ共和国", common: "ジンバブエ") },
                { "kor", new CountryName(official: "짐바브웨 공화국", common: "짐바브웨") },
                { "nld", new CountryName(official: "Republiek Zimbabwe", common: "Zimbabwe") },
                { "per", new CountryName(official: "جمهوری زیمبابوه", common: "زیمبابوه") },
                { "pol", new CountryName(official: "Republika Zimbabwe", common: "Zimbabwe") },
                { "por", new CountryName(official: "República do Zimbabwe", common: "Zimbabwe") },
                { "rus", new CountryName(official: "Республика Зимбабве", common: "Зимбабве") },
                { "slk", new CountryName(official: "Zimbabwianska republika", common: "Zimbabwe") },
                { "spa", new CountryName(official: "República de Zimbabue", common: "Zimbabue") },
                { "swe", new CountryName(official: "Republiken Zimbabwe", common: "Zimbabwe") },
                { "urd", new CountryName(official: "جمہوریہ زمبابوے", common: "زمبابوے") },
                { "zho", new CountryName(official: "津巴布韦共和国", common: "津巴布韦") },
            },
            cca2: "ZW",
            cca3: "ZWE",
            ccn3: "716",
            cioc: "ZIM",
            flag: "🇿🇼",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"63", }),
            borders: new string[] { "BWA", "MOZ", "ZAF", "ZMB",  },
            capital: new string[] { "Harare",  },
            altSpellings: new string[] { "ZW", "Republic of Zimbabwe",  },
            tld: new string[] { ".zw",  },
            latlng: new double[] { -20, 30,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Chibarwe", iso6391: "", iso6392: "bwg"),
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Kalanga", iso6391: "", iso6392: "kck"),
                new Language(name: "Khoisan", iso6391: "", iso6392: "khi"),
                new Language(name: "Ndau", iso6391: "", iso6392: "ndc"),
                new Language(name: "Northern Ndebele", iso6391: "nd", iso6392: "nde"),
                new Language(name: "Chewa", iso6391: "", iso6392: "nya"),
                new Language(name: "Shona", iso6391: "sn", iso6392: "sna"),
                new Language(name: "Sotho", iso6391: "st", iso6392: "sot"),
                new Language(name: "Tonga", iso6391: "", iso6392: "toi"),
                new Language(name: "Tswana", iso6391: "tn", iso6392: "tsn"),
                new Language(name: "Tsonga", iso6391: "ts", iso6392: "tso"),
                new Language(name: "Venda", iso6391: "ve", iso6392: "ven"),
                new Language(name: "Xhosa", iso6391: "xh", iso6392: "xho"),
                new Language(name: "Zimbabwean Sign Language", iso6391: "", iso6392: "zib"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "ZWL", name: "Zimbabwean dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Zimbabwean", female: "Zimbabwean") },
                { "fra", new DemonymsGender(male: "Zimbabwean", female: "Zimbabwean") },
            }
        );

        /// <summary>
        /// create an instance of Zimbabwe country
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
        private Zimbabwe(
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
