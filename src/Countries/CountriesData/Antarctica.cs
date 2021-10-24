namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Antarctica country
    /// </summary>
    public class Antarctica : Country
    {
        /// <summary>
        /// get the Antarctica country instance
        /// </summary>
        public static Antarctica Instance = new Antarctica(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Antarctica", common: "Antarctica") },
                { "ara", new CountryName(official: "أنتارتيكا", common: "أنتارتيكا") },
                { "ces", new CountryName(official: "Antarktida", common: "Antarktida") },
                { "cym", new CountryName(official: "Yr Antarctig", common: "Yr Antarctig") },
                { "deu", new CountryName(official: "Antarktika", common: "Antarktis") },
                { "est", new CountryName(official: "Antarktika", common: "Antarktika") },
                { "fin", new CountryName(official: "Etelämanner", common: "Etelämanner") },
                { "fra", new CountryName(official: "Antarctique", common: "Antarctique") },
                { "hrv", new CountryName(official: "Antarktika", common: "Antarktika") },
                { "hun", new CountryName(official: "Antarktisz", common: "Antarktisz") },
                { "ita", new CountryName(official: "Antartide", common: "Antartide") },
                { "jpn", new CountryName(official: "南極大陸", common: "南極") },
                { "kor", new CountryName(official: "남극", common: "남극") },
                { "nld", new CountryName(official: "Antarctica", common: "Antarctica") },
                { "per", new CountryName(official: "جنوبگان", common: "جنوبگان") },
                { "pol", new CountryName(official: "Antarktyka", common: "Antarktyka") },
                { "por", new CountryName(official: "Antártica", common: "Antártida") },
                { "rus", new CountryName(official: "Антарктида", common: "Антарктида") },
                { "slk", new CountryName(official: "Antarktída", common: "Antarktída") },
                { "spa", new CountryName(official: "Antártida", common: "Antártida") },
                { "swe", new CountryName(official: "Antarktis", common: "Antarktis") },
                { "urd", new CountryName(official: "انٹارکٹکا", common: "انٹارکٹکا") },
                { "zho", new CountryName(official: "南极洲", common: "南极洲") },
            },
            cca2: "AQ",
            cca3: "ATA",
            ccn3: "010",
            cioc: "",
            flag: "🇦🇶",
            region: Region.Antarctic,
            subregion: "",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "", suffixes: new string[] {}),
            borders: new string[] {  },
            capital: new string[] {  },
            altSpellings: new string[] { "AQ",  },
            tld: new string[] { ".aq",  },
            latlng: new double[] { -90, 0,  },
            timezones: new string[] { "UTC-03:00", "UTC+03:00", "UTC+05:00", "UTC+06:00", "UTC+07:00", "UTC+08:00", "UTC+10:00", "UTC+12:00",  },
            languages: new Language[]
            {
                
            },
            currencies: new Currency[]
            {
                
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Antarctican", female: "Antarctican") },
                { "fra", new DemonymsGender(male: "Antarctican", female: "Antarctican") },
            }
        );

        /// <summary>
        /// create an instance of Antarctica country
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
        private Antarctica(
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
