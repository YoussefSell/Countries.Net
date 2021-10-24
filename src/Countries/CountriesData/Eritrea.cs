namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Eritrea country
    /// </summary>
    public class Eritrea : Country
    {
        /// <summary>
        /// get the Eritrea country instance
        /// </summary>
        public static Eritrea Instance = new Eritrea(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "State of Eritrea", common: "Eritrea") },
                { "ara", new CountryName(official: "دولة إرتريا", common: "إرتريا‎") },
                { "tir", new CountryName(official: "ሃገረ ኤርትራ", common: "ኤርትራ") },
                { "ces", new CountryName(official: "Stát Eritrea", common: "Eritrea") },
                { "cym", new CountryName(official: "Gwladwriaeth Eritrea", common: "Eritrea") },
                { "deu", new CountryName(official: "Staat Eritrea", common: "Eritrea") },
                { "est", new CountryName(official: "Eritrea Riik", common: "Eritrea") },
                { "fin", new CountryName(official: "Eritrean valtio", common: "Eritrea") },
                { "fra", new CountryName(official: "État d'Érythrée", common: "Érythrée") },
                { "hrv", new CountryName(official: "Država Eritreji", common: "Eritreja") },
                { "hun", new CountryName(official: "Eritrea", common: "Eritrea") },
                { "ita", new CountryName(official: "Stato di Eritrea", common: "Eritrea") },
                { "jpn", new CountryName(official: "エリトリア国", common: "エリトリア") },
                { "kor", new CountryName(official: "에리트레아국", common: "에리트레아") },
                { "nld", new CountryName(official: "Staat Eritrea", common: "Eritrea") },
                { "per", new CountryName(official: "جمهوری اریتره", common: "اریتره") },
                { "pol", new CountryName(official: "Państwo Erytrea", common: "Erytrea") },
                { "por", new CountryName(official: "Estado da Eritreia", common: "Eritreia") },
                { "rus", new CountryName(official: "Государство Эритрея", common: "Эритрея") },
                { "slk", new CountryName(official: "Eritrejský štát", common: "Eritrea") },
                { "spa", new CountryName(official: "Estado de Eritrea", common: "Eritrea") },
                { "swe", new CountryName(official: "Staten Eritrea", common: "Eritrea") },
                { "urd", new CountryName(official: "ریاستِ ارتریا", common: "ارتریا") },
                { "zho", new CountryName(official: "厄立特里亚", common: "厄立特里亚") },

            },
            cca2: "ER",
            cca3: "ERI",
            ccn3: "232",
            cioc: "ERI",
            flag: "🇪🇷",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"91", }),
            borders: new string[] { "DJI", "ETH", "SDN",  },
            capital: new string[] { "Asmara",  },
            altSpellings: new string[] { "ER", "State of Eritrea", "ሃገረ ኤርትራ", "Dawlat Iritriyá", "ʾErtrā", "Iritriyā",  },
            tld: new string[] { ".er",  },
            latlng: new double[] { 15, 39,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Tigrinya", iso6391: "ti", iso6392: "tir"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "ERN", name: "Eritrean nakfa", symbol: "Nfk"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Eritrean", female: "Eritrean") },
                { "fra", new DemonymsGender(male: "Eritrean", female: "Eritrean") },
            }
        );

        /// <summary>
        /// create an instance of Eritrea country
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
        private Eritrea(
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
