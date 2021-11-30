namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Israel country
    /// </summary>
    public class Israel : Country
    {
        /// <summary>
        /// get the Israel country instance
        /// </summary>
        public static Israel Instance = new Israel(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "State of Israel", common: "Israel") },
                { "ara", new CountryName(official: "دولة إسرائيل", common: "إسرائيل") },
                { "heb", new CountryName(official: "מדינת ישראל", common: "ישראל") },
                { "ces", new CountryName(official: "Stát Izrael", common: "Izrael") },
                { "cym", new CountryName(official: "State of Israel", common: "Israel") },
                { "deu", new CountryName(official: "Staat Israel", common: "Israel") },
                { "est", new CountryName(official: "Iisraeli Riik", common: "Iisrael") },
                { "fin", new CountryName(official: "Israelin valtio", common: "Israel") },
                { "fra", new CountryName(official: "État d'Israël", common: "Israël") },
                { "hrv", new CountryName(official: "Država Izrael", common: "Izrael") },
                { "hun", new CountryName(official: "Izrael", common: "Izrael") },
                { "ita", new CountryName(official: "Stato di Israele", common: "Israele") },
                { "jpn", new CountryName(official: "イスラエル国", common: "イスラエル") },
                { "kor", new CountryName(official: "이스라엘국", common: "이스라엘") },
                { "nld", new CountryName(official: "Staat Israël", common: "Israël") },
                { "per", new CountryName(official: "فلسطين اشغالی", common: "فلسطين اشغالی") },
                { "pol", new CountryName(official: "Państwo Izrael", common: "Izrael") },
                { "por", new CountryName(official: "Estado de Israel", common: "Israel") },
                { "rus", new CountryName(official: "Государство Израиль", common: "Израиль") },
                { "slk", new CountryName(official: "Izraelský štát", common: "Izrael") },
                { "spa", new CountryName(official: "Estado de Israel", common: "Israel") },
                { "swe", new CountryName(official: "Staten Israel", common: "Israel") },
                { "urd", new CountryName(official: "ریاستِ اسرائیل", common: "اسرائیل") },
                { "zho", new CountryName(official: "以色列国", common: "以色列") },

            },
            cca2: "IL",
            cca3: "ISR",
            ccn3: "376",
            cioc: "ISR",
            flag: "🇮🇱",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"72", }),
            borders: new string[] { "EGY", "JOR", "LBN", "PSE", "SYR",  },
            capital: new string[] { "Jerusalem",  },
            altSpellings: new string[] { "IL", "State of Israel", "Medīnat Yisrā'el",  },
            tld: new string[] { ".il",  },
            latlng: new double[] { 31.47, 35.13,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
                new Language(name: "Hebrew", iso6391: "he", iso6392: "heb"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "ILS", name: "Israeli new shekel", symbol: "₪"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Israeli", female: "Israeli") },
                { "fra", new DemonymsGender(male: "Israeli", female: "Israeli") },
            }
        );

        /// <summary>
        /// create an instance of Israel country
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
        private Israel(
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
