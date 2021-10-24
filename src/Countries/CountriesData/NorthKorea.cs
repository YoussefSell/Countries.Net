namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of NorthKorea country
    /// </summary>
    public class NorthKorea : Country
    {
        /// <summary>
        /// get the NorthKorea country instance
        /// </summary>
        public static NorthKorea Instance = new NorthKorea(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Democratic People's Republic of Korea", common: "North Korea") },
                { "kor", new CountryName(official: "조선민주주의인민공화국", common: "조선") },
                { "ara", new CountryName(official: "جمهورية كوريا الديمقراطية الشعبية", common: "كوريا الشمالية") },
                { "ces", new CountryName(official: "Korejská lidově demokratická republika", common: "Severní Korea") },
                { "cym", new CountryName(official: "Democratic People's Republic of Korea", common: "North Korea") },
                { "deu", new CountryName(official: "Demokratische Volksrepublik Korea", common: "Nordkorea") },
                { "est", new CountryName(official: "Korea Rahvademokraatlik Vabariik", common: "Põhja-Korea") },
                { "fin", new CountryName(official: "Korean demokraattinen kansantasavalta", common: "Pohjois-Korea") },
                { "fra", new CountryName(official: "République populaire démocratique de Corée", common: "Corée du Nord") },
                { "hrv", new CountryName(official: "Demokratska Narodna Republika Koreja", common: "Sjeverna Koreja") },
                { "hun", new CountryName(official: "Koreai Népi Demokratikus Köztársaság", common: "Észak-Korea") },
                { "ita", new CountryName(official: "Repubblica democratica popolare di Corea", common: "Corea del Nord") },
                { "jpn", new CountryName(official: "朝鮮民主主義人民共和国", common: "朝鮮民主主義人民共和国") },
                { "nld", new CountryName(official: "Democratische Volksrepubliek Korea", common: "Noord-Korea") },
                { "per", new CountryName(official: "جمهوری دموکراتیک خلق کره", common: "کُره شمالی") },
                { "pol", new CountryName(official: "Koreańska Republika Ludowo-Demokratyczna", common: "Korea Północna") },
                { "por", new CountryName(official: "República Popular Democrática da Coreia", common: "Coreia do Norte") },
                { "rus", new CountryName(official: "Корейская Народно-Демократическая Республика Корея", common: "Северная Корея") },
                { "slk", new CountryName(official: "Kórejská ľudovodemokratická republika", common: "Kórejská ľudovodemokratická republika (KĽR, Severná Kórea)") },
                { "spa", new CountryName(official: "República Popular Democrática de Corea", common: "Corea del Norte") },
                { "swe", new CountryName(official: "Demokratiska Folkrepubliken Korea", common: "Nordkorea") },
                { "urd", new CountryName(official: "جمہوری عوامی جمہوریہ کوریا", common: "شمالی کوریا") },
                { "zho", new CountryName(official: "朝鲜人民民主共和国", common: "朝鲜") },

            },
            cca2: "KP",
            cca3: "PRK",
            ccn3: "408",
            cioc: "PRK",
            flag: "🇰🇵",
            region: Region.Asia,
            subregion: "Eastern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+8", suffixes: new string[] {"50", }),
            borders: new string[] { "CHN", "KOR", "RUS",  },
            capital: new string[] { "Pyongyang",  },
            altSpellings: new string[] { "KP", "Democratic People's Republic of Korea", "DPRK", "조선민주주의인민공화국", "Chosŏn Minjujuŭi Inmin Konghwaguk", "Korea, Democratic People's Republic of", "북한", "북조선",  },
            tld: new string[] { ".kp",  },
            latlng: new double[] { 40, 127,  },
            timezones: new string[] { "UTC+09:00",  },
            languages: new Language[]
            {
                new Language(name: "Korean", iso6391: "ko", iso6392: "kor"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "KPW", name: "North Korean won", symbol: "₩"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "North Korean", female: "North Korean") },
                { "fra", new DemonymsGender(male: "North Korean", female: "North Korean") },
            }
        );

        /// <summary>
        /// create an instance of NorthKorea country
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
        private NorthKorea(
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
