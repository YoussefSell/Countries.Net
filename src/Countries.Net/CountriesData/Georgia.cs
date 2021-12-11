namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Georgia country
    /// </summary>
    public class Georgia : Country
    {
        /// <summary>
        /// get the Georgia country instance
        /// </summary>
        public static Georgia Instance = new Georgia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Georgia", common: "Georgia") },
                { "kat", new CountryName(official: "საქართველო", common: "საქართველო") },
                { "ara", new CountryName(official: "جورجيا", common: "جورجيا") },
                { "ces", new CountryName(official: "Gruzie", common: "Gruzie") },
                { "cym", new CountryName(official: "Georgia", common: "Georgia") },
                { "deu", new CountryName(official: "Georgien", common: "Georgien") },
                { "est", new CountryName(official: "Gruusia", common: "Gruusia") },
                { "fin", new CountryName(official: "Georgia", common: "Georgia") },
                { "fra", new CountryName(official: "République de Géorgie", common: "Géorgie") },
                { "hrv", new CountryName(official: "Gruzija", common: "Gruzija") },
                { "hun", new CountryName(official: "Grúzia", common: "Grúzia") },
                { "ita", new CountryName(official: "Georgia", common: "Georgia") },
                { "jpn", new CountryName(official: "グルジア", common: "グルジア") },
                { "kor", new CountryName(official: "조지아", common: "조지아") },
                { "nld", new CountryName(official: "Georgia", common: "Georgië") },
                { "per", new CountryName(official: "گرجستان", common: "گرجستان") },
                { "pol", new CountryName(official: "Gruzja", common: "Gruzja") },
                { "por", new CountryName(official: "Georgia", common: "Geórgia") },
                { "rus", new CountryName(official: "Грузия", common: "Грузия") },
                { "slk", new CountryName(official: "Gruzínsko", common: "Gruzínsko") },
                { "spa", new CountryName(official: "Georgia", common: "Georgia") },
                { "swe", new CountryName(official: "Georgien", common: "Georgien") },
                { "urd", new CountryName(official: "جارجیا", common: "جارجیا") },
                { "zho", new CountryName(official: "格鲁吉亚", common: "格鲁吉亚") },
            },
            cca2: "GE",
            cca3: "GEO",
            ccn3: "268",
            cioc: "GEO",
            flag: "🇬🇪",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"95", }),
            borders: new string[] { "ARM", "AZE", "RUS", "TUR",  },
            capital: new string[] { "Tbilisi",  },
            altSpellings: new string[] { "GE", "Sakartvelo",  },
            tld: new string[] { ".ge",  },
            latlng: new double[] { 42, 43.5,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "Georgian", iso6391: "ka", iso6392: "kat"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "GEL", name: "lari", symbol: "₾"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Georgian", female: "Georgian") },
                { "fra", new DemonymsGender(male: "Georgian", female: "Georgian") },
            }
        );

        /// <summary>
        /// create an instance of Georgia country
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
        private Georgia(
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
