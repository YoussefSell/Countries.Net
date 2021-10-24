namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Monaco country
    /// </summary>
    public class Monaco : Country
    {
        /// <summary>
        /// get the Monaco country instance
        /// </summary>
        public static Monaco Instance = new Monaco(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Principality of Monaco", common: "Monaco") },
                { "fra", new CountryName(official: "Principauté de Monaco", common: "Monaco") },
                { "ara", new CountryName(official: "إمارة موناكو", common: "موناكو") },
                { "ces", new CountryName(official: "Monacké knížectví", common: "Monako") },
                { "cym", new CountryName(official: "Principality of Monaco", common: "Monaco") },
                { "deu", new CountryName(official: "Fürstentum Monaco", common: "Monaco") },
                { "est", new CountryName(official: "Monaco Vürstiriik", common: "Monaco") },
                { "fin", new CountryName(official: "Monacon ruhtinaskunta", common: "Monaco") },
                { "hrv", new CountryName(official: "Kneževina Monako", common: "Monako") },
                { "hun", new CountryName(official: "Monacói Hercegség", common: "Monaco") },
                { "ita", new CountryName(official: "Principato di Monaco", common: "Principato di Monaco") },
                { "jpn", new CountryName(official: "モナコ公国", common: "モナコ") },
                { "kor", new CountryName(official: "모나코 공국", common: "모나코") },
                { "nld", new CountryName(official: "Vorstendom Monaco", common: "Monaco") },
                { "per", new CountryName(official: "شاهزاده‌نشین موناکو", common: "موناکو") },
                { "pol", new CountryName(official: "Księstwo Monako", common: "Monako") },
                { "por", new CountryName(official: "Principado do Mónaco", common: "Mónaco") },
                { "rus", new CountryName(official: "Княжество Монако", common: "Монако") },
                { "slk", new CountryName(official: "Monacké kniežatstvo", common: "Monako") },
                { "spa", new CountryName(official: "Principado de Mónaco", common: "Mónaco") },
                { "swe", new CountryName(official: "Furstendömet Monaco", common: "Monaco") },
                { "urd", new CountryName(official: "جمہوریہ مناکو", common: "موناکو") },
                { "zho", new CountryName(official: "摩纳哥公国", common: "摩纳哥") },

            },
            cca2: "MC",
            cca3: "MCO",
            ccn3: "492",
            cioc: "MON",
            flag: "🇲🇨",
            region: Region.Europe,
            subregion: "Western Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"77", }),
            borders: new string[] { "FRA",  },
            capital: new string[] { "Monaco",  },
            altSpellings: new string[] { "MC", "Principality of Monaco", "Principauté de Monaco",  },
            tld: new string[] { ".mc",  },
            latlng: new double[] { 43.73333333, 7.4,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Monegasque", female: "Monegasque") },
                { "fra", new DemonymsGender(male: "Monegasque", female: "Monegasque") },
            }
        );

        /// <summary>
        /// create an instance of Monaco country
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
        private Monaco(
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
