namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of NorfolkIsland country
    /// </summary>
    public class NorfolkIsland : Country
    {
        /// <summary>
        /// get the NorfolkIsland country instance
        /// </summary>
        public static NorfolkIsland Instance = new NorfolkIsland(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Territory of Norfolk Island", common: "Norfolk Island") },
                { "pih", new CountryName(official: "Teratri of Norf'k Ailen", common: "Norf'k Ailen") },
                { "ara", new CountryName(official: "إقليم جزيرة نورفولك", common: "جزيرة نورفولك") },
                { "ces", new CountryName(official: "Teritorium ostrova Norfolk", common: "Norfolk") },
                { "cym", new CountryName(official: "Territory of Norfolk Island", common: "Norfolk Island") },
                { "deu", new CountryName(official: "Gebiet der Norfolkinsel", common: "Norfolkinsel") },
                { "est", new CountryName(official: "Norfolki saare ala", common: "Norfolk") },
                { "fin", new CountryName(official: "Norfolkinsaaren territorio", common: "Norfolkinsaari") },
                { "fra", new CountryName(official: "Territoire de l'île Norfolk", common: "Île Norfolk") },
                { "hrv", new CountryName(official: "Teritorij Norfolk Island", common: "Otok Norfolk") },
                { "hun", new CountryName(official: "Norfolk-sziget", common: "Norfolk-sziget") },
                { "ita", new CountryName(official: "Territorio di Norfolk Island", common: "Isola Norfolk") },
                { "jpn", new CountryName(official: "ノーフォーク島の領土", common: "ノーフォーク島") },
                { "kor", new CountryName(official: "노퍽 섬", common: "노퍽 섬") },
                { "nld", new CountryName(official: "Grondgebied van Norfolk Island", common: "Norfolkeiland") },
                { "per", new CountryName(official: "قلمرو جزایر نورفک", common: "جزیره نورفک") },
                { "pol", new CountryName(official: "Terytorium Wyspy Norfolk", common: "Wyspa Norfolk") },
                { "por", new CountryName(official: "Território da Ilha Norfolk", common: "Ilha Norfolk") },
                { "rus", new CountryName(official: "Территория острова Норфолк", common: "Норфолк") },
                { "slk", new CountryName(official: "Teritórium ostrova Norfolk", common: "Norfolk") },
                { "spa", new CountryName(official: "Territorio de la Isla Norfolk", common: "Isla de Norfolk") },
                { "swe", new CountryName(official: "Norfolkön", common: "Norfolkön") },
                { "urd", new CountryName(official: "جزیرہ نورفک خطہ", common: "جزیرہ نورفک") },
                { "zho", new CountryName(official: "诺福克岛", common: "诺福克岛") },
            },
            cca2: "NF",
            cca3: "NFK",
            ccn3: "574",
            cioc: "",
            flag: "🇳🇫",
            region: Region.Oceania,
            subregion: "Australia and New Zealand",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"72", }),
            borders: new string[] {  },
            capital: new string[] { "Kingston",  },
            altSpellings: new string[] { "NF", "Territory of Norfolk Island", "Teratri of Norf'k Ailen",  },
            tld: new string[] { ".nf",  },
            latlng: new double[] { -29.03333333, 167.95,  },
            timezones: new string[] { "UTC+11:30",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Norfuk", iso6391: "", iso6392: "pih"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "AUD", name: "Australian dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Norfolk Islander", female: "Norfolk Islander") },
                { "fra", new DemonymsGender(male: "Norfolk Islander", female: "Norfolk Islander") },
            }
        );

        /// <summary>
        /// create an instance of NorfolkIsland country
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
        private NorfolkIsland(
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
