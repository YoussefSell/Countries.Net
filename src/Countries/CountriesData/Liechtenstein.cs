namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Liechtenstein country
    /// </summary>
    public class Liechtenstein : Country
    {
        /// <summary>
        /// get the Liechtenstein country instance
        /// </summary>
        public static Liechtenstein Instance = new Liechtenstein(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Principality of Liechtenstein", common: "Liechtenstein") },
                { "deu", new CountryName(official: "Fürstentum Liechtenstein", common: "Liechtenstein") },
                { "ara", new CountryName(official: "إمارة ليختنشتاين", common: "ليختنشتاين") },
                { "ces", new CountryName(official: "Knížectví Lichtenštejnské", common: "Lichtenštejnsko") },
                { "cym", new CountryName(official: "Principality of Liechtenstein", common: "Liechtenstein") },
                { "est", new CountryName(official: "Liechtensteini Vürstiriik", common: "Liechtenstein") },
                { "fin", new CountryName(official: "Liechensteinin ruhtinaskunta", common: "Liechenstein") },
                { "fra", new CountryName(official: "Principauté du Liechtenstein", common: "Liechtenstein") },
                { "hrv", new CountryName(official: "Kneževina Lihtenštajn", common: "Lihtenštajn") },
                { "hun", new CountryName(official: "Liechtensteini Hercegség", common: "Liechtenstein") },
                { "ita", new CountryName(official: "Principato del Liechtenstein", common: "Liechtenstein") },
                { "jpn", new CountryName(official: "リヒテンシュタイン公国", common: "リヒテンシュタイン") },
                { "kor", new CountryName(official: "리히텐슈타인 공국", common: "리히텐슈타인") },
                { "nld", new CountryName(official: "Vorstendom Liechtenstein", common: "Liechtenstein") },
                { "per", new CountryName(official: "شاهزاده‌نشین لیختن‌اشتاین", common: "لیختن‌اشتاین") },
                { "pol", new CountryName(official: "Księstwo Liechtensteinu", common: "Liechtenstein") },
                { "por", new CountryName(official: "Principado de Liechtenstein", common: "Liechtenstein") },
                { "rus", new CountryName(official: "Княжество Лихтенштейн", common: "Лихтенштейн") },
                { "slk", new CountryName(official: "Lichtenštajnské kniežatstvo", common: "Lichtenštajnsko") },
                { "spa", new CountryName(official: "Principado de Liechtenstein", common: "Liechtenstein") },
                { "swe", new CountryName(official: "Furstendömet Liechtenstein", common: "Liechtenstein") },
                { "urd", new CountryName(official: "امارات لیختینستائن", common: "لیختینستائن") },
                { "zho", new CountryName(official: "列支敦士登公国", common: "列支敦士登") },

            },
            cca2: "LI",
            cca3: "LIE",
            ccn3: "438",
            cioc: "LIE",
            flag: "🇱🇮",
            region: Region.Europe,
            subregion: "Western Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"23", }),
            borders: new string[] { "AUT", "CHE",  },
            capital: new string[] { "Vaduz",  },
            altSpellings: new string[] { "LI", "Principality of Liechtenstein", "Fürstentum Liechtenstein",  },
            tld: new string[] { ".li",  },
            latlng: new double[] { 47.26666666, 9.53333333,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "German", iso6391: "de", iso6392: "deu"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "CHF", name: "Swiss franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Liechtensteiner", female: "Liechtensteiner") },
                { "fra", new DemonymsGender(male: "Liechtensteiner", female: "Liechtensteiner") },
            }
        );

        /// <summary>
        /// create an instance of Liechtenstein country
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
        private Liechtenstein(
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
