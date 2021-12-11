namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Laos country
    /// </summary>
    public class Laos : Country
    {
        /// <summary>
        /// get the Laos country instance
        /// </summary>
        public static Laos Instance = new Laos(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Lao People's Democratic Republic", common: "Laos") },
                { "lao", new CountryName(official: "ສາທາລະນະ ຊາທິປະໄຕ ຄົນລາວ ຂອງ", common: "ສປປລາວ") },
                { "ara", new CountryName(official: "جمهورية لاوس الديمقراطية الشعبية", common: "لاوس") },
                { "ces", new CountryName(official: "Laoská lidově demokratická republika", common: "Laos") },
                { "cym", new CountryName(official: "Lao People's Democratic Republic", common: "Laos") },
                { "deu", new CountryName(official: "Demokratische Volksrepublik Laos", common: "Laos") },
                { "est", new CountryName(official: "Laose Demokraatlik Rahvavabariik", common: "Laos") },
                { "fin", new CountryName(official: "Laosin demokraattinen kansantasavalta", common: "Laos") },
                { "fra", new CountryName(official: "République démocratique populaire lao", common: "Laos") },
                { "hrv", new CountryName(official: "Narodna Demokratska Republika", common: "Laos") },
                { "hun", new CountryName(official: "Laoszi Népi Demokratikus Köztársaság", common: "Laosz") },
                { "ita", new CountryName(official: "Repubblica democratica popolare del Laos", common: "Laos") },
                { "jpn", new CountryName(official: "ラオス人民民主共和国", common: "ラオス人民民主共和国") },
                { "kor", new CountryName(official: "라오 인민 민주 공화국", common: "라오스") },
                { "nld", new CountryName(official: "Lao Democratische Volksrepubliek", common: "Laos") },
                { "per", new CountryName(official: "جمهوری دموکراتیک خلق لائوس", common: "لائوس") },
                { "pol", new CountryName(official: "Laotańska Republika Ludowo-Demokratyczna", common: "Laos") },
                { "por", new CountryName(official: "Laos, República Democrática", common: "Laos") },
                { "rus", new CountryName(official: "Лаосская Народно-Демократическая Республика", common: "Лаос") },
                { "slk", new CountryName(official: "Laoská ľudovodemokratická republika", common: "Laos") },
                { "spa", new CountryName(official: "República Democrática Popular Lao", common: "Laos") },
                { "swe", new CountryName(official: "Demokratiska folkrepubliken Laos", common: "Laos") },
                { "urd", new CountryName(official: "عوامی جمہوری جمہوریہ لاؤ", common: "لاؤس") },
                { "zho", new CountryName(official: "老挝人民民主共和国", common: "老挝") },
            },
            cca2: "LA",
            cca3: "LAO",
            ccn3: "418",
            cioc: "LAO",
            flag: "🇱🇦",
            region: Region.Asia,
            subregion: "South-Eastern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+8", suffixes: new string[] {"56", }),
            borders: new string[] { "MMR", "KHM", "CHN", "THA", "VNM",  },
            capital: new string[] { "Vientiane",  },
            altSpellings: new string[] { "LA", "Lao", "Lao People's Democratic Republic", "Sathalanalat Paxathipatai Paxaxon Lao",  },
            tld: new string[] { ".la",  },
            latlng: new double[] { 18, 105,  },
            timezones: new string[] { "UTC+07:00",  },
            languages: new Language[]
            {
                new Language(name: "Lao", iso6391: "lo", iso6392: "lao"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "LAK", name: "Lao kip", symbol: "₭"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Laotian", female: "Laotian") },
                { "fra", new DemonymsGender(male: "Laotian", female: "Laotian") },
            }
        );

        /// <summary>
        /// create an instance of Laos country
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
        private Laos(
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
