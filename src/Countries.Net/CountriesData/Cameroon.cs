namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Cameroon country
    /// </summary>
    public class Cameroon : Country
    {
        /// <summary>
        /// get the Cameroon country instance
        /// </summary>
        public static Cameroon Instance = new Cameroon(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Cameroon", common: "Cameroon") },
                { "fra", new CountryName(official: "République du Cameroun", common: "Cameroun") },
                { "ara", new CountryName(official: "جمهورية الكاميرون", common: "الكاميرون") },
                { "ces", new CountryName(official: "Kamerunská republika", common: "Kamerun") },
                { "cym", new CountryName(official: "Gweriniaeth Camerŵn", common: "Camerŵn") },
                { "deu", new CountryName(official: "Republik Kamerun", common: "Kamerun") },
                { "est", new CountryName(official: "Kameruni Vabariik", common: "Kamerun") },
                { "fin", new CountryName(official: "Kamerunin tasavalta", common: "Kamerun") },
                { "hrv", new CountryName(official: "Republika Kamerun", common: "Kamerun") },
                { "hun", new CountryName(official: "Kameruni Köztársaság", common: "Kamerun") },
                { "ita", new CountryName(official: "Repubblica del Camerun", common: "Camerun") },
                { "jpn", new CountryName(official: "カメルーン共和国", common: "カメルーン") },
                { "kor", new CountryName(official: "카메룬 공화국", common: "카메룬") },
                { "nld", new CountryName(official: "Republiek Kameroen", common: "Kameroen") },
                { "per", new CountryName(official: "جمهوری کامِرون", common: "کامِرون") },
                { "pol", new CountryName(official: "Republika WybrzeŻa Kości Słoniowej", common: "WybrzeŻe Kości Słoniowej") },
                { "por", new CountryName(official: "República dos Camarões", common: "Camarões") },
                { "rus", new CountryName(official: "Республика Камерун", common: "Камерун") },
                { "slk", new CountryName(official: "Kamerunská republika", common: "Kamerun") },
                { "spa", new CountryName(official: "República de Camerún", common: "Camerún") },
                { "swe", new CountryName(official: "Republiken Kamerun", common: "Kamerun") },
                { "urd", new CountryName(official: "جمہوریہ کیمرون", common: "کیمرون") },
                { "zho", new CountryName(official: "喀麦隆共和国", common: "喀麦隆") },

            },
            cca2: "CM",
            cca3: "CMR",
            ccn3: "120",
            cioc: "CMR",
            flag: "🇨🇲",
            region: Region.Africa,
            subregion: "Middle Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"37", }),
            borders: new string[] { "CAF", "TCD", "COG", "GNQ", "GAB", "NGA",  },
            capital: new string[] { "Yaoundé",  },
            altSpellings: new string[] { "CM", "Republic of Cameroon", "République du Cameroun",  },
            tld: new string[] { ".cm",  },
            latlng: new double[] { 6, 12,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XAF", name: "Central African CFA franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Cameroonian", female: "Cameroonian") },
                { "fra", new DemonymsGender(male: "Cameroonian", female: "Cameroonian") },
            }
        );

        /// <summary>
        /// create an instance of Cameroon country
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
        private Cameroon(
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
