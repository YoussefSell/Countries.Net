namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of UnitedArabEmirates country
    /// </summary>
    public class UnitedArabEmirates : Country
    {
        /// <summary>
        /// get the UnitedArabEmirates country instance
        /// </summary>
        public static UnitedArabEmirates Instance = new UnitedArabEmirates(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "United Arab Emirates", common: "United Arab Emirates") },
                { "ara", new CountryName(official: "الإمارات العربية المتحدة", common: "دولة الإمارات العربية المتحدة") },
                { "ces", new CountryName(official: "Spojené arabské emiráty", common: "Spojené arabské emiráty") },
                { "cym", new CountryName(official: "United Arab Emirates", common: "United Arab Emirates") },
                { "deu", new CountryName(official: "Vereinigte Arabische Emirate", common: "Vereinigte Arabische Emirate") },
                { "est", new CountryName(official: "Araabia Ühendemiraadid", common: "Araabia Ühendemiraadid") },
                { "fin", new CountryName(official: "Yhdistyneet arabiemiirikunnat", common: "Arabiemiraatit") },
                { "fra", new CountryName(official: "Émirats arabes unis", common: "Émirats arabes unis") },
                { "hrv", new CountryName(official: "Ujedinjeni Arapski Emirati", common: "Ujedinjeni Arapski Emirati") },
                { "hun", new CountryName(official: "Egyesült Arab Emírségek", common: "Egyesült Arab Emírségek") },
                { "ita", new CountryName(official: "Emirati Arabi Uniti", common: "Emirati Arabi Uniti") },
                { "jpn", new CountryName(official: "アラブ首長国連邦", common: "アラブ首長国連邦") },
                { "kor", new CountryName(official: "아랍 토후국 연방", common: "아랍에미리트") },
                { "nld", new CountryName(official: "Verenigde Arabische Emiraten", common: "Verenigde Arabische Emiraten") },
                { "per", new CountryName(official: "امارات متحده عربی", common: "امارات") },
                { "pol", new CountryName(official: "Zjednoczone Emiraty Arabskie", common: "Zjednoczone Emiraty Arabskie") },
                { "por", new CountryName(official: "Emirados Árabes Unidos", common: "Emirados Árabes Unidos") },
                { "rus", new CountryName(official: "Объединенные Арабские Эмираты", common: "Объединённые Арабские Эмираты") },
                { "slk", new CountryName(official: "Spojené arabské emiráty", common: "Spojené arabské emiráty") },
                { "spa", new CountryName(official: "Emiratos Árabes Unidos", common: "Emiratos Árabes Unidos") },
                { "swe", new CountryName(official: "Förenade Arabemiraten", common: "Förenade Arabemiraten") },
                { "urd", new CountryName(official: "متحدہ عرب امارات", common: "متحدہ عرب امارات") },
                { "zho", new CountryName(official: "阿拉伯联合酋长国", common: "阿拉伯联合酋长国") },

            },
            cca2: "AE",
            cca3: "ARE",
            ccn3: "784",
            cioc: "UAE",
            flag: "🇦🇪",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"71", }),
            borders: new string[] { "OMN", "SAU",  },
            capital: new string[] { "Abu Dhabi",  },
            altSpellings: new string[] { "AE", "UAE", "Emirates",  },
            tld: new string[] { ".ae", "امارات.",  },
            latlng: new double[] { 24, 54,  },
            timezones: new string[] { "UTC+04",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "AED", name: "United Arab Emirates dirham", symbol: "د.إ"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Emirati", female: "Emirati") },
                { "fra", new DemonymsGender(male: "Emirati", female: "Emirati") },
            }
        );

        /// <summary>
        /// create an instance of UnitedArabEmirates country
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
        private UnitedArabEmirates(
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
