namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Aruba country
    /// </summary>
    public class Aruba : Country
    {
        /// <summary>
        /// get the Aruba country instance
        /// </summary>
        public static Aruba Instance = new Aruba(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Aruba", common: "Aruba") },
                { "nld", new CountryName(official: "Aruba", common: "Aruba") },
                { "pap", new CountryName(official: "Aruba", common: "Aruba") },
                { "ara", new CountryName(official: "أروبا", common: "أروبا") },
                { "ces", new CountryName(official: "Aruba", common: "Aruba") },
                { "cym", new CountryName(official: "Aruba", common: "Aruba") },
                { "deu", new CountryName(official: "Aruba", common: "Aruba") },
                { "est", new CountryName(official: "Aruba", common: "Aruba") },
                { "fin", new CountryName(official: "Aruba", common: "Aruba") },
                { "fra", new CountryName(official: "Aruba", common: "Aruba") },
                { "hrv", new CountryName(official: "Aruba", common: "Aruba") },
                { "hun", new CountryName(official: "Aruba", common: "Aruba") },
                { "ita", new CountryName(official: "Aruba", common: "Aruba") },
                { "jpn", new CountryName(official: "アルバ", common: "アルバ") },
                { "kor", new CountryName(official: "아루바", common: "아루바") },
                { "per", new CountryName(official: "آروبا", common: "آروبا") },
                { "pol", new CountryName(official: "Aruba", common: "Aruba") },
                { "por", new CountryName(official: "Aruba", common: "Aruba") },
                { "rus", new CountryName(official: "Аруба", common: "Аруба") },
                { "slk", new CountryName(official: "Aruba", common: "Aruba") },
                { "spa", new CountryName(official: "Aruba", common: "Aruba") },
                { "swe", new CountryName(official: "Aruba", common: "Aruba") },
                { "urd", new CountryName(official: "اروبا", common: "اروبا") },
                { "zho", new CountryName(official: "阿鲁巴", common: "阿鲁巴") },

            },
            cca2: "AW",
            cca3: "ABW",
            ccn3: "533",
            cioc: "ARU",
            flag: "🇦🇼",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"97", }),
            borders: new string[] {  },
            capital: new string[] { "Oranjestad",  },
            altSpellings: new string[] { "AW",  },
            tld: new string[] { ".aw",  },
            latlng: new double[] { 12.5, -69.96666666,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "Dutch", iso6391: "nl", iso6392: "nld"),
                new Language(name: "Papiamento", iso6391: "pap", iso6392: "pap"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "AWG", name: "Aruban florin", symbol: "ƒ"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Aruban", female: "Aruban") },
                { "fra", new DemonymsGender(male: "Aruban", female: "Aruban") },
            }
        );

        /// <summary>
        /// create an instance of Aruba country
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
        private Aruba(
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
