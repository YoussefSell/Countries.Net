namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Lesotho country
    /// </summary>
    public class Lesotho : Country
    {
        /// <summary>
        /// get the Lesotho country instance
        /// </summary>
        public static Lesotho Instance = new Lesotho(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Kingdom of Lesotho", common: "Lesotho") },
                { "sot", new CountryName(official: "Kingdom of Lesotho", common: "Lesotho") },
                { "ara", new CountryName(official: "مملكة ليسوتو", common: "ليسوتو") },
                { "ces", new CountryName(official: "Lesothské království", common: "Lesotho") },
                { "cym", new CountryName(official: "Kingdom of Lesotho", common: "Lesotho") },
                { "deu", new CountryName(official: "Königreich Lesotho", common: "Lesotho") },
                { "est", new CountryName(official: "Lesotho Kuningriik", common: "Lesotho") },
                { "fin", new CountryName(official: "Lesothon kuningaskunta", common: "Lesotho") },
                { "fra", new CountryName(official: "Royaume du Lesotho", common: "Lesotho") },
                { "hrv", new CountryName(official: "Kraljevina Lesoto", common: "Lesoto") },
                { "hun", new CountryName(official: "Lesothói Királyság", common: "Lesotho") },
                { "ita", new CountryName(official: "Regno del Lesotho", common: "Lesotho") },
                { "jpn", new CountryName(official: "レソト王国", common: "レソト") },
                { "kor", new CountryName(official: "레소토 왕국", common: "레소토") },
                { "nld", new CountryName(official: "Koninkrijk Lesotho", common: "Lesotho") },
                { "per", new CountryName(official: "پادشاهی لسوتو", common: "لسوتو") },
                { "pol", new CountryName(official: "Królestwo Lesotho", common: "Lesotho") },
                { "por", new CountryName(official: "Reino do Lesoto", common: "Lesoto") },
                { "rus", new CountryName(official: "Королевство Лесото", common: "Лесото") },
                { "slk", new CountryName(official: "Lesothské kráľovstvo", common: "Lesotho") },
                { "spa", new CountryName(official: "Reino de Lesotho", common: "Lesotho") },
                { "swe", new CountryName(official: "Konungariket Lesotho", common: "Lesotho") },
                { "urd", new CountryName(official: "مملکتِ لیسوتھو", common: "لیسوتھو") },
                { "zho", new CountryName(official: "莱索托王国", common: "莱索托") },
            },
            cca2: "LS",
            cca3: "LSO",
            ccn3: "426",
            cioc: "LES",
            flag: "🇱🇸",
            region: Region.Africa,
            subregion: "Southern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"66", }),
            borders: new string[] { "ZAF",  },
            capital: new string[] { "Maseru",  },
            altSpellings: new string[] { "LS", "Kingdom of Lesotho", "Muso oa Lesotho",  },
            tld: new string[] { ".ls",  },
            latlng: new double[] { -29.5, 28.5,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Sotho", iso6391: "st", iso6392: "sot"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "LSL", name: "Lesotho loti", symbol: "L"),
                new Currency(code: "ZAR", name: "South African rand", symbol: "R"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Mosotho", female: "Mosotho") },
                { "fra", new DemonymsGender(male: "Mosotho", female: "Mosotho") },
            }
        );

        /// <summary>
        /// create an instance of Lesotho country
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
        private Lesotho(
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
