namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Macau country
    /// </summary>
    public class Macau : Country
    {
        /// <summary>
        /// get the Macau country instance
        /// </summary>
        public static Macau Instance = new Macau(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Macao Special Administrative Region of the People's Republic of China", common: "Macau") },
                { "por", new CountryName(official: "Região Administrativa Especial de Macau da República Popular da China", common: "Macau") },
                { "zho", new CountryName(official: "中华人民共和国澳门特别行政区", common: "澳门") },
                { "ara", new CountryName(official: "منطقة ماكاو الإدارية التابعة لجمهورية الصين الشعبية", common: "ماكاو") },
                { "ces", new CountryName(official: "Zvláštní správní oblast Čínské lidové republiky Macao", common: "Macao") },
                { "cym", new CountryName(official: "Macao Special Administrative Region of the People's Republic of China", common: "Macau") },
                { "deu", new CountryName(official: "Sonderverwaltungsregion Macau der Volksrepublik China", common: "Macao") },
                { "est", new CountryName(official: "Macau erihalduspiirkond", common: "Macau") },
                { "fin", new CountryName(official: "Macaon Kiinan kansantasavallan erityishallintoalue", common: "Macao") },
                { "fra", new CountryName(official: "Région administrative spéciale de Macao de la République populaire de Chine", common: "Macao") },
                { "hrv", new CountryName(official: "Makao Posebnog upravnog područjaNarodne Republike Kine", common: "Makao") },
                { "hun", new CountryName(official: "Makaó", common: "Makaó") },
                { "ita", new CountryName(official: "Macao Regione amministrativa speciale della Repubblica Popolare Cinese", common: "Macao") },
                { "jpn", new CountryName(official: "中華人民共和国マカオ特別行政区", common: "マカオ") },
                { "kor", new CountryName(official: "중화인민공화국 마카오 특별행정구", common: "마카오") },
                { "nld", new CountryName(official: "Speciale Administratieve Regio Macau van de Volksrepubliek China", common: "Macao") },
                { "per", new CountryName(official: "ماکائو", common: "ماکائو") },
                { "pol", new CountryName(official: "Specjalny Region Administracyjny Chińskiej Republiki Ludowej Makau", common: "Makau") },
                { "rus", new CountryName(official: "Специальный административный район Макао Китайской Народной Республики Китай", common: "Макао") },
                { "slk", new CountryName(official: "Macao, Špeciàlna administratívna oblasŦ", common: "Macao") },
                { "spa", new CountryName(official: "Macao, Región Administrativa Especial de la República Popular China", common: "Macao") },
                { "swe", new CountryName(official: "Macao", common: "Macao") },
                { "urd", new CountryName(official: "مکاؤ عوامی جمہوریہ چین کا خصوصی انتظامی علاقہ", common: "مکاؤ") },

            },
            cca2: "MO",
            cca3: "MAC",
            ccn3: "446",
            cioc: "",
            flag: "🇲🇴",
            region: Region.Asia,
            subregion: "Eastern Asia",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+8", suffixes: new string[] {"53", }),
            borders: new string[] { "CHN",  },
            capital: new string[] {  },
            altSpellings: new string[] { "MO", "澳门", "Macao", "Macao Special Administrative Region of the People's Republic of China", "中華人民共和國澳門特別行政區", "Região Administrativa Especial de Macau da República Popular da China",  },
            tld: new string[] { ".mo",  },
            latlng: new double[] { 22.16666666, 113.55,  },
            timezones: new string[] { "UTC+08:00",  },
            languages: new Language[]
            {
                new Language(name: "Portuguese", iso6391: "pt", iso6392: "por"),
                new Language(name: "Chinese", iso6391: "zh", iso6392: "zho"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "MOP", name: "Macanese pataca", symbol: "P"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Macanese", female: "Macanese") },
                { "fra", new DemonymsGender(male: "Macanese", female: "Macanese") },
            }
        );

        /// <summary>
        /// create an instance of Macau country
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
        private Macau(
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
