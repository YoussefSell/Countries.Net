namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Guernsey country
    /// </summary>
    public class Guernsey : Country
    {
        /// <summary>
        /// get the Guernsey country instance
        /// </summary>
        public static Guernsey Instance = new Guernsey(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Bailiwick of Guernsey", common: "Guernsey") },
                { "fra", new CountryName(official: "Bailliage de Guernesey", common: "Guernesey") },
                { "nfr", new CountryName(official: "Dgèrnésiais", common: "Dgèrnésiais") },
                { "ara", new CountryName(official: "غيرنزي", common: "غيرنزي") },
                { "ces", new CountryName(official: "Rychtářství Guernsey", common: "Guernsey") },
                { "cym", new CountryName(official: "Bailiwick of Guernsey", common: "Guernsey") },
                { "deu", new CountryName(official: "Vogtei Guernsey", common: "Guernsey") },
                { "est", new CountryName(official: "Guernsey foogtkond", common: "Guernsey") },
                { "fin", new CountryName(official: "Guernsey", common: "Guernsey") },
                { "hrv", new CountryName(official: "Struka Guernsey", common: "Guernsey") },
                { "hun", new CountryName(official: "Guernsey", common: "Guernsey") },
                { "ita", new CountryName(official: "Baliato di Guernsey", common: "Guernsey") },
                { "jpn", new CountryName(official: "ガーンジーの得意分野", common: "ガーンジー") },
                { "kor", new CountryName(official: "건지 섬", common: "건지 섬") },
                { "nld", new CountryName(official: "Baljuwschap Guernsey", common: "Guernsey") },
                { "per", new CountryName(official: "گرنزی", common: "گرنزی") },
                { "pol", new CountryName(official: "Baliwat Guernsey", common: "Guernsey") },
                { "por", new CountryName(official: "Bailiado de Guernsey", common: "Guernsey") },
                { "rus", new CountryName(official: "Коронное владение Гернси", common: "Гернси") },
                { "slk", new CountryName(official: "Guernsey", common: "Guernsey") },
                { "spa", new CountryName(official: "Bailía de Guernsey", common: "Guernsey") },
                { "swe", new CountryName(official: "Guernsey", common: "Guernsey") },
                { "urd", new CountryName(official: "گرنزی رودبار", common: "گرنزی") },
                { "zho", new CountryName(official: "根西岛", common: "根西岛") },

            },
            cca2: "GG",
            cca3: "GGY",
            ccn3: "831",
            cioc: "",
            flag: "🇬🇬",
            region: Region.Europe,
            subregion: "Northern Europe",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"4", }),
            borders: new string[] {  },
            capital: new string[] { "St. Peter Port",  },
            altSpellings: new string[] { "GG", "Bailiwick of Guernsey", "Bailliage de Guernesey",  },
            tld: new string[] { ".gg",  },
            latlng: new double[] { 49.46666666, -2.58333333,  },
            timezones: new string[] { "UTC+00:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
                new Language(name: "Guernésiais", iso6391: "", iso6392: "nfr"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "GBP", name: "British pound", symbol: "£"),
                new Currency(code: "GGP", name: "Guernsey pound", symbol: "£"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Channel Islander", female: "Channel Islander") },
                { "fra", new DemonymsGender(male: "Channel Islander", female: "Channel Islander") },
            }
        );

        /// <summary>
        /// create an instance of Guernsey country
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
        private Guernsey(
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
