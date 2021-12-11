namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Botswana country
    /// </summary>
    public class Botswana : Country
    {
        /// <summary>
        /// get the Botswana country instance
        /// </summary>
        public static Botswana Instance = new Botswana(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Botswana", common: "Botswana") },
                { "tsn", new CountryName(official: "Lefatshe la Botswana", common: "Botswana") },
                { "ara", new CountryName(official: "جمهورية بوتسوانا", common: "بوتسوانا") },
                { "ces", new CountryName(official: "Botswanská republika", common: "Botswana") },
                { "cym", new CountryName(official: "Republic of Botswana", common: "Botswana") },
                { "deu", new CountryName(official: "Republik Botsuana", common: "Botswana") },
                { "est", new CountryName(official: "Botswana Vabariik", common: "Botswana") },
                { "fin", new CountryName(official: "Botswanan tasavalta", common: "Botswana") },
                { "fra", new CountryName(official: "République du Botswana", common: "Botswana") },
                { "hrv", new CountryName(official: "Republika Bocvana", common: "Bocvana") },
                { "hun", new CountryName(official: "Botswanai Köztársaság", common: "Botswana") },
                { "ita", new CountryName(official: "Repubblica del Botswana", common: "Botswana") },
                { "jpn", new CountryName(official: "ボツワナ共和国", common: "ボツワナ") },
                { "kor", new CountryName(official: "보츠와나 공화국", common: "보츠와나") },
                { "nld", new CountryName(official: "Republiek Botswana", common: "Botswana") },
                { "per", new CountryName(official: "جمهوری بوتسوانا", common: "بوتسوانا") },
                { "pol", new CountryName(official: "Republika Botswany", common: "Botswana") },
                { "por", new CountryName(official: "República do Botswana", common: "Botswana") },
                { "rus", new CountryName(official: "Республика Ботсвана", common: "Ботсвана") },
                { "slk", new CountryName(official: "Botswanská republika", common: "Botswana") },
                { "spa", new CountryName(official: "República de Botswana", common: "Botswana") },
                { "swe", new CountryName(official: "Republiken Botswana", common: "Botswana") },
                { "urd", new CountryName(official: "جمہوریہ بوٹسوانا", common: "بوٹسوانا") },
                { "zho", new CountryName(official: "博茨瓦纳共和国", common: "博茨瓦纳") },
            },
            cca2: "BW",
            cca3: "BWA",
            ccn3: "072",
            cioc: "BOT",
            flag: "🇧🇼",
            region: Region.Africa,
            subregion: "Southern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"67", }),
            borders: new string[] { "NAM", "ZAF", "ZMB", "ZWE",  },
            capital: new string[] { "Gaborone",  },
            altSpellings: new string[] { "BW", "Republic of Botswana", "Lefatshe la Botswana",  },
            tld: new string[] { ".bw",  },
            latlng: new double[] { -22, 24,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Tswana", iso6391: "tn", iso6392: "tsn"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "BWP", name: "Botswana pula", symbol: "P"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Motswana", female: "Motswana") },
                { "fra", new DemonymsGender(male: "Motswana", female: "Motswana") },
            }
        );

        /// <summary>
        /// create an instance of Botswana country
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
        private Botswana(
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
