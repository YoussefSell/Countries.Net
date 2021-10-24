namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Réunion country
    /// </summary>
    public class Réunion : Country
    {
        /// <summary>
        /// get the Réunion country instance
        /// </summary>
        public static Réunion Instance = new Réunion(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Réunion Island", common: "Réunion") },
                { "fra", new CountryName(official: "Ile de la Réunion", common: "La Réunion") },
                { "ara", new CountryName(official: "جزيرة لا ريونيون", common: "لا ريونيون") },
                { "ces", new CountryName(official: "Réunion", common: "Réunion") },
                { "cym", new CountryName(official: "Réunion Island", common: "Réunion") },
                { "deu", new CountryName(official: "Réunion", common: "Réunion") },
                { "est", new CountryName(official: "Réunioni departemang", common: "Réunion") },
                { "fin", new CountryName(official: "Réunion", common: "Réunion") },
                { "hrv", new CountryName(official: "Réunion Island", common: "Réunion") },
                { "hun", new CountryName(official: "Réunion", common: "Réunion") },
                { "ita", new CountryName(official: "Réunion", common: "Riunione") },
                { "jpn", new CountryName(official: "レユニオン島", common: "レユニオン") },
                { "kor", new CountryName(official: "레위니옹", common: "레위니옹") },
                { "nld", new CountryName(official: "Réunion", common: "Réunion") },
                { "per", new CountryName(official: "رئونیون", common: "رئونیون") },
                { "pol", new CountryName(official: "Reunion", common: "Reunion") },
                { "por", new CountryName(official: "Ilha da Reunião", common: "Reunião") },
                { "rus", new CountryName(official: "Реюньон", common: "Реюньон") },
                { "slk", new CountryName(official: "Réunionský zámorský departmán", common: "Réunion") },
                { "spa", new CountryName(official: "Isla de la Reunión", common: "Reunión") },
                { "swe", new CountryName(official: "Réunion", common: "Réunion") },
                { "urd", new CountryName(official: "رے یونیوں جزیرہ", common: "رے یونیوں") },
                { "zho", new CountryName(official: "留尼旺岛", common: "留尼旺岛") },

            },
            cca2: "RE",
            cca3: "REU",
            ccn3: "638",
            cioc: "",
            flag: "🇷🇪",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"62", }),
            borders: new string[] {  },
            capital: new string[] { "Saint-Denis",  },
            altSpellings: new string[] { "RE", "Reunion",  },
            tld: new string[] { ".re",  },
            latlng: new double[] { -21.15, 55.5,  },
            timezones: new string[] { "UTC+04:00",  },
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
                { "eng", new DemonymsGender(male: "Réunionese", female: "Réunionese") },
                { "fra", new DemonymsGender(male: "Réunionese", female: "Réunionese") },
            }
        );

        /// <summary>
        /// create an instance of Réunion country
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
        private Réunion(
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
