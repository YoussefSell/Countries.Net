namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Lithuania country
    /// </summary>
    public class Lithuania : Country
    {
        /// <summary>
        /// get the Lithuania country instance
        /// </summary>
        public static Lithuania Instance = new Lithuania(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Lithuania", common: "Lithuania") },
                { "lit", new CountryName(official: "Lietuvos Respublikos", common: "Lietuva") },
                { "ara", new CountryName(official: "جمهورية ليتوانيا", common: "ليتوانيا") },
                { "ces", new CountryName(official: "Litevská republika", common: "Litva") },
                { "cym", new CountryName(official: "Republic of Lithuania", common: "Lithuania") },
                { "deu", new CountryName(official: "Republik Litauen", common: "Litauen") },
                { "est", new CountryName(official: "Leedu Vabariik", common: "Leedu") },
                { "fin", new CountryName(official: "Liettuan tasavalta", common: "Liettua") },
                { "fra", new CountryName(official: "République de Lituanie", common: "Lituanie") },
                { "hrv", new CountryName(official: "Republika Litva", common: "Litva") },
                { "hun", new CountryName(official: "Litván Köztársaság", common: "Litvánia") },
                { "ita", new CountryName(official: "Repubblica di Lituania", common: "Lituania") },
                { "jpn", new CountryName(official: "リトアニア共和国", common: "リトアニア") },
                { "kor", new CountryName(official: "리투아니아 공화국", common: "리투아니아") },
                { "nld", new CountryName(official: "Republiek Litouwen", common: "Litouwen") },
                { "per", new CountryName(official: "لیتوانیایی‌ها", common: "لیتوانیایی‌ها") },
                { "pol", new CountryName(official: "Republika Litewska", common: "Litwa") },
                { "por", new CountryName(official: "República da Lituânia", common: "Lituânia") },
                { "rus", new CountryName(official: "Литовская Республика", common: "Литва") },
                { "slk", new CountryName(official: "Litovská republika", common: "Litva") },
                { "spa", new CountryName(official: "República de Lituania", common: "Lituania") },
                { "swe", new CountryName(official: "Republiken Litauen", common: "Litauen") },
                { "urd", new CountryName(official: "جمہوریہ لتھووینیا", common: "لتھووینیا") },
                { "zho", new CountryName(official: "立陶宛共和国", common: "立陶宛") },
            },
            cca2: "LT",
            cca3: "LTU",
            ccn3: "440",
            cioc: "LTU",
            flag: "🇱🇹",
            region: Region.Europe,
            subregion: "Northern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"70", }),
            borders: new string[] { "BLR", "LVA", "POL", "RUS",  },
            capital: new string[] { "Vilnius",  },
            altSpellings: new string[] { "LT", "Republic of Lithuania", "Lietuvos Respublika",  },
            tld: new string[] { ".lt",  },
            latlng: new double[] { 56, 24,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Lithuanian", iso6391: "lt", iso6392: "lit"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Lithuanian", female: "Lithuanian") },
                { "fra", new DemonymsGender(male: "Lithuanian", female: "Lithuanian") },
            }
        );

        /// <summary>
        /// create an instance of Lithuania country
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
        private Lithuania(
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
