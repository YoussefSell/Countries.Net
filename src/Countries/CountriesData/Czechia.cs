namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Czechia country
    /// </summary>
    public class Czechia : Country
    {
        /// <summary>
        /// get the Czechia country instance
        /// </summary>
        public static Czechia Instance = new Czechia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Czech Republic", common: "Czechia") },
                { "ces", new CountryName(official: "Česká republika", common: "Česko") },
                { "slk", new CountryName(official: "Česká republika", common: "Česko") },
                { "ara", new CountryName(official: "جمهورية التشيك", common: "التشيك") },
                { "cym", new CountryName(official: "Y Weriniaeth Tsiec", common: "Y Weriniaeth Tsiec") },
                { "deu", new CountryName(official: "Tschechische Republik", common: "Tschechien") },
                { "est", new CountryName(official: "Tšehhi Vabariik", common: "Tšehhi") },
                { "fin", new CountryName(official: "Tšekin tasavalta", common: "Tšekki") },
                { "fra", new CountryName(official: "République tchèque", common: "Tchéquie") },
                { "hrv", new CountryName(official: "Češka", common: "Češka") },
                { "hun", new CountryName(official: "Cseh Köztársaság", common: "Csehország") },
                { "ita", new CountryName(official: "Repubblica Ceca", common: "Cechia") },
                { "jpn", new CountryName(official: "チェコ共和国", common: "チェコ") },
                { "kor", new CountryName(official: "체코", common: "체코") },
                { "nld", new CountryName(official: "Tsjechische Republiek", common: "Tsjechië") },
                { "per", new CountryName(official: "جمهوری چک", common: "جمهوری چک") },
                { "pol", new CountryName(official: "Republika Czeska", common: "Czechy") },
                { "por", new CountryName(official: "República Checa", common: "Chéquia") },
                { "rus", new CountryName(official: "Чешская Республика", common: "Чехия") },
                { "spa", new CountryName(official: "República Checa", common: "Chequia") },
                { "swe", new CountryName(official: "Republiken Tjeckien", common: "Tjeckien") },
                { "urd", new CountryName(official: "چيک جمہوريہ", common: "چيک") },
                { "zho", new CountryName(official: "捷克共和国", common: "捷克") },

            },
            cca2: "CZ",
            cca3: "CZE",
            ccn3: "203",
            cioc: "CZE",
            flag: "🇨🇿",
            region: Region.Europe,
            subregion: "Central Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"20", }),
            borders: new string[] { "AUT", "DEU", "POL", "SVK",  },
            capital: new string[] { "Prague",  },
            altSpellings: new string[] { "CZ", "Česká republika", "Česko",  },
            tld: new string[] { ".cz",  },
            latlng: new double[] { 49.75, 15.5,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Czech", iso6391: "cs", iso6392: "ces"),
                new Language(name: "Slovak", iso6391: "sk", iso6392: "slk"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "CZK", name: "Czech koruna", symbol: "Kč"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Czech", female: "Czech") },
                { "fra", new DemonymsGender(male: "Czech", female: "Czech") },
            }
        );

        /// <summary>
        /// create an instance of Czechia country
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
        private Czechia(
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
