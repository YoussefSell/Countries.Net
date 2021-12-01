namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Iraq country
    /// </summary>
    public class Iraq : Country
    {
        /// <summary>
        /// get the Iraq country instance
        /// </summary>
        public static Iraq Instance = new Iraq(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Iraq", common: "Iraq") },
                { "ara", new CountryName(official: "جمهورية العراق", common: "العراق") },
                { "arc", new CountryName(official: "ܩܘܼܛܢܵܐ ܐܝܼܪܲܩ", common: "ܩܘܼܛܢܵܐ") },
                { "ckb", new CountryName(official: "کۆماری عێراق", common: "کۆماری") },
                { "ces", new CountryName(official: "Irácká republika", common: "Irák") },
                { "cym", new CountryName(official: "Republic of Iraq", common: "Iraq") },
                { "deu", new CountryName(official: "Republik Irak", common: "Irak") },
                { "est", new CountryName(official: "Iraagi Vabariik", common: "Iraak") },
                { "fin", new CountryName(official: "Irakin tasavalta", common: "Irak") },
                { "fra", new CountryName(official: "République d'Irak", common: "Irak") },
                { "hrv", new CountryName(official: "Republika Irak", common: "Irak") },
                { "hun", new CountryName(official: "Iraki Köztársaság", common: "Irak") },
                { "ita", new CountryName(official: "Repubblica dell'Iraq", common: "Iraq") },
                { "jpn", new CountryName(official: "イラク共和国", common: "イラク") },
                { "kor", new CountryName(official: "이라크 공화국", common: "이라크") },
                { "nld", new CountryName(official: "Republiek Irak", common: "Irak") },
                { "per", new CountryName(official: "جمهوری عراق", common: "عراق") },
                { "pol", new CountryName(official: "Republika Iraku", common: "Irak") },
                { "por", new CountryName(official: "República do Iraque", common: "Iraque") },
                { "rus", new CountryName(official: "Республика Ирак", common: "Ирак") },
                { "slk", new CountryName(official: "Iracká republika", common: "Irak") },
                { "spa", new CountryName(official: "República de Irak", common: "Irak") },
                { "swe", new CountryName(official: "Republiken Irak", common: "Irak") },
                { "urd", new CountryName(official: "جمہوریہ عراق", common: "عراق") },
                { "zho", new CountryName(official: "伊拉克共和国", common: "伊拉克") },

            },
            cca2: "IQ",
            cca3: "IRQ",
            ccn3: "368",
            cioc: "IRQ",
            flag: "🇮🇶",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"64", }),
            borders: new string[] { "IRN", "JOR", "KWT", "SAU", "SYR", "TUR",  },
            capital: new string[] { "Baghdad",  },
            altSpellings: new string[] { "IQ", "Republic of Iraq", "Jumhūriyyat al-‘Irāq",  },
            tld: new string[] { ".iq",  },
            latlng: new double[] { 33, 44,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
                new Language(name: "Aramaic", iso6391: "", iso6392: "arc"),
                new Language(name: "Sorani", iso6391: "", iso6392: "ckb"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "IQD", name: "Iraqi dinar", symbol: "ع.د"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Iraqi", female: "Iraqi") },
                { "fra", new DemonymsGender(male: "Iraqi", female: "Iraqi") },
            }
        );

        /// <summary>
        /// create an instance of Iraq country
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
        private Iraq(
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
