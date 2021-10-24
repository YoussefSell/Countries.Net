namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Tanzania country
    /// </summary>
    public class Tanzania : Country
    {
        /// <summary>
        /// get the Tanzania country instance
        /// </summary>
        public static Tanzania Instance = new Tanzania(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "United Republic of Tanzania", common: "Tanzania") },
                { "swa", new CountryName(official: "Jamhuri ya Muungano wa Tanzania", common: "Tanzania") },
                { "ara", new CountryName(official: "جمهورية تنزانيا الاتحادية", common: "تنزانيا") },
                { "ces", new CountryName(official: "Sjednocená tanzanská republika", common: "Tanzanie") },
                { "cym", new CountryName(official: "United Republic of Tanzania", common: "Tanzania") },
                { "deu", new CountryName(official: "Vereinigte Republik Tansania", common: "Tansania") },
                { "est", new CountryName(official: "Tansaania Ühendvabariik", common: "Tansaania") },
                { "fin", new CountryName(official: "Tansanian yhdistynyt tasavalta", common: "Tansania") },
                { "fra", new CountryName(official: "République -Unie de Tanzanie", common: "Tanzanie") },
                { "hrv", new CountryName(official: "Ujedinjena Republika Tanzanija", common: "Tanzanija") },
                { "hun", new CountryName(official: "Tádzsik Köztársaság", common: "Tádzsikisztán") },
                { "ita", new CountryName(official: "Repubblica Unita di Tanzania", common: "Tanzania") },
                { "jpn", new CountryName(official: "タンザニア連合共和国", common: "タンザニア") },
                { "kor", new CountryName(official: "탄자니아 연합 공화국", common: "탄자니아") },
                { "nld", new CountryName(official: "Verenigde Republiek Tanzania", common: "Tanzania") },
                { "per", new CountryName(official: "جمهوری متحد تانزانیا", common: "تانزانیا") },
                { "pol", new CountryName(official: "Zjednoczona Republika Tanzanii", common: "Tanzania") },
                { "por", new CountryName(official: "República Unida da Tanzânia", common: "Tanzânia") },
                { "rus", new CountryName(official: "Объединенная Республика Танзания", common: "Танзания") },
                { "slk", new CountryName(official: "Tanzánijská zjednotená republika", common: "Tanzánia") },
                { "spa", new CountryName(official: "República Unida de Tanzania", common: "Tanzania") },
                { "swe", new CountryName(official: "Förenade republiken Tanzania", common: "Tanzania") },
                { "urd", new CountryName(official: "متحدہ جمہوریہ تنزانیہ", common: "تنزانیہ") },
                { "zho", new CountryName(official: "坦桑尼亚联合共和国", common: "坦桑尼亚") },
            },
            cca2: "TZ",
            cca3: "TZA",
            ccn3: "834",
            cioc: "TAN",
            flag: "🇹🇿",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"55", }),
            borders: new string[] { "BDI", "COD", "KEN", "MWI", "MOZ", "RWA", "UGA", "ZMB",  },
            capital: new string[] { "Dodoma",  },
            altSpellings: new string[] { "TZ", "Tanzania, United Republic of", "United Republic of Tanzania", "Jamhuri ya Muungano wa Tanzania",  },
            tld: new string[] { ".tz",  },
            latlng: new double[] { -6, 35,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Swahili", iso6391: "sw", iso6392: "swa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "TZS", name: "Tanzanian shilling", symbol: "Sh"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Tanzanian", female: "Tanzanian") },
                { "fra", new DemonymsGender(male: "Tanzanian", female: "Tanzanian") },
            }
        );

        /// <summary>
        /// create an instance of Tanzania country
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
        private Tanzania(
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
