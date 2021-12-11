namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Mozambique country
    /// </summary>
    public class Mozambique : Country
    {
        /// <summary>
        /// get the Mozambique country instance
        /// </summary>
        public static Mozambique Instance = new Mozambique(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Mozambique", common: "Mozambique") },
                { "por", new CountryName(official: "República de Moçambique", common: "Moçambique") },
                { "ara", new CountryName(official: "جمهورية موزمبيق", common: "موزمبيق") },
                { "ces", new CountryName(official: "Mosambická republika", common: "Mosambik") },
                { "cym", new CountryName(official: "Republic of Mozambique", common: "Mozambique") },
                { "deu", new CountryName(official: "Republik Mosambik", common: "Mosambik") },
                { "est", new CountryName(official: "Mosambiigi Vabariik", common: "Mosambiik") },
                { "fin", new CountryName(official: "Mosambikin tasavalta", common: "Mosambik") },
                { "fra", new CountryName(official: "République du Mozambique", common: "Mozambique") },
                { "hrv", new CountryName(official: "Republika Mozambiku", common: "Mozambik") },
                { "hun", new CountryName(official: "Mozambiki Köztársaság", common: "Mozambik") },
                { "ita", new CountryName(official: "Repubblica del Mozambico", common: "Mozambico") },
                { "jpn", new CountryName(official: "モザンビーク共和国", common: "モザンビーク") },
                { "kor", new CountryName(official: "모잠비크 공화국", common: "모잠비크") },
                { "nld", new CountryName(official: "Republiek Mozambique", common: "Mozambique") },
                { "per", new CountryName(official: "جمهوری موزامبیک", common: "موزامبیک") },
                { "pol", new CountryName(official: "Republika Mozambiku", common: "Mozambik") },
                { "rus", new CountryName(official: "Республика Мозамбик", common: "Мозамбик") },
                { "slk", new CountryName(official: "Mozambická republika", common: "Mozambik") },
                { "spa", new CountryName(official: "República de Mozambique", common: "Mozambique") },
                { "swe", new CountryName(official: "Republiken Moçambique", common: "Moçambique") },
                { "urd", new CountryName(official: "جمہوریہ موزمبیق", common: "موزمبیق") },
                { "zho", new CountryName(official: "莫桑比克共和国", common: "莫桑比克") },

            },
            cca2: "MZ",
            cca3: "MOZ",
            ccn3: "508",
            cioc: "MOZ",
            flag: "🇲🇿",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"58", }),
            borders: new string[] { "MWI", "ZAF", "SWZ", "TZA", "ZMB", "ZWE",  },
            capital: new string[] { "Maputo",  },
            altSpellings: new string[] { "MZ", "Republic of Mozambique", "República de Moçambique",  },
            tld: new string[] { ".mz",  },
            latlng: new double[] { -18.25, 35,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Portuguese", iso6391: "pt", iso6392: "por"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "MZN", name: "Mozambican metical", symbol: "MT"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Mozambican", female: "Mozambican") },
                { "fra", new DemonymsGender(male: "Mozambican", female: "Mozambican") },
            }
        );

        /// <summary>
        /// create an instance of Mozambique country
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
        private Mozambique(
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
