namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Micronesia country
    /// </summary>
    public class Micronesia : Country
    {
        /// <summary>
        /// get the Micronesia country instance
        /// </summary>
        public static Micronesia Instance = new Micronesia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Federated States of Micronesia", common: "Micronesia") },
                { "ara", new CountryName(official: "ولايات ميكرونيسيا المتحدة", common: "ميكرونيسيا") },
                { "ces", new CountryName(official: "Federativní státy Mikronésie", common: "Mikronésie") },
                { "cym", new CountryName(official: "Federated States of Micronesia", common: "Micronesia") },
                { "deu", new CountryName(official: "Föderierte Staaten von Mikronesien", common: "Mikronesien") },
                { "est", new CountryName(official: "Mikroneesia Liiduriigid", common: "Mikroneesia") },
                { "fin", new CountryName(official: "Mikronesian liittovaltio", common: "Mikronesia") },
                { "fra", new CountryName(official: "États fédérés de Micronésie", common: "Micronésie") },
                { "hrv", new CountryName(official: "Savezne Države Mikronezije", common: "Mikronezija") },
                { "hun", new CountryName(official: "Mikronéziai Szövetségi Államok", common: "Mikronéziai Szövetségi Államok") },
                { "ita", new CountryName(official: "Stati federati di Micronesia", common: "Micronesia") },
                { "jpn", new CountryName(official: "ミクロネシア連邦", common: "ミクロネシア連邦") },
                { "kor", new CountryName(official: "미크로네시아 연방", common: "미크로네시아") },
                { "nld", new CountryName(official: "Federale Staten van Micronesia", common: "Micronesië") },
                { "per", new CountryName(official: "ایالات فدرال میکرونزی", common: "میکرونزی") },
                { "pol", new CountryName(official: "Sfederowane Stany Mikronezji", common: "Mikronezja") },
                { "por", new CountryName(official: "Estados Federados da Micronésia", common: "Micronésia") },
                { "rus", new CountryName(official: "Федеративные Штаты Микронезии", common: "Федеративные Штаты Микронезии") },
                { "slk", new CountryName(official: "Mikronézske federatívne štáty", common: "Mikronézia") },
                { "spa", new CountryName(official: "Estados Federados de Micronesia", common: "Micronesia") },
                { "swe", new CountryName(official: "Mikronesiska federationen", common: "Mikronesiska federationen") },
                { "urd", new CountryName(official: "ریاستہائے وفاقیہ مائکرونیشیا", common: "مائکرونیشیا") },
                { "zho", new CountryName(official: "密克罗尼西亚联邦", common: "密克罗尼西亚") },
            },
            cca2: "FM",
            cca3: "FSM",
            ccn3: "583",
            cioc: "FSM",
            flag: "🇫🇲",
            region: Region.Oceania,
            subregion: "Micronesia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"91", }),
            borders: new string[] {  },
            capital: new string[] { "Palikir",  },
            altSpellings: new string[] { "FM", "Federated States of Micronesia", "Micronesia, Federated States of",  },
            tld: new string[] { ".fm",  },
            latlng: new double[] { 6.91666666, 158.25,  },
            timezones: new string[] { "UTC+10:00", "UTC+11",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "USD", name: "United States dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Micronesian", female: "Micronesian") },
                { "fra", new DemonymsGender(male: "Micronesian", female: "Micronesian") },
            }
        );

        /// <summary>
        /// create an instance of Micronesia country
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
        private Micronesia(
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
