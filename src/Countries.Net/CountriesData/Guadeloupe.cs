namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Guadeloupe country
    /// </summary>
    public class Guadeloupe : Country
    {
        /// <summary>
        /// get the Guadeloupe country instance
        /// </summary>
        public static Guadeloupe Instance = new Guadeloupe(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Guadeloupe", common: "Guadeloupe") },
                { "fra", new CountryName(official: "Guadeloupe", common: "Guadeloupe") },
                { "ara", new CountryName(official: "غوادلوب", common: "غوادلوب") },
                { "ces", new CountryName(official: "Guadeloupe", common: "Guadeloupe") },
                { "cym", new CountryName(official: "Guadeloupe", common: "Guadeloupe") },
                { "deu", new CountryName(official: "Guadeloupe", common: "Guadeloupe") },
                { "est", new CountryName(official: "Guadeloupe’i ja sõltkondade departemang", common: "Guadeloupe") },
                { "fin", new CountryName(official: "Guadeloupen departmentti", common: "Guadeloupe") },
                { "hrv", new CountryName(official: "Gvadalupa", common: "Gvadalupa") },
                { "hun", new CountryName(official: "Guadeloupe", common: "Guadeloupe") },
                { "ita", new CountryName(official: "Guadeloupe", common: "Guadeloupa") },
                { "jpn", new CountryName(official: "グアドループ島", common: "グアドループ") },
                { "kor", new CountryName(official: "과들루프", common: "과들루프") },
                { "nld", new CountryName(official: "Guadeloupe", common: "Guadeloupe") },
                { "per", new CountryName(official: "گوادلوپ", common: "گوادلوپ") },
                { "pol", new CountryName(official: "Gwadelupa", common: "Gwadelupa") },
                { "por", new CountryName(official: "Guadalupe", common: "Guadalupe") },
                { "rus", new CountryName(official: "Гваделупа", common: "Гваделупа") },
                { "slk", new CountryName(official: "Guadeloupe", common: "Guadeloupe") },
                { "spa", new CountryName(official: "Guadalupe", common: "Guadalupe") },
                { "swe", new CountryName(official: "Guadeloupe", common: "Guadeloupe") },
                { "urd", new CountryName(official: "گواڈیلوپ", common: "گواڈیلوپ") },
                { "zho", new CountryName(official: "瓜德罗普岛", common: "瓜德罗普岛") },

            },
            cca2: "GP",
            cca3: "GLP",
            ccn3: "312",
            cioc: "",
            flag: "🇬🇵",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"90", }),
            borders: new string[] {  },
            capital: new string[] { "Basse-Terre",  },
            altSpellings: new string[] { "GP", "Gwadloup",  },
            tld: new string[] { ".gp",  },
            latlng: new double[] { 16.25, -61.583333,  },
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
                { "eng", new DemonymsGender(male: "Guadeloupian", female: "Guadeloupian") },
                { "fra", new DemonymsGender(male: "Guadeloupian", female: "Guadeloupian") },
            }
        );

        /// <summary>
        /// create an instance of Guadeloupe country
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
        private Guadeloupe(
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
