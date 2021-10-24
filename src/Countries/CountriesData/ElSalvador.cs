namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of ElSalvador country
    /// </summary>
    public class ElSalvador : Country
    {
        /// <summary>
        /// get the ElSalvador country instance
        /// </summary>
        public static ElSalvador Instance = new ElSalvador(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of El Salvador", common: "El Salvador") },
                { "spa", new CountryName(official: "República de El Salvador", common: "El Salvador") },
                { "ara", new CountryName(official: "جمهورية السلفادور", common: "السلفادور") },
                { "ces", new CountryName(official: "Salvadorská republika", common: "Salvador") },
                { "cym", new CountryName(official: "Gweriniaeth El Salfador", common: "El Salfador") },
                { "deu", new CountryName(official: "Republik El Salvador", common: "El Salvador") },
                { "est", new CountryName(official: "El Salvadori Vabariik", common: "El Salvador") },
                { "fin", new CountryName(official: "El Salvadorin tasavalta", common: "El Salvador") },
                { "fra", new CountryName(official: "République du Salvador", common: "Salvador") },
                { "hrv", new CountryName(official: "Republika El Salvador", common: "Salvador") },
                { "hun", new CountryName(official: "Salvadori Köztársaság", common: "Salvador") },
                { "ita", new CountryName(official: "Repubblica di El Salvador", common: "El Salvador") },
                { "jpn", new CountryName(official: "エルサルバドル共和国", common: "エルサルバドル") },
                { "kor", new CountryName(official: "엘살바도르 공화국", common: "엘살바도르") },
                { "nld", new CountryName(official: "Republiek El Salvador", common: "El Salvador") },
                { "per", new CountryName(official: "جمهوری السالوادور", common: "السالوادور") },
                { "pol", new CountryName(official: "Republika Salwadoru", common: "Salwador") },
                { "por", new CountryName(official: "República de El Salvador", common: "El Salvador") },
                { "rus", new CountryName(official: "Республика Эль-Сальвадор", common: "Сальвадор") },
                { "slk", new CountryName(official: "Salvádorská republika", common: "Salvádor") },
                { "swe", new CountryName(official: "Republiken El Salvador", common: "El Salvador") },
                { "urd", new CountryName(official: "جمہوریہ ایل سیلواڈور", common: "ایل سیلواڈور") },
                { "zho", new CountryName(official: "萨尔瓦多共和国", common: "萨尔瓦多") },

            },
            cca2: "SV",
            cca3: "SLV",
            ccn3: "222",
            cioc: "ESA",
            flag: "🇸🇻",
            region: Region.Americas,
            subregion: "Central America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"03", }),
            borders: new string[] { "GTM", "HND",  },
            capital: new string[] { "San Salvador",  },
            altSpellings: new string[] { "SV", "Republic of El Salvador", "República de El Salvador",  },
            tld: new string[] { ".sv",  },
            latlng: new double[] { 13.83333333, -88.91666666,  },
            timezones: new string[] { "UTC-06:00",  },
            languages: new Language[]
            {
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "USD", name: "United States dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Salvadoran", female: "Salvadoran") },
                { "fra", new DemonymsGender(male: "Salvadoran", female: "Salvadoran") },
            }
        );

        /// <summary>
        /// create an instance of ElSalvador country
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
        private ElSalvador(
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
