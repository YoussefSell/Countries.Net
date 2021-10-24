namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Comoros country
    /// </summary>
    public class Comoros : Country
    {
        /// <summary>
        /// get the Comoros country instance
        /// </summary>
        public static Comoros Instance = new Comoros(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Union of the Comoros", common: "Comoros") },
                { "ara", new CountryName(official: "الاتحاد القمري", common: "القمر‎") },
                { "fra", new CountryName(official: "Union des Comores", common: "Comores") },
                { "zdj", new CountryName(official: "Udzima wa Komori", common: "Komori") },
                { "ces", new CountryName(official: "Komorský svaz", common: "Komory") },
                { "cym", new CountryName(official: "Undeb y Comoros", common: "Y Comoros") },
                { "deu", new CountryName(official: "Union der Komoren", common: "Komoren") },
                { "est", new CountryName(official: "Komoori Liit", common: "Komoorid") },
                { "fin", new CountryName(official: "Komorien liitto", common: "Komorit") },
                { "hrv", new CountryName(official: "Savez Komori", common: "Komori") },
                { "hun", new CountryName(official: "Comore-szigeteki Unió", common: "Comore-szigetek") },
                { "ita", new CountryName(official: "Unione delle Comore", common: "Comore") },
                { "jpn", new CountryName(official: "コモロ連合", common: "コモロ") },
                { "kor", new CountryName(official: "코모로 연방", common: "코모로") },
                { "nld", new CountryName(official: "Unie van de Comoren", common: "Comoren") },
                { "per", new CountryName(official: "مجمع‌الجزایر قمر", common: "اتحاد قُمُر") },
                { "pol", new CountryName(official: "Związek Komorów", common: "Komory") },
                { "por", new CountryName(official: "União das Comores", common: "Comores") },
                { "rus", new CountryName(official: "Союз Коморских Островов", common: "Коморы") },
                { "slk", new CountryName(official: "Komorská únia", common: "Komory") },
                { "spa", new CountryName(official: "Unión de las Comoras", common: "Comoras") },
                { "swe", new CountryName(official: "Unionen Komorerna", common: "Komorerna") },
                { "urd", new CountryName(official: "اتحاد القمری", common: "القمری") },
                { "zho", new CountryName(official: "科摩罗联盟", common: "科摩罗") },

            },
            cca2: "KM",
            cca3: "COM",
            ccn3: "174",
            cioc: "COM",
            flag: "🇰🇲",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"69", }),
            borders: new string[] {  },
            capital: new string[] { "Moroni",  },
            altSpellings: new string[] { "KM", "Union of the Comoros", "Union des Comores", "Udzima wa Komori", "al-Ittiḥād al-Qumurī",  },
            tld: new string[] { ".km",  },
            latlng: new double[] { -12.16666666, 44.25,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
                new Language(name: "Comorian", iso6391: "", iso6392: "zdj"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "KMF", name: "Comorian franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Comoran", female: "Comoran") },
                { "fra", new DemonymsGender(male: "Comoran", female: "Comoran") },
            }
        );

        /// <summary>
        /// create an instance of Comoros country
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
        private Comoros(
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
