namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Latvia country
    /// </summary>
    public class Latvia : Country
    {
        /// <summary>
        /// get the Latvia country instance
        /// </summary>
        public static Latvia Instance = new Latvia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Latvia", common: "Latvia") },
                { "lav", new CountryName(official: "Latvijas Republikas", common: "Latvija") },
                { "ara", new CountryName(official: "جمهورية لاتفيا", common: "لاتفيا") },
                { "ces", new CountryName(official: "Lotyšská republika", common: "Lotyšsko") },
                { "cym", new CountryName(official: "Republic of Latvia", common: "Latvia") },
                { "deu", new CountryName(official: "Republik Lettland", common: "Lettland") },
                { "est", new CountryName(official: "Läti Vabariik", common: "Läti") },
                { "fin", new CountryName(official: "Latvian tasavalta", common: "Latvia") },
                { "fra", new CountryName(official: "République de Lettonie", common: "Lettonie") },
                { "hrv", new CountryName(official: "Republika Latvija", common: "Latvija") },
                { "hun", new CountryName(official: "Lett Köztársaság", common: "Lettország") },
                { "ita", new CountryName(official: "Repubblica di Lettonia", common: "Lettonia") },
                { "jpn", new CountryName(official: "ラトビア共和国", common: "ラトビア") },
                { "kor", new CountryName(official: "라트비아 공화국", common: "라트비아") },
                { "nld", new CountryName(official: "Republiek Letland", common: "Letland") },
                { "per", new CountryName(official: "جمهوری لتونی", common: "لتونی") },
                { "pol", new CountryName(official: "Republika Łotewska", common: "Łotwa") },
                { "por", new CountryName(official: "República da Letónia", common: "Letónia") },
                { "rus", new CountryName(official: "Латвийская Республика", common: "Латвия") },
                { "slk", new CountryName(official: "Lotyšská republika", common: "Lotyšsko") },
                { "spa", new CountryName(official: "República de Letonia", common: "Letonia") },
                { "swe", new CountryName(official: "Republiken Lettland", common: "Lettland") },
                { "urd", new CountryName(official: "جمہوریہ لٹویا", common: "لٹویا") },
                { "zho", new CountryName(official: "拉脱维亚共和国", common: "拉脱维亚") },
            },
            cca2: "LV",
            cca3: "LVA",
            ccn3: "428",
            cioc: "LAT",
            flag: "🇱🇻",
            region: Region.Europe,
            subregion: "Northern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"71", }),
            borders: new string[] { "BLR", "EST", "LTU", "RUS",  },
            capital: new string[] { "Riga",  },
            altSpellings: new string[] { "LV", "Republic of Latvia", "Latvijas Republika",  },
            tld: new string[] { ".lv",  },
            latlng: new double[] { 57, 25,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Latvian", iso6391: "lv", iso6392: "lav"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Latvian", female: "Latvian") },
                { "fra", new DemonymsGender(male: "Latvian", female: "Latvian") },
            }
        );

        /// <summary>
        /// create an instance of Latvia country
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
        private Latvia(
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
