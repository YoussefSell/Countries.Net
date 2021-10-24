namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Canada country
    /// </summary>
    public class Canada : Country
    {
        /// <summary>
        /// get the Canada country instance
        /// </summary>
        public static Canada Instance = new Canada(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Canada", common: "Canada") },
                { "fra", new CountryName(official: "Canada", common: "Canada") },
                { "ara", new CountryName(official: "كندا", common: "كندا") },
                { "ces", new CountryName(official: "Kanada", common: "Kanada") },
                { "cym", new CountryName(official: "Canada", common: "Canada") },
                { "deu", new CountryName(official: "Kanada", common: "Kanada") },
                { "est", new CountryName(official: "Kanada", common: "Kanada") },
                { "fin", new CountryName(official: "Kanada", common: "Kanada") },
                { "hrv", new CountryName(official: "Kanada", common: "Kanada") },
                { "hun", new CountryName(official: "Kanada", common: "Kanada") },
                { "ita", new CountryName(official: "Canada", common: "Canada") },
                { "jpn", new CountryName(official: "カナダ", common: "カナダ") },
                { "kor", new CountryName(official: "캐나다", common: "캐나다") },
                { "nld", new CountryName(official: "Canada", common: "Canada") },
                { "per", new CountryName(official: "کانادا", common: "کانادا") },
                { "pol", new CountryName(official: "Kanada", common: "Kanada") },
                { "por", new CountryName(official: "Canadá", common: "Canadá") },
                { "rus", new CountryName(official: "Канада", common: "Канада") },
                { "slk", new CountryName(official: "Kanada", common: "Kanada") },
                { "spa", new CountryName(official: "Canadá", common: "Canadá") },
                { "swe", new CountryName(official: "Kanada", common: "Kanada") },
                { "urd", new CountryName(official: "کینیڈا", common: "کینیڈا") },
                { "zho", new CountryName(official: "加拿大", common: "加拿大") },

            },
            cca2: "CA",
            cca3: "CAN",
            ccn3: "124",
            cioc: "CAN",
            flag: "🇨🇦",
            region: Region.Americas,
            subregion: "North America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"", }),
            borders: new string[] { "USA",  },
            capital: new string[] { "Ottawa",  },
            altSpellings: new string[] { "CA",  },
            tld: new string[] { ".ca",  },
            latlng: new double[] { 60, -95,  },
            timezones: new string[] { "UTC-08:00", "UTC-07:00", "UTC-06:00", "UTC-05:00", "UTC-04:00", "UTC-03:30",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "CAD", name: "Canadian dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Canadian", female: "Canadian") },
                { "fra", new DemonymsGender(male: "Canadian", female: "Canadian") },
            }
        );

        /// <summary>
        /// create an instance of Canada country
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
        private Canada(
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
