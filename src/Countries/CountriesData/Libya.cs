namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Libya country
    /// </summary>
    public class Libya : Country
    {
        /// <summary>
        /// get the Libya country instance
        /// </summary>
        public static Libya Instance = new Libya(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "State of Libya", common: "Libya") },
                { "ara", new CountryName(official: "الدولة ليبيا", common: "‏ليبيا") },
                { "ces", new CountryName(official: "Stát Libye", common: "Libye") },
                { "cym", new CountryName(official: "State of Libya", common: "Libya") },
                { "deu", new CountryName(official: "Staat Libyen", common: "Libyen") },
                { "est", new CountryName(official: "Liibüa", common: "Liibüa") },
                { "fin", new CountryName(official: "Libyan valtio", common: "Libya") },
                { "fra", new CountryName(official: "Grande République arabe libyenne populaire et socialiste", common: "Libye") },
                { "hrv", new CountryName(official: "Država Libiji", common: "Libija") },
                { "hun", new CountryName(official: "Líbia Állam", common: "Líbia") },
                { "ita", new CountryName(official: "Stato della Libia", common: "Libia") },
                { "jpn", new CountryName(official: "リビアの国家", common: "リビア") },
                { "kor", new CountryName(official: "리비아", common: "리비아") },
                { "nld", new CountryName(official: "Staat van Libië", common: "Libië") },
                { "per", new CountryName(official: "دولت لیبی", common: "لیبی") },
                { "pol", new CountryName(official: "Państwo Libia", common: "Libia") },
                { "por", new CountryName(official: "Estado da Líbia", common: "Líbia") },
                { "rus", new CountryName(official: "Государство Ливии", common: "Ливия") },
                { "slk", new CountryName(official: "Líbya", common: "Líbya") },
                { "spa", new CountryName(official: "Estado de Libia", common: "Libia") },
                { "swe", new CountryName(official: "Staten Libyen", common: "Libyen") },
                { "urd", new CountryName(official: "ریاستِ لیبیا", common: "لیبیا") },
                { "zho", new CountryName(official: "利比亚国", common: "利比亚") },

            },
            cca2: "LY",
            cca3: "LBY",
            ccn3: "434",
            cioc: "LBA",
            flag: "🇱🇾",
            region: Region.Africa,
            subregion: "Northern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"18", }),
            borders: new string[] { "DZA", "TCD", "EGY", "NER", "SDN", "TUN",  },
            capital: new string[] { "Tripoli",  },
            altSpellings: new string[] { "LY", "State of Libya", "Dawlat Libya",  },
            tld: new string[] { ".ly",  },
            latlng: new double[] { 25, 17,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "LYD", name: "Libyan dinar", symbol: "ل.د"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Libyan", female: "Libyan") },
                { "fra", new DemonymsGender(male: "Libyan", female: "Libyan") },
            }
        );

        /// <summary>
        /// create an instance of Libya country
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
        private Libya(
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
