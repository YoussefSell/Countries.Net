namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of France country
    /// </summary>
    public class France : Country
    {
        /// <summary>
        /// get the France country instance
        /// </summary>
        public static France Instance = new France(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "French Republic", common: "France") },
                { "fra", new CountryName(official: "République française", common: "France") },
                { "ara", new CountryName(official: "الجمهورية الفرنسية", common: "فرنسا") },
                { "ces", new CountryName(official: "Francouzská republika", common: "Francie") },
                { "cym", new CountryName(official: "French Republic", common: "France") },
                { "deu", new CountryName(official: "Französische Republik", common: "Frankreich") },
                { "est", new CountryName(official: "Prantsuse Vabariik", common: "Prantsusmaa") },
                { "fin", new CountryName(official: "Ranskan tasavalta", common: "Ranska") },
                { "hrv", new CountryName(official: "Francuska Republika", common: "Francuska") },
                { "hun", new CountryName(official: "Francia Köztársaság", common: "Franciaország") },
                { "ita", new CountryName(official: "Repubblica francese", common: "Francia") },
                { "jpn", new CountryName(official: "フランス共和国", common: "フランス") },
                { "kor", new CountryName(official: "프랑스 공화국", common: "프랑스") },
                { "nld", new CountryName(official: "Franse Republiek", common: "Frankrijk") },
                { "per", new CountryName(official: "جمهوری فرانسه", common: "فرانسه") },
                { "pol", new CountryName(official: "Republika Francuska", common: "Francja") },
                { "por", new CountryName(official: "República Francesa", common: "França") },
                { "rus", new CountryName(official: "Французская Республика", common: "Франция") },
                { "slk", new CountryName(official: "Francúzska republika", common: "Francúzsko") },
                { "spa", new CountryName(official: "República francés", common: "Francia") },
                { "swe", new CountryName(official: "Republiken Frankrike", common: "Frankrike") },
                { "urd", new CountryName(official: "جمہوریہ فرانس", common: "فرانس") },
                { "zho", new CountryName(official: "法兰西共和国", common: "法国") },

            },
            cca2: "FR",
            cca3: "FRA",
            ccn3: "250",
            cioc: "FRA",
            flag: "🇫🇷",
            region: Region.Europe,
            subregion: "Western Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"3", }),
            borders: new string[] { "AND", "BEL", "DEU", "ITA", "LUX", "MCO", "ESP", "CHE",  },
            capital: new string[] { "Paris",  },
            altSpellings: new string[] { "FR", "French Republic", "République française",  },
            tld: new string[] { ".fr",  },
            latlng: new double[] { 46, 2,  },
            timezones: new string[] { "UTC-10:00", "UTC-09:30", "UTC-09:00", "UTC-08:00", "UTC-04:00", "UTC-03:00", "UTC+01:00", "UTC+02:00", "UTC+03:00", "UTC+04:00", "UTC+05:00", "UTC+10:00", "UTC+11:00", "UTC+12:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "French", female: "French") },
                { "fra", new DemonymsGender(male: "French", female: "French") },
            }
        );

        /// <summary>
        /// create an instance of France country
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
        private France(
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
