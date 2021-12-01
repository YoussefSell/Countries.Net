namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Guinea country
    /// </summary>
    public class Guinea : Country
    {
        /// <summary>
        /// get the Guinea country instance
        /// </summary>
        public static Guinea Instance = new Guinea(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Guinea", common: "Guinea") },
                { "fra", new CountryName(official: "République de Guinée", common: "Guinée") },
                { "ara", new CountryName(official: "جمهورية غينيا", common: "غينيا") },
                { "ces", new CountryName(official: "Guinejská republika", common: "Guinea") },
                { "cym", new CountryName(official: "Republic of Guinea", common: "Guinea") },
                { "deu", new CountryName(official: "Republik Guinea", common: "Guinea") },
                { "est", new CountryName(official: "Guinea Vabariik", common: "Guinea") },
                { "fin", new CountryName(official: "Guinean tasavalta", common: "Guinea") },
                { "hrv", new CountryName(official: "Republika Gvineja", common: "Gvineja") },
                { "hun", new CountryName(official: "Guineai Köztársaság", common: "Guinea") },
                { "ita", new CountryName(official: "Repubblica di Guinea", common: "Guinea") },
                { "jpn", new CountryName(official: "ギニア共和国", common: "ギニア") },
                { "kor", new CountryName(official: "기니 공화국", common: "기니") },
                { "nld", new CountryName(official: "Republiek Guinee", common: "Guinee") },
                { "per", new CountryName(official: "مملکت مستقل پاپوآ گینه نو", common: "پاپوآ گینه نو") },
                { "pol", new CountryName(official: "Republika Gwinei", common: "Gwinea") },
                { "por", new CountryName(official: "República da Guiné", common: "Guiné") },
                { "rus", new CountryName(official: "Республика Гвинея", common: "Гвинея") },
                { "slk", new CountryName(official: "Guinejská republika", common: "Guinea") },
                { "spa", new CountryName(official: "República de Guinea", common: "Guinea") },
                { "swe", new CountryName(official: "Republiken Guinea", common: "Guinea") },
                { "urd", new CountryName(official: "جمہوریہ گنی", common: "گنی") },
                { "zho", new CountryName(official: "几内亚共和国", common: "几内亚") },

            },
            cca2: "GN",
            cca3: "GIN",
            ccn3: "324",
            cioc: "GUI",
            flag: "🇬🇳",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"24", }),
            borders: new string[] { "CIV", "GNB", "LBR", "MLI", "SEN", "SLE",  },
            capital: new string[] { "Conakry",  },
            altSpellings: new string[] { "GN", "Republic of Guinea", "République de Guinée",  },
            tld: new string[] { ".gn",  },
            latlng: new double[] { 11, -10,  },
            timezones: new string[] { "UTC",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "GNF", name: "Guinean franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Guinean", female: "Guinean") },
                { "fra", new DemonymsGender(male: "Guinean", female: "Guinean") },
            }
        );

        /// <summary>
        /// create an instance of Guinea country
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
        private Guinea(
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
