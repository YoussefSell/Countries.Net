namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Turkey country
    /// </summary>
    public class Turkey : Country
    {
        /// <summary>
        /// get the Turkey country instance
        /// </summary>
        public static Turkey Instance = new Turkey(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Turkey", common: "Turkey") },
                { "tur", new CountryName(official: "Türkiye Cumhuriyeti", common: "Türkiye") },
                { "ara", new CountryName(official: "الجمهورية التركية", common: "تركيا") },
                { "ces", new CountryName(official: "Turecká republika", common: "Turecko") },
                { "cym", new CountryName(official: "Republic of Turkey", common: "Turkey") },
                { "deu", new CountryName(official: "Republik Türkei", common: "Türkei") },
                { "est", new CountryName(official: "Türgi Vabariik", common: "Türgi") },
                { "fin", new CountryName(official: "Turkin tasavalta", common: "Turkki") },
                { "fra", new CountryName(official: "République de Turquie", common: "Turquie") },
                { "hrv", new CountryName(official: "Republika Turska", common: "Turska") },
                { "hun", new CountryName(official: "Török Köztársaság", common: "Törökország") },
                { "ita", new CountryName(official: "Repubblica di Turchia", common: "Turchia") },
                { "jpn", new CountryName(official: "トルコ共和国", common: "トルコ") },
                { "kor", new CountryName(official: "터키 공화국", common: "터키") },
                { "nld", new CountryName(official: "Republiek Turkije", common: "Turkije") },
                { "per", new CountryName(official: "جمهوری ترکیه", common: "ترکیه") },
                { "pol", new CountryName(official: "Republika Turcji", common: "Turcja") },
                { "por", new CountryName(official: "República da Turquia", common: "Turquia") },
                { "rus", new CountryName(official: "Республика Турции", common: "Турция") },
                { "slk", new CountryName(official: "Turecká republika", common: "Turecko") },
                { "spa", new CountryName(official: "República de Turquía", common: "Turquía") },
                { "swe", new CountryName(official: "Republiken Turkiet", common: "Turkiet") },
                { "urd", new CountryName(official: "جمہوریہ ترکی", common: "ترکی") },
                { "zho", new CountryName(official: "土耳其共和国", common: "土耳其") },
            },
            cca2: "TR",
            cca3: "TUR",
            ccn3: "792",
            cioc: "TUR",
            flag: "🇹🇷",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"0", }),
            borders: new string[] { "ARM", "AZE", "BGR", "GEO", "GRC", "IRN", "IRQ", "SYR",  },
            capital: new string[] { "Ankara",  },
            altSpellings: new string[] { "TR", "Turkiye", "Republic of Turkey", "Türkiye Cumhuriyeti",  },
            tld: new string[] { ".tr",  },
            latlng: new double[] { 39, 35,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "Turkish", iso6391: "tr", iso6392: "tur"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "TRY", name: "Turkish lira", symbol: "₺"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Turkish", female: "Turkish") },
                { "fra", new DemonymsGender(male: "Turkish", female: "Turkish") },
            }
        );

        /// <summary>
        /// create an instance of Turkey country
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
        private Turkey(
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
