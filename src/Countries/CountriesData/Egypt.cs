namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Egypt country
    /// </summary>
    public class Egypt : Country
    {
        /// <summary>
        /// get the Egypt country instance
        /// </summary>
        public static Egypt Instance = new Egypt(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Arab Republic of Egypt", common: "Egypt") },
                { "ara", new CountryName(official: "جمهورية مصر العربية", common: "مصر") },
                { "ces", new CountryName(official: "Egyptská arabská republika", common: "Egypt") },
                { "cym", new CountryName(official: "Gweriniaeth Arabaidd yr Aifft", common: "Yr Aifft") },
                { "deu", new CountryName(official: "Arabische Republik Ägypten", common: "Ägypten") },
                { "est", new CountryName(official: "Egiptuse Araabia Vabariik", common: "Egiptus") },
                { "fin", new CountryName(official: "Egyptin arabitasavalta", common: "Egypti") },
                { "fra", new CountryName(official: "République arabe d'Égypte", common: "Égypte") },
                { "hrv", new CountryName(official: "Arapska Republika Egipat", common: "Egipat") },
                { "hun", new CountryName(official: "Egyiptomi Arab Köztársaság", common: "Egyiptom") },
                { "ita", new CountryName(official: "Repubblica araba d'Egitto", common: "Egitto") },
                { "jpn", new CountryName(official: "エジプト·アラブ共和国", common: "エジプト") },
                { "kor", new CountryName(official: "이집트 아랍 공화국", common: "이집트") },
                { "nld", new CountryName(official: "Arabische Republiek Egypte", common: "Egypte") },
                { "per", new CountryName(official: "جمهوری عربی مصر", common: "مصر") },
                { "pol", new CountryName(official: "Arabska Republika Egiptu", common: "Egipt") },
                { "por", new CountryName(official: "República Árabe do Egipto", common: "Egito") },
                { "rus", new CountryName(official: "Арабская Республика Египет", common: "Египет") },
                { "slk", new CountryName(official: "Egyptská arabská republika", common: "Egypt") },
                { "spa", new CountryName(official: "República Árabe de Egipto", common: "Egipto") },
                { "swe", new CountryName(official: "Arabrepubliken Egypten", common: "Egypten") },
                { "urd", new CountryName(official: "مصری عرب جمہوریہ", common: "مصر") },
                { "zho", new CountryName(official: "阿拉伯埃及共和国", common: "埃及") },

            },
            cca2: "EG",
            cca3: "EGY",
            ccn3: "818",
            cioc: "EGY",
            flag: "🇪🇬",
            region: Region.Africa,
            subregion: "Northern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"0", }),
            borders: new string[] { "ISR", "LBY", "PSE", "SDN",  },
            capital: new string[] { "Cairo",  },
            altSpellings: new string[] { "EG", "Arab Republic of Egypt",  },
            tld: new string[] { ".eg", ".مصر",  },
            latlng: new double[] { 27, 30,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EGP", name: "Egyptian pound", symbol: "£"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Egyptian", female: "Egyptian") },
                { "fra", new DemonymsGender(male: "Egyptian", female: "Egyptian") },
            }
        );

        /// <summary>
        /// create an instance of Egypt country
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
        private Egypt(
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
