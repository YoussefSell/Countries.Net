namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Chile country
    /// </summary>
    public class Chile : Country
    {
        /// <summary>
        /// get the Chile country instance
        /// </summary>
        public static Chile Instance = new Chile(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Chile", common: "Chile") },
                { "spa", new CountryName(official: "República de Chile", common: "Chile") },
                { "ara", new CountryName(official: "جمهورية تشيلي", common: "تشيلي") },
                { "ces", new CountryName(official: "Chilská republika", common: "Chile") },
                { "cym", new CountryName(official: "Gweriniaeth Chile", common: "Chile") },
                { "deu", new CountryName(official: "Republik Chile", common: "Chile") },
                { "est", new CountryName(official: "Tšiili Vabariik", common: "Tšiili") },
                { "fin", new CountryName(official: "Chilen tasavalta", common: "Chile") },
                { "fra", new CountryName(official: "République du Chili", common: "Chili") },
                { "hrv", new CountryName(official: "Republika Čile", common: "Čile") },
                { "hun", new CountryName(official: "Chilei Köztársaság", common: "Chile") },
                { "ita", new CountryName(official: "Repubblica del Cile", common: "Cile") },
                { "jpn", new CountryName(official: "チリ共和国", common: "チリ") },
                { "kor", new CountryName(official: "칠레 공화국", common: "칠레") },
                { "nld", new CountryName(official: "Republiek Chili", common: "Chili") },
                { "per", new CountryName(official: "جمهوری شیلی", common: "شیلی") },
                { "pol", new CountryName(official: "Republika Chile", common: "Chile") },
                { "por", new CountryName(official: "República do Chile", common: "Chile") },
                { "rus", new CountryName(official: "Республика Чили", common: "Чили") },
                { "slk", new CountryName(official: "Čílska republika", common: "Čile") },
                { "swe", new CountryName(official: "Republiken Chile", common: "Chile") },
                { "urd", new CountryName(official: "جمہوریہ چلی", common: "چلی") },
                { "zho", new CountryName(official: "智利共和国", common: "智利") },

            },
            cca2: "CL",
            cca3: "CHL",
            ccn3: "152",
            cioc: "CHI",
            flag: "🇨🇱",
            region: Region.Americas,
            subregion: "South America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"6", }),
            borders: new string[] { "ARG", "BOL", "PER",  },
            capital: new string[] { "Santiago",  },
            altSpellings: new string[] { "CL", "Republic of Chile", "República de Chile",  },
            tld: new string[] { ".cl",  },
            latlng: new double[] { -30, -71,  },
            timezones: new string[] { "UTC-06:00", "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "CLP", name: "Chilean peso", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Chilean", female: "Chilean") },
                { "fra", new DemonymsGender(male: "Chilean", female: "Chilean") },
            }
        );

        /// <summary>
        /// create an instance of Chile country
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
        private Chile(
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
