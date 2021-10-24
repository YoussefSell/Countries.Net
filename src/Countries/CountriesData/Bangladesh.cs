namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Bangladesh country
    /// </summary>
    public class Bangladesh : Country
    {
        /// <summary>
        /// get the Bangladesh country instance
        /// </summary>
        public static Bangladesh Instance = new Bangladesh(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "People's Republic of Bangladesh", common: "Bangladesh") },
                { "ben", new CountryName(official: "বাংলাদেশ গণপ্রজাতন্ত্রী", common: "বাংলাদেশ") },
                { "ara", new CountryName(official: "جمهورية بنغلاديش الشعبية", common: "بنغلاديش") },
                { "ces", new CountryName(official: "Bangladéšská lidová republika", common: "Bangladéš") },
                { "cym", new CountryName(official: "Gweriniaeth Pobl Bangladesh", common: "Bangladesh") },
                { "deu", new CountryName(official: "Volksrepublik Bangladesch", common: "Bangladesch") },
                { "est", new CountryName(official: "Bangladeshi Rahvavabariik", common: "Bangladesh") },
                { "fin", new CountryName(official: "Bangladeshin kansantasavalta", common: "Bangladesh") },
                { "fra", new CountryName(official: "La République populaire du Bangladesh", common: "Bangladesh") },
                { "hrv", new CountryName(official: "Narodna Republika Bangladeš", common: "Bangladeš") },
                { "hun", new CountryName(official: "Banglades", common: "Banglades") },
                { "ita", new CountryName(official: "Repubblica popolare del Bangladesh", common: "Bangladesh") },
                { "jpn", new CountryName(official: "バングラデシュ人民共和国", common: "バングラデシュ") },
                { "kor", new CountryName(official: "방글라데시 인민 공화국", common: "방글라데시") },
                { "nld", new CountryName(official: "Volksrepubliek Bangladesh", common: "Bangladesh") },
                { "per", new CountryName(official: "جمهوری خلق بنگلادش", common: "بنگلادش") },
                { "pol", new CountryName(official: "Ludowa Republika Bangladeszu", common: "Bangladesz") },
                { "por", new CountryName(official: "República Popular do Bangladesh", common: "Bangladesh") },
                { "rus", new CountryName(official: "Народная Республика Бангладеш", common: "Бангладеш") },
                { "slk", new CountryName(official: "Bangladéšska ľudová republika", common: "Bangladéš") },
                { "spa", new CountryName(official: "República Popular de Bangladesh", common: "Bangladesh") },
                { "swe", new CountryName(official: "Folkrepubliken Bangladesh", common: "Bangladesh") },
                { "urd", new CountryName(official: "عوامی جمہوریہ بنگلہ دیش", common: "بنگلہ دیش") },
                { "zho", new CountryName(official: "孟加拉人民共和国", common: "孟加拉国") },
            },
            cca2: "BD",
            cca3: "BGD",
            ccn3: "050",
            cioc: "BAN",
            flag: "🇧🇩",
            region: Region.Asia,
            subregion: "Southern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+8", suffixes: new string[] {"80", }),
            borders: new string[] { "MMR", "IND",  },
            capital: new string[] { "Dhaka",  },
            altSpellings: new string[] { "BD", "People's Republic of Bangladesh", "Gônôprôjatôntri Bangladesh",  },
            tld: new string[] { ".bd",  },
            latlng: new double[] { 24, 90,  },
            timezones: new string[] { "UTC+06:00",  },
            languages: new Language[]
            {
                new Language(name: "Bengali", iso6391: "bn", iso6392: "ben"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "BDT", name: "Bangladeshi taka", symbol: "৳"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Bangladeshi", female: "Bangladeshi") },
                { "fra", new DemonymsGender(male: "Bangladeshi", female: "Bangladeshi") },
            }
        );

        /// <summary>
        /// create an instance of Bangladesh country
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
        private Bangladesh(
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
