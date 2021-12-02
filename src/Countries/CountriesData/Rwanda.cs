namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Rwanda country
    /// </summary>
    public class Rwanda : Country
    {
        /// <summary>
        /// get the Rwanda country instance
        /// </summary>
        public static Rwanda Instance = new Rwanda(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Rwanda", common: "Rwanda") },
                { "fra", new CountryName(official: "République rwandaise", common: "Rwanda") },
                { "kin", new CountryName(official: "Repubulika y'u Rwanda", common: "Rwanda") },
                { "ara", new CountryName(official: "جمهورية رواندا", common: "رواندا") },
                { "ces", new CountryName(official: "Rwandská republika", common: "Rwanda") },
                { "cym", new CountryName(official: "Republic of Rwanda", common: "Rwanda") },
                { "deu", new CountryName(official: "Republik Ruanda", common: "Ruanda") },
                { "est", new CountryName(official: "Rwanda Vabariik", common: "Rwanda") },
                { "fin", new CountryName(official: "Ruandan tasavalta", common: "Ruanda") },
                { "hrv", new CountryName(official: "Republika Ruandi", common: "Ruanda") },
                { "hun", new CountryName(official: "Ruandai Köztársaság", common: "Ruanda") },
                { "ita", new CountryName(official: "Repubblica del Ruanda", common: "Ruanda") },
                { "jpn", new CountryName(official: "ルワンダ共和国", common: "ルワンダ") },
                { "kor", new CountryName(official: "르완다 공화국", common: "르완다") },
                { "nld", new CountryName(official: "Republiek Rwanda", common: "Rwanda") },
                { "per", new CountryName(official: "جمهوری رواندا", common: "رواندا") },
                { "pol", new CountryName(official: "Republika Rwandy", common: "Rwanda") },
                { "por", new CountryName(official: "República do Ruanda", common: "Ruanda") },
                { "rus", new CountryName(official: "Республика Руанда", common: "Руанда") },
                { "slk", new CountryName(official: "Rwandská republika", common: "Rwanda") },
                { "spa", new CountryName(official: "República de Rwanda", common: "Ruanda") },
                { "swe", new CountryName(official: "Republiken Rwanda", common: "Rwanda") },
                { "urd", new CountryName(official: "جمہوریہ روانڈا", common: "روانڈا") },
                { "zho", new CountryName(official: "卢旺达共和国", common: "卢旺达") },

            },
            cca2: "RW",
            cca3: "RWA",
            ccn3: "646",
            cioc: "RWA",
            flag: "🇷🇼",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"50", }),
            borders: new string[] { "BDI", "COD", "TZA", "UGA",  },
            capital: new string[] { "Kigali",  },
            altSpellings: new string[] { "RW", "Republic of Rwanda", "Repubulika y'u Rwanda", "République du Rwanda",  },
            tld: new string[] { ".rw",  },
            latlng: new double[] { -2, 30,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
                new Language(name: "Kinyarwanda", iso6391: "rw", iso6392: "kin"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "RWF", name: "Rwandan franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Rwandan", female: "Rwandan") },
                { "fra", new DemonymsGender(male: "Rwandan", female: "Rwandan") },
            }
        );

        /// <summary>
        /// create an instance of Rwanda country
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
        private Rwanda(
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
