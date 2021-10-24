namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of RepublicoftheCongo country
    /// </summary>
    public class RepublicoftheCongo : Country
    {
        /// <summary>
        /// get the RepublicoftheCongo country instance
        /// </summary>
        public static RepublicoftheCongo Instance = new RepublicoftheCongo(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of the Congo", common: "Republic of the Congo") },
                { "fra", new CountryName(official: "République du Congo", common: "République du Congo") },
                { "kon", new CountryName(official: "Repubilika ya Kongo", common: "Repubilika ya Kongo") },
                { "lin", new CountryName(official: "Republíki ya Kongó", common: "Republíki ya Kongó") },
                { "ara", new CountryName(official: "جمهورية الكونغو", common: "جمهورية الكونفو") },
                { "ces", new CountryName(official: "Konžská republika", common: "Kongo") },
                { "cym", new CountryName(official: "Gweriniaeth y Congo", common: "Gweriniaeth y Congo") },
                { "deu", new CountryName(official: "Republik Kongo", common: "Kongo") },
                { "est", new CountryName(official: "Kongo Vabariik", common: "Kongo Vabariik") },
                { "fin", new CountryName(official: "Kongon tasavalta", common: "Kongo-Brazzaville") },
                { "hrv", new CountryName(official: "Republika Kongo", common: "Kongo") },
                { "hun", new CountryName(official: "Kongói Köztársaság", common: "Kongói Köztársaság") },
                { "ita", new CountryName(official: "Repubblica del Congo", common: "Congo") },
                { "jpn", new CountryName(official: "コンゴ共和国", common: "コンゴ共和国") },
                { "kor", new CountryName(official: "콩고", common: "콩고") },
                { "nld", new CountryName(official: "Republiek Congo", common: "Congo") },
                { "per", new CountryName(official: "جمهوری برازاویل کُنگو", common: "جمهوری کُنگو") },
                { "pol", new CountryName(official: "Republika Konga", common: "Kongo") },
                { "por", new CountryName(official: "República do Congo", common: "Congo") },
                { "rus", new CountryName(official: "Республика Конго", common: "Республика Конго") },
                { "slk", new CountryName(official: "Konžská republika", common: "Kongo") },
                { "spa", new CountryName(official: "República del Congo", common: "Congo") },
                { "swe", new CountryName(official: "Republiken Kongo", common: "Kongo-Brazzaville") },
                { "urd", new CountryName(official: "جمہوریہ کانگو", common: "جمہوریہ کانگو") },
                { "zho", new CountryName(official: "刚果共和国", common: "刚果") },

            },
            cca2: "CG",
            cca3: "COG",
            ccn3: "178",
            cioc: "CGO",
            flag: "🇨🇬",
            region: Region.Africa,
            subregion: "Middle Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"42", }),
            borders: new string[] { "AGO", "CMR", "CAF", "COD", "GAB",  },
            capital: new string[] { "Brazzaville",  },
            altSpellings: new string[] { "CG", "Congo", "Congo-Brazzaville",  },
            tld: new string[] { ".cg",  },
            latlng: new double[] { -1, 15,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
                new Language(name: "Kikongo", iso6391: "", iso6392: "kon"),
                new Language(name: "Lingala", iso6391: "ln", iso6392: "lin"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XAF", name: "Central African CFA franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Congolese", female: "Congolese") },
                { "fra", new DemonymsGender(male: "Congolese", female: "Congolese") },
            }
        );

        /// <summary>
        /// create an instance of RepublicoftheCongo country
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
        private RepublicoftheCongo(
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
