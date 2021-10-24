namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Chad country
    /// </summary>
    public class Chad : Country
    {
        /// <summary>
        /// get the Chad country instance
        /// </summary>
        public static Chad Instance = new Chad(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Chad", common: "Chad") },
                { "ara", new CountryName(official: "جمهورية تشاد", common: "تشاد‎") },
                { "fra", new CountryName(official: "République du Tchad", common: "Tchad") },
                { "ces", new CountryName(official: "Čadská republika", common: "Čad") },
                { "cym", new CountryName(official: "Gweriniaeth Tsiad", common: "Tsiad") },
                { "deu", new CountryName(official: "Republik Tschad", common: "Tschad") },
                { "est", new CountryName(official: "Tšaadi Vabariik", common: "Tšaad") },
                { "fin", new CountryName(official: "Tšadin tasavalta", common: "Tšad") },
                { "hrv", new CountryName(official: "Čadu", common: "Čad") },
                { "hun", new CountryName(official: "Csád Köztársaság", common: "Csád") },
                { "ita", new CountryName(official: "Repubblica del Ciad", common: "Ciad") },
                { "jpn", new CountryName(official: "チャド共和国", common: "チャド") },
                { "kor", new CountryName(official: "차드 공화국", common: "차드") },
                { "nld", new CountryName(official: "Republiek Tsjaad", common: "Tsjaad") },
                { "per", new CountryName(official: "جمهوری چاد", common: "چاد") },
                { "pol", new CountryName(official: "Republika Czadu", common: "Czad") },
                { "por", new CountryName(official: "República do Chade", common: "Chade") },
                { "rus", new CountryName(official: "Республика Чад", common: "Чад") },
                { "slk", new CountryName(official: "Čadská republika", common: "Čad") },
                { "spa", new CountryName(official: "República de Chad", common: "Chad") },
                { "swe", new CountryName(official: "Republiken Tchad", common: "Tchad") },
                { "urd", new CountryName(official: "جمہوریہ چاڈ", common: "چاڈ") },
                { "zho", new CountryName(official: "乍得共和国", common: "乍得") },

            },
            cca2: "TD",
            cca3: "TCD",
            ccn3: "148",
            cioc: "CHA",
            flag: "🇹🇩",
            region: Region.Africa,
            subregion: "Middle Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"35", }),
            borders: new string[] { "CMR", "CAF", "LBY", "NER", "NGA", "SDN",  },
            capital: new string[] { "N'Djamena",  },
            altSpellings: new string[] { "TD", "Tchad", "Republic of Chad", "République du Tchad",  },
            tld: new string[] { ".td",  },
            latlng: new double[] { 15, 19,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XAF", name: "Central African CFA franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Chadian", female: "Chadian") },
                { "fra", new DemonymsGender(male: "Chadian", female: "Chadian") },
            }
        );

        /// <summary>
        /// create an instance of Chad country
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
        private Chad(
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
