namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of AmericanSamoa country
    /// </summary>
    public class AmericanSamoa : Country
    {
        /// <summary>
        /// get the AmericanSamoa country instance
        /// </summary>
        public static AmericanSamoa Instance = new AmericanSamoa(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "American Samoa", common: "American Samoa") },
                { "smo", new CountryName(official: "Sāmoa Amelika", common: "Sāmoa Amelika") },
                { "ara", new CountryName(official: "ساموا الأمريكية", common: "ساموا الأمريكية") },
                { "ces", new CountryName(official: "Americká Samoa", common: "Americká Samoa") },
                { "cym", new CountryName(official: "American Samoa", common: "American Samoa") },
                { "deu", new CountryName(official: "Amerikanisch-Samoa", common: "Amerikanisch-Samoa") },
                { "est", new CountryName(official: "Ameerika Samoa", common: "Ameerika Samoa") },
                { "fin", new CountryName(official: "Amerikan Samoa", common: "Amerikan Samoa") },
                { "fra", new CountryName(official: "Samoa américaines", common: "Samoa américaines") },
                { "hrv", new CountryName(official: "američka Samoa", common: "Američka Samoa") },
                { "hun", new CountryName(official: "Szamoa", common: "Szamoa") },
                { "ita", new CountryName(official: "Samoa americane", common: "Samoa Americane") },
                { "jpn", new CountryName(official: "米サモア", common: "アメリカ領サモア") },
                { "kor", new CountryName(official: "아메리칸사모아", common: "아메리칸사모아") },
                { "nld", new CountryName(official: "Amerikaans Samoa", common: "Amerikaans Samoa") },
                { "per", new CountryName(official: "ساموآی آمریکا", common: "ساموآی آمریکا") },
                { "pol", new CountryName(official: "Samoa Amerykańskie", common: "Samoa Amerykańskie") },
                { "por", new CountryName(official: "Samoa americana", common: "Samoa Americana") },
                { "rus", new CountryName(official: "американское Самоа", common: "Американское Самоа") },
                { "slk", new CountryName(official: "Americká Samoa", common: "Americká Samoa") },
                { "spa", new CountryName(official: "Samoa Americana", common: "Samoa Americana") },
                { "swe", new CountryName(official: "Amerikanska Samoa", common: "Amerikanska Samoa") },
                { "urd", new CountryName(official: "امریکی سمووا", common: "امریکی سمووا") },
                { "zho", new CountryName(official: "美属萨摩亚", common: "美属萨摩亚") },
            },
            cca2: "AS",
            cca3: "ASM",
            ccn3: "016",
            cioc: "ASA",
            flag: "🇦🇸",
            region: Region.Oceania,
            subregion: "Polynesia",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"684", }),
            borders: new string[] {  },
            capital: new string[] { "Pago Pago",  },
            altSpellings: new string[] { "AS", "Amerika Sāmoa", "Amelika Sāmoa", "Sāmoa Amelika",  },
            tld: new string[] { ".as",  },
            latlng: new double[] { -14.33333333, -170,  },
            timezones: new string[] { "UTC-11:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Samoan", iso6391: "sm", iso6392: "smo"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "USD", name: "United States dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "American Samoan", female: "American Samoan") },
                { "fra", new DemonymsGender(male: "American Samoan", female: "American Samoan") },
            }
        );

        /// <summary>
        /// create an instance of AmericanSamoa country
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
        private AmericanSamoa(
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
