namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Djibouti country
    /// </summary>
    public class Djibouti : Country
    {
        /// <summary>
        /// get the Djibouti country instance
        /// </summary>
        public static Djibouti Instance = new Djibouti(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Djibouti", common: "Djibouti") },
                { "ara", new CountryName(official: "جمهورية جيبوتي", common: "جيبوتي‎") },
                { "fra", new CountryName(official: "République de Djibouti", common: "Djibouti") },
                { "ces", new CountryName(official: "Džibutská republika", common: "Džibutsko") },
                { "cym", new CountryName(official: "Gweriniaeth Jibwti", common: "Jibwti") },
                { "deu", new CountryName(official: "Republik Dschibuti", common: "Dschibuti") },
                { "est", new CountryName(official: "Djibouti Vabariik", common: "Djibouti") },
                { "fin", new CountryName(official: "Dijiboutin tasavalta", common: "Dijibouti") },
                { "hrv", new CountryName(official: "Republika Džibuti", common: "Džibuti") },
                { "hun", new CountryName(official: "Dzsibuti Köztársaság", common: "Dzsibuti") },
                { "ita", new CountryName(official: "Repubblica di Gibuti", common: "Gibuti") },
                { "jpn", new CountryName(official: "ジブチ共和国", common: "ジブチ") },
                { "kor", new CountryName(official: "지부티 공화국", common: "지부티") },
                { "nld", new CountryName(official: "Republiek Djibouti", common: "Djibouti") },
                { "per", new CountryName(official: "جمهوری جیبوتی", common: "جیبوتی") },
                { "pol", new CountryName(official: "Republika Dżibuti", common: "Dżibuti") },
                { "por", new CountryName(official: "República do Djibouti", common: "Djibouti") },
                { "rus", new CountryName(official: "Республика Джибути", common: "Джибути") },
                { "slk", new CountryName(official: "ǅibutská republika", common: "ǅibutsko") },
                { "spa", new CountryName(official: "República de Djibouti", common: "Djibouti") },
                { "swe", new CountryName(official: "Republiken Djibouti", common: "Djibouti") },
                { "urd", new CountryName(official: "جمہوریہ جبوتی", common: "جبوتی") },
                { "zho", new CountryName(official: "吉布提共和国", common: "吉布提") },

            },
            cca2: "DJ",
            cca3: "DJI",
            ccn3: "262",
            cioc: "DJI",
            flag: "🇩🇯",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"53", }),
            borders: new string[] { "ERI", "ETH", "SOM",  },
            capital: new string[] { "Djibouti",  },
            altSpellings: new string[] { "DJ", "Jabuuti", "Gabuuti", "Republic of Djibouti", "République de Djibouti", "Gabuutih Ummuuno", "Jamhuuriyadda Jabuuti",  },
            tld: new string[] { ".dj",  },
            latlng: new double[] { 11.5, 43,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "DJF", name: "Djiboutian franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Djibouti", female: "Djibouti") },
                { "fra", new DemonymsGender(male: "Djibouti", female: "Djibouti") },
            }
        );

        /// <summary>
        /// create an instance of Djibouti country
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
        private Djibouti(
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
