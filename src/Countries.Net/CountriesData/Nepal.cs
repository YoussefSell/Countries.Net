namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Nepal country
    /// </summary>
    public class Nepal : Country
    {
        /// <summary>
        /// get the Nepal country instance
        /// </summary>
        public static Nepal Instance = new Nepal(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Federal Democratic Republic of Nepal", common: "Nepal") },
                { "nep", new CountryName(official: "नेपाल संघीय लोकतान्त्रिक गणतन्त्र", common: "नेपाल") },
                { "ara", new CountryName(official: "جمهورية نيبال الديمقراطية الاتحادية", common: "نيبال") },
                { "ces", new CountryName(official: "Federativní demokratická republika Nepál", common: "Nepál") },
                { "cym", new CountryName(official: "Federal Democratic Republic of Nepal", common: "Nepal") },
                { "deu", new CountryName(official: "Demokratische Bundesrepublik Nepal", common: "Nepal") },
                { "est", new CountryName(official: "Nepali Demokraatlik Liitvabariik", common: "Nepal") },
                { "fin", new CountryName(official: "Nepalin demokraattinen liittotasavalta", common: "Nepal") },
                { "fra", new CountryName(official: "République du Népal", common: "Népal") },
                { "hrv", new CountryName(official: "Savezna Demokratska Republika Nepal", common: "Nepal") },
                { "hun", new CountryName(official: "Nepáli Szövetségi Demokratikus Köztársaság", common: "Nepál") },
                { "ita", new CountryName(official: "Repubblica federale democratica del Nepal", common: "Nepal") },
                { "jpn", new CountryName(official: "ネパール連邦民主共和国", common: "ネパール") },
                { "kor", new CountryName(official: "네팔 연방 민주 공화국", common: "네팔") },
                { "nld", new CountryName(official: "Federale Democratische Republiek Nepal", common: "Nepal") },
                { "per", new CountryName(official: "جمهوری فدرال دموکراتیک نپال", common: "نپال") },
                { "pol", new CountryName(official: "Federalna Demokratyczna Republika Nepalu", common: "Nepal") },
                { "por", new CountryName(official: "República Democrática Federal do Nepal", common: "Nepal") },
                { "rus", new CountryName(official: "Федеративная Демократическая Республика Непал", common: "Непал") },
                { "slk", new CountryName(official: "Nepálska federatívna demokratická republika", common: "Nepál") },
                { "spa", new CountryName(official: "República Democrática Federal de Nepal", common: "Nepal") },
                { "swe", new CountryName(official: "Demokratiska förbundsrepubliken Nepal", common: "Nepal") },
                { "urd", new CountryName(official: "وفاقی جمہوری جمہوریہ نیپال", common: "نیپال") },
                { "zho", new CountryName(official: "尼泊尔联邦民主共和国", common: "尼泊尔") },
            },
            cca2: "NP",
            cca3: "NPL",
            ccn3: "524",
            cioc: "NEP",
            flag: "🇳🇵",
            region: Region.Asia,
            subregion: "Southern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"77", }),
            borders: new string[] { "CHN", "IND",  },
            capital: new string[] { "Kathmandu",  },
            altSpellings: new string[] { "NP", "Federal Democratic Republic of Nepal", "Loktāntrik Ganatantra Nepāl",  },
            tld: new string[] { ".np",  },
            latlng: new double[] { 28, 84,  },
            timezones: new string[] { "UTC+05:45",  },
            languages: new Language[]
            {
                new Language(name: "Nepali", iso6391: "ne", iso6392: "nep"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "NPR", name: "Nepalese rupee", symbol: "₨"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Nepalese", female: "Nepalese") },
                { "fra", new DemonymsGender(male: "Nepalese", female: "Nepalese") },
            }
        );

        /// <summary>
        /// create an instance of Nepal country
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
        private Nepal(
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
