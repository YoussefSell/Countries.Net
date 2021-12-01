namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Tajikistan country
    /// </summary>
    public class Tajikistan : Country
    {
        /// <summary>
        /// get the Tajikistan country instance
        /// </summary>
        public static Tajikistan Instance = new Tajikistan(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Tajikistan", common: "Tajikistan") },
                { "rus", new CountryName(official: "Республика Таджикистан", common: "Таджикистан") },
                { "tgk", new CountryName(official: "Ҷумҳурии Тоҷикистон", common: "Тоҷикистон") },
                { "ara", new CountryName(official: "جمهورية طاجيكستان", common: "طاجيكستان") },
                { "ces", new CountryName(official: "Republika Tádžikistán", common: "Tádžikistán") },
                { "cym", new CountryName(official: "Republic of Tajikistan", common: "Tajikistan") },
                { "deu", new CountryName(official: "Republik Tadschikistan", common: "Tadschikistan") },
                { "est", new CountryName(official: "Tadžikistani Vabariik", common: "Tadžikistan") },
                { "fin", new CountryName(official: "Tadžikistanin tasavalta", common: "Tadžikistan") },
                { "fra", new CountryName(official: "République du Tadjikistan", common: "Tadjikistan") },
                { "hrv", new CountryName(official: "Republika Tadžikistan", common: "Tađikistan") },
                { "hun", new CountryName(official: "Tádzsik Köztársaság", common: "Tádzsikisztán") },
                { "ita", new CountryName(official: "Repubblica del Tajikistan", common: "Tagikistan") },
                { "jpn", new CountryName(official: "タジキスタン共和国", common: "タジキスタン") },
                { "kor", new CountryName(official: "타지키스탄 공화국", common: "타지키스탄") },
                { "nld", new CountryName(official: "Tadzjikistan", common: "Tadzjikistan") },
                { "per", new CountryName(official: "جمهوری تاجیکستان", common: "تاجیکِستان") },
                { "pol", new CountryName(official: "Republika Tadżykistanu", common: "Tadżykistan") },
                { "por", new CountryName(official: "República do Tajiquistão", common: "Tajiquistão") },
                { "slk", new CountryName(official: "Taǆická republika", common: "Taǆikistan") },
                { "spa", new CountryName(official: "República de Tayikistán", common: "Tayikistán") },
                { "swe", new CountryName(official: "Republiken Tadzjikistan", common: "Tadzjikistan") },
                { "urd", new CountryName(official: "جمہوریہ تاجکستان", common: "تاجکستان") },
                { "zho", new CountryName(official: "塔吉克斯坦共和国", common: "塔吉克斯坦") },

            },
            cca2: "TJ",
            cca3: "TJK",
            ccn3: "762",
            cioc: "TJK",
            flag: "🇹🇯",
            region: Region.Asia,
            subregion: "Central Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"92", }),
            borders: new string[] { "AFG", "CHN", "KGZ", "UZB",  },
            capital: new string[] { "Dushanbe",  },
            altSpellings: new string[] { "TJ", "Toçikiston", "Republic of Tajikistan", "Ҷумҳурии Тоҷикистон", "Çumhuriyi Toçikiston",  },
            tld: new string[] { ".tj",  },
            latlng: new double[] { 39, 71,  },
            timezones: new string[] { "UTC+05:00",  },
            languages: new Language[]
            {
                new Language(name: "Russian", iso6391: "ru", iso6392: "rus"),
                new Language(name: "Tajik", iso6391: "tg", iso6392: "tgk"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "TJS", name: "Tajikistani somoni", symbol: "ЅМ"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Tadzhik", female: "Tadzhik") },
                { "fra", new DemonymsGender(male: "Tadzhik", female: "Tadzhik") },
            }
        );

        /// <summary>
        /// create an instance of Tajikistan country
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
        private Tajikistan(
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
