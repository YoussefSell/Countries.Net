namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Togo country
    /// </summary>
    public class Togo : Country
    {
        /// <summary>
        /// get the Togo country instance
        /// </summary>
        public static Togo Instance = new Togo(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Togolese Republic", common: "Togo") },
                { "fra", new CountryName(official: "République togolaise", common: "Togo") },
                { "ara", new CountryName(official: "جمهورية توغو", common: "توغو") },
                { "ces", new CountryName(official: "Republika Togo", common: "Togo") },
                { "cym", new CountryName(official: "Togolese Republic", common: "Togo") },
                { "deu", new CountryName(official: "Republik Togo", common: "Togo") },
                { "est", new CountryName(official: "Togo Vabariik", common: "Togo") },
                { "fin", new CountryName(official: "Togon tasavalta", common: "Togo") },
                { "hrv", new CountryName(official: "Togolese Republika", common: "Togo") },
                { "hun", new CountryName(official: "Togói Köztársaság", common: "Togo") },
                { "ita", new CountryName(official: "Repubblica del Togo", common: "Togo") },
                { "jpn", new CountryName(official: "トーゴ共和国", common: "トーゴ") },
                { "kor", new CountryName(official: "토고 공화국", common: "토고") },
                { "nld", new CountryName(official: "Republiek Togo", common: "Togo") },
                { "per", new CountryName(official: "جمهوری توگو", common: "توگو") },
                { "pol", new CountryName(official: "Republika Togijska", common: "Togo") },
                { "por", new CountryName(official: "República do Togo", common: "Togo") },
                { "rus", new CountryName(official: "Того Республика", common: "Того") },
                { "slk", new CountryName(official: "Togská republika", common: "Togo") },
                { "spa", new CountryName(official: "República de Togo", common: "Togo") },
                { "swe", new CountryName(official: "Republiken Togo", common: "Togo") },
                { "urd", new CountryName(official: "جمہوریہ ٹوگو", common: "ٹوگو") },
                { "zho", new CountryName(official: "多哥共和国", common: "多哥") },

            },
            cca2: "TG",
            cca3: "TGO",
            ccn3: "768",
            cioc: "TOG",
            flag: "🇹🇬",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"28", }),
            borders: new string[] { "BEN", "BFA", "GHA",  },
            capital: new string[] { "Lomé",  },
            altSpellings: new string[] { "TG", "Togolese", "Togolese Republic", "République Togolaise",  },
            tld: new string[] { ".tg",  },
            latlng: new double[] { 8, 1.16666666,  },
            timezones: new string[] { "UTC",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XOF", name: "West African CFA franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Togolese", female: "Togolese") },
                { "fra", new DemonymsGender(male: "Togolese", female: "Togolese") },
            }
        );

        /// <summary>
        /// create an instance of Togo country
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
        private Togo(
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
