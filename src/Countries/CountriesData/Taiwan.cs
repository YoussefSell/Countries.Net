namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Taiwan country
    /// </summary>
    public class Taiwan : Country
    {
        /// <summary>
        /// get the Taiwan country instance
        /// </summary>
        public static Taiwan Instance = new Taiwan(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of China (Taiwan)", common: "Taiwan") },
                { "zho", new CountryName(official: "中華民國", common: "台灣") },
                { "ara", new CountryName(official: "جمهورية الصين (تايوان)", common: "تايوان") },
                { "ces", new CountryName(official: "Čínská republika", common: "Tchaj-wan") },
                { "cym", new CountryName(official: "Republic of China (Taiwan)", common: "Taiwan") },
                { "deu", new CountryName(official: "Republik China (Taiwan)", common: "Taiwan") },
                { "est", new CountryName(official: "Taiwani", common: "Taiwan") },
                { "fin", new CountryName(official: "Kiinan tasavalta", common: "Taiwan") },
                { "fra", new CountryName(official: "République de Chine (Taïwan)", common: "Taïwan") },
                { "hrv", new CountryName(official: "Republika Kina", common: "Tajvan") },
                { "hun", new CountryName(official: "Kínai Köztársaság", common: "Tajvan") },
                { "ita", new CountryName(official: "Repubblica cinese (Taiwan)", common: "Taiwan") },
                { "jpn", new CountryName(official: "中華民国", common: "台湾") },
                { "kor", new CountryName(official: "중화민국", common: "대만") },
                { "nld", new CountryName(official: "Republiek China (Taiwan)", common: "Taiwan") },
                { "per", new CountryName(official: "جمهوری چین", common: "تایوان") },
                { "pol", new CountryName(official: "Republika Chińska (Tajwan)", common: "Tajwan") },
                { "por", new CountryName(official: "República da China", common: "Ilha Formosa") },
                { "rus", new CountryName(official: "Китайская Республика", common: "Тайвань") },
                { "slk", new CountryName(official: "Čínska republika", common: "Taiwan") },
                { "spa", new CountryName(official: "República de China en Taiwán", common: "Taiwán") },
                { "swe", new CountryName(official: "Republiken Kina", common: "Taiwan") },
                { "urd", new CountryName(official: "جمہوریہ چین (تائیوان)", common: "تائیوان") },
            },
            cca2: "TW",
            cca3: "TWN",
            ccn3: "158",
            cioc: "TPE",
            flag: "🇹🇼",
            region: Region.Asia,
            subregion: "Eastern Asia",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+8", suffixes: new string[] {"86", }),
            borders: new string[] {  },
            capital: new string[] { "Taipei",  },
            altSpellings: new string[] { "TW", "Táiwān", "Republic of China", "中華民國", "Zhōnghuá Mínguó", "Chinese Taipei",  },
            tld: new string[] { ".tw", ".台灣", ".台湾",  },
            latlng: new double[] { 23.5, 121,  },
            timezones: new string[] { "UTC+08:00",  },
            languages: new Language[]
            {
                new Language(name: "Chinese", iso6391: "zh", iso6392: "zho"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "TWD", name: "New Taiwan dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Taiwanese", female: "Taiwanese") },
                { "fra", new DemonymsGender(male: "Taiwanese", female: "Taiwanese") },
            }
        );

        /// <summary>
        /// create an instance of Taiwan country
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
        private Taiwan(
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
