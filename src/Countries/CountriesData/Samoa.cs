namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Samoa country
    /// </summary>
    public class Samoa : Country
    {
        /// <summary>
        /// get the Samoa country instance
        /// </summary>
        public static Samoa Instance = new Samoa(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Independent State of Samoa", common: "Samoa") },
                { "smo", new CountryName(official: "Malo Saʻoloto Tutoʻatasi o Sāmoa", common: "Sāmoa") },
                { "ara", new CountryName(official: "دولة ساموا المستقلة", common: "ساموا") },
                { "ces", new CountryName(official: "Nezávislý stát Samoa", common: "Samoa") },
                { "cym", new CountryName(official: "Independent State of Samoa", common: "Samoa") },
                { "deu", new CountryName(official: "Unabhängige Staat Samoa", common: "Samoa") },
                { "est", new CountryName(official: "Samoa Iseseisvusriik", common: "Samoa") },
                { "fin", new CountryName(official: "Samoan itsenäinen valtio", common: "Samoa") },
                { "fra", new CountryName(official: "Samoa", common: "Samoa") },
                { "hrv", new CountryName(official: "Nezavisna Država Samoa", common: "Samoa") },
                { "hun", new CountryName(official: "Szamoai Független Állam", common: "Szamoa") },
                { "ita", new CountryName(official: "Stato indipendente di Samoa", common: "Samoa") },
                { "jpn", new CountryName(official: "サモア独立国", common: "サモア") },
                { "kor", new CountryName(official: "사모아 독립국", common: "사모아") },
                { "nld", new CountryName(official: "Onafhankelijke Staat Samoa", common: "Samoa") },
                { "per", new CountryName(official: "ایالت مستقل ساموآ", common: "ساموآ") },
                { "pol", new CountryName(official: "Niezależne Państwo Samoa", common: "Samoa") },
                { "por", new CountryName(official: "Estado Independente de Samoa", common: "Samoa") },
                { "rus", new CountryName(official: "Независимое Государство Самоа", common: "Самоа") },
                { "slk", new CountryName(official: "Nezávislý štátSamoa", common: "Samoa") },
                { "spa", new CountryName(official: "Estado Independiente de Samoa", common: "Samoa") },
                { "swe", new CountryName(official: "Självständiga staten Samoa", common: "Samoa") },
                { "urd", new CountryName(official: "آزاد سلطنتِ ساموا", common: "سامووا") },
                { "zho", new CountryName(official: "萨摩亚独立国", common: "萨摩亚") },
            },
            cca2: "WS",
            cca3: "WSM",
            ccn3: "882",
            cioc: "SAM",
            flag: "🇼🇸",
            region: Region.Oceania,
            subregion: "Polynesia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"85", }),
            borders: new string[] {  },
            capital: new string[] { "Apia",  },
            altSpellings: new string[] { "WS", "Independent State of Samoa", "Malo Saʻoloto Tutoʻatasi o Sāmoa",  },
            tld: new string[] { ".ws",  },
            latlng: new double[] { -13.58333333, -172.33333333,  },
            timezones: new string[] { "UTC+13:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Samoan", iso6391: "sm", iso6392: "smo"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "WST", name: "Samoan tālā", symbol: "T"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Samoan", female: "Samoan") },
                { "fra", new DemonymsGender(male: "Samoan", female: "Samoan") },
            }
        );

        /// <summary>
        /// create an instance of Samoa country
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
        private Samoa(
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
