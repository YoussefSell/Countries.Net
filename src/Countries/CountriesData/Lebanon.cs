namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Lebanon country
    /// </summary>
    public class Lebanon : Country
    {
        /// <summary>
        /// get the Lebanon country instance
        /// </summary>
        public static Lebanon Instance = new Lebanon(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Lebanese Republic", common: "Lebanon") },
                { "ara", new CountryName(official: "الجمهورية اللبنانية", common: "لبنان") },
                { "fra", new CountryName(official: "République libanaise", common: "Liban") },
                { "ces", new CountryName(official: "Libanonská republika", common: "Libanon") },
                { "cym", new CountryName(official: "Lebanese Republic", common: "Lebanon") },
                { "deu", new CountryName(official: "Libanesische Republik", common: "Libanon") },
                { "est", new CountryName(official: "Liibanoni Vabariik", common: "Liibanon") },
                { "fin", new CountryName(official: "Libanonin tasavalta", common: "Libanon") },
                { "hrv", new CountryName(official: "Libanonska Republika", common: "Libanon") },
                { "hun", new CountryName(official: "Libanoni Köztársaság", common: "Libanon") },
                { "ita", new CountryName(official: "Repubblica libanese", common: "Libano") },
                { "jpn", new CountryName(official: "レバノン共和国", common: "レバノン") },
                { "kor", new CountryName(official: "레바논 공화국", common: "레바논") },
                { "nld", new CountryName(official: "Libanese Republiek", common: "Libanon") },
                { "per", new CountryName(official: "جمهوری لبنان", common: "لبنان") },
                { "pol", new CountryName(official: "Republika Libańska", common: "Liban") },
                { "por", new CountryName(official: "República Libanesa", common: "Líbano") },
                { "rus", new CountryName(official: "Ливанская Республика", common: "Ливан") },
                { "slk", new CountryName(official: "Libanonská republika", common: "Libanon") },
                { "spa", new CountryName(official: "República Libanesa", common: "Líbano") },
                { "swe", new CountryName(official: "Republiken Libanon", common: "Libanon") },
                { "urd", new CountryName(official: "جمہوریہ لبنان", common: "لبنان") },
                { "zho", new CountryName(official: "黎巴嫩共和国", common: "黎巴嫩") },

            },
            cca2: "LB",
            cca3: "LBN",
            ccn3: "422",
            cioc: "LBN",
            flag: "🇱🇧",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"61", }),
            borders: new string[] { "ISR", "SYR",  },
            capital: new string[] { "Beirut",  },
            altSpellings: new string[] { "LB", "Lebanese Republic", "Al-Jumhūrīyah Al-Libnānīyah",  },
            tld: new string[] { ".lb",  },
            latlng: new double[] { 33.83333333, 35.83333333,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "LBP", name: "Lebanese pound", symbol: "ل.ل"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Lebanese", female: "Lebanese") },
                { "fra", new DemonymsGender(male: "Lebanese", female: "Lebanese") },
            }
        );

        /// <summary>
        /// create an instance of Lebanon country
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
        private Lebanon(
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
