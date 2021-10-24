namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Panama country
    /// </summary>
    public class Panama : Country
    {
        /// <summary>
        /// get the Panama country instance
        /// </summary>
        public static Panama Instance = new Panama(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Panama", common: "Panama") },
                { "spa", new CountryName(official: "República de Panamá", common: "Panamá") },
                { "ara", new CountryName(official: "جمهورية بنما", common: "بنما") },
                { "ces", new CountryName(official: "Panamská republika", common: "Panama") },
                { "cym", new CountryName(official: "Republic of Panama", common: "Panama") },
                { "deu", new CountryName(official: "Republik Panama", common: "Panama") },
                { "est", new CountryName(official: "Panama Vabariik", common: "Panama") },
                { "fin", new CountryName(official: "Panaman tasavalta", common: "Panama") },
                { "fra", new CountryName(official: "République du Panama", common: "Panama") },
                { "hrv", new CountryName(official: "Republika Panama", common: "Panama") },
                { "hun", new CountryName(official: "Panamai Köztársaság", common: "Panama") },
                { "ita", new CountryName(official: "Repubblica di Panama", common: "Panama") },
                { "jpn", new CountryName(official: "パナマ共和国", common: "パナマ") },
                { "kor", new CountryName(official: "파나마 공화국", common: "파나마") },
                { "nld", new CountryName(official: "Republiek Panama", common: "Panama") },
                { "per", new CountryName(official: "جمهوری پاناما", common: "پاناما") },
                { "pol", new CountryName(official: "Republika Panamy", common: "Panama") },
                { "por", new CountryName(official: "República do Panamá", common: "Panamá") },
                { "rus", new CountryName(official: "Республика Панама", common: "Панама") },
                { "slk", new CountryName(official: "Panamská republika", common: "Panama") },
                { "swe", new CountryName(official: "Republiken Panama", common: "Panama") },
                { "urd", new CountryName(official: "جمہوریہ پاناما", common: "پاناما") },
                { "zho", new CountryName(official: "巴拿马共和国", common: "巴拿马") },

            },
            cca2: "PA",
            cca3: "PAN",
            ccn3: "591",
            cioc: "PAN",
            flag: "🇵🇦",
            region: Region.Americas,
            subregion: "Central America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"07", }),
            borders: new string[] { "COL", "CRI",  },
            capital: new string[] { "Panama City",  },
            altSpellings: new string[] { "PA", "Republic of Panama", "República de Panamá",  },
            tld: new string[] { ".pa",  },
            latlng: new double[] { 9, -80,  },
            timezones: new string[] { "UTC-05:00",  },
            languages: new Language[]
            {
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "PAB", name: "Panamanian balboa", symbol: "B/."),
                new Currency(code: "USD", name: "United States dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Panamanian", female: "Panamanian") },
                { "fra", new DemonymsGender(male: "Panamanian", female: "Panamanian") },
            }
        );

        /// <summary>
        /// create an instance of Panama country
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
        private Panama(
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
