namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Sudan country
    /// </summary>
    public class Sudan : Country
    {
        /// <summary>
        /// get the Sudan country instance
        /// </summary>
        public static Sudan Instance = new Sudan(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of the Sudan", common: "Sudan") },
                { "ara", new CountryName(official: "جمهورية السودان", common: "السودان") },
                { "ces", new CountryName(official: "Súdánská republika", common: "Súdán") },
                { "cym", new CountryName(official: "Republic of the Sudan", common: "Sudan") },
                { "deu", new CountryName(official: "Republik Sudan", common: "Sudan") },
                { "est", new CountryName(official: "Sudaani Vabariik", common: "Sudaan") },
                { "fin", new CountryName(official: "Sudanin tasavalta", common: "Sudan") },
                { "fra", new CountryName(official: "République du Soudan", common: "Soudan") },
                { "hrv", new CountryName(official: "Republika Sudan", common: "Sudan") },
                { "hun", new CountryName(official: "Szudáni Köztársaság", common: "Szudán") },
                { "ita", new CountryName(official: "Repubblica del Sudan", common: "Sudan") },
                { "jpn", new CountryName(official: "スーダン共和国", common: "スーダン") },
                { "kor", new CountryName(official: "수단 공화국", common: "수단") },
                { "nld", new CountryName(official: "Republiek Soedan", common: "Soedan") },
                { "per", new CountryName(official: "جمهوری سودان", common: "سودان") },
                { "pol", new CountryName(official: "Republika Sudanu", common: "Sudan") },
                { "por", new CountryName(official: "República do Sudão", common: "Sudão") },
                { "rus", new CountryName(official: "Республика Судан", common: "Судан") },
                { "slk", new CountryName(official: "Sudánska republika", common: "Sudán") },
                { "spa", new CountryName(official: "República de Sudán", common: "Sudán") },
                { "swe", new CountryName(official: "Republiken Sudan", common: "Sudan") },
                { "urd", new CountryName(official: "جمہوریہ سودان", common: "سودان") },
                { "zho", new CountryName(official: "苏丹共和国", common: "苏丹") },

            },
            cca2: "SD",
            cca3: "SDN",
            ccn3: "729",
            cioc: "SUD",
            flag: "🇸🇩",
            region: Region.Africa,
            subregion: "Northern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"49", }),
            borders: new string[] { "CAF", "TCD", "EGY", "ERI", "ETH", "LBY", "SSD",  },
            capital: new string[] { "Khartoum",  },
            altSpellings: new string[] { "SD", "Republic of the Sudan", "Jumhūrīyat as-Sūdān",  },
            tld: new string[] { ".sd",  },
            latlng: new double[] { 15, 30,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "SDG", name: "Sudanese pound", symbol: ""),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Sudanese", female: "Sudanese") },
                { "fra", new DemonymsGender(male: "Sudanese", female: "Sudanese") },
            }
        );

        /// <summary>
        /// create an instance of Sudan country
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
        private Sudan(
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
