namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Burundi country
    /// </summary>
    public class Burundi : Country
    {
        /// <summary>
        /// get the Burundi country instance
        /// </summary>
        public static Burundi Instance = new Burundi(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Burundi", common: "Burundi") },
                { "fra", new CountryName(official: "République du Burundi", common: "Burundi") },
                { "run", new CountryName(official: "Republika y'Uburundi ", common: "Uburundi") },
                { "ara", new CountryName(official: "جمهورية بوروندي", common: "بوروندي") },
                { "ces", new CountryName(official: "Burundská republika", common: "Burundi") },
                { "cym", new CountryName(official: "Gweriniaeth Bwrwndi", common: "Bwrwndi") },
                { "deu", new CountryName(official: "Republik Burundi", common: "Burundi") },
                { "est", new CountryName(official: "Burundi Vabariik", common: "Burundi") },
                { "fin", new CountryName(official: "Burundin tasavalta", common: "Burundi") },
                { "hrv", new CountryName(official: "Burundi", common: "Burundi") },
                { "hun", new CountryName(official: "Burundi", common: "Burundi") },
                { "ita", new CountryName(official: "Repubblica del Burundi", common: "Burundi") },
                { "jpn", new CountryName(official: "ブルンジ共和国", common: "ブルンジ") },
                { "kor", new CountryName(official: "부룬디", common: "부룬디") },
                { "nld", new CountryName(official: "Republiek Burundi", common: "Burundi") },
                { "per", new CountryName(official: "جمهوری بوروندی", common: "بوروندی") },
                { "pol", new CountryName(official: "Republika Burundi", common: "Burundi") },
                { "por", new CountryName(official: "República do Burundi", common: "Burundi") },
                { "rus", new CountryName(official: "Республика Бурунди", common: "Бурунди") },
                { "slk", new CountryName(official: "Burundská republika", common: "Burundi") },
                { "spa", new CountryName(official: "República de Burundi", common: "Burundi") },
                { "swe", new CountryName(official: "Republiken Burundi", common: "Burundi") },
                { "urd", new CountryName(official: "جمہوریہ برونڈی", common: "برونڈی") },
                { "zho", new CountryName(official: "布隆迪共和国", common: "布隆迪") },

            },
            cca2: "BI",
            cca3: "BDI",
            ccn3: "108",
            cioc: "BDI",
            flag: "🇧🇮",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"57", }),
            borders: new string[] { "COD", "RWA", "TZA",  },
            capital: new string[] { "Gitega",  },
            altSpellings: new string[] { "BI", "Republic of Burundi", "Republika y'Uburundi", "République du Burundi",  },
            tld: new string[] { ".bi",  },
            latlng: new double[] { -3.5, 30,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
                new Language(name: "Kirundi", iso6391: "rn", iso6392: "run"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "BIF", name: "Burundian franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Burundian", female: "Burundian") },
                { "fra", new DemonymsGender(male: "Burundian", female: "Burundian") },
            }
        );

        /// <summary>
        /// create an instance of Burundi country
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
        private Burundi(
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
