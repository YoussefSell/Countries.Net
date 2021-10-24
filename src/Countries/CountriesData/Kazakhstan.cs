namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Kazakhstan country
    /// </summary>
    public class Kazakhstan : Country
    {
        /// <summary>
        /// get the Kazakhstan country instance
        /// </summary>
        public static Kazakhstan Instance = new Kazakhstan(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Kazakhstan", common: "Kazakhstan") },
                { "kaz", new CountryName(official: "Қазақстан Республикасы", common: "Қазақстан") },
                { "rus", new CountryName(official: "Республика Казахстан", common: "Казахстан") },
                { "ara", new CountryName(official: "جمهورية كازاخستان", common: "كازاخستان") },
                { "ces", new CountryName(official: "Republika Kazachstán", common: "Kazachstán") },
                { "cym", new CountryName(official: "Republic of Kazakhstan", common: "Kazakhstan") },
                { "deu", new CountryName(official: "Republik Kasachstan", common: "Kasachstan") },
                { "est", new CountryName(official: "Kasahstani Vabariik", common: "Kasahstan") },
                { "fin", new CountryName(official: "Kazakstanin tasavalta", common: "Kazakstan") },
                { "fra", new CountryName(official: "République du Kazakhstan", common: "Kazakhstan") },
                { "hrv", new CountryName(official: "Republika Kazahstan", common: "Kazahstan") },
                { "hun", new CountryName(official: "Kazah Köztársaság", common: "Kazahsztán") },
                { "ita", new CountryName(official: "Repubblica del Kazakhstan", common: "Kazakistan") },
                { "jpn", new CountryName(official: "カザフスタン共和国", common: "カザフスタン") },
                { "kor", new CountryName(official: "카자흐스탄 공화국", common: "카자흐스탄") },
                { "nld", new CountryName(official: "Republiek Kazachstan", common: "Kazachstan") },
                { "per", new CountryName(official: "جمهوری قزاقستان", common: "قزاقستان") },
                { "pol", new CountryName(official: "Republika Kazachstanu", common: "Kazachstan") },
                { "por", new CountryName(official: "República do Cazaquistão", common: "Cazaquistão") },
                { "slk", new CountryName(official: "Kazašská republika", common: "Kazachstan") },
                { "spa", new CountryName(official: "República de Kazajstán", common: "Kazajistán") },
                { "swe", new CountryName(official: "Republiken Kazakstan", common: "Kazakstan") },
                { "urd", new CountryName(official: "جمہوریہ قازقستان", common: "قازقستان") },
                { "zho", new CountryName(official: "哈萨克斯坦共和国", common: "哈萨克斯坦") },

            },
            cca2: "KZ",
            cca3: "KAZ",
            ccn3: "398",
            cioc: "KAZ",
            flag: "🇰🇿",
            region: Region.Asia,
            subregion: "Central Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+7", suffixes: new string[] {"6", "7", }),
            borders: new string[] { "CHN", "KGZ", "RUS", "TKM", "UZB",  },
            capital: new string[] { "Nur-Sultan",  },
            altSpellings: new string[] { "KZ", "Qazaqstan", "Казахстан", "Republic of Kazakhstan", "Қазақстан Республикасы", "Qazaqstan Respublïkası", "Республика Казахстан", "Respublika Kazakhstan",  },
            tld: new string[] { ".kz", ".қаз",  },
            latlng: new double[] { 48, 68,  },
            timezones: new string[] { "UTC+05:00", "UTC+06:00",  },
            languages: new Language[]
            {
                new Language(name: "Kazakh", iso6391: "kk", iso6392: "kaz"),
                new Language(name: "Russian", iso6391: "ru", iso6392: "rus"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "KZT", name: "Kazakhstani tenge", symbol: "₸"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Kazakhstani", female: "Kazakhstani") },
                { "fra", new DemonymsGender(male: "Kazakhstani", female: "Kazakhstani") },
            }
        );

        /// <summary>
        /// create an instance of Kazakhstan country
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
        private Kazakhstan(
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
