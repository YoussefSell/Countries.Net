namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of CostaRica country
    /// </summary>
    public class CostaRica : Country
    {
        /// <summary>
        /// get the CostaRica country instance
        /// </summary>
        public static CostaRica Instance = new CostaRica(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Costa Rica", common: "Costa Rica") },
                { "spa", new CountryName(official: "República de Costa Rica", common: "Costa Rica") },
                { "ara", new CountryName(official: "جمهورية كوستاريكا", common: "كوستاريكا") },
                { "ces", new CountryName(official: "Kostarická republika", common: "Kostarika") },
                { "cym", new CountryName(official: "Gweriniaeth Costa Rica", common: "Costa Rica") },
                { "deu", new CountryName(official: "Republik Costa Rica", common: "Costa Rica") },
                { "est", new CountryName(official: "Costa Rica Vabariik", common: "Costa Rica") },
                { "fin", new CountryName(official: "Costa Rican tasavalta", common: "Costa Rica") },
                { "fra", new CountryName(official: "République du Costa Rica", common: "Costa Rica") },
                { "hrv", new CountryName(official: "Republika Kostarika", common: "Kostarika") },
                { "hun", new CountryName(official: "Costa Rica-i Köztársaság", common: "Costa Rica") },
                { "ita", new CountryName(official: "Repubblica di Costa Rica", common: "Costa Rica") },
                { "jpn", new CountryName(official: "コスタリカ共和国", common: "コスタリカ") },
                { "kor", new CountryName(official: "코스타리카 공화국", common: "코스타리카") },
                { "nld", new CountryName(official: "Republiek Costa Rica", common: "Costa Rica") },
                { "per", new CountryName(official: "جمهوری کاستاریکا", common: "کاستاریکا") },
                { "pol", new CountryName(official: "Republika Kostaryki", common: "Kostaryka") },
                { "por", new CountryName(official: "República da Costa Rica", common: "Costa Rica") },
                { "rus", new CountryName(official: "Республика Коста-Рика", common: "Коста-Рика") },
                { "slk", new CountryName(official: "Kostarická republika", common: "Kostarika") },
                { "swe", new CountryName(official: "Republiken Costa Rica", common: "Costa Rica") },
                { "urd", new CountryName(official: "جمہوریہ کوسٹاریکا", common: "کوسٹاریکا") },
                { "zho", new CountryName(official: "哥斯达黎加共和国", common: "哥斯达黎加") },

            },
            cca2: "CR",
            cca3: "CRI",
            ccn3: "188",
            cioc: "CRC",
            flag: "🇨🇷",
            region: Region.Americas,
            subregion: "Central America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"06", }),
            borders: new string[] { "NIC", "PAN",  },
            capital: new string[] { "San José",  },
            altSpellings: new string[] { "CR", "Republic of Costa Rica", "República de Costa Rica",  },
            tld: new string[] { ".cr",  },
            latlng: new double[] { 10, -84,  },
            timezones: new string[] { "UTC-06:00",  },
            languages: new Language[]
            {
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "CRC", name: "Costa Rican colón", symbol: "₡"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Costa Rican", female: "Costa Rican") },
                { "fra", new DemonymsGender(male: "Costa Rican", female: "Costa Rican") },
            }
        );

        /// <summary>
        /// create an instance of CostaRica country
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
        private CostaRica(
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
