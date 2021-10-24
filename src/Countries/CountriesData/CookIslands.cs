namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of CookIslands country
    /// </summary>
    public class CookIslands : Country
    {
        /// <summary>
        /// get the CookIslands country instance
        /// </summary>
        public static CookIslands Instance = new CookIslands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Cook Islands", common: "Cook Islands") },
                { "rar", new CountryName(official: "Kūki 'Āirani", common: "Kūki 'Āirani") },
                { "ara", new CountryName(official: "جزر كوك", common: "جزر كوك") },
                { "ces", new CountryName(official: "Cookovy ostrovy", common: "Cookovy ostrovy") },
                { "cym", new CountryName(official: "Ynysoedd Cook", common: "Ynysoedd Cook") },
                { "deu", new CountryName(official: "Cookinseln", common: "Cookinseln") },
                { "est", new CountryName(official: "Cooki saared", common: "Cooki saared") },
                { "fin", new CountryName(official: "Cookinsaaret", common: "Cookinsaaret") },
                { "fra", new CountryName(official: "Îles Cook", common: "Îles Cook") },
                { "hrv", new CountryName(official: "Cook Islands", common: "Cookovo Otočje") },
                { "hun", new CountryName(official: "Cook-szigetek", common: "Cook-szigetek") },
                { "ita", new CountryName(official: "Isole Cook", common: "Isole Cook") },
                { "jpn", new CountryName(official: "クック諸島", common: "クック諸島") },
                { "kor", new CountryName(official: "쿡 제도", common: "쿡 제도") },
                { "nld", new CountryName(official: "Cook eilanden", common: "Cookeilanden") },
                { "per", new CountryName(official: "جزایر کوک", common: "جزایر کوک") },
                { "pol", new CountryName(official: "Wyspy Cooka", common: "Wyspy Cooka") },
                { "por", new CountryName(official: "Ilhas Cook", common: "Ilhas Cook") },
                { "rus", new CountryName(official: "острова Кука", common: "Острова Кука") },
                { "slk", new CountryName(official: "Cookove ostrovy", common: "Cookove ostrovy") },
                { "spa", new CountryName(official: "Islas Cook", common: "Islas Cook") },
                { "swe", new CountryName(official: "Cooköarna", common: "Cooköarna") },
                { "urd", new CountryName(official: "جزائر کک", common: "جزائر کک") },
                { "zho", new CountryName(official: "库克群岛", common: "库克群岛") },
            },
            cca2: "CK",
            cca3: "COK",
            ccn3: "184",
            cioc: "COK",
            flag: "🇨🇰",
            region: Region.Oceania,
            subregion: "Polynesia",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"82", }),
            borders: new string[] {  },
            capital: new string[] { "Avarua",  },
            altSpellings: new string[] { "CK", "Kūki 'Āirani",  },
            tld: new string[] { ".ck",  },
            latlng: new double[] { -21.23333333, -159.76666666,  },
            timezones: new string[] { "UTC-10:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Cook Islands Māori", iso6391: "", iso6392: "rar"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "CKD", name: "Cook Islands dollar", symbol: "$"),
                new Currency(code: "NZD", name: "New Zealand dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Cook Islander", female: "Cook Islander") },
                { "fra", new DemonymsGender(male: "Cook Islander", female: "Cook Islander") },
            }
        );

        /// <summary>
        /// create an instance of CookIslands country
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
        private CookIslands(
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
