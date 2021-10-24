namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Jordan country
    /// </summary>
    public class Jordan : Country
    {
        /// <summary>
        /// get the Jordan country instance
        /// </summary>
        public static Jordan Instance = new Jordan(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Hashemite Kingdom of Jordan", common: "Jordan") },
                { "ara", new CountryName(official: "المملكة الأردنية الهاشمية", common: "الأردن") },
                { "ces", new CountryName(official: "Jordánské hášimovské království", common: "Jordánsko") },
                { "cym", new CountryName(official: "Hashemite Kingdom of Jordan", common: "Jordan") },
                { "deu", new CountryName(official: "Haschemitisches Königreich Jordanien", common: "Jordanien") },
                { "est", new CountryName(official: "Jordaania Hašimiidi Kuningriik", common: "Jordaania") },
                { "fin", new CountryName(official: "Jordanian hašemiittinen kunigaskunta", common: "Jordania") },
                { "fra", new CountryName(official: "Royaume hachémite de Jordanie", common: "Jordanie") },
                { "hrv", new CountryName(official: "Hašemitske Kraljevine Jordan", common: "Jordan") },
                { "hun", new CountryName(official: "Jordánia", common: "Jordánia") },
                { "ita", new CountryName(official: "Regno hascemita di Giordania", common: "Giordania") },
                { "jpn", new CountryName(official: "ヨルダン·ハシミテ王国", common: "ヨルダン") },
                { "kor", new CountryName(official: "요르단 하심 왕국", common: "요르단") },
                { "nld", new CountryName(official: "Hasjemitisch Koninkrijk Jordanië", common: "Jordanië") },
                { "per", new CountryName(official: "پادشاهی اُردُن هاشمی", common: "اردن") },
                { "pol", new CountryName(official: "Jordańskie Królestwo Haszymidzkie", common: "Jordania") },
                { "por", new CountryName(official: "Reino Hachemita da Jordânia", common: "Jordânia") },
                { "rus", new CountryName(official: "Иорданского Хашимитского Королевства", common: "Иордания") },
                { "slk", new CountryName(official: "Jordánske hášimovské kráľovstvo", common: "Jordánsko") },
                { "spa", new CountryName(official: "Reino Hachemita de Jordania", common: "Jordania") },
                { "swe", new CountryName(official: "Hashimitiska kungadömet Jordanien", common: "Jordanien") },
                { "urd", new CountryName(official: "ھاشمی مملکتِ اردن", common: "اردن") },
                { "zho", new CountryName(official: "约旦哈希姆王国", common: "约旦") },

            },
            cca2: "JO",
            cca3: "JOR",
            ccn3: "400",
            cioc: "JOR",
            flag: "🇯🇴",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"62", }),
            borders: new string[] { "IRQ", "ISR", "PSE", "SAU", "SYR",  },
            capital: new string[] { "Amman",  },
            altSpellings: new string[] { "JO", "Hashemite Kingdom of Jordan", "al-Mamlakah al-Urdunīyah al-Hāshimīyah",  },
            tld: new string[] { ".jo", "الاردن.",  },
            latlng: new double[] { 31, 36,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "JOD", name: "Jordanian dinar", symbol: "د.ا"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Jordanian", female: "Jordanian") },
                { "fra", new DemonymsGender(male: "Jordanian", female: "Jordanian") },
            }
        );

        /// <summary>
        /// create an instance of Jordan country
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
        private Jordan(
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
