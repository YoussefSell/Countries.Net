namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of PuertoRico country
    /// </summary>
    public class PuertoRico : Country
    {
        /// <summary>
        /// get the PuertoRico country instance
        /// </summary>
        public static PuertoRico Instance = new PuertoRico(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Commonwealth of Puerto Rico", common: "Puerto Rico") },
                { "spa", new CountryName(official: "Estado Libre Asociado de Puerto Rico", common: "Puerto Rico") },
                { "ara", new CountryName(official: "كومنولث بويرتوريكو", common: "بويرتوريكو") },
                { "ces", new CountryName(official: "Portoriko", common: "Portoriko") },
                { "cym", new CountryName(official: "Commonwealth of Puerto Rico", common: "Puerto Rico") },
                { "deu", new CountryName(official: "Freistaat Puerto Rico", common: "Puerto Rico") },
                { "est", new CountryName(official: "Puerto Rico Ühendus", common: "Puerto Rico") },
                { "fin", new CountryName(official: "Puerto Rico", common: "Puerto Rico") },
                { "fra", new CountryName(official: "Porto Rico", common: "Porto Rico") },
                { "hrv", new CountryName(official: "Zajednica Puerto Rico", common: "Portoriko") },
                { "hun", new CountryName(official: "Puerto Rico", common: "Puerto Rico") },
                { "ita", new CountryName(official: "Commonwealth di Porto Rico", common: "Porto Rico") },
                { "jpn", new CountryName(official: "プエルトリコのコモンウェルス", common: "プエルトリコ") },
                { "kor", new CountryName(official: "푸에르토리코", common: "푸에르토리코") },
                { "nld", new CountryName(official: "Gemenebest van Puerto Rico", common: "Puerto Rico") },
                { "per", new CountryName(official: "قلمرو همسود پورتوریکو", common: "پورتوریکو") },
                { "pol", new CountryName(official: "Wolne Stowarzyszone Państwo Portoryko", common: "Portoryko") },
                { "por", new CountryName(official: "Commonwealth of Puerto Rico", common: "Porto Rico") },
                { "rus", new CountryName(official: "Содружество Пуэрто-Рико", common: "Пуэрто-Рико") },
                { "slk", new CountryName(official: "Portorické spoločenstvo", common: "Portoriko") },
                { "swe", new CountryName(official: "Puerto Rico", common: "Puerto Rico") },
                { "urd", new CountryName(official: " دولتِ مشترکہ پورٹو ریکو", common: "پورٹو ریکو") },
                { "zho", new CountryName(official: "波多黎各联邦", common: "波多黎各") },

            },
            cca2: "PR",
            cca3: "PRI",
            ccn3: "630",
            cioc: "PUR",
            flag: "🇵🇷",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"787", "939", }),
            borders: new string[] {  },
            capital: new string[] { "San Juan",  },
            altSpellings: new string[] { "PR", "Commonwealth of Puerto Rico", "Estado Libre Asociado de Puerto Rico",  },
            tld: new string[] { ".pr",  },
            latlng: new double[] { 18.25, -66.5,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "USD", name: "United States dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Puerto Rican", female: "Puerto Rican") },
                { "fra", new DemonymsGender(male: "Puerto Rican", female: "Puerto Rican") },
            }
        );

        /// <summary>
        /// create an instance of PuertoRico country
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
        private PuertoRico(
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
