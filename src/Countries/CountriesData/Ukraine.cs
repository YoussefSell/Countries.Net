namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Ukraine country
    /// </summary>
    public class Ukraine : Country
    {
        /// <summary>
        /// get the Ukraine country instance
        /// </summary>
        public static Ukraine Instance = new Ukraine(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Ukraine", common: "Ukraine") },
                { "ukr", new CountryName(official: "Україна", common: "Україна") },
                { "ara", new CountryName(official: "أوكرانيا", common: "أوكرانيا") },
                { "ces", new CountryName(official: "Ukrajina", common: "Ukrajina") },
                { "cym", new CountryName(official: "Ukraine", common: "Ukraine") },
                { "deu", new CountryName(official: "Ukraine", common: "Ukraine") },
                { "est", new CountryName(official: "Ukraina", common: "Ukraina") },
                { "fin", new CountryName(official: "Ukraina", common: "Ukraina") },
                { "fra", new CountryName(official: "Ukraine", common: "Ukraine") },
                { "hrv", new CountryName(official: "Ukrajina", common: "Ukrajina") },
                { "hun", new CountryName(official: "Ukrajna", common: "Ukrajna") },
                { "ita", new CountryName(official: "Ucraina", common: "Ucraina") },
                { "jpn", new CountryName(official: "ウクライナ", common: "ウクライナ") },
                { "kor", new CountryName(official: "우크라이나", common: "우크라이나") },
                { "nld", new CountryName(official: "Oekraïne", common: "Oekraïne") },
                { "per", new CountryName(official: "اوکراین", common: "اوکراین") },
                { "pol", new CountryName(official: "Ukraina", common: "Ukraina") },
                { "por", new CountryName(official: "Ucrânia", common: "Ucrânia") },
                { "rus", new CountryName(official: "Украина", common: "Украина") },
                { "slk", new CountryName(official: "Ukrajina", common: "Ukrajina") },
                { "spa", new CountryName(official: "Ucrania", common: "Ucrania") },
                { "swe", new CountryName(official: "Ukraina", common: "Ukraina") },
                { "urd", new CountryName(official: "یوکرین", common: "یوکرین") },
                { "zho", new CountryName(official: "乌克兰", common: "乌克兰") },
            },
            cca2: "UA",
            cca3: "UKR",
            ccn3: "804",
            cioc: "UKR",
            flag: "🇺🇦",
            region: Region.Europe,
            subregion: "Eastern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"80", }),
            borders: new string[] { "BLR", "HUN", "MDA", "POL", "ROU", "RUS", "SVK",  },
            capital: new string[] { "Kyiv",  },
            altSpellings: new string[] { "UA", "Ukrayina",  },
            tld: new string[] { ".ua", ".укр",  },
            latlng: new double[] { 49, 32,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Ukrainian", iso6391: "uk", iso6392: "ukr"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "UAH", name: "Ukrainian hryvnia", symbol: "₴"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Ukrainian", female: "Ukrainian") },
                { "fra", new DemonymsGender(male: "Ukrainian", female: "Ukrainian") },
            }
        );

        /// <summary>
        /// create an instance of Ukraine country
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
        private Ukraine(
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
