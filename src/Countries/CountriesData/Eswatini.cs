namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Eswatini country
    /// </summary>
    public class Eswatini : Country
    {
        /// <summary>
        /// get the Eswatini country instance
        /// </summary>
        public static Eswatini Instance = new Eswatini(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Kingdom of Eswatini", common: "Eswatini") },
                { "ssw", new CountryName(official: "Umbuso weSwatini", common: "eSwatini") },
                { "ara", new CountryName(official: "مملكة إسواتيني", common: "إسواتيني") },
                { "ces", new CountryName(official: "Svazijské království", common: "Svazijsko") },
                { "cym", new CountryName(official: "Kingdom of Eswatini", common: "Eswatini") },
                { "deu", new CountryName(official: "Königreich Eswatini", common: "Swasiland") },
                { "est", new CountryName(official: "eSwatini Kuningriik", common: "Svaasimaa") },
                { "fin", new CountryName(official: "Swazimaan kuningaskunta", common: "Swazimaa") },
                { "fra", new CountryName(official: "Royaume d’Eswatini", common: "Swaziland") },
                { "hrv", new CountryName(official: "Kraljevina eSwatini", common: "Svazi") },
                { "hun", new CountryName(official: "Szváziföldi Királyság", common: "Szváziföld") },
                { "ita", new CountryName(official: "Regno di eSwatini", common: "Swaziland") },
                { "jpn", new CountryName(official: "スワジランド王国", common: "スワジランド") },
                { "kor", new CountryName(official: "에스와티니 왕국", common: "에스와티니") },
                { "nld", new CountryName(official: "Koninkrijk eSwatini", common: "Swaziland") },
                { "per", new CountryName(official: "پادشاهی سوازیلند", common: "اسواتینی") },
                { "pol", new CountryName(official: "Królestwo Suazi", common: "Suazi") },
                { "por", new CountryName(official: "Reino de eSwatini", common: "Suazilândia") },
                { "rus", new CountryName(official: "Королевство Свазиленд", common: "Свазиленд") },
                { "slk", new CountryName(official: "Svazijské kráľovstvo", common: "Svazijsko") },
                { "spa", new CountryName(official: "Reino de eSwatini", common: "Suazilandia") },
                { "swe", new CountryName(official: "Konungariket Eswatini", common: "Swaziland") },
                { "urd", new CountryName(official: "مملکتِ سوازی لینڈ", common: "سوازی لینڈ") },
                { "zho", new CountryName(official: "斯威士兰王国", common: "斯威士兰") },
            },
            cca2: "SZ",
            cca3: "SWZ",
            ccn3: "748",
            cioc: "SWZ",
            flag: "🇸🇿",
            region: Region.Africa,
            subregion: "Southern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"68", }),
            borders: new string[] { "MOZ", "ZAF",  },
            capital: new string[] { "Mbabane",  },
            altSpellings: new string[] { "SZ", "Swaziland", "weSwatini", "Swatini", "Ngwane", "Kingdom of Eswatini", "Umbuso weSwatini",  },
            tld: new string[] { ".sz",  },
            latlng: new double[] { -26.5, 31.5,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Swazi", iso6391: "ss", iso6392: "ssw"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "SZL", name: "Swazi lilangeni", symbol: "L"),
                new Currency(code: "ZAR", name: "South African rand", symbol: "R"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Swazi", female: "Swazi") },
                { "fra", new DemonymsGender(male: "Swazi", female: "Swazi") },
            }
        );

        /// <summary>
        /// create an instance of Eswatini country
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
        private Eswatini(
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
