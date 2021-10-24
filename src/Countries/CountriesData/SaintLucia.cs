namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of SaintLucia country
    /// </summary>
    public class SaintLucia : Country
    {
        /// <summary>
        /// get the SaintLucia country instance
        /// </summary>
        public static SaintLucia Instance = new SaintLucia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Saint Lucia", common: "Saint Lucia") },
                { "ara", new CountryName(official: "سانت لوسيا", common: "سانت لوسيا") },
                { "ces", new CountryName(official: "Svatá Lucie", common: "Svatá Lucie") },
                { "cym", new CountryName(official: "Saint Lucia", common: "Saint Lucia") },
                { "deu", new CountryName(official: "St. Lucia", common: "St. Lucia") },
                { "est", new CountryName(official: "Saint Lucia", common: "Saint Lucia") },
                { "fin", new CountryName(official: "Saint Lucia", common: "Saint Lucia") },
                { "fra", new CountryName(official: "Sainte-Lucie", common: "Sainte-Lucie") },
                { "hrv", new CountryName(official: "Sveta Lucija", common: "Sveta Lucija") },
                { "hun", new CountryName(official: "Saint Lucia", common: "Saint Lucia") },
                { "ita", new CountryName(official: "Santa Lucia", common: "Santa Lucia") },
                { "jpn", new CountryName(official: "セントルシア", common: "セントルシア") },
                { "kor", new CountryName(official: "세인트루시아", common: "세인트루시아") },
                { "nld", new CountryName(official: "Saint Lucia", common: "Saint Lucia") },
                { "per", new CountryName(official: "سنت لوسیا", common: "سنت لوسیا") },
                { "pol", new CountryName(official: "Saint Lucia", common: "Saint Lucia") },
                { "por", new CountryName(official: "Santa Lúcia", common: "Santa Lúcia") },
                { "rus", new CountryName(official: "Сент-Люсия", common: "Сент-Люсия") },
                { "slk", new CountryName(official: "Svätá Lucia", common: "Svätá Lucia") },
                { "spa", new CountryName(official: "Santa Lucía", common: "Santa Lucía") },
                { "swe", new CountryName(official: "Saint Lucia", common: "Saint Lucia") },
                { "urd", new CountryName(official: "سینٹ لوسیا", common: "سینٹ لوسیا") },
                { "zho", new CountryName(official: "圣卢西亚", common: "圣卢西亚") },
            },
            cca2: "LC",
            cca3: "LCA",
            ccn3: "662",
            cioc: "LCA",
            flag: "🇱🇨",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"758", }),
            borders: new string[] {  },
            capital: new string[] { "Castries",  },
            altSpellings: new string[] { "LC",  },
            tld: new string[] { ".lc",  },
            latlng: new double[] { 13.88333333, -60.96666666,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XCD", name: "Eastern Caribbean dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Saint Lucian", female: "Saint Lucian") },
                { "fra", new DemonymsGender(male: "Saint Lucian", female: "Saint Lucian") },
            }
        );

        /// <summary>
        /// create an instance of SaintLucia country
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
        private SaintLucia(
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
