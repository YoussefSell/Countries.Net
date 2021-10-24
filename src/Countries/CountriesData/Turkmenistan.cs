namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Turkmenistan country
    /// </summary>
    public class Turkmenistan : Country
    {
        /// <summary>
        /// get the Turkmenistan country instance
        /// </summary>
        public static Turkmenistan Instance = new Turkmenistan(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Turkmenistan", common: "Turkmenistan") },
                { "rus", new CountryName(official: "Туркменистан", common: "Туркмения") },
                { "tuk", new CountryName(official: "Türkmenistan", common: "Türkmenistan") },
                { "ara", new CountryName(official: "تركمانستان", common: "تركمانستان") },
                { "ces", new CountryName(official: "Turkmenistán", common: "Turkmenistán") },
                { "cym", new CountryName(official: "Turkmenistan", common: "Turkmenistan") },
                { "deu", new CountryName(official: "Turkmenistan", common: "Turkmenistan") },
                { "est", new CountryName(official: "Türkmenistan", common: "Türkmenistan") },
                { "fin", new CountryName(official: "Turkmenistan", common: "Turkmenistan") },
                { "fra", new CountryName(official: "Turkménistan", common: "Turkménistan") },
                { "hrv", new CountryName(official: "Turkmenistan", common: "Turkmenistan") },
                { "hun", new CountryName(official: "Türkmén Köztársaság", common: "Türkmenisztán") },
                { "ita", new CountryName(official: "Turkmenistan", common: "Turkmenistan") },
                { "jpn", new CountryName(official: "トルクメニスタン", common: "トルクメニスタン") },
                { "kor", new CountryName(official: "투르크메니스탄", common: "투르크메니스탄") },
                { "nld", new CountryName(official: "Turkmenistan", common: "Turkmenistan") },
                { "per", new CountryName(official: "جمهوری خلق ترکمنستان", common: "ترکمنستان") },
                { "pol", new CountryName(official: "Republika Turkmenistanu", common: "Turkmenistan") },
                { "por", new CountryName(official: "Turcomenistão", common: "Turquemenistão") },
                { "slk", new CountryName(official: "Turkménsko", common: "Turkménsko") },
                { "spa", new CountryName(official: "Turkmenistán", common: "Turkmenistán") },
                { "swe", new CountryName(official: "Turkmenistan", common: "Turkmenistan") },
                { "urd", new CountryName(official: "ترکمانستان", common: "ترکمانستان") },
                { "zho", new CountryName(official: "土库曼斯坦", common: "土库曼斯坦") },

            },
            cca2: "TM",
            cca3: "TKM",
            ccn3: "795",
            cioc: "TKM",
            flag: "🇹🇲",
            region: Region.Asia,
            subregion: "Central Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"93", }),
            borders: new string[] { "AFG", "IRN", "KAZ", "UZB",  },
            capital: new string[] { "Ashgabat",  },
            altSpellings: new string[] { "TM",  },
            tld: new string[] { ".tm",  },
            latlng: new double[] { 40, 60,  },
            timezones: new string[] { "UTC+05:00",  },
            languages: new Language[]
            {
                new Language(name: "Russian", iso6391: "ru", iso6392: "rus"),
                new Language(name: "Turkmen", iso6391: "tk", iso6392: "tuk"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "TMT", name: "Turkmenistan manat", symbol: "m"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Turkmen", female: "Turkmen") },
                { "fra", new DemonymsGender(male: "Turkmen", female: "Turkmen") },
            }
        );

        /// <summary>
        /// create an instance of Turkmenistan country
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
        private Turkmenistan(
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
