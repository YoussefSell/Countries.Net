namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Malawi country
    /// </summary>
    public class Malawi : Country
    {
        /// <summary>
        /// get the Malawi country instance
        /// </summary>
        public static Malawi Instance = new Malawi(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Malawi", common: "Malawi") },
                { "nya", new CountryName(official: "Chalo cha Malawi, Dziko la Malaŵi", common: "Malaŵi") },
                { "ara", new CountryName(official: "جمهورية مالاوي", common: "مالاوي") },
                { "ces", new CountryName(official: "Malawiská republika", common: "Malawi") },
                { "cym", new CountryName(official: "Republic of Malawi", common: "Malawi") },
                { "deu", new CountryName(official: "Republik Malawi", common: "Malawi") },
                { "est", new CountryName(official: "Malawi Vabariik", common: "Malawi") },
                { "fin", new CountryName(official: "Malawin tasavalta", common: "Malawi") },
                { "fra", new CountryName(official: "République du Malawi", common: "Malawi") },
                { "hrv", new CountryName(official: "Republika Malavi", common: "Malavi") },
                { "hun", new CountryName(official: "Malawi Köztársaság", common: "Malawi") },
                { "ita", new CountryName(official: "Repubblica del Malawi", common: "Malawi") },
                { "jpn", new CountryName(official: "マラウイ共和国", common: "マラウイ") },
                { "kor", new CountryName(official: "말라위 공화국", common: "말라위") },
                { "nld", new CountryName(official: "Republiek Malawi", common: "Malawi") },
                { "per", new CountryName(official: "جمهوری مالاوی", common: "مالاوی") },
                { "pol", new CountryName(official: "Republika Malawi", common: "Malawi") },
                { "por", new CountryName(official: "República do Malawi", common: "Malawi") },
                { "rus", new CountryName(official: "Республика Малави", common: "Малави") },
                { "slk", new CountryName(official: "Malawijská republika", common: "Malawi") },
                { "spa", new CountryName(official: "República de Malawi", common: "Malawi") },
                { "swe", new CountryName(official: "Republiken Malawi", common: "Malawi") },
                { "urd", new CountryName(official: "جمہوریہ ملاوی", common: "ملاوی") },
                { "zho", new CountryName(official: "马拉维共和国", common: "马拉维") },
            },
            cca2: "MW",
            cca3: "MWI",
            ccn3: "454",
            cioc: "MAW",
            flag: "🇲🇼",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"65", }),
            borders: new string[] { "MOZ", "TZA", "ZMB",  },
            capital: new string[] { "Lilongwe",  },
            altSpellings: new string[] { "MW", "Republic of Malawi",  },
            tld: new string[] { ".mw",  },
            latlng: new double[] { -13.5, 34,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Chewa", iso6391: "", iso6392: "nya"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "MWK", name: "Malawian kwacha", symbol: "MK"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Malawian", female: "Malawian") },
                { "fra", new DemonymsGender(male: "Malawian", female: "Malawian") },
            }
        );

        /// <summary>
        /// create an instance of Malawi country
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
        private Malawi(
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
