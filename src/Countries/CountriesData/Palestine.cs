namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Palestine country
    /// </summary>
    public class Palestine : Country
    {
        /// <summary>
        /// get the Palestine country instance
        /// </summary>
        public static Palestine Instance = new Palestine(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "State of Palestine", common: "Palestine") },
                { "ara", new CountryName(official: "دولة فلسطين", common: "فلسطين") },
                { "ces", new CountryName(official: "Stát Palestina", common: "Palestina") },
                { "cym", new CountryName(official: "State of Palestine", common: "Palestine") },
                { "deu", new CountryName(official: "Staat Palästina", common: "Palästina") },
                { "est", new CountryName(official: "Palestiina Riik", common: "Palestiina") },
                { "fin", new CountryName(official: "Palestiinan valtio", common: "Palestiina") },
                { "fra", new CountryName(official: "État de Palestine", common: "Palestine") },
                { "hrv", new CountryName(official: "State of Palestine", common: "Palestina") },
                { "hun", new CountryName(official: "Palesztin Autonómia", common: "Palesztina") },
                { "ita", new CountryName(official: "Stato di Palestina", common: "Palestina") },
                { "jpn", new CountryName(official: "パレスチナ自治政府", common: "パレスチナ") },
                { "kor", new CountryName(official: "팔레스타인국", common: "팔레스타인") },
                { "nld", new CountryName(official: "Staat Palestina", common: "Palestijnse gebieden") },
                { "per", new CountryName(official: "دولت فلسطین", common: "فلسطین") },
                { "pol", new CountryName(official: "Państwo Palestyna", common: "Palestyna") },
                { "por", new CountryName(official: "Estado da Palestina", common: "Palestina") },
                { "rus", new CountryName(official: "Государство Палестина", common: "Палестина") },
                { "slk", new CountryName(official: "Palestínsky štát", common: "Palestína") },
                { "spa", new CountryName(official: "Estado de Palestina", common: "Palestina") },
                { "swe", new CountryName(official: "Palestina", common: "Palestina") },
                { "urd", new CountryName(official: "ریاستِ فلسطین", common: "فلسطین") },
                { "zho", new CountryName(official: "巴勒斯坦国", common: "巴勒斯坦") },

            },
            cca2: "PS",
            cca3: "PSE",
            ccn3: "275",
            cioc: "PLE",
            flag: "🇵🇸",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"70", }),
            borders: new string[] { "ISR", "EGY", "JOR",  },
            capital: new string[] { "Ramallah",  },
            altSpellings: new string[] { "PS", "Palestine, State of", "State of Palestine", "Dawlat Filasṭin",  },
            tld: new string[] { ".ps", "فلسطين.",  },
            latlng: new double[] { 31.9, 35.2,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EGP", name: "Egyptian pound", symbol: "E£"),
                new Currency(code: "ILS", name: "Israeli new shekel", symbol: "₪"),
                new Currency(code: "JOD", name: "Jordanian dinar", symbol: "JD"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Palestinian", female: "Palestinian") },
                { "fra", new DemonymsGender(male: "Palestinian", female: "Palestinian") },
            }
        );

        /// <summary>
        /// create an instance of Palestine country
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
        private Palestine(
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
