namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Haiti country
    /// </summary>
    public class Haiti : Country
    {
        /// <summary>
        /// get the Haiti country instance
        /// </summary>
        public static Haiti Instance = new Haiti(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Haiti", common: "Haiti") },
                { "fra", new CountryName(official: "République d'Haïti", common: "Haïti") },
                { "hat", new CountryName(official: "Repiblik Ayiti", common: "Ayiti") },
                { "ara", new CountryName(official: "جمهورية هايتي", common: "هايتي") },
                { "ces", new CountryName(official: "Republika Haiti", common: "Haiti") },
                { "cym", new CountryName(official: "Republic of Haiti", common: "Haiti") },
                { "deu", new CountryName(official: "Republik Haiti", common: "Haiti") },
                { "est", new CountryName(official: "Haiti Vabariik", common: "Haiti") },
                { "fin", new CountryName(official: "Haitin tasavalta", common: "Haiti") },
                { "hrv", new CountryName(official: "Republika Haiti", common: "Haiti") },
                { "hun", new CountryName(official: "Haiti Köztársaság", common: "Haiti") },
                { "ita", new CountryName(official: "Repubblica di Haiti", common: "Haiti") },
                { "jpn", new CountryName(official: "ハイチ共和国", common: "ハイチ") },
                { "kor", new CountryName(official: "아이티 공화국", common: "아이티") },
                { "nld", new CountryName(official: "Republiek Haïti", common: "Haïti") },
                { "per", new CountryName(official: "جمهوری هائیتی", common: "هائیتی") },
                { "pol", new CountryName(official: "Republika Haiti", common: "Haiti") },
                { "por", new CountryName(official: "República do Haiti", common: "Haiti") },
                { "rus", new CountryName(official: "Республика Гаити", common: "Гаити") },
                { "slk", new CountryName(official: "Haitská republika", common: "Haiti") },
                { "spa", new CountryName(official: "República de Haití", common: "Haití") },
                { "swe", new CountryName(official: "Republiken Haiti", common: "Haiti") },
                { "urd", new CountryName(official: "جمہوریہ ہیٹی", common: "ہیٹی") },
                { "zho", new CountryName(official: "海地共和国", common: "海地") },

            },
            cca2: "HT",
            cca3: "HTI",
            ccn3: "332",
            cioc: "HAI",
            flag: "🇭🇹",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"09", }),
            borders: new string[] { "DOM",  },
            capital: new string[] { "Port-au-Prince",  },
            altSpellings: new string[] { "HT", "Republic of Haiti", "République d'Haïti", "Repiblik Ayiti",  },
            tld: new string[] { ".ht",  },
            latlng: new double[] { 19, -72.41666666,  },
            timezones: new string[] { "UTC-05:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
                new Language(name: "Haitian Creole", iso6391: "ht", iso6392: "hat"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "HTG", name: "Haitian gourde", symbol: "G"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Haitian", female: "Haitian") },
                { "fra", new DemonymsGender(male: "Haitian", female: "Haitian") },
            }
        );

        /// <summary>
        /// create an instance of Haiti country
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
        private Haiti(
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
