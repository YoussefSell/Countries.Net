namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Honduras country
    /// </summary>
    public class Honduras : Country
    {
        /// <summary>
        /// get the Honduras country instance
        /// </summary>
        public static Honduras Instance = new Honduras(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Honduras", common: "Honduras") },
                { "spa", new CountryName(official: "República de Honduras", common: "Honduras") },
                { "ara", new CountryName(official: "جمهورية هندوراس", common: "هندوراس") },
                { "ces", new CountryName(official: "Honduraská republika", common: "Honduras") },
                { "cym", new CountryName(official: "Republic of Honduras", common: "Honduras") },
                { "deu", new CountryName(official: "Republik Honduras", common: "Honduras") },
                { "est", new CountryName(official: "Hondurase Vabariik", common: "Honduras") },
                { "fin", new CountryName(official: "Hondurasin tasavalta", common: "Honduras") },
                { "fra", new CountryName(official: "République du Honduras", common: "Honduras") },
                { "hrv", new CountryName(official: "Republika Honduras", common: "Honduras") },
                { "hun", new CountryName(official: "Hondurasi Köztársaság", common: "Honduras") },
                { "ita", new CountryName(official: "Repubblica di Honduras", common: "Honduras") },
                { "jpn", new CountryName(official: "ホンジュラス共和国", common: "ホンジュラス") },
                { "kor", new CountryName(official: "온두라스 공화국", common: "온두라스") },
                { "nld", new CountryName(official: "Republiek Honduras", common: "Honduras") },
                { "per", new CountryName(official: "جمهوری هندوراس", common: "هُندوراس") },
                { "pol", new CountryName(official: "Republika Hondurasu", common: "Honduras") },
                { "por", new CountryName(official: "República de Honduras", common: "Honduras") },
                { "rus", new CountryName(official: "Республика Гондурас", common: "Гондурас") },
                { "slk", new CountryName(official: "Honduraská republika", common: "Honduras") },
                { "swe", new CountryName(official: "Republiken Honduras", common: "Honduras") },
                { "urd", new CountryName(official: "جمہوریہ ہونڈوراس", common: "ہونڈوراس") },
                { "zho", new CountryName(official: "洪都拉斯共和国", common: "洪都拉斯") },

            },
            cca2: "HN",
            cca3: "HND",
            ccn3: "340",
            cioc: "HON",
            flag: "🇭🇳",
            region: Region.Americas,
            subregion: "Central America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"04", }),
            borders: new string[] { "GTM", "SLV", "NIC",  },
            capital: new string[] { "Tegucigalpa",  },
            altSpellings: new string[] { "HN", "Republic of Honduras", "República de Honduras",  },
            tld: new string[] { ".hn",  },
            latlng: new double[] { 15, -86.5,  },
            timezones: new string[] { "UTC-06:00",  },
            languages: new Language[]
            {
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "HNL", name: "Honduran lempira", symbol: "L"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Honduran", female: "Honduran") },
                { "fra", new DemonymsGender(male: "Honduran", female: "Honduran") },
            }
        );

        /// <summary>
        /// create an instance of Honduras country
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
        private Honduras(
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
