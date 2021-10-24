namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Uzbekistan country
    /// </summary>
    public class Uzbekistan : Country
    {
        /// <summary>
        /// get the Uzbekistan country instance
        /// </summary>
        public static Uzbekistan Instance = new Uzbekistan(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Uzbekistan", common: "Uzbekistan") },
                { "rus", new CountryName(official: "Республика Узбекистан", common: "Узбекистан") },
                { "uzb", new CountryName(official: "O'zbekiston Respublikasi", common: "O‘zbekiston") },
                { "ara", new CountryName(official: "جمهورية أوزباكستان", common: "أوزباكستان") },
                { "ces", new CountryName(official: "Republika Uzbekistán", common: "Uzbekistán") },
                { "cym", new CountryName(official: "Republic of Uzbekistan", common: "Uzbekistan") },
                { "deu", new CountryName(official: "Republik Usbekistan", common: "Usbekistan") },
                { "est", new CountryName(official: "Usbekistani Vabariik", common: "Usbekistan") },
                { "fin", new CountryName(official: "Uzbekistanin tasavalta", common: "Uzbekistan") },
                { "fra", new CountryName(official: "République d'Ouzbékistan", common: "Ouzbékistan") },
                { "hrv", new CountryName(official: "Republika Uzbekistan", common: "Uzbekistan") },
                { "hun", new CountryName(official: "Üzbég Köztársaság", common: "Üzbegisztán") },
                { "ita", new CountryName(official: "Repubblica di Uzbekistan", common: "Uzbekistan") },
                { "jpn", new CountryName(official: "ウズベキスタン共和国", common: "ウズベキスタン") },
                { "kor", new CountryName(official: "우즈베키스탄 공화국", common: "우즈베키스탄") },
                { "nld", new CountryName(official: "Republiek Oezbekistan", common: "Oezbekistan") },
                { "per", new CountryName(official: "جمهوری ازبکستان", common: "ازبکستان") },
                { "pol", new CountryName(official: "Republika Uzbekistanu", common: "Uzbekistan") },
                { "por", new CountryName(official: "República do Usbequistão", common: "Uzbequistão") },
                { "slk", new CountryName(official: "Uzbecká republika", common: "Uzbekistan") },
                { "spa", new CountryName(official: "República de Uzbekistán", common: "Uzbekistán") },
                { "swe", new CountryName(official: "Republiken Uzbekistan", common: "Uzbekistan") },
                { "urd", new CountryName(official: "جمہوریہ ازبکستان", common: "ازبکستان") },
                { "zho", new CountryName(official: "乌兹别克斯坦共和国", common: "乌兹别克斯坦") },

            },
            cca2: "UZ",
            cca3: "UZB",
            ccn3: "860",
            cioc: "UZB",
            flag: "🇺🇿",
            region: Region.Asia,
            subregion: "Central Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"98", }),
            borders: new string[] { "AFG", "KAZ", "KGZ", "TJK", "TKM",  },
            capital: new string[] { "Tashkent",  },
            altSpellings: new string[] { "UZ", "Republic of Uzbekistan", "O‘zbekiston Respublikasi", "Ўзбекистон Республикаси",  },
            tld: new string[] { ".uz",  },
            latlng: new double[] { 41, 64,  },
            timezones: new string[] { "UTC+05:00",  },
            languages: new Language[]
            {
                new Language(name: "Russian", iso6391: "ru", iso6392: "rus"),
                new Language(name: "Uzbek", iso6391: "uz", iso6392: "uzb"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "UZS", name: "Uzbekistani soʻm", symbol: "so'm"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Uzbekistani", female: "Uzbekistani") },
                { "fra", new DemonymsGender(male: "Uzbekistani", female: "Uzbekistani") },
            }
        );

        /// <summary>
        /// create an instance of Uzbekistan country
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
        private Uzbekistan(
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
