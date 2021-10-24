namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Ireland country
    /// </summary>
    public class Ireland : Country
    {
        /// <summary>
        /// get the Ireland country instance
        /// </summary>
        public static Ireland Instance = new Ireland(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Ireland", common: "Ireland") },
                { "gle", new CountryName(official: "Poblacht na hÉireann", common: "Éire") },
                { "ara", new CountryName(official: "جمهورية أيرلندا", common: "أيرلندا") },
                { "ces", new CountryName(official: "Irsko", common: "Irsko") },
                { "cym", new CountryName(official: "Republic of Ireland", common: "Ireland") },
                { "deu", new CountryName(official: "Republik Irland", common: "Irland") },
                { "est", new CountryName(official: "Iirimaa", common: "Iirimaa") },
                { "fin", new CountryName(official: "Irlannin tasavalta", common: "Irlanti") },
                { "fra", new CountryName(official: "République d'Irlande", common: "Irlande") },
                { "hrv", new CountryName(official: "Republika Irska", common: "Irska") },
                { "hun", new CountryName(official: "Ír Köztársaság", common: "Írország") },
                { "ita", new CountryName(official: "Repubblica d'Irlanda", common: "Irlanda") },
                { "jpn", new CountryName(official: "アイルランド共和国", common: "アイルランド") },
                { "kor", new CountryName(official: "아일랜드 공화국", common: "아일랜드") },
                { "nld", new CountryName(official: "Republic of Ireland", common: "Ierland") },
                { "per", new CountryName(official: "ایرلند", common: "ایرلند") },
                { "pol", new CountryName(official: "Republika Irlandii", common: "Irlandia") },
                { "por", new CountryName(official: "República da Irlanda", common: "Irlanda") },
                { "rus", new CountryName(official: "Ирландия", common: "Ирландия") },
                { "slk", new CountryName(official: "Írska republika", common: "Írsko") },
                { "spa", new CountryName(official: "República de Irlanda", common: "Irlanda") },
                { "swe", new CountryName(official: "Irland", common: "Irland") },
                { "urd", new CountryName(official: "جمہوریہ جزیرہ آئرلینڈ", common: "جزیرہ آئرلینڈ") },
                { "zho", new CountryName(official: "爱尔兰共和国", common: "爱尔兰") },
            },
            cca2: "IE",
            cca3: "IRL",
            ccn3: "372",
            cioc: "IRL",
            flag: "🇮🇪",
            region: Region.Europe,
            subregion: "Northern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"53", }),
            borders: new string[] { "GBR",  },
            capital: new string[] { "Dublin",  },
            altSpellings: new string[] { "IE", "Éire", "Republic of Ireland", "Poblacht na hÉireann",  },
            tld: new string[] { ".ie",  },
            latlng: new double[] { 53, -8,  },
            timezones: new string[] { "UTC",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Irish", iso6391: "ga", iso6392: "gle"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Irish", female: "Irish") },
                { "fra", new DemonymsGender(male: "Irish", female: "Irish") },
            }
        );

        /// <summary>
        /// create an instance of Ireland country
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
        private Ireland(
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
