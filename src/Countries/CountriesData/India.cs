namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of India country
    /// </summary>
    public class India : Country
    {
        /// <summary>
        /// get the India country instance
        /// </summary>
        public static India Instance = new India(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of India", common: "India") },
                { "hin", new CountryName(official: "भारत गणराज्य", common: "भारत") },
                { "tam", new CountryName(official: "இந்தியக் குடியரசு", common: "இந்தியா") },
                { "ara", new CountryName(official: "جمهورية الهند", common: "الهند") },
                { "ces", new CountryName(official: "Indická republika", common: "Indie") },
                { "cym", new CountryName(official: "Republic of India", common: "India") },
                { "deu", new CountryName(official: "Republik Indien", common: "Indien") },
                { "est", new CountryName(official: "India Vabariik", common: "India") },
                { "fin", new CountryName(official: "Intian tasavalta", common: "Intia") },
                { "fra", new CountryName(official: "République de l'Inde", common: "Inde") },
                { "hrv", new CountryName(official: "Republika Indija", common: "Indija") },
                { "hun", new CountryName(official: "Indiai Köztársaság", common: "India") },
                { "ita", new CountryName(official: "Repubblica dell'India", common: "India") },
                { "jpn", new CountryName(official: "インド共和国", common: "インド") },
                { "kor", new CountryName(official: "인도 공화국", common: "인도") },
                { "nld", new CountryName(official: "Republiek India", common: "India") },
                { "per", new CountryName(official: "جمهوری هندوستان", common: "هند") },
                { "pol", new CountryName(official: "Republika Indii", common: "Indie") },
                { "por", new CountryName(official: "República da Índia", common: "Índia") },
                { "rus", new CountryName(official: "Республика Индия", common: "Индия") },
                { "slk", new CountryName(official: "Indická republika", common: "India") },
                { "spa", new CountryName(official: "República de la India", common: "India") },
                { "swe", new CountryName(official: "Republiken Indien", common: "Indien") },
                { "urd", new CountryName(official: "جمہوریہ بھارت", common: "بھارت") },
                { "zho", new CountryName(official: "印度共和国", common: "印度") },
            },
            cca2: "IN",
            cca3: "IND",
            ccn3: "356",
            cioc: "IND",
            flag: "🇮🇳",
            region: Region.Asia,
            subregion: "Southern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"1", }),
            borders: new string[] { "BGD", "BTN", "MMR", "CHN", "NPL", "PAK",  },
            capital: new string[] { "New Delhi",  },
            altSpellings: new string[] { "IN", "Bhārat", "Republic of India", "Bharat Ganrajya", "இந்தியா",  },
            tld: new string[] { ".in",  },
            latlng: new double[] { 20, 77,  },
            timezones: new string[] { "UTC+05:30",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Hindi", iso6391: "hi", iso6392: "hin"),
                new Language(name: "Tamil", iso6391: "ta", iso6392: "tam"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "INR", name: "Indian rupee", symbol: "₹"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Indian", female: "Indian") },
                { "fra", new DemonymsGender(male: "Indian", female: "Indian") },
            }
        );

        /// <summary>
        /// create an instance of India country
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
        private India(
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
