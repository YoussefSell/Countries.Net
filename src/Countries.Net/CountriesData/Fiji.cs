namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Fiji country
    /// </summary>
    public class Fiji : Country
    {
        /// <summary>
        /// get the Fiji country instance
        /// </summary>
        public static Fiji Instance = new Fiji(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Fiji", common: "Fiji") },
                { "fij", new CountryName(official: "Matanitu Tugalala o Viti", common: "Viti") },
                { "hif", new CountryName(official: "रिपब्लिक ऑफ फीजी", common: "फिजी") },
                { "ara", new CountryName(official: "جمهورية جزر فيجي", common: "فيجي") },
                { "ces", new CountryName(official: "Republika Fidžijských ostrovů", common: "Fidži") },
                { "cym", new CountryName(official: "Republic of Fiji", common: "Fiji") },
                { "deu", new CountryName(official: "Republik Fidschi", common: "Fidschi") },
                { "est", new CountryName(official: "Fidži Vabariik", common: "Fidži") },
                { "fin", new CountryName(official: "Fidžin tasavalta", common: "Fidži") },
                { "fra", new CountryName(official: "République des Fidji", common: "Fidji") },
                { "hrv", new CountryName(official: "Republika Fidži", common: "Fiđi") },
                { "hun", new CountryName(official: "Fidzsi-szigeteki Köztársaság", common: "Fidzsi-szigetek") },
                { "ita", new CountryName(official: "Repubblica di Figi", common: "Figi") },
                { "jpn", new CountryName(official: "フィジー共和国", common: "フィジー") },
                { "kor", new CountryName(official: "피지 공화국", common: "피지") },
                { "nld", new CountryName(official: "Republiek Fiji", common: "Fiji") },
                { "per", new CountryName(official: "جمهوری جزایر فیجی", common: "فیجی") },
                { "pol", new CountryName(official: "Republika Fidżi", common: "Fidżi") },
                { "por", new CountryName(official: "República de Fiji", common: "Fiji") },
                { "rus", new CountryName(official: "Республика Фиджи", common: "Фиджи") },
                { "slk", new CountryName(official: "Fiǆijská republika", common: "Fiǆi") },
                { "spa", new CountryName(official: "República de Fiji", common: "Fiyi") },
                { "swe", new CountryName(official: "Republiken Fiji", common: "Fiji") },
                { "urd", new CountryName(official: "جمہوریہ فجی", common: "فجی") },
                { "zho", new CountryName(official: "斐济共和国", common: "斐济") },
            },
            cca2: "FJ",
            cca3: "FJI",
            ccn3: "242",
            cioc: "FIJ",
            flag: "🇫🇯",
            region: Region.Oceania,
            subregion: "Melanesia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"79", }),
            borders: new string[] {  },
            capital: new string[] { "Suva",  },
            altSpellings: new string[] { "FJ", "Viti", "Republic of Fiji", "Matanitu ko Viti", "Fijī Gaṇarājya",  },
            tld: new string[] { ".fj",  },
            latlng: new double[] { -18, 175,  },
            timezones: new string[] { "UTC+12:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Fijian", iso6391: "", iso6392: "fij"),
                new Language(name: "Fiji Hindi", iso6391: "", iso6392: "hif"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "FJD", name: "Fijian dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Fijian", female: "Fijian") },
                { "fra", new DemonymsGender(male: "Fijian", female: "Fijian") },
            }
        );

        /// <summary>
        /// create an instance of Fiji country
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
        private Fiji(
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
