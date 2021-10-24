namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Kuwait country
    /// </summary>
    public class Kuwait : Country
    {
        /// <summary>
        /// get the Kuwait country instance
        /// </summary>
        public static Kuwait Instance = new Kuwait(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "State of Kuwait", common: "Kuwait") },
                { "ara", new CountryName(official: "دولة الكويت", common: "الكويت") },
                { "ces", new CountryName(official: "Stát Kuvajt", common: "Kuvajt") },
                { "cym", new CountryName(official: "State of Kuwait", common: "Kuwait") },
                { "deu", new CountryName(official: "Staat Kuwait", common: "Kuwait") },
                { "est", new CountryName(official: "Kuveidi Riik", common: "Kuveit") },
                { "fin", new CountryName(official: "Kuwaitin valtio", common: "Kuwait") },
                { "fra", new CountryName(official: "État du Koweït", common: "Koweït") },
                { "hrv", new CountryName(official: "Država Kuvajt", common: "Kuvajt") },
                { "hun", new CountryName(official: "Kuvaiti Állam", common: "Kuvait") },
                { "ita", new CountryName(official: "Stato del Kuwait", common: "Kuwait") },
                { "jpn", new CountryName(official: "クウェート国", common: "クウェート") },
                { "kor", new CountryName(official: "쿠웨이트국", common: "쿠웨이트") },
                { "nld", new CountryName(official: "Staat Koeweit", common: "Koeweit") },
                { "per", new CountryName(official: "دولت کویت", common: "کُویت") },
                { "pol", new CountryName(official: "Państwo Kuwejt", common: "Kuwejt") },
                { "por", new CountryName(official: "Estado do Kuwait", common: "Kuwait") },
                { "rus", new CountryName(official: "Государство Кувейт", common: "Кувейт") },
                { "slk", new CountryName(official: "Kuvajtský štát", common: "Kuvajt") },
                { "spa", new CountryName(official: "Estado de Kuwait", common: "Kuwait") },
                { "swe", new CountryName(official: "Staten Kuwait", common: "Kuwait") },
                { "urd", new CountryName(official: "دولتِ کویت", common: "کویت") },
                { "zho", new CountryName(official: "科威特国", common: "科威特") },

            },
            cca2: "KW",
            cca3: "KWT",
            ccn3: "414",
            cioc: "KUW",
            flag: "🇰🇼",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"65", }),
            borders: new string[] { "IRQ", "SAU",  },
            capital: new string[] { "Kuwait City",  },
            altSpellings: new string[] { "KW", "State of Kuwait", "Dawlat al-Kuwait",  },
            tld: new string[] { ".kw",  },
            latlng: new double[] { 29.5, 45.75,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "KWD", name: "Kuwaiti dinar", symbol: "د.ك"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Kuwaiti", female: "Kuwaiti") },
                { "fra", new DemonymsGender(male: "Kuwaiti", female: "Kuwaiti") },
            }
        );

        /// <summary>
        /// create an instance of Kuwait country
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
        private Kuwait(
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
