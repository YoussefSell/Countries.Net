namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Senegal country
    /// </summary>
    public class Senegal : Country
    {
        /// <summary>
        /// get the Senegal country instance
        /// </summary>
        public static Senegal Instance = new Senegal(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Senegal", common: "Senegal") },
                { "fra", new CountryName(official: "République du Sénégal", common: "Sénégal") },
                { "ara", new CountryName(official: "جمهورية السنغال", common: "السنغال") },
                { "ces", new CountryName(official: "Senegalská republika", common: "Senegal") },
                { "cym", new CountryName(official: "Republic of Senegal", common: "Senegal") },
                { "deu", new CountryName(official: "Republik Senegal", common: "Senegal") },
                { "est", new CountryName(official: "Senegali Vabariik", common: "Senegal") },
                { "fin", new CountryName(official: "Senegalin tasavalta", common: "Senegal") },
                { "hrv", new CountryName(official: "Republika Senegal", common: "Senegal") },
                { "hun", new CountryName(official: "Szenegáli Köztársaság", common: "Szenegál") },
                { "ita", new CountryName(official: "Repubblica del Senegal", common: "Senegal") },
                { "jpn", new CountryName(official: "セネガル共和国", common: "セネガル") },
                { "kor", new CountryName(official: "세네갈 공화국", common: "세네갈") },
                { "nld", new CountryName(official: "Republiek Senegal", common: "Senegal") },
                { "per", new CountryName(official: "جمهوری سنگال", common: "سنگال") },
                { "pol", new CountryName(official: "Senegal", common: "Senegal") },
                { "por", new CountryName(official: "República do Senegal", common: "Senegal") },
                { "rus", new CountryName(official: "Республика Сенегал", common: "Сенегал") },
                { "slk", new CountryName(official: "Senegalská republika", common: "Senegal") },
                { "spa", new CountryName(official: "República de Senegal", common: "Senegal") },
                { "swe", new CountryName(official: "Republiken Senegal", common: "Senegal") },
                { "urd", new CountryName(official: "جمہوریہ سینیگال", common: "سینیگال") },
                { "zho", new CountryName(official: "塞内加尔共和国", common: "塞内加尔") },

            },
            cca2: "SN",
            cca3: "SEN",
            ccn3: "686",
            cioc: "SEN",
            flag: "🇸🇳",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"21", }),
            borders: new string[] { "GMB", "GIN", "GNB", "MLI", "MRT",  },
            capital: new string[] { "Dakar",  },
            altSpellings: new string[] { "SN", "Republic of Senegal", "République du Sénégal",  },
            tld: new string[] { ".sn",  },
            latlng: new double[] { 14, -14,  },
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
                { "eng", new DemonymsGender(male: "Senegalese", female: "Senegalese") },
                { "fra", new DemonymsGender(male: "Senegalese", female: "Senegalese") },
            }
        );

        /// <summary>
        /// create an instance of Senegal country
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
        private Senegal(
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
