namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Iran country
    /// </summary>
    public class Iran : Country
    {
        /// <summary>
        /// get the Iran country instance
        /// </summary>
        public static Iran Instance = new Iran(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Islamic Republic of Iran", common: "Iran") },
                { "fas", new CountryName(official: "جمهوری اسلامی ایران", common: "ایران") },
                { "ara", new CountryName(official: "جمهورية إيران الإسلامية", common: "إيران") },
                { "ces", new CountryName(official: "Islámská republika Írán", common: "Írán") },
                { "cym", new CountryName(official: "Islamic Republic of Iran", common: "Iran") },
                { "deu", new CountryName(official: "Islamische Republik Iran", common: "Iran") },
                { "est", new CountryName(official: "Iraani Islamivabariik", common: "Iraan") },
                { "fin", new CountryName(official: "Iranin islamilainen tasavalta", common: "Iran") },
                { "fra", new CountryName(official: "République islamique d'Iran", common: "Iran") },
                { "hrv", new CountryName(official: "Islamska Republika Iran", common: "Iran") },
                { "hun", new CountryName(official: "Iráni Iszlám Köztársaság", common: "Irán") },
                { "ita", new CountryName(official: "Repubblica islamica dell'Iran", common: "Iran") },
                { "jpn", new CountryName(official: "イラン·イスラム共和国", common: "イラン・イスラム共和国") },
                { "kor", new CountryName(official: "이란 이슬람 공화국", common: "이란") },
                { "nld", new CountryName(official: "Islamitische Republiek Iran", common: "Iran") },
                { "pol", new CountryName(official: "Islamska Republika Iranu", common: "Iran") },
                { "por", new CountryName(official: "República Islâmica do Irã", common: "Irão") },
                { "rus", new CountryName(official: "Исламская Республика Иран", common: "Иран") },
                { "slk", new CountryName(official: "Iránska islamská republika", common: "Irán") },
                { "spa", new CountryName(official: "República Islámica de Irán", common: "Iran") },
                { "swe", new CountryName(official: "Islamiska republiken Iran", common: "Iran") },
                { "urd", new CountryName(official: "جمہوریہ ایران", common: "ایران") },
                { "zho", new CountryName(official: "伊朗伊斯兰共和国", common: "伊朗") },
            },
            cca2: "IR",
            cca3: "IRN",
            ccn3: "364",
            cioc: "IRI",
            flag: "🇮🇷",
            region: Region.Asia,
            subregion: "Southern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"8", }),
            borders: new string[] { "AFG", "ARM", "AZE", "IRQ", "PAK", "TUR", "TKM",  },
            capital: new string[] { "Tehran",  },
            altSpellings: new string[] { "IR", "Islamic Republic of Iran", "Iran, Islamic Republic of", "Jomhuri-ye Eslāmi-ye Irān",  },
            tld: new string[] { ".ir", "ایران.",  },
            latlng: new double[] { 32, 53,  },
            timezones: new string[] { "UTC+03:30",  },
            languages: new Language[]
            {
                new Language(name: "Persian (Farsi)", iso6391: "fa", iso6392: "fas"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "IRR", name: "Iranian rial", symbol: "﷼"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Iranian", female: "Iranian") },
                { "fra", new DemonymsGender(male: "Iranian", female: "Iranian") },
            }
        );

        /// <summary>
        /// create an instance of Iran country
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
        private Iran(
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
