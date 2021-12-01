namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of CentralAfricanRepublic country
    /// </summary>
    public class CentralAfricanRepublic : Country
    {
        /// <summary>
        /// get the CentralAfricanRepublic country instance
        /// </summary>
        public static CentralAfricanRepublic Instance = new CentralAfricanRepublic(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Central African Republic", common: "Central African Republic") },
                { "fra", new CountryName(official: "République centrafricaine", common: "République centrafricaine") },
                { "sag", new CountryName(official: "Ködörösêse tî Bêafrîka", common: "Bêafrîka") },
                { "ara", new CountryName(official: "جمهورية أفريقيا الوسطى", common: "جمهورية أفريقيا الوسطى") },
                { "ces", new CountryName(official: "Středoafrická republika", common: "Středoafrická republika") },
                { "cym", new CountryName(official: "Gweriniaeth Canolbarth Affrica", common: "Gweriniaeth Canolbarth Affrica") },
                { "deu", new CountryName(official: "Zentralafrikanische Republik", common: "Zentralafrikanische Republik") },
                { "est", new CountryName(official: "Kesk-Aafrika Vabariik", common: "Kesk-Aafrika Vabariik") },
                { "fin", new CountryName(official: "Keski-Afrikan tasavalta", common: "Keski-Afrikan tasavalta") },
                { "hrv", new CountryName(official: "Centralna Afrička Republika", common: "Srednjoafrička Republika") },
                { "hun", new CountryName(official: "Közép-afrikai Köztársaság", common: "Közép-afrikai Köztársaság") },
                { "ita", new CountryName(official: "Repubblica Centrafricana", common: "Repubblica Centrafricana") },
                { "jpn", new CountryName(official: "中央アフリカ共和国", common: "中央アフリカ共和国") },
                { "kor", new CountryName(official: "중앙아프리카 공화국", common: "중앙아프리카 공화국") },
                { "nld", new CountryName(official: "Centraal-Afrikaanse Republiek", common: "Centraal-Afrikaanse Republiek") },
                { "per", new CountryName(official: "جمهوری آفریقای مرکزی", common: "جمهوری آفریقای مرکزی") },
                { "pol", new CountryName(official: "Republika Środkowoafrykańska", common: "Republika Środkowoafrykańska") },
                { "por", new CountryName(official: "República Centro-Africano", common: "República Centro-Africana") },
                { "rus", new CountryName(official: "Центрально-Африканская Республика", common: "Центральноафриканская Республика") },
                { "slk", new CountryName(official: "Stredoafrická republika", common: "Stredoafrická republika") },
                { "spa", new CountryName(official: "República Centroafricana", common: "República Centroafricana") },
                { "swe", new CountryName(official: "Centralafrikanska republiken", common: "Centralafrikanska republiken") },
                { "urd", new CountryName(official: "وسطی افریقی جمہوریہ", common: "وسطی افریقی جمہوریہ") },
                { "zho", new CountryName(official: "中非共和国", common: "中非共和国") },

            },
            cca2: "CF",
            cca3: "CAF",
            ccn3: "140",
            cioc: "CAF",
            flag: "🇨🇫",
            region: Region.Africa,
            subregion: "Middle Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"36", }),
            borders: new string[] { "CMR", "TCD", "COD", "COG", "SSD", "SDN",  },
            capital: new string[] { "Bangui",  },
            altSpellings: new string[] { "CF", "Central African Republic", "République centrafricaine",  },
            tld: new string[] { ".cf",  },
            latlng: new double[] { 7, 21,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
                new Language(name: "Sango", iso6391: "sg", iso6392: "sag"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XAF", name: "Central African CFA franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Central African", female: "Central African") },
                { "fra", new DemonymsGender(male: "Central African", female: "Central African") },
            }
        );

        /// <summary>
        /// create an instance of CentralAfricanRepublic country
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
        private CentralAfricanRepublic(
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
