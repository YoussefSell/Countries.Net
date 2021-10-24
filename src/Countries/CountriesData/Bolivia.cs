namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Bolivia country
    /// </summary>
    public class Bolivia : Country
    {
        /// <summary>
        /// get the Bolivia country instance
        /// </summary>
        public static Bolivia Instance = new Bolivia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Plurinational State of Bolivia", common: "Bolivia") },
                { "aym", new CountryName(official: "Wuliwya Suyu", common: "Wuliwya") },
                { "grn", new CountryName(official: "Tetã Volívia", common: "Volívia") },
                { "que", new CountryName(official: "Buliwya Mamallaqta", common: "Buliwya") },
                { "spa", new CountryName(official: "Estado Plurinacional de Bolivia", common: "Bolivia") },
                { "ara", new CountryName(official: "دولة بوليفيا المتعددة القوميات", common: "بوليفيا") },
                { "ces", new CountryName(official: "Mnohonárodnostní stát Bolívie", common: "Bolívie") },
                { "cym", new CountryName(official: "Gweriniaeth Bolifia", common: "Bolifia") },
                { "deu", new CountryName(official: "Plurinationaler Staat Bolivien", common: "Bolivien") },
                { "est", new CountryName(official: "Boliivia Paljurahvuseline Riik", common: "Boliivia") },
                { "fin", new CountryName(official: "Bolivian monikansainen valtio", common: "Bolivia") },
                { "fra", new CountryName(official: "État plurinational de Bolivie", common: "Bolivie") },
                { "hrv", new CountryName(official: "Plurinational State of Bolivia", common: "Bolivija") },
                { "hun", new CountryName(official: "Bolíviai Többnemzetiségű Állam", common: "Bolívia") },
                { "ita", new CountryName(official: "Stato Plurinazionale della Bolivia", common: "Bolivia") },
                { "jpn", new CountryName(official: "ボリビアの多民族国", common: "ボリビア多民族国") },
                { "kor", new CountryName(official: "볼리비아 다민족국", common: "볼리비아") },
                { "nld", new CountryName(official: "Plurinationale Staat van Bolivia", common: "Bolivia") },
                { "per", new CountryName(official: "جمهوری بولیوی", common: "بولیوی") },
                { "pol", new CountryName(official: "Wielonarodowe Państwo Boliwia", common: "Boliwia") },
                { "por", new CountryName(official: "Estado Plurinacional da Bolívia", common: "Bolívia") },
                { "rus", new CountryName(official: "Многонациональное Государство Боливия", common: "Боливия") },
                { "slk", new CountryName(official: "Bolívijská republika", common: "Bolívia") },
                { "swe", new CountryName(official: "Mångnationella staten Bolivia", common: "Bolivia") },
                { "urd", new CountryName(official: "جمہوریہ بولیویا", common: "بولیویا") },
                { "zho", new CountryName(official: "多民族玻利维亚国", common: "玻利维亚") },

            },
            cca2: "BO",
            cca3: "BOL",
            ccn3: "068",
            cioc: "BOL",
            flag: "🇧🇴",
            region: Region.Americas,
            subregion: "South America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"91", }),
            borders: new string[] { "ARG", "BRA", "CHL", "PRY", "PER",  },
            capital: new string[] { "Sucre",  },
            altSpellings: new string[] { "BO", "Buliwya", "Wuliwya", "Bolivia, Plurinational State of", "Plurinational State of Bolivia", "Estado Plurinacional de Bolivia", "Buliwya Mamallaqta", "Wuliwya Suyu", "Tetã Volívia",  },
            tld: new string[] { ".bo",  },
            latlng: new double[] { -17, -65,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "Aymara", iso6391: "", iso6392: "aym"),
                new Language(name: "Guaraní", iso6391: "gn", iso6392: "grn"),
                new Language(name: "Quechua", iso6391: "quz", iso6392: "que"),
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "BOB", name: "Bolivian boliviano", symbol: "Bs."),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Bolivian", female: "Bolivian") },
                { "fra", new DemonymsGender(male: "Bolivian", female: "Bolivian") },
            }
        );

        /// <summary>
        /// create an instance of Bolivia country
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
        private Bolivia(
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
