namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Yemen country
    /// </summary>
    public class Yemen : Country
    {
        /// <summary>
        /// get the Yemen country instance
        /// </summary>
        public static Yemen Instance = new Yemen(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Yemen", common: "Yemen") },
                { "ara", new CountryName(official: "الجمهورية اليمنية", common: "اليَمَن") },
                { "ces", new CountryName(official: "Jemenská republika", common: "Jemen") },
                { "cym", new CountryName(official: "Republic of Yemen", common: "Yemen") },
                { "deu", new CountryName(official: "Republik Jemen", common: "Jemen") },
                { "est", new CountryName(official: "Jeemeni Vabariik", common: "Jeemen") },
                { "fin", new CountryName(official: "Jemenin tasavalta", common: "Jemen") },
                { "fra", new CountryName(official: "République du Yémen", common: "Yémen") },
                { "hrv", new CountryName(official: "Republika Jemen", common: "Jemen") },
                { "hun", new CountryName(official: "Jemeni Köztársaság", common: "Jemen") },
                { "ita", new CountryName(official: "Repubblica dello Yemen", common: "Yemen") },
                { "jpn", new CountryName(official: "イエメン共和国", common: "イエメン") },
                { "kor", new CountryName(official: "예멘 공화국", common: "예멘") },
                { "nld", new CountryName(official: "Republiek Jemen", common: "Jemen") },
                { "per", new CountryName(official: "جمهوری یمن", common: "یمن") },
                { "pol", new CountryName(official: "Republika Jemeńska", common: "Jemen") },
                { "por", new CountryName(official: "República do Iêmen", common: "Iémen") },
                { "rus", new CountryName(official: "Йеменская Республика", common: "Йемен") },
                { "slk", new CountryName(official: "Jemenská republika", common: "Jemen") },
                { "spa", new CountryName(official: "República de Yemen", common: "Yemen") },
                { "swe", new CountryName(official: "Republiken Jemen", common: "Jemen") },
                { "urd", new CountryName(official: "جمہوریہ یمن", common: "یمن") },
                { "zho", new CountryName(official: "也门共和国", common: "也门") },

            },
            cca2: "YE",
            cca3: "YEM",
            ccn3: "887",
            cioc: "YEM",
            flag: "🇾🇪",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"67", }),
            borders: new string[] { "OMN", "SAU",  },
            capital: new string[] { "Sana'a",  },
            altSpellings: new string[] { "YE", "Yemeni Republic", "al-Jumhūriyyah al-Yamaniyyah",  },
            tld: new string[] { ".ye",  },
            latlng: new double[] { 15, 48,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "YER", name: "Yemeni rial", symbol: "﷼"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Yemeni", female: "Yemeni") },
                { "fra", new DemonymsGender(male: "Yemeni", female: "Yemeni") },
            }
        );

        /// <summary>
        /// create an instance of Yemen country
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
        private Yemen(
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
