namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Tokelau country
    /// </summary>
    public class Tokelau : Country
    {
        /// <summary>
        /// get the Tokelau country instance
        /// </summary>
        public static Tokelau Instance = new Tokelau(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Tokelau", common: "Tokelau") },
                { "smo", new CountryName(official: "Tokelau", common: "Tokelau") },
                { "tkl", new CountryName(official: "Tokelau", common: "Tokelau") },
                { "ara", new CountryName(official: "توكيلاو", common: "توكيلاو") },
                { "ces", new CountryName(official: "Tokelau", common: "Tokelau") },
                { "cym", new CountryName(official: "Tokelau", common: "Tokelau") },
                { "deu", new CountryName(official: "Tokelau", common: "Tokelau") },
                { "est", new CountryName(official: "Tokelau", common: "Tokelau") },
                { "fin", new CountryName(official: "Tokelau", common: "Tokelau") },
                { "fra", new CountryName(official: "Îles Tokelau", common: "Tokelau") },
                { "hrv", new CountryName(official: "Tokelau", common: "Tokelau") },
                { "hun", new CountryName(official: "Tokelau-szigetek", common: "Tokelau-szigetek") },
                { "ita", new CountryName(official: "Tokelau", common: "Isole Tokelau") },
                { "jpn", new CountryName(official: "トケラウ諸島", common: "トケラウ") },
                { "kor", new CountryName(official: "토켈라우", common: "토켈라우") },
                { "nld", new CountryName(official: "Tokelau", common: "Tokelau") },
                { "per", new CountryName(official: "توکلائو", common: "توکلائو") },
                { "pol", new CountryName(official: "Tokelau", common: "Tokelau") },
                { "por", new CountryName(official: "Tokelau", common: "Tokelau") },
                { "rus", new CountryName(official: "Токелау", common: "Токелау") },
                { "slk", new CountryName(official: "Tokelauské ostrovy", common: "Tokelau") },
                { "spa", new CountryName(official: "Tokelau", common: "Islas Tokelau") },
                { "swe", new CountryName(official: "Tokelauöarna", common: "Tokelauöarna") },
                { "urd", new CountryName(official: "ٹوکیلاؤ", common: "ٹوکیلاؤ") },
                { "zho", new CountryName(official: "托克劳", common: "托克劳") },
            },
            cca2: "TK",
            cca3: "TKL",
            ccn3: "772",
            cioc: "",
            flag: "🇹🇰",
            region: Region.Oceania,
            subregion: "Polynesia",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"90", }),
            borders: new string[] {  },
            capital: new string[] { "Fakaofo",  },
            altSpellings: new string[] { "TK",  },
            tld: new string[] { ".tk",  },
            latlng: new double[] { -9, -172,  },
            timezones: new string[] { "UTC+13:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Samoan", iso6391: "sm", iso6392: "smo"),
                new Language(name: "Tokelauan", iso6391: "", iso6392: "tkl"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "NZD", name: "New Zealand dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Tokelauan", female: "Tokelauan") },
                { "fra", new DemonymsGender(male: "Tokelauan", female: "Tokelauan") },
            }
        );

        /// <summary>
        /// create an instance of Tokelau country
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
        private Tokelau(
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
