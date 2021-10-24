namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Jersey country
    /// </summary>
    public class Jersey : Country
    {
        /// <summary>
        /// get the Jersey country instance
        /// </summary>
        public static Jersey Instance = new Jersey(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Bailiwick of Jersey", common: "Jersey") },
                { "fra", new CountryName(official: "Bailliage de Jersey", common: "Jersey") },
                { "nrf", new CountryName(official: "Bailliage dé Jèrri", common: "Jèrri") },
                { "ara", new CountryName(official: "جيرزي", common: "جيرزي") },
                { "ces", new CountryName(official: "Rychtářství Jersey", common: "Jersey") },
                { "cym", new CountryName(official: "Bailiwick of Jersey", common: "Jersey") },
                { "deu", new CountryName(official: "Vogtei Jersey", common: "Jersey") },
                { "est", new CountryName(official: "Jersey foogtkond", common: "Jersey") },
                { "fin", new CountryName(official: "Jersey", common: "Jersey") },
                { "hrv", new CountryName(official: "Struka od Jersey", common: "Jersey") },
                { "hun", new CountryName(official: "Jersey", common: "Jersey") },
                { "ita", new CountryName(official: "Baliato di Jersey", common: "Isola di Jersey") },
                { "jpn", new CountryName(official: "ジャージの得意分野", common: "ジャージー") },
                { "kor", new CountryName(official: "저지 섬", common: "저지 섬") },
                { "nld", new CountryName(official: "Baljuwschap Jersey", common: "Jersey") },
                { "per", new CountryName(official: "جرزی", common: "جرزی") },
                { "pol", new CountryName(official: "Jersey", common: "Jersey") },
                { "por", new CountryName(official: "Bailiado de Jersey", common: "Jersey") },
                { "rus", new CountryName(official: "Коронное владение Джерси", common: "Джерси") },
                { "slk", new CountryName(official: "Bailiwick Jersey", common: "Jersey") },
                { "spa", new CountryName(official: "Bailía de Jersey", common: "Jersey") },
                { "swe", new CountryName(official: "Jersey", common: "Jersey") },
                { "urd", new CountryName(official: "جرزی", common: "جرزی") },
                { "zho", new CountryName(official: "泽西岛", common: "泽西岛") },

            },
            cca2: "JE",
            cca3: "JEY",
            ccn3: "832",
            cioc: "",
            flag: "🇯🇪",
            region: Region.Europe,
            subregion: "Northern Europe",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"4", }),
            borders: new string[] {  },
            capital: new string[] { "Saint Helier",  },
            altSpellings: new string[] { "JE", "Bailiwick of Jersey", "Bailliage de Jersey", "Bailliage dé Jèrri",  },
            tld: new string[] { ".je",  },
            latlng: new double[] { 49.25, -2.16666666,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
                new Language(name: "Jèrriais", iso6391: "", iso6392: "nrf"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "GBP", name: "British pound", symbol: "£"),
                new Currency(code: "JEP", name: "Jersey pound", symbol: "£"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Channel Islander", female: "Channel Islander") },
                { "fra", new DemonymsGender(male: "Channel Islander", female: "Channel Islander") },
            }
        );

        /// <summary>
        /// create an instance of Jersey country
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
        private Jersey(
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
