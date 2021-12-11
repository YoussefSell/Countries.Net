namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Iceland country
    /// </summary>
    public class Iceland : Country
    {
        /// <summary>
        /// get the Iceland country instance
        /// </summary>
        public static Iceland Instance = new Iceland(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Iceland", common: "Iceland") },
                { "isl", new CountryName(official: "Ísland", common: "Ísland") },
                { "ara", new CountryName(official: "آيسلندا", common: "آيسلندا") },
                { "ces", new CountryName(official: "Island", common: "Island") },
                { "cym", new CountryName(official: "Iceland", common: "Iceland") },
                { "deu", new CountryName(official: "Island", common: "Island") },
                { "est", new CountryName(official: "Islandi Vabariik", common: "Island") },
                { "fin", new CountryName(official: "Islanti", common: "Islanti") },
                { "fra", new CountryName(official: "République d'Islande", common: "Islande") },
                { "hrv", new CountryName(official: "Island", common: "Island") },
                { "hun", new CountryName(official: "Izland", common: "Izland") },
                { "ita", new CountryName(official: "Islanda", common: "Islanda") },
                { "jpn", new CountryName(official: "アイスランド", common: "アイスランド") },
                { "kor", new CountryName(official: "아이슬란드 공화국", common: "아이슬란드") },
                { "nld", new CountryName(official: "IJsland", common: "IJsland") },
                { "per", new CountryName(official: "جمهوری ایسلند", common: "ایسلند") },
                { "pol", new CountryName(official: "Republika Islandii", common: "Islandia") },
                { "por", new CountryName(official: "Islândia", common: "Islândia") },
                { "rus", new CountryName(official: "Исландия", common: "Исландия") },
                { "slk", new CountryName(official: "Islandská republika", common: "Island") },
                { "spa", new CountryName(official: "Islandia", common: "Islandia") },
                { "swe", new CountryName(official: "Island", common: "Island") },
                { "urd", new CountryName(official: "آئس لینڈ", common: "آئس لینڈ") },
                { "zho", new CountryName(official: "冰岛", common: "冰岛") },
            },
            cca2: "IS",
            cca3: "ISL",
            ccn3: "352",
            cioc: "ISL",
            flag: "🇮🇸",
            region: Region.Europe,
            subregion: "Northern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"54", }),
            borders: new string[] {  },
            capital: new string[] { "Reykjavik",  },
            altSpellings: new string[] { "IS", "Island", "Republic of Iceland", "Lýðveldið Ísland",  },
            tld: new string[] { ".is",  },
            latlng: new double[] { 65, -18,  },
            timezones: new string[] { "UTC",  },
            languages: new Language[]
            {
                new Language(name: "Icelandic", iso6391: "is", iso6392: "isl"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "ISK", name: "Icelandic króna", symbol: "kr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Icelander", female: "Icelander") },
                { "fra", new DemonymsGender(male: "Icelander", female: "Icelander") },
            }
        );

        /// <summary>
        /// create an instance of Iceland country
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
        private Iceland(
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
