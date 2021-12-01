namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of China country
    /// </summary>
    public class China : Country
    {
        /// <summary>
        /// get the China country instance
        /// </summary>
        public static China Instance = new China(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "People's Republic of China", common: "China") },
                { "zho", new CountryName(official: "中华人民共和国", common: "中国") },
                { "ara", new CountryName(official: "جمهورية الصين الشعبية", common: "الصين") },
                { "ces", new CountryName(official: "Čínská lidová republika", common: "Čína") },
                { "cym", new CountryName(official: "Gweriniaeth Pobl Tsieina", common: "Tsieina") },
                { "deu", new CountryName(official: "Volksrepublik China", common: "China") },
                { "est", new CountryName(official: "Hiina Rahvavabariik", common: "Hiina") },
                { "fin", new CountryName(official: "Kiinan kansantasavalta", common: "Kiina") },
                { "fra", new CountryName(official: "République populaire de Chine", common: "Chine") },
                { "hrv", new CountryName(official: "Narodna Republika Kina", common: "Kina") },
                { "hun", new CountryName(official: "Kínai Népköztársaság", common: "Kína") },
                { "ita", new CountryName(official: "Repubblica popolare cinese", common: "Cina") },
                { "jpn", new CountryName(official: "中華人民共和国", common: "中国") },
                { "kor", new CountryName(official: "중화인민공화국", common: "중국") },
                { "nld", new CountryName(official: "Volksrepubliek China", common: "China") },
                { "per", new CountryName(official: "جمهوری خلق چین", common: "چین") },
                { "pol", new CountryName(official: "Chińska Republika Ludowa", common: "Chiny") },
                { "por", new CountryName(official: "República Popular da China", common: "China") },
                { "rus", new CountryName(official: "Народная Республика Китай", common: "Китай") },
                { "slk", new CountryName(official: "Čínska ľudová republika", common: "Čína") },
                { "spa", new CountryName(official: "República Popular de China", common: "China") },
                { "swe", new CountryName(official: "Folkrepubliken Kina", common: "Kina") },
                { "urd", new CountryName(official: "عوامی جمہوریہ چین", common: "چین") },
            },
            cca2: "CN",
            cca3: "CHN",
            ccn3: "156",
            cioc: "CHN",
            flag: "🇨🇳",
            region: Region.Asia,
            subregion: "Eastern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+8", suffixes: new string[] {"6", }),
            borders: new string[] { "AFG", "BTN", "MMR", "HKG", "IND", "KAZ", "NPL", "PRK", "KGZ", "LAO", "MAC", "MNG", "PAK", "RUS", "TJK", "VNM",  },
            capital: new string[] { "Beijing",  },
            altSpellings: new string[] { "CN", "Zhōngguó", "Zhongguo", "Zhonghua", "People's Republic of China", "中华人民共和国", "Zhōnghuá Rénmín Gònghéguó",  },
            tld: new string[] { ".cn", ".中国", ".中國", ".公司", ".网络",  },
            latlng: new double[] { 35, 105,  },
            timezones: new string[] { "UTC+08:00",  },
            languages: new Language[]
            {
                new Language(name: "Chinese", iso6391: "zh", iso6392: "zho"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "CNY", name: "Chinese yuan", symbol: "¥"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Chinese", female: "Chinese") },
                { "fra", new DemonymsGender(male: "Chinese", female: "Chinese") },
            }
        );

        /// <summary>
        /// create an instance of China country
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
        private China(
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
