namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of CaribbeanNetherlands country
    /// </summary>
    public class CaribbeanNetherlands : Country
    {
        /// <summary>
        /// get the CaribbeanNetherlands country instance
        /// </summary>
        public static CaribbeanNetherlands Instance = new CaribbeanNetherlands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Bonaire, Sint Eustatius and Saba", common: "Caribbean Netherlands") },
                { "nld", new CountryName(official: "Bonaire, Sint Eustatius en Saba", common: "Caribisch Nederland") },
                { "pap", new CountryName(official: "Boneiru, Sint Eustatius y Saba", common: "Boneiru, Sint Eustatius y Saba") },
                { "ara", new CountryName(official: "بونير وسينت أوستاتيوس وسابا", common: "الجزر الكاريبية الهولندية") },
                { "ces", new CountryName(official: "Karibské Nizozemsko", common: "Karibské Nizozemsko") },
                { "cym", new CountryName(official: "Bonaire, Sint Eustatius and Saba", common: "Caribbean Netherlands") },
                { "deu", new CountryName(official: "Bonaire, Sint Eustatius und Saba", common: "Karibische Niederlande") },
                { "est", new CountryName(official: "Bonaire, Sint Eustatius ja Saba", common: "Bonaire, Sint Eustatius ja Saba") },
                { "fin", new CountryName(official: "Bonaire, Sint Eustatius ja Saba", common: "Bonaire, Sint Eustatius ja Saba") },
                { "fra", new CountryName(official: "Bonaire, Saint-Eustache et Saba", common: "Pays-Bas caribéens") },
                { "hrv", new CountryName(official: "Bonaire, Sint Eustatius i Saba", common: "Bonaire, Sint Eustatius i Saba") },
                { "hun", new CountryName(official: "Bonaire", common: "Bonaire") },
                { "ita", new CountryName(official: "Bonaire, Sint Eustatius e Saba", common: "Paesi Bassi caraibici") },
                { "jpn", new CountryName(official: "ボネール、シント・ユースタティウスおよびサバ", common: "ボネール、シント・ユースタティウスおよびサバ") },
                { "kor", new CountryName(official: "보네르, 신트외스타티위스, 사바", common: "카리브 네덜란드") },
                { "per", new CountryName(official: "جزایر کارائیب هلند", common: "جزایر کارائیب هلند") },
                { "pol", new CountryName(official: "Bonaire, Sint Eustatius i Saba", common: "Antyle Holenderskie") },
                { "por", new CountryName(official: "Bonaire, Saba e Santo Eustáquio", common: "Países Baixos Caribenhos") },
                { "rus", new CountryName(official: "Бонэйр, Синт-Эстатиус и Саба", common: "Карибские Нидерланды") },
                { "slk", new CountryName(official: "Bonaire, Sint Eustatius a Saba", common: "Bonaire, Sint Eustatius a Saba") },
                { "spa", new CountryName(official: "Bonaire, San Eustaquio y Saba", common: "Caribe Neerlandés") },
                { "swe", new CountryName(official: "Bonaire, Sint Eustatius and Saba", common: "Karibiska Nederländerna") },
                { "urd", new CountryName(official: "بونایر، سینٹ ایوسٹائیس اور سابا", common: "کیریبین نیدرلینڈز") },
                { "zho", new CountryName(official: "荷蘭加勒比區", common: "荷蘭加勒比區") },

            },
            cca2: "BQ",
            cca3: "BES",
            ccn3: "535",
            cioc: "",
            flag: "",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"99", }),
            borders: new string[] {  },
            capital: new string[] { "Kralendijk",  },
            altSpellings: new string[] { "BES islands",  },
            tld: new string[] { ".bq", ".nl",  },
            latlng: new double[] { 12.18, -68.25,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Dutch", iso6391: "nl", iso6392: "nld"),
                new Language(name: "Papiamento", iso6391: "pap", iso6392: "pap"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "USD", name: "United States dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Dutch", female: "Dutch") },
                { "fra", new DemonymsGender(male: "Dutch", female: "Dutch") },
            }
        );

        /// <summary>
        /// create an instance of CaribbeanNetherlands country
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
        private CaribbeanNetherlands(
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
