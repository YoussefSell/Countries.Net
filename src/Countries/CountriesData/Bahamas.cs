namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Bahamas country
    /// </summary>
    public class Bahamas : Country
    {
        /// <summary>
        /// get the Bahamas country instance
        /// </summary>
        public static Bahamas Instance = new Bahamas(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Commonwealth of the Bahamas", common: "Bahamas") },
                { "ara", new CountryName(official: "كومنولث جزر البهاما", common: "باهاماس") },
                { "ces", new CountryName(official: "Bahamské společenství", common: "Bahamy") },
                { "cym", new CountryName(official: "Cymanwlad y Bahamas", common: "Bahamas") },
                { "deu", new CountryName(official: "Commonwealth der Bahamas", common: "Bahamas") },
                { "est", new CountryName(official: "Bahama Ühendus", common: "Bahama") },
                { "fin", new CountryName(official: "Bahaman liittovaltio", common: "Bahamasaaret") },
                { "fra", new CountryName(official: "Commonwealth des Bahamas", common: "Bahamas") },
                { "hrv", new CountryName(official: "Zajednica Bahama", common: "Bahami") },
                { "hun", new CountryName(official: "Bahamai Közösség", common: "Bahama-szigetek") },
                { "ita", new CountryName(official: "Commonwealth delle Bahamas", common: "Bahamas") },
                { "jpn", new CountryName(official: "バハマ", common: "バハマ") },
                { "kor", new CountryName(official: "바하마 연방", common: "바하마") },
                { "nld", new CountryName(official: "Gemenebest van de Bahama's", common: "Bahama’s") },
                { "per", new CountryName(official: "قلمرو همسود باهاما", common: "باهاما") },
                { "pol", new CountryName(official: "Bahamy", common: "Bahamy") },
                { "por", new CountryName(official: "Comunidade das Bahamas", common: "Bahamas") },
                { "rus", new CountryName(official: "Содружество Багамских Островов", common: "Багамские Острова") },
                { "slk", new CountryName(official: "Bahamské spoločenstvo", common: "Bahamy") },
                { "spa", new CountryName(official: "Commonwealth de las Bahamas", common: "Bahamas") },
                { "swe", new CountryName(official: "Samväldet Bahamas", common: "Bahamas") },
                { "urd", new CountryName(official: "دولتِ مشترکہ بہاماس", common: "بہاماس") },
                { "zho", new CountryName(official: "巴哈马联邦", common: "巴哈马") },
            },
            cca2: "BS",
            cca3: "BHS",
            ccn3: "044",
            cioc: "BAH",
            flag: "🇧🇸",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"242", }),
            borders: new string[] {  },
            capital: new string[] { "Nassau",  },
            altSpellings: new string[] { "BS", "Commonwealth of the Bahamas",  },
            tld: new string[] { ".bs",  },
            latlng: new double[] { 24.25, -76,  },
            timezones: new string[] { "UTC-05:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "BSD", name: "Bahamian dollar", symbol: "$"),
                new Currency(code: "USD", name: "United States dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Bahamian", female: "Bahamian") },
                { "fra", new DemonymsGender(male: "Bahamian", female: "Bahamian") },
            }
        );

        /// <summary>
        /// create an instance of Bahamas country
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
        private Bahamas(
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
