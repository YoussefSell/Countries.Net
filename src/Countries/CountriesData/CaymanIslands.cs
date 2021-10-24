namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of CaymanIslands country
    /// </summary>
    public class CaymanIslands : Country
    {
        /// <summary>
        /// get the CaymanIslands country instance
        /// </summary>
        public static CaymanIslands Instance = new CaymanIslands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Cayman Islands", common: "Cayman Islands") },
                { "ara", new CountryName(official: "جزر كايمان", common: "جزر كايمان") },
                { "ces", new CountryName(official: "Kajmanské ostrovy", common: "Kajmanské ostrovy") },
                { "cym", new CountryName(official: "Ynysoedd Cayman", common: "Ynysoedd Cayman") },
                { "deu", new CountryName(official: "Cayman-Inseln", common: "Kaimaninseln") },
                { "est", new CountryName(official: "Kaimanisaared", common: "Kaimanisaared") },
                { "fin", new CountryName(official: "Caymansaaret", common: "Caymansaaret") },
                { "fra", new CountryName(official: "Îles Caïmans", common: "Îles Caïmans") },
                { "hrv", new CountryName(official: "Kajmanski otoci", common: "Kajmanski otoci") },
                { "hun", new CountryName(official: "Kajmán-szigetek", common: "Kajmán-szigetek") },
                { "ita", new CountryName(official: "Isole Cayman", common: "Isole Cayman") },
                { "jpn", new CountryName(official: "ケイマン諸島", common: "ケイマン諸島") },
                { "kor", new CountryName(official: "케이맨 제도", common: "케이맨 제도") },
                { "nld", new CountryName(official: "Caymaneilanden", common: "Caymaneilanden") },
                { "per", new CountryName(official: "جزایر کیمن", common: "جزایر کیمن") },
                { "pol", new CountryName(official: "Kajmany", common: "Kajmany") },
                { "por", new CountryName(official: "Ilhas Cayman", common: "Ilhas Caimão") },
                { "rus", new CountryName(official: "Каймановы острова", common: "Каймановы острова") },
                { "slk", new CountryName(official: "Kajmanie ostrovy", common: "Kajmanie ostrovy") },
                { "spa", new CountryName(official: "Islas Caimán", common: "Islas Caimán") },
                { "swe", new CountryName(official: "Caymanöarna", common: "Caymanöarna") },
                { "urd", new CountryName(official: "جزائر کیمین", common: "جزائر کیمین") },
                { "zho", new CountryName(official: "开曼群岛", common: "开曼群岛") },
            },
            cca2: "KY",
            cca3: "CYM",
            ccn3: "136",
            cioc: "CAY",
            flag: "🇰🇾",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"345", }),
            borders: new string[] {  },
            capital: new string[] { "George Town",  },
            altSpellings: new string[] { "KY",  },
            tld: new string[] { ".ky",  },
            latlng: new double[] { 19.5, -80.5,  },
            timezones: new string[] { "UTC-05:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "KYD", name: "Cayman Islands dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Caymanian", female: "Caymanian") },
                { "fra", new DemonymsGender(male: "Caymanian", female: "Caymanian") },
            }
        );

        /// <summary>
        /// create an instance of CaymanIslands country
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
        private CaymanIslands(
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
