namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Syria country
    /// </summary>
    public class Syria : Country
    {
        /// <summary>
        /// get the Syria country instance
        /// </summary>
        public static Syria Instance = new Syria(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Syrian Arab Republic", common: "Syria") },
                { "ara", new CountryName(official: "الجمهورية العربية السورية", common: "سوريا") },
                { "ces", new CountryName(official: "Syrská arabská republika", common: "Sýrie") },
                { "cym", new CountryName(official: "Syrian Arab Republic", common: "Syria") },
                { "deu", new CountryName(official: "Arabische Republik Syrien", common: "Syrien") },
                { "est", new CountryName(official: "Süüria Araabia Vabariik", common: "Süüria") },
                { "fin", new CountryName(official: "Syyrian arabitasavalta", common: "Syyria") },
                { "fra", new CountryName(official: "République arabe syrienne", common: "Syrie") },
                { "hrv", new CountryName(official: "Sirijska Arapska Republika", common: "Sirija") },
                { "hun", new CountryName(official: "Szíriai Arab Köztársaság", common: "Szíria") },
                { "ita", new CountryName(official: "Repubblica araba siriana", common: "Siria") },
                { "jpn", new CountryName(official: "シリアアラブ共和国", common: "シリア・アラブ共和国") },
                { "kor", new CountryName(official: "시리아 아랍 공화국", common: "시리아") },
                { "nld", new CountryName(official: "Syrische Arabische Republiek", common: "Syrië") },
                { "per", new CountryName(official: "جمهوری عربی سوریه", common: "سوریه") },
                { "pol", new CountryName(official: "Syryjska Republika Arabska", common: "Syria") },
                { "por", new CountryName(official: "República Árabe Síria", common: "Síria") },
                { "rus", new CountryName(official: "Сирийская Арабская Республика", common: "Сирия") },
                { "slk", new CountryName(official: "Sýrska arabská republika", common: "Sýria") },
                { "spa", new CountryName(official: "República Árabe Siria", common: "Siria") },
                { "swe", new CountryName(official: "Syriska arabiska republiken", common: "Syrien") },
                { "urd", new CountryName(official: "عرب جمہوریہ سوریہ", common: "سوریہ") },
                { "zho", new CountryName(official: "叙利亚阿拉伯共和国", common: "叙利亚") },

            },
            cca2: "SY",
            cca3: "SYR",
            ccn3: "760",
            cioc: "SYR",
            flag: "🇸🇾",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"63", }),
            borders: new string[] { "IRQ", "ISR", "JOR", "LBN", "TUR",  },
            capital: new string[] { "Damascus",  },
            altSpellings: new string[] { "SY", "Syrian Arab Republic", "Al-Jumhūrīyah Al-ʻArabīyah As-Sūrīyah",  },
            tld: new string[] { ".sy", "سوريا.",  },
            latlng: new double[] { 35, 38,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "SYP", name: "Syrian pound", symbol: "£"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Syrian", female: "Syrian") },
                { "fra", new DemonymsGender(male: "Syrian", female: "Syrian") },
            }
        );

        /// <summary>
        /// create an instance of Syria country
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
        private Syria(
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
