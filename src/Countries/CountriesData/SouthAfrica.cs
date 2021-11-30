namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of SouthAfrica country
    /// </summary>
    public class SouthAfrica : Country
    {
        /// <summary>
        /// get the SouthAfrica country instance
        /// </summary>
        public static SouthAfrica Instance = new SouthAfrica(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of South Africa", common: "South Africa") },
                { "afr", new CountryName(official: "Republiek van Suid-Afrika", common: "South Africa") },
                { "nbl", new CountryName(official: "IRiphabliki yeSewula Afrika", common: "Sewula Afrika") },
                { "nso", new CountryName(official: "Rephaboliki ya Afrika-Borwa ", common: "Afrika-Borwa") },
                { "sot", new CountryName(official: "Rephaboliki ya Afrika Borwa", common: "Afrika Borwa") },
                { "ssw", new CountryName(official: "IRiphabhulikhi yeNingizimu Afrika", common: "Ningizimu Afrika") },
                { "tsn", new CountryName(official: "Rephaboliki ya Aforika Borwa", common: "Aforika Borwa") },
                { "tso", new CountryName(official: "Riphabliki ra Afrika Dzonga", common: "Afrika Dzonga") },
                { "ven", new CountryName(official: "Riphabuḽiki ya Afurika Tshipembe", common: "Afurika Tshipembe") },
                { "xho", new CountryName(official: "IRiphabliki yaseMzantsi Afrika", common: "Mzantsi Afrika") },
                { "zul", new CountryName(official: "IRiphabliki yaseNingizimu Afrika", common: "Ningizimu Afrika") },
                { "ara", new CountryName(official: "جمهورية جنوب أفريقيا", common: "جنوب أفريقيا") },
                { "ces", new CountryName(official: "Jihoafrická republika", common: "Jihoafrická republika") },
                { "cym", new CountryName(official: "Republic of South Africa", common: "South Africa") },
                { "deu", new CountryName(official: "Republik Südafrika", common: "Südafrika") },
                { "est", new CountryName(official: "Lõuna-Aafrika Vabariik", common: "Lõuna-Aafrika Vabariik") },
                { "fin", new CountryName(official: "Etelä-Afrikan tasavalta", common: "Etelä-Afrikka") },
                { "fra", new CountryName(official: "République d'Afrique du Sud", common: "Afrique du Sud") },
                { "hrv", new CountryName(official: "Južnoafrička Republika", common: "Južnoafrička Republika") },
                { "hun", new CountryName(official: "Dél-afrikai Köztársaság", common: "Dél-afrikai Köztársaság") },
                { "ita", new CountryName(official: "Repubblica del Sud Africa", common: "Sud Africa") },
                { "jpn", new CountryName(official: "南アフリカ共和国", common: "南アフリカ") },
                { "kor", new CountryName(official: "남아프리카 공화국", common: "남아프리카") },
                { "nld", new CountryName(official: "Republiek Zuid-Afrika", common: "Zuid-Afrika") },
                { "per", new CountryName(official: "جمهوری آفریقای جنوبی", common: "آفریقای جنوبی") },
                { "pol", new CountryName(official: "Republika Południowej Afryki", common: "Południowa Afryka") },
                { "por", new CountryName(official: "República da África do Sul", common: "África do Sul") },
                { "rus", new CountryName(official: "Южно-Африканская Республика", common: "Южно-Африканская Республика") },
                { "slk", new CountryName(official: "Juhoafrická republika", common: "Juhoafrická republika") },
                { "spa", new CountryName(official: "República de Sudáfrica", common: "República de Sudáfrica") },
                { "swe", new CountryName(official: "Republiken Sydafrika", common: "Sydafrika") },
                { "urd", new CountryName(official: "جمہوریہ جنوبی افریقا", common: "جنوبی افریقا") },
                { "zho", new CountryName(official: "南非共和国", common: "南非") },
            },
            cca2: "ZA",
            cca3: "ZAF",
            ccn3: "710",
            cioc: "RSA",
            flag: "🇿🇦",
            region: Region.Africa,
            subregion: "Southern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"7", }),
            borders: new string[] { "BWA", "LSO", "MOZ", "NAM", "SWZ", "ZWE",  },
            capital: new string[] { "Pretoria", "Bloemfontein", "Cape Town",  },
            altSpellings: new string[] { "ZA", "RSA", "Suid-Afrika", "Republic of South Africa",  },
            tld: new string[] { ".za",  },
            latlng: new double[] { -29, 24,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Afrikaans", iso6391: "af", iso6392: "afr"),
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Southern Ndebele", iso6391: "nr", iso6392: "nbl"),
                new Language(name: "Northern Sotho", iso6391: "nso", iso6392: "nso"),
                new Language(name: "Southern Sotho", iso6391: "st", iso6392: "sot"),
                new Language(name: "Swazi", iso6391: "ss", iso6392: "ssw"),
                new Language(name: "Tswana", iso6391: "tn", iso6392: "tsn"),
                new Language(name: "Tsonga", iso6391: "ts", iso6392: "tso"),
                new Language(name: "Venda", iso6391: "ve", iso6392: "ven"),
                new Language(name: "Xhosa", iso6391: "xh", iso6392: "xho"),
                new Language(name: "Zulu", iso6391: "zu", iso6392: "zul"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "ZAR", name: "South African rand", symbol: "R"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "South African", female: "South African") },
                { "fra", new DemonymsGender(male: "South African", female: "South African") },
            }
        );

        /// <summary>
        /// create an instance of SouthAfrica country
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
        private SouthAfrica(
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
