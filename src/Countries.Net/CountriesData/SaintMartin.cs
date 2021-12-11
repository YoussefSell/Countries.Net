namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of SaintMartin country
    /// </summary>
    public class SaintMartin : Country
    {
        /// <summary>
        /// get the SaintMartin country instance
        /// </summary>
        public static SaintMartin Instance = new SaintMartin(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Saint Martin", common: "Saint Martin") },
                { "fra", new CountryName(official: "Saint-Martin", common: "Saint-Martin") },
                { "ara", new CountryName(official: "سانت مارتن", common: "سانت مارتن") },
                { "ces", new CountryName(official: "Svatý Martin", common: "Svatý Martin (Francie)") },
                { "cym", new CountryName(official: "Saint Martin", common: "Saint Martin") },
                { "deu", new CountryName(official: "Saint-Martin", common: "Saint-Martin") },
                { "est", new CountryName(official: "Saint-Martini ühendus", common: "Saint-Martin") },
                { "fin", new CountryName(official: "Saint-Martin", common: "Saint-Martin") },
                { "hrv", new CountryName(official: "Saint Martin", common: "Sveti Martin") },
                { "hun", new CountryName(official: "Saint-Martin Közösség", common: "Saint-Martin") },
                { "ita", new CountryName(official: "saint Martin", common: "Saint Martin") },
                { "jpn", new CountryName(official: "サンマルタン島", common: "サン・マルタン（フランス領）") },
                { "kor", new CountryName(official: "생마르탱", common: "생마르탱") },
                { "nld", new CountryName(official: "Saint Martin", common: "Saint-Martin") },
                { "per", new CountryName(official: "سن مارتن", common: "سن مارتن") },
                { "pol", new CountryName(official: "Wspólnota Saint-Martin", common: "Saint-Martin") },
                { "por", new CountryName(official: "saint Martin", common: "São Martinho") },
                { "rus", new CountryName(official: "Сен-Мартен", common: "Сен-Мартен") },
                { "slk", new CountryName(official: "Saint-Martin", common: "Saint-Martin") },
                { "spa", new CountryName(official: "Saint Martin", common: "Saint Martin") },
                { "swe", new CountryName(official: "Förvaltningsområdet Saint-Martin", common: "Saint-Martin") },
                { "urd", new CountryName(official: "سینٹ مارٹن", common: "سینٹ مارٹن") },
                { "zho", new CountryName(official: "圣马丁", common: "圣马丁") },

            },
            cca2: "MF",
            cca3: "MAF",
            ccn3: "663",
            cioc: "",
            flag: "🇲🇫",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"90", }),
            borders: new string[] { "SXM",  },
            capital: new string[] { "Marigot",  },
            altSpellings: new string[] { "MF", "Collectivity of Saint Martin", "Collectivité de Saint-Martin", "Saint Martin (French part)",  },
            tld: new string[] { ".fr", ".gp",  },
            latlng: new double[] { 18.08333333, -63.95,  },
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
                { "eng", new DemonymsGender(male: "Saint Martin Islander", female: "Saint Martin Islander") },
                { "fra", new DemonymsGender(male: "Saint Martin Islander", female: "Saint Martin Islander") },
            }
        );

        /// <summary>
        /// create an instance of SaintMartin country
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
        private SaintMartin(
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
