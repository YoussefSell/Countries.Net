namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Kenya country
    /// </summary>
    public class Kenya : Country
    {
        /// <summary>
        /// get the Kenya country instance
        /// </summary>
        public static Kenya Instance = new Kenya(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Kenya", common: "Kenya") },
                { "swa", new CountryName(official: "Republic of Kenya", common: "Kenya") },
                { "ara", new CountryName(official: "جمهورية كينيا", common: "كينيا") },
                { "ces", new CountryName(official: "Keňská republika", common: "Keňa") },
                { "cym", new CountryName(official: "Republic of Kenya", common: "Kenya") },
                { "deu", new CountryName(official: "Republik Kenia", common: "Kenia") },
                { "est", new CountryName(official: "Keenia Vabariik", common: "Keenia") },
                { "fin", new CountryName(official: "Kenian tasavalta", common: "Kenia") },
                { "fra", new CountryName(official: "République du Kenya", common: "Kenya") },
                { "hrv", new CountryName(official: "Republika Kenija", common: "Kenija") },
                { "hun", new CountryName(official: "Kenyai Köztársaság", common: "Kenya") },
                { "ita", new CountryName(official: "Repubblica del Kenya", common: "Kenya") },
                { "jpn", new CountryName(official: "ケニア共和国", common: "ケニア") },
                { "kor", new CountryName(official: "케냐 공화국", common: "케냐") },
                { "nld", new CountryName(official: "Republiek Kenia", common: "Kenia") },
                { "per", new CountryName(official: "جمهوری کنیا", common: "کنیا") },
                { "pol", new CountryName(official: "Republika Kenii", common: "Kenia") },
                { "por", new CountryName(official: "República do Quénia", common: "Quénia") },
                { "rus", new CountryName(official: "Республика Кения", common: "Кения") },
                { "slk", new CountryName(official: "Kenská republika", common: "Keňa") },
                { "spa", new CountryName(official: "República de Kenya", common: "Kenia") },
                { "swe", new CountryName(official: "Republiken Kenya", common: "Kenya") },
                { "urd", new CountryName(official: "جمہوریہ کینیا", common: "کینیا") },
                { "zho", new CountryName(official: "肯尼亚共和国", common: "肯尼亚") },
            },
            cca2: "KE",
            cca3: "KEN",
            ccn3: "404",
            cioc: "KEN",
            flag: "🇰🇪",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"54", }),
            borders: new string[] { "ETH", "SOM", "SSD", "TZA", "UGA",  },
            capital: new string[] { "Nairobi",  },
            altSpellings: new string[] { "KE", "Republic of Kenya", "Jamhuri ya Kenya",  },
            tld: new string[] { ".ke",  },
            latlng: new double[] { 1, 38,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Swahili", iso6391: "sw", iso6392: "swa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "KES", name: "Kenyan shilling", symbol: "Sh"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Kenyan", female: "Kenyan") },
                { "fra", new DemonymsGender(male: "Kenyan", female: "Kenyan") },
            }
        );

        /// <summary>
        /// create an instance of Kenya country
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
        private Kenya(
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
