namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Kosovo country
    /// </summary>
    public class Kosovo : Country
    {
        /// <summary>
        /// get the Kosovo country instance
        /// </summary>
        public static Kosovo Instance = new Kosovo(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Kosovo", common: "Kosovo") },
                { "sqi", new CountryName(official: "Republika e Kosovës", common: "Kosova") },
                { "srp", new CountryName(official: "Република Косово", common: "Косово") },
                { "ara", new CountryName(official: "جمهورية كوسوفو", common: "كوسوفو") },
                { "ces", new CountryName(official: "Kosovská republika", common: "Kosovo") },
                { "cym", new CountryName(official: "Republic of Kosovo", common: "Kosovo") },
                { "deu", new CountryName(official: "Republik Kosovo", common: "Kosovo") },
                { "est", new CountryName(official: "Kosovo Vabariik", common: "Kosovo") },
                { "fin", new CountryName(official: "Kosovon tasavalta", common: "Kosovo") },
                { "fra", new CountryName(official: "République du Kosovo", common: "Kosovo") },
                { "hrv", new CountryName(official: "Republika Kosovo", common: "Kosovo") },
                { "hun", new CountryName(official: "Koszovó", common: "Koszovó") },
                { "ita", new CountryName(official: "Repubblica del Kosovo", common: "Kosovo") },
                { "kor", new CountryName(official: "코소보 공화국", common: "코소보") },
                { "nld", new CountryName(official: "Republiek Kosovo", common: "Kosovo") },
                { "per", new CountryName(official: "جمهوری کوزوو", common: "کوزوو") },
                { "pol", new CountryName(official: "Republika Kosowa", common: "Kosowo") },
                { "por", new CountryName(official: "República do Kosovo", common: "Kosovo") },
                { "rus", new CountryName(official: "Республика Косово", common: "Республика Косово") },
                { "slk", new CountryName(official: "Republika Kosovo", common: "Kosovo") },
                { "spa", new CountryName(official: "República de Kosovo", common: "Kosovo") },
                { "swe", new CountryName(official: "Republiken Kosovo", common: "Kosovo") },
                { "urd", new CountryName(official: "جمہوریہ کوسووہ", common: "کوسووہ") },
                { "zho", new CountryName(official: "科索沃共和国", common: "科索沃") },
            },
            cca2: "XK",
            cca3: "UNK",
            ccn3: "",
            cioc: "KOS",
            flag: "🇽🇰",
            region: Region.Europe,
            subregion: "Southeast Europe",
            independent: false,
            status: "user-assigned",
            unMember: false,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"83", }),
            borders: new string[] { "ALB", "MKD", "MNE", "SRB",  },
            capital: new string[] { "Pristina",  },
            altSpellings: new string[] { "XK", "Република Косово",  },
            tld: new string[] {  },
            latlng: new double[] { 42.666667, 21.166667,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Albanian", iso6391: "sq", iso6392: "sqi"),
                new Language(name: "Serbian", iso6391: "sr", iso6392: "srp"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Kosovar", female: "Kosovar") },
                { "fra", new DemonymsGender(male: "Kosovar", female: "Kosovar") },
            }
        );

        /// <summary>
        /// create an instance of Kosovo country
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
        private Kosovo(
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
