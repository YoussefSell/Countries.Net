namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Malta country
    /// </summary>
    public class Malta : Country
    {
        /// <summary>
        /// get the Malta country instance
        /// </summary>
        public static Malta Instance = new Malta(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Malta", common: "Malta") },
                { "mlt", new CountryName(official: "Repubblika ta ' Malta", common: "Malta") },
                { "ara", new CountryName(official: "جمهورية مالطا", common: "مالطا") },
                { "ces", new CountryName(official: "Maltská republika", common: "Malta") },
                { "cym", new CountryName(official: "Republic of Malta", common: "Malta") },
                { "deu", new CountryName(official: "Republik Malta", common: "Malta") },
                { "est", new CountryName(official: "Malta Vabariik", common: "Malta") },
                { "fin", new CountryName(official: "Maltan tasavalta", common: "Malta") },
                { "fra", new CountryName(official: "République de Malte", common: "Malte") },
                { "hrv", new CountryName(official: "Republika Malta", common: "Malta") },
                { "hun", new CountryName(official: "Máltai Köztársaság", common: "Málta") },
                { "ita", new CountryName(official: "Repubblica di Malta", common: "Malta") },
                { "jpn", new CountryName(official: "マルタ共和国", common: "マルタ") },
                { "kor", new CountryName(official: "몰타 공화국", common: "몰타") },
                { "nld", new CountryName(official: "Republiek Malta", common: "Malta") },
                { "per", new CountryName(official: "جمهوری مالت", common: "مالت") },
                { "pol", new CountryName(official: "Republika Malty", common: "Malta") },
                { "por", new CountryName(official: "República de Malta", common: "Malta") },
                { "rus", new CountryName(official: "Республика Мальта", common: "Мальта") },
                { "slk", new CountryName(official: "Maltská republika", common: "Malta") },
                { "spa", new CountryName(official: "República de Malta", common: "Malta") },
                { "swe", new CountryName(official: "Republiken Malta", common: "Malta") },
                { "urd", new CountryName(official: "جمہوریہ مالٹا", common: "مالٹا") },
                { "zho", new CountryName(official: "马耳他共和国", common: "马耳他") },
            },
            cca2: "MT",
            cca3: "MLT",
            ccn3: "470",
            cioc: "MLT",
            flag: "🇲🇹",
            region: Region.Europe,
            subregion: "Southern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"56", }),
            borders: new string[] {  },
            capital: new string[] { "Valletta",  },
            altSpellings: new string[] { "MT", "Republic of Malta", "Repubblika ta' Malta",  },
            tld: new string[] { ".mt",  },
            latlng: new double[] { 35.83333333, 14.58333333,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Maltese", iso6391: "mt", iso6392: "mlt"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Maltese", female: "Maltese") },
                { "fra", new DemonymsGender(male: "Maltese", female: "Maltese") },
            }
        );

        /// <summary>
        /// create an instance of Malta country
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
        private Malta(
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
