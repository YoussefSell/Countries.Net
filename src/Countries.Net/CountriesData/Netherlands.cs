namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Netherlands country
    /// </summary>
    public class Netherlands : Country
    {
        /// <summary>
        /// get the Netherlands country instance
        /// </summary>
        public static Netherlands Instance = new Netherlands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Kingdom of the Netherlands", common: "Netherlands") },
                { "nld", new CountryName(official: "Koninkrijk der Nederlanden", common: "Nederland") },
                { "ara", new CountryName(official: "مملكة هولندا", common: "هولندا") },
                { "ces", new CountryName(official: "Nizozemské království", common: "Nizozemsko") },
                { "cym", new CountryName(official: "Kingdom of the Netherlands", common: "Netherlands") },
                { "deu", new CountryName(official: "Niederlande", common: "Niederlande") },
                { "est", new CountryName(official: "Madalmaade Kuningriik", common: "Holland") },
                { "fin", new CountryName(official: "Alankomaat", common: "Alankomaat") },
                { "fra", new CountryName(official: "Pays-Bas", common: "Pays-Bas") },
                { "hrv", new CountryName(official: "Holandija", common: "Nizozemska") },
                { "hun", new CountryName(official: "Holland Királyság", common: "Hollandia") },
                { "ita", new CountryName(official: "Paesi Bassi", common: "Paesi Bassi") },
                { "jpn", new CountryName(official: "オランダ", common: "オランダ") },
                { "kor", new CountryName(official: "네덜란드 왕국", common: "네덜란드") },
                { "per", new CountryName(official: "هلند", common: "هلند") },
                { "pol", new CountryName(official: "Królestwo Niderlandów", common: "Holandia") },
                { "por", new CountryName(official: "Holanda", common: "Holanda") },
                { "rus", new CountryName(official: "Нидерланды", common: "Нидерланды") },
                { "slk", new CountryName(official: "Holandské kráľovstvo", common: "Holansko") },
                { "spa", new CountryName(official: "Países Bajos", common: "Países Bajos") },
                { "swe", new CountryName(official: "Nederländerna", common: "Nederländerna") },
                { "urd", new CountryName(official: "مملکتِ نیدرلینڈز", common: "نیدرلینڈز") },
                { "zho", new CountryName(official: "荷兰", common: "荷兰") },

            },
            cca2: "NL",
            cca3: "NLD",
            ccn3: "528",
            cioc: "NED",
            flag: "🇳🇱",
            region: Region.Europe,
            subregion: "Western Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"1", }),
            borders: new string[] { "BEL", "DEU",  },
            capital: new string[] { "Amsterdam",  },
            altSpellings: new string[] { "NL", "Holland", "Nederland", "The Netherlands",  },
            tld: new string[] { ".nl",  },
            latlng: new double[] { 52.5, 5.75,  },
            timezones: new string[] { "UTC-04:00", "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Dutch", iso6391: "nl", iso6392: "nld"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Dutch", female: "Dutch") },
                { "fra", new DemonymsGender(male: "Dutch", female: "Dutch") },
            }
        );

        /// <summary>
        /// create an instance of Netherlands country
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
        private Netherlands(
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
