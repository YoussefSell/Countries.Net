namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Martinique country
    /// </summary>
    public class Martinique : Country
    {
        /// <summary>
        /// get the Martinique country instance
        /// </summary>
        public static Martinique Instance = new Martinique(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Martinique", common: "Martinique") },
                { "fra", new CountryName(official: "Martinique", common: "Martinique") },
                { "ara", new CountryName(official: "مارتينيك", common: "مارتينيك") },
                { "ces", new CountryName(official: "Martinik", common: "Martinik") },
                { "cym", new CountryName(official: "Martinique", common: "Martinique") },
                { "deu", new CountryName(official: "Martinique", common: "Martinique") },
                { "est", new CountryName(official: "Martinique’i departemang", common: "Martinique") },
                { "fin", new CountryName(official: "Martinique", common: "Martinique") },
                { "hrv", new CountryName(official: "Martinique", common: "Martinique") },
                { "hun", new CountryName(official: "Martinique", common: "Martinique") },
                { "ita", new CountryName(official: "Martinique", common: "Martinica") },
                { "jpn", new CountryName(official: "マルティニーク島", common: "マルティニーク") },
                { "kor", new CountryName(official: "마르티니크", common: "마르티니크") },
                { "nld", new CountryName(official: "Martinique", common: "Martinique") },
                { "per", new CountryName(official: "مارتینیک", common: "مارتینیک") },
                { "pol", new CountryName(official: "Martynika", common: "Martynika") },
                { "por", new CountryName(official: "Martinique", common: "Martinica") },
                { "rus", new CountryName(official: "Мартиника", common: "Мартиника") },
                { "slk", new CountryName(official: "Martinique", common: "Martinique") },
                { "spa", new CountryName(official: "Martinica", common: "Martinica") },
                { "swe", new CountryName(official: "Martinique", common: "Martinique") },
                { "urd", new CountryName(official: "مارٹینیک", common: "مارٹینیک") },
                { "zho", new CountryName(official: "马提尼克", common: "马提尼克") },

            },
            cca2: "MQ",
            cca3: "MTQ",
            ccn3: "474",
            cioc: "",
            flag: "🇲🇶",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"96", }),
            borders: new string[] {  },
            capital: new string[] { "Fort-de-France",  },
            altSpellings: new string[] { "MQ",  },
            tld: new string[] { ".mq",  },
            latlng: new double[] { 14.666667, -61,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Martinican", female: "Martinican") },
                { "fra", new DemonymsGender(male: "Martinican", female: "Martinican") },
            }
        );

        /// <summary>
        /// create an instance of Martinique country
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
        private Martinique(
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
