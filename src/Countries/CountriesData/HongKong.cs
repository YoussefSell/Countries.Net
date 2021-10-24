namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of HongKong country
    /// </summary>
    public class HongKong : Country
    {
        /// <summary>
        /// get the HongKong country instance
        /// </summary>
        public static HongKong Instance = new HongKong(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Hong Kong Special Administrative Region of the People's Republic of China", common: "Hong Kong") },
                { "zho", new CountryName(official: "中华人民共和国香港特别行政区", common: "香港") },
                { "ara", new CountryName(official: "منطقة هونغ كونغ الادارية التابعة لجمهورية الصين الشعبية", common: "هونغ كونغ") },
                { "ces", new CountryName(official: "Zvláštní administrativní oblast Čínské lidové republiky Hongkong", common: "Hongkong") },
                { "cym", new CountryName(official: "Hong Kong Special Administrative Region of the People's Republic of China", common: "Hong Kong") },
                { "deu", new CountryName(official: "Sonderverwaltungszone Hongkong der Volksrepublik China", common: "Hongkong") },
                { "est", new CountryName(official: "Hongkongi erihalduspiirkond", common: "Hongkong") },
                { "fin", new CountryName(official: "Hong Kongin erityishallintoalue", common: "Hongkong") },
                { "fra", new CountryName(official: "Région administrative spéciale de Hong Kong de la République populaire de Chine", common: "Hong Kong") },
                { "hrv", new CountryName(official: "Hong Kong Posebnog upravnog područjaNarodne Republike Kine", common: "Hong Kong") },
                { "hun", new CountryName(official: "Hongkong", common: "Hongkong") },
                { "ita", new CountryName(official: "Hong Kong Regione amministrativa speciale della Repubblica Popolare Cinese", common: "Hong Kong") },
                { "jpn", new CountryName(official: "中華人民共和国香港特別行政区", common: "香港") },
                { "kor", new CountryName(official: "중화인민공화국 홍콩 특별행정구", common: "홍콩") },
                { "nld", new CountryName(official: "Hong Kong Speciale Administratieve Regio van de Volksrepubliek China", common: "Hongkong") },
                { "per", new CountryName(official: "هُنگ کُنگ", common: "هُنگ کُنگ") },
                { "pol", new CountryName(official: "Specjalny Region Administracyjny Chińskiej Republiki Ludowej Hongkong", common: "Hongkong") },
                { "por", new CountryName(official: "Hong Kong Região Administrativa Especial da República Popular da China", common: "Hong Kong") },
                { "rus", new CountryName(official: "Hong Kong Специальный административный район Китайской Народной Республики Китая", common: "Гонконг") },
                { "slk", new CountryName(official: "Špeciálna administratívna oblasťČínskej ľudovej republiky Hongkong", common: "Hongkong") },
                { "spa", new CountryName(official: "Hong Kong Región Administrativa Especial de la República Popular China", common: "Hong Kong") },
                { "swe", new CountryName(official: "Hongkong", common: "Hongkong") },
                { "urd", new CountryName(official: "ہانگ کانگ عوامی جمہوریہ چین کا خصوصی انتظامی علاقہ", common: "ہانگ کانگ") },
            },
            cca2: "HK",
            cca3: "HKG",
            ccn3: "344",
            cioc: "HKG",
            flag: "🇭🇰",
            region: Region.Asia,
            subregion: "Eastern Asia",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+8", suffixes: new string[] {"52", }),
            borders: new string[] { "CHN",  },
            capital: new string[] { "City of Victoria",  },
            altSpellings: new string[] { "HK",  },
            tld: new string[] { ".hk", ".香港",  },
            latlng: new double[] { 22.267, 114.188,  },
            timezones: new string[] { "UTC+08:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Chinese", iso6391: "zh", iso6392: "zho"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "HKD", name: "Hong Kong dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Hong Konger", female: "Hong Konger") },
                { "fra", new DemonymsGender(male: "Hong Konger", female: "Hong Konger") },
            }
        );

        /// <summary>
        /// create an instance of HongKong country
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
        private HongKong(
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
