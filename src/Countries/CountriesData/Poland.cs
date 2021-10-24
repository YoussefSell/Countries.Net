namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Poland country
    /// </summary>
    public class Poland : Country
    {
        /// <summary>
        /// get the Poland country instance
        /// </summary>
        public static Poland Instance = new Poland(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Poland", common: "Poland") },
                { "pol", new CountryName(official: "Rzeczpospolita Polska", common: "Polska") },
                { "ara", new CountryName(official: "الجمهورية البولندية", common: "بولندا") },
                { "ces", new CountryName(official: "Polská republika", common: "Polsko") },
                { "cym", new CountryName(official: "Republic of Poland", common: "Poland") },
                { "deu", new CountryName(official: "Republik Polen", common: "Polen") },
                { "est", new CountryName(official: "Poola Vabariik", common: "Poola") },
                { "fin", new CountryName(official: "Puolan tasavalta", common: "Puola") },
                { "fra", new CountryName(official: "République de Pologne", common: "Pologne") },
                { "hrv", new CountryName(official: "Republika Poljska", common: "Poljska") },
                { "hun", new CountryName(official: "Lengyel Köztársaság", common: "Lengyelország") },
                { "ita", new CountryName(official: "Repubblica di Polonia", common: "Polonia") },
                { "jpn", new CountryName(official: "ポーランド共和国", common: "ポーランド") },
                { "kor", new CountryName(official: "폴란드 공화국", common: "폴란드") },
                { "nld", new CountryName(official: "Republiek Polen", common: "Polen") },
                { "per", new CountryName(official: "جمهوری لهستان", common: "لهستان") },
                { "por", new CountryName(official: "República da Polónia", common: "Polónia") },
                { "rus", new CountryName(official: "Республика Польша", common: "Польша") },
                { "slk", new CountryName(official: "Poľská republika", common: "Poľsko") },
                { "spa", new CountryName(official: "República de Polonia", common: "Polonia") },
                { "swe", new CountryName(official: "Republiken Polen", common: "Polen") },
                { "urd", new CountryName(official: "جمہوریہ پولینڈ", common: "پولینڈ") },
                { "zho", new CountryName(official: "波兰共和国", common: "波兰") },

            },
            cca2: "PL",
            cca3: "POL",
            ccn3: "616",
            cioc: "POL",
            flag: "🇵🇱",
            region: Region.Europe,
            subregion: "Central Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"8", }),
            borders: new string[] { "BLR", "CZE", "DEU", "LTU", "RUS", "SVK", "UKR",  },
            capital: new string[] { "Warsaw",  },
            altSpellings: new string[] { "PL", "Republic of Poland", "Rzeczpospolita Polska",  },
            tld: new string[] { ".pl",  },
            latlng: new double[] { 52, 20,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Polish", iso6391: "pl", iso6392: "pol"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "PLN", name: "Polish złoty", symbol: "zł"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Polish", female: "Polish") },
                { "fra", new DemonymsGender(male: "Polish", female: "Polish") },
            }
        );

        /// <summary>
        /// create an instance of Poland country
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
        private Poland(
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
