namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Vanuatu country
    /// </summary>
    public class Vanuatu : Country
    {
        /// <summary>
        /// get the Vanuatu country instance
        /// </summary>
        public static Vanuatu Instance = new Vanuatu(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Vanuatu", common: "Vanuatu") },
                { "bis", new CountryName(official: "Ripablik blong Vanuatu", common: "Vanuatu") },
                { "fra", new CountryName(official: "République de Vanuatu", common: "Vanuatu") },
                { "ara", new CountryName(official: "جمهورية فانواتو", common: "فانواتو") },
                { "ces", new CountryName(official: "Republika Vanuatu", common: "Vanuatu") },
                { "cym", new CountryName(official: "Republic of Vanuatu", common: "Vanuatu") },
                { "deu", new CountryName(official: "Vanuatu", common: "Vanuatu") },
                { "est", new CountryName(official: "Vanuatu Vabariik", common: "Vanuatu") },
                { "fin", new CountryName(official: "Vanuatun tasavalta", common: "Vanuatu") },
                { "hrv", new CountryName(official: "Republika Vanuatu", common: "Vanuatu") },
                { "hun", new CountryName(official: "Vanuatui Köztársaság", common: "Vanuatu") },
                { "ita", new CountryName(official: "Repubblica di Vanuatu", common: "Vanuatu") },
                { "jpn", new CountryName(official: "バヌアツ共和国", common: "バヌアツ") },
                { "kor", new CountryName(official: "바누아투 공화국", common: "바누아투") },
                { "nld", new CountryName(official: "Republiek Vanuatu", common: "Vanuatu") },
                { "per", new CountryName(official: "جمهوری وانواتو", common: "وانواتو") },
                { "pol", new CountryName(official: "Republika Vanuatu", common: "Vanuatu") },
                { "por", new CountryName(official: "República de Vanuatu", common: "Vanuatu") },
                { "rus", new CountryName(official: "Республика Вануату", common: "Вануату") },
                { "slk", new CountryName(official: "Vanuatská republika", common: "Vanuatu") },
                { "spa", new CountryName(official: "República de Vanuatu", common: "Vanuatu") },
                { "swe", new CountryName(official: "Republiken Vanuatu", common: "Vanuatu") },
                { "urd", new CountryName(official: "جمہوریہ وانواتو", common: "وانواتو") },
                { "zho", new CountryName(official: "瓦努阿图共和国", common: "瓦努阿图") },

            },
            cca2: "VU",
            cca3: "VUT",
            ccn3: "548",
            cioc: "VAN",
            flag: "🇻🇺",
            region: Region.Oceania,
            subregion: "Melanesia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"78", }),
            borders: new string[] {  },
            capital: new string[] { "Port Vila",  },
            altSpellings: new string[] { "VU", "Republic of Vanuatu", "Ripablik blong Vanuatu", "République de Vanuatu",  },
            tld: new string[] { ".vu",  },
            latlng: new double[] { -16, 167,  },
            timezones: new string[] { "UTC+11:00",  },
            languages: new Language[]
            {
                new Language(name: "Bislama", iso6391: "", iso6392: "bis"),
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "VUV", name: "Vanuatu vatu", symbol: "Vt"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Ni-Vanuatu", female: "Ni-Vanuatu") },
                { "fra", new DemonymsGender(male: "Ni-Vanuatu", female: "Ni-Vanuatu") },
            }
        );

        /// <summary>
        /// create an instance of Vanuatu country
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
        private Vanuatu(
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
