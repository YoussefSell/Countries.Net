namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Albania country
    /// </summary>
    public class Albania : Country
    {
        /// <summary>
        /// get the Albania country instance
        /// </summary>
        public static Albania Instance = new Albania(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Albania", common: "Albania") },
                { "sqi", new CountryName(official: "Republika e Shqipërisë", common: "Shqipëria") },
                { "ara", new CountryName(official: "جمهورية ألبانيا", common: "ألبانيا") },
                { "ces", new CountryName(official: "Albánská republika", common: "Albánie") },
                { "cym", new CountryName(official: "Gweriniaeth Albania", common: "Albania") },
                { "deu", new CountryName(official: "Republik Albanien", common: "Albanien") },
                { "est", new CountryName(official: "Albaania Vabariik", common: "Albaania") },
                { "fin", new CountryName(official: "Albanian tasavalta", common: "Albania") },
                { "fra", new CountryName(official: "République d'Albanie", common: "Albanie") },
                { "hrv", new CountryName(official: "Republika Albanija", common: "Albanija") },
                { "hun", new CountryName(official: "Albán Köztársaság", common: "Albánia") },
                { "ita", new CountryName(official: "Repubblica d'Albania", common: "Albania") },
                { "jpn", new CountryName(official: "アルバニア共和国", common: "アルバニア") },
                { "kor", new CountryName(official: "알바니아 공화국", common: "알바니아") },
                { "nld", new CountryName(official: "Republiek Albanië", common: "Albanië") },
                { "per", new CountryName(official: "جمهوری آلبانی", common: "آلبانی") },
                { "pol", new CountryName(official: "Republika Albanii", common: "Albania") },
                { "por", new CountryName(official: "República da Albânia", common: "Albânia") },
                { "rus", new CountryName(official: "Республика Албания", common: "Албания") },
                { "slk", new CountryName(official: "Albánska republika", common: "Albánsko") },
                { "spa", new CountryName(official: "República de Albania", common: "Albania") },
                { "swe", new CountryName(official: "Republiken Albanien", common: "Albanien") },
                { "urd", new CountryName(official: "جمہوریہ البانیا", common: "البانیا") },
                { "zho", new CountryName(official: "阿尔巴尼亚共和国", common: "阿尔巴尼亚") },
            },
            cca2: "AL",
            cca3: "ALB",
            ccn3: "008",
            cioc: "ALB",
            flag: "🇦🇱",
            region: Region.Europe,
            subregion: "Southeast Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"55", }),
            borders: new string[] { "MNE", "GRC", "MKD", "UNK",  },
            capital: new string[] { "Tirana",  },
            altSpellings: new string[] { "AL", "Shqipëri", "Shqipëria", "Shqipnia",  },
            tld: new string[] { ".al",  },
            latlng: new double[] { 41, 20,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Albanian", iso6391: "sq", iso6392: "sqi"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "ALL", name: "Albanian lek", symbol: "L"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Albanian", female: "Albanian") },
                { "fra", new DemonymsGender(male: "Albanian", female: "Albanian") },
            }
        );

        /// <summary>
        /// create an instance of Albania country
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
        private Albania(
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
