namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Norway country
    /// </summary>
    public class Norway : Country
    {
        /// <summary>
        /// get the Norway country instance
        /// </summary>
        public static Norway Instance = new Norway(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Kingdom of Norway", common: "Norway") },
                { "nno", new CountryName(official: "Kongeriket Noreg", common: "Noreg") },
                { "nob", new CountryName(official: "Kongeriket Norge", common: "Norge") },
                { "smi", new CountryName(official: "Norgga gonagasriika", common: "Norgga") },
                { "ara", new CountryName(official: "مملكة النرويج", common: "النرويج") },
                { "ces", new CountryName(official: "Norské království", common: "Norsko") },
                { "cym", new CountryName(official: "Kingdom of Norway", common: "Norway") },
                { "deu", new CountryName(official: "Königreich Norwegen", common: "Norwegen") },
                { "est", new CountryName(official: "Norra Kuningriik", common: "Norra") },
                { "fin", new CountryName(official: "Norjan kuningaskunta", common: "Norja") },
                { "fra", new CountryName(official: "Royaume de Norvège", common: "Norvège") },
                { "hrv", new CountryName(official: "Kraljevina Norveška", common: "Norveška") },
                { "hun", new CountryName(official: "Norvég Királyság", common: "Norvégia") },
                { "ita", new CountryName(official: "Regno di Norvegia", common: "Norvegia") },
                { "jpn", new CountryName(official: "ノルウェー王国", common: "ノルウェー") },
                { "kor", new CountryName(official: "노르웨이 왕국", common: "노르웨이") },
                { "nld", new CountryName(official: "Koninkrijk Noorwegen", common: "Noorwegen") },
                { "per", new CountryName(official: "پادشاهی نروژ", common: "نروژ") },
                { "pol", new CountryName(official: "Królestwo Norwegii", common: "Norwegia") },
                { "por", new CountryName(official: "Reino da Noruega", common: "Noruega") },
                { "rus", new CountryName(official: "Королевство Норвегия", common: "Норвегия") },
                { "slk", new CountryName(official: "Nórske kráľovstvo", common: "Nórsko") },
                { "spa", new CountryName(official: "Reino de Noruega", common: "Noruega") },
                { "swe", new CountryName(official: "Konungariket Norge", common: "Norge") },
                { "urd", new CountryName(official: "مملکتِ ناروے", common: "ناروے") },
                { "zho", new CountryName(official: "挪威王国", common: "挪威") },
            },
            cca2: "NO",
            cca3: "NOR",
            ccn3: "578",
            cioc: "NOR",
            flag: "🇳🇴",
            region: Region.Europe,
            subregion: "Northern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"7", }),
            borders: new string[] { "FIN", "SWE", "RUS",  },
            capital: new string[] { "Oslo",  },
            altSpellings: new string[] { "NO", "Norge", "Noreg", "Kingdom of Norway", "Kongeriket Norge", "Kongeriket Noreg",  },
            tld: new string[] { ".no",  },
            latlng: new double[] { 62, 10,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Norwegian Nynorsk", iso6391: "nn", iso6392: "nno"),
                new Language(name: "Norwegian Bokmål", iso6391: "nb", iso6392: "nob"),
                new Language(name: "Sami", iso6391: "", iso6392: "smi"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "NOK", name: "Norwegian krone", symbol: "kr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Norwegian", female: "Norwegian") },
                { "fra", new DemonymsGender(male: "Norwegian", female: "Norwegian") },
            }
        );

        /// <summary>
        /// create an instance of Norway country
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
        private Norway(
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
