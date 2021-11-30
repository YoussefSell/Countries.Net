namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of TrinidadandTobago country
    /// </summary>
    public class TrinidadandTobago : Country
    {
        /// <summary>
        /// get the TrinidadandTobago country instance
        /// </summary>
        public static TrinidadandTobago Instance = new TrinidadandTobago(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Trinidad and Tobago", common: "Trinidad and Tobago") },
                { "ara", new CountryName(official: "جمهورية ترينيداد وتوباغو", common: "ترينيداد وتوباغو") },
                { "ces", new CountryName(official: "Republika Trinidad a Tobago", common: "Trinidad a Tobago") },
                { "cym", new CountryName(official: "Republic of Trinidad and Tobago", common: "Trinidad and Tobago") },
                { "deu", new CountryName(official: "Republik Trinidad und Tobago", common: "Trinidad und Tobago") },
                { "est", new CountryName(official: "Trinidadi ja Tobago Vabariik", common: "Trinidad ja Tobago") },
                { "fin", new CountryName(official: "Trinidadin ja Tobagon tasavalta", common: "Trinidad ja Tobago") },
                { "fra", new CountryName(official: "République de Trinité-et-Tobago", common: "Trinité-et-Tobago") },
                { "hrv", new CountryName(official: "Republika Trinidad i Tobago", common: "Trinidad i Tobago") },
                { "hun", new CountryName(official: "Trinidad és Tobago Köztársaság", common: "Trinidad és Tobago") },
                { "ita", new CountryName(official: "Repubblica di Trinidad e Tobago", common: "Trinidad e Tobago") },
                { "jpn", new CountryName(official: "トリニダード·トバゴ共和国", common: "トリニダード・トバゴ") },
                { "kor", new CountryName(official: "트리니다드 토바고 공화국", common: "트리니다드 토바고") },
                { "nld", new CountryName(official: "Republiek Trinidad en Tobago", common: "Trinidad en Tobago") },
                { "per", new CountryName(official: "جمهوری ترینیداد و توباگو", common: "ترینیداد و توباگو") },
                { "pol", new CountryName(official: "Trynidad i Tobago", common: "Trynidad i Tobago") },
                { "por", new CountryName(official: "República de Trinidad e Tobago", common: "Trinidade e Tobago") },
                { "rus", new CountryName(official: "Республика Тринидад и Тобаго", common: "Тринидад и Тобаго") },
                { "slk", new CountryName(official: "Republika Trinidad a Tobaga", common: "Trinidad a Tobago") },
                { "spa", new CountryName(official: "República de Trinidad y Tobago", common: "Trinidad y Tobago") },
                { "swe", new CountryName(official: "Republiken Trinidad och Tobago", common: "Trinidad och Tobago") },
                { "urd", new CountryName(official: "جمہوریہ ٹرینیڈاڈ و ٹوباگو", common: "ٹرینیڈاڈ و ٹوباگو") },
                { "zho", new CountryName(official: "特立尼达和多巴哥共和国", common: "特立尼达和多巴哥") },
            },
            cca2: "TT",
            cca3: "TTO",
            ccn3: "780",
            cioc: "TTO",
            flag: "🇹🇹",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"868", }),
            borders: new string[] {  },
            capital: new string[] { "Port of Spain",  },
            altSpellings: new string[] { "TT", "Republic of Trinidad and Tobago",  },
            tld: new string[] { ".tt",  },
            latlng: new double[] { 11, -61,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "TTD", name: "Trinidad and Tobago dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Trinidadian", female: "Trinidadian") },
                { "fra", new DemonymsGender(male: "Trinidadian", female: "Trinidadian") },
            }
        );

        /// <summary>
        /// create an instance of TrinidadandTobago country
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
        private TrinidadandTobago(
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
