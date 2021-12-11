namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of FrenchPolynesia country
    /// </summary>
    public class FrenchPolynesia : Country
    {
        /// <summary>
        /// get the FrenchPolynesia country instance
        /// </summary>
        public static FrenchPolynesia Instance = new FrenchPolynesia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "French Polynesia", common: "French Polynesia") },
                { "fra", new CountryName(official: "Polynésie française", common: "Polynésie française") },
                { "ara", new CountryName(official: "بولينزيا الفرنسية", common: "بولينزيا الفرنسية") },
                { "ces", new CountryName(official: "Francouzská Polynésie", common: "Francouzská Polynésie") },
                { "cym", new CountryName(official: "French Polynesia", common: "French Polynesia") },
                { "deu", new CountryName(official: "Französisch-Polynesien", common: "Französisch-Polynesien") },
                { "est", new CountryName(official: "Prantsuse Polüneesia", common: "Prantsuse Polüneesia") },
                { "fin", new CountryName(official: "Ranskan Polynesia", common: "Ranskan Polynesia") },
                { "hrv", new CountryName(official: "Francuska Polinezija", common: "Francuska Polinezija") },
                { "hun", new CountryName(official: "Francia Polinézia", common: "Francia Polinézia") },
                { "ita", new CountryName(official: "Polinesia Francese", common: "Polinesia Francese") },
                { "jpn", new CountryName(official: "フランス領ポリネシア", common: "フランス領ポリネシア") },
                { "kor", new CountryName(official: "프랑스령 폴리네시아", common: "프랑스령 폴리네시아") },
                { "nld", new CountryName(official: "Frans-Polynesië", common: "Frans-Polynesië") },
                { "per", new CountryName(official: "پُلی‌نِزی فرانسه", common: "پُلی‌نِزی فرانسه") },
                { "pol", new CountryName(official: "Polinezja Francuska", common: "Polinezja Francuska") },
                { "por", new CountryName(official: "Polinésia Francesa", common: "Polinésia Francesa") },
                { "rus", new CountryName(official: "Французская Полинезия", common: "Французская Полинезия") },
                { "slk", new CountryName(official: "Francúzska Polynézia", common: "Francúzska Polynézia") },
                { "spa", new CountryName(official: "Polinesia francés", common: "Polinesia Francesa") },
                { "swe", new CountryName(official: "Franska Polynesien", common: "Franska Polynesien") },
                { "urd", new CountryName(official: "فرانسیسی پولینیشیا", common: "فرانسیسی پولینیشیا") },
                { "zho", new CountryName(official: "法属波利尼西亚", common: "法属波利尼西亚") },

            },
            cca2: "PF",
            cca3: "PYF",
            ccn3: "258",
            cioc: "",
            flag: "🇵🇫",
            region: Region.Oceania,
            subregion: "Polynesia",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"89", }),
            borders: new string[] {  },
            capital: new string[] { "Papeetē",  },
            altSpellings: new string[] { "PF", "Polynésie française", "French Polynesia", "Pōrīnetia Farāni",  },
            tld: new string[] { ".pf",  },
            latlng: new double[] { -15, -140,  },
            timezones: new string[] { "UTC-10:00", "UTC-09:30", "UTC-09:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XPF", name: "CFP franc", symbol: "₣"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "French Polynesian", female: "French Polynesian") },
                { "fra", new DemonymsGender(male: "French Polynesian", female: "French Polynesian") },
            }
        );

        /// <summary>
        /// create an instance of FrenchPolynesia country
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
        private FrenchPolynesia(
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
