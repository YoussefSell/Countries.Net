namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Myanmar country
    /// </summary>
    public class Myanmar : Country
    {
        /// <summary>
        /// get the Myanmar country instance
        /// </summary>
        public static Myanmar Instance = new Myanmar(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of the Union of Myanmar", common: "Myanmar") },
                { "mya", new CountryName(official: "ပြည်ထောင်စု သမ္မတ မြန်မာနိုင်ငံတော်", common: "မြန်မာ") },
                { "ara", new CountryName(official: "جمهورية اتحاد ميانمار", common: "ميانمار") },
                { "ces", new CountryName(official: "Republika Myanmarský svaz", common: "Myanmar") },
                { "cym", new CountryName(official: "Republic of the Union of Myanmar", common: "Myanmar") },
                { "deu", new CountryName(official: "Republik der Union Myanmar", common: "Myanmar") },
                { "est", new CountryName(official: "Myanmari Liidu Vabariik", common: "Myanmar") },
                { "fin", new CountryName(official: "Myanmarin liiton tasavalta", common: "Myanmar") },
                { "fra", new CountryName(official: "République de l'Union du Myanmar", common: "Birmanie") },
                { "hrv", new CountryName(official: "Republika Unije Mijanmar", common: "Mijanmar") },
                { "hun", new CountryName(official: "Mianmari Államszövetség Köztársasága", common: "Mianmar") },
                { "ita", new CountryName(official: "Repubblica dell'Unione di Myanmar", common: "Birmania") },
                { "jpn", new CountryName(official: "ミャンマー連邦共和国", common: "ミャンマー") },
                { "kor", new CountryName(official: "미얀마 연방 공화국", common: "미얀마") },
                { "nld", new CountryName(official: "Republiek van de Unie van Myanmar", common: "Myanmar") },
                { "per", new CountryName(official: "اتحادیه جمهوری میانمار", common: "میانمار") },
                { "pol", new CountryName(official: "Republika Związku Mjanmy", common: "Mjanma") },
                { "por", new CountryName(official: "República da União de Myanmar", common: "Myanmar") },
                { "rus", new CountryName(official: "Республика Союза Мьянма", common: "Мьянма") },
                { "slk", new CountryName(official: "Mjanmarská zväzová republika", common: "Mjanmarsko") },
                { "spa", new CountryName(official: "República de la Unión de Myanmar", common: "Myanmar") },
                { "swe", new CountryName(official: "Republiken Unionen Myanmar", common: "Myanmar") },
                { "urd", new CountryName(official: "متحدہ جمہوریہ میانمار", common: "میانمار") },
                { "zho", new CountryName(official: "缅甸联邦共和国", common: "缅甸") },
            },
            cca2: "MM",
            cca3: "MMR",
            ccn3: "104",
            cioc: "MYA",
            flag: "🇲🇲",
            region: Region.Asia,
            subregion: "South-Eastern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"5", }),
            borders: new string[] { "BGD", "CHN", "IND", "LAO", "THA",  },
            capital: new string[] { "Naypyidaw",  },
            altSpellings: new string[] { "MM", "Burma", "Republic of the Union of Myanmar", "Pyidaunzu Thanmăda Myăma Nainngandaw",  },
            tld: new string[] { ".mm",  },
            latlng: new double[] { 22, 98,  },
            timezones: new string[] { "UTC+06:30",  },
            languages: new Language[]
            {
                new Language(name: "Burmese", iso6391: "my", iso6392: "mya"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "MMK", name: "Burmese kyat", symbol: "Ks"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Burmese", female: "Burmese") },
                { "fra", new DemonymsGender(male: "Burmese", female: "Burmese") },
            }
        );

        /// <summary>
        /// create an instance of Myanmar country
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
        private Myanmar(
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
