namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Guinea-Bissau country
    /// </summary>
    public class GuineaBissau : Country
    {
        /// <summary>
        /// get the Guinea-Bissau country instance
        /// </summary>
        public static GuineaBissau Instance = new GuineaBissau(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Guinea-Bissau", common: "Guinea-Bissau") },
                { "por", new CountryName(official: "República da Guiné-Bissau", common: "Guiné-Bissau") },
                { "pov", new CountryName(official: "República da Guiné-Bissau", common: "Guiné-Bissau") },
                { "ara", new CountryName(official: "جمهورية غينيا بيساو", common: "غينيا بيساو") },
                { "ces", new CountryName(official: "Republika Guinea-Bissau", common: "Guinea-Bissau") },
                { "cym", new CountryName(official: "Republic of Guinea-Bissau", common: "Guinea-Bissau") },
                { "deu", new CountryName(official: "Republik Guinea-Bissau", common: "Guinea-Bissau") },
                { "est", new CountryName(official: "Guinea-Bissau Vabariik", common: "Guinea-Bissau") },
                { "fin", new CountryName(official: "Guinea-Bissaun tasavalta", common: "Guinea-Bissau") },
                { "fra", new CountryName(official: "République de Guinée-Bissau", common: "Guinée-Bissau") },
                { "hrv", new CountryName(official: "Republika Gvineja Bisau", common: "Gvineja Bisau") },
                { "hun", new CountryName(official: "Bissau-Guineai Köztársaság", common: "Bissau-Guinea") },
                { "ita", new CountryName(official: "Repubblica di Guinea-Bissau", common: "Guinea-Bissau") },
                { "jpn", new CountryName(official: "ギニアビサウ共和国", common: "ギニアビサウ") },
                { "kor", new CountryName(official: "기니비사우 공화국", common: "기니비사우") },
                { "nld", new CountryName(official: "Republiek Guinee-Bissau", common: "Guinee-Bissau") },
                { "per", new CountryName(official: "جمهوری گینه بیسائو", common: "گینه بیسائو") },
                { "pol", new CountryName(official: "Republika Gwinei Bissau", common: "Gwinea Bissau") },
                { "rus", new CountryName(official: "Республика Гвинея -Бисау", common: "Гвинея-Бисау") },
                { "slk", new CountryName(official: "Guinejsko-bissauská republika", common: "Guinea-Bissau") },
                { "spa", new CountryName(official: "República de Guinea-Bissau", common: "Guinea-Bisáu") },
                { "swe", new CountryName(official: "Republiken Guinea-Bissau", common: "Guinea-Bissau") },
                { "urd", new CountryName(official: "جمہوریہ گنی بساؤ", common: "گنی بساؤ") },
                { "zho", new CountryName(official: "几内亚比绍共和国", common: "几内亚比绍") },

            },
            cca2: "GW",
            cca3: "GNB",
            ccn3: "624",
            cioc: "GBS",
            flag: "🇬🇼",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: true,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"45", }),
            borders: new string[] { "GIN", "SEN",  },
            capital: new string[] { "Bissau",  },
            altSpellings: new string[] { "GW", "Republic of Guinea-Bissau", "República da Guiné-Bissau",  },
            tld: new string[] { ".gw",  },
            latlng: new double[] { 12, -15,  },
            timezones: new string[] { "UTC",  },
            languages: new Language[]
            {
                new Language(name: "Portuguese", iso6391: "pt", iso6392: "por"),
                new Language(name: "Upper Guinea Creole", iso6391: "", iso6392: "pov"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XOF", name: "West African CFA franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Guinea-Bissauan", female: "Guinea-Bissauan") },
                { "fra", new DemonymsGender(male: "Guinea-Bissauan", female: "Guinea-Bissauan") },
            }
        );

        /// <summary>
        /// create an instance of Guinea-Bissau country
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
        private GuineaBissau(
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
