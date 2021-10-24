namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Sweden country
    /// </summary>
    public class Sweden : Country
    {
        /// <summary>
        /// get the Sweden country instance
        /// </summary>
        public static Sweden Instance = new Sweden(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Kingdom of Sweden", common: "Sweden") },
                { "swe", new CountryName(official: "Konungariket Sverige", common: "Sverige") },
                { "ara", new CountryName(official: "مملكة السويد", common: "السويد") },
                { "ces", new CountryName(official: "Švédské království", common: "Švédsko") },
                { "cym", new CountryName(official: "Kingdom of Sweden", common: "Sweden") },
                { "deu", new CountryName(official: "Königreich Schweden", common: "Schweden") },
                { "est", new CountryName(official: "Rootsi Kuningriik", common: "Rootsi") },
                { "fin", new CountryName(official: "Ruotsin kuningaskunta", common: "Ruotsi") },
                { "fra", new CountryName(official: "Royaume de Suède", common: "Suède") },
                { "hrv", new CountryName(official: "Kraljevina Švedska", common: "Švedska") },
                { "hun", new CountryName(official: "Svéd Királyság", common: "Svédország") },
                { "ita", new CountryName(official: "Regno di Svezia", common: "Svezia") },
                { "jpn", new CountryName(official: "スウェーデン王国", common: "スウェーデン") },
                { "kor", new CountryName(official: "스웨덴 왕국", common: "스웨덴") },
                { "nld", new CountryName(official: "Koninkrijk Zweden", common: "Zweden") },
                { "per", new CountryName(official: "پادشاهی سوئد", common: "سوئد") },
                { "pol", new CountryName(official: "Królestwo Szwecji", common: "Szwecja") },
                { "por", new CountryName(official: "Reino da Suécia", common: "Suécia") },
                { "rus", new CountryName(official: "Королевство Швеция", common: "Швеция") },
                { "slk", new CountryName(official: "Švédske kráľovstvo", common: "Švédsko") },
                { "spa", new CountryName(official: "Reino de Suecia", common: "Suecia") },
                { "urd", new CountryName(official: "مملکتِ سویڈن", common: "سویڈن") },
                { "zho", new CountryName(official: "瑞典王国", common: "瑞典") },

            },
            cca2: "SE",
            cca3: "SWE",
            ccn3: "752",
            cioc: "SWE",
            flag: "🇸🇪",
            region: Region.Europe,
            subregion: "Northern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"6", }),
            borders: new string[] { "FIN", "NOR",  },
            capital: new string[] { "Stockholm",  },
            altSpellings: new string[] { "SE", "Kingdom of Sweden", "Konungariket Sverige",  },
            tld: new string[] { ".se",  },
            latlng: new double[] { 62, 15,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Swedish", iso6391: "sv", iso6392: "swe"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "SEK", name: "Swedish krona", symbol: "kr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Swedish", female: "Swedish") },
                { "fra", new DemonymsGender(male: "Swedish", female: "Swedish") },
            }
        );

        /// <summary>
        /// create an instance of Sweden country
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
        private Sweden(
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
