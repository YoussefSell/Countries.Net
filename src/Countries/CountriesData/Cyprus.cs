namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Cyprus country
    /// </summary>
    public class Cyprus : Country
    {
        /// <summary>
        /// get the Cyprus country instance
        /// </summary>
        public static Cyprus Instance = new Cyprus(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Cyprus", common: "Cyprus") },
                { "ell", new CountryName(official: "Δημοκρατία της Κύπρος", common: "Κύπρος") },
                { "tur", new CountryName(official: "Kıbrıs Cumhuriyeti", common: "Kıbrıs") },
                { "ara", new CountryName(official: "جمهورية قبرص", common: "قبرص") },
                { "ces", new CountryName(official: "Kyperská republika", common: "Kypr") },
                { "cym", new CountryName(official: "Gweriniaeth Cyprus", common: "Cyprus") },
                { "deu", new CountryName(official: "Republik Zypern", common: "Zypern") },
                { "est", new CountryName(official: "Küprose Vabariik", common: "Küpros") },
                { "fin", new CountryName(official: "Kyproksen tasavalta", common: "Kypros") },
                { "fra", new CountryName(official: "République de Chypre", common: "Chypre") },
                { "hrv", new CountryName(official: "Republika Cipar", common: "Cipar") },
                { "hun", new CountryName(official: "Ciprusi Köztársaság", common: "Ciprus") },
                { "ita", new CountryName(official: "Repubblica di Cipro", common: "Cipro") },
                { "jpn", new CountryName(official: "キプロス共和国", common: "キプロス") },
                { "kor", new CountryName(official: "키프로스 공화국", common: "키프로스") },
                { "nld", new CountryName(official: "Republiek Cyprus", common: "Cyprus") },
                { "per", new CountryName(official: "جمهوری قبرس", common: "قِبرِس") },
                { "pol", new CountryName(official: "Republika Cypryjska", common: "Cypr") },
                { "por", new CountryName(official: "República de Chipre", common: "Chipre") },
                { "rus", new CountryName(official: "Республика Кипр", common: "Кипр") },
                { "slk", new CountryName(official: "Cyperská republika", common: "Cyprus") },
                { "spa", new CountryName(official: "República de Chipre", common: "Chipre") },
                { "swe", new CountryName(official: "Republiken Cypern", common: "Cypern") },
                { "urd", new CountryName(official: "جمہوریہ قبرص", common: "قبرص") },
                { "zho", new CountryName(official: "塞浦路斯共和国", common: "塞浦路斯") },
            },
            cca2: "CY",
            cca3: "CYP",
            ccn3: "196",
            cioc: "CYP",
            flag: "🇨🇾",
            region: Region.Europe,
            subregion: "Southern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"57", }),
            borders: new string[] {  },
            capital: new string[] { "Nicosia",  },
            altSpellings: new string[] { "CY", "Kýpros", "Kıbrıs", "Republic of Cyprus", "Κυπριακή Δημοκρατία", "Kıbrıs Cumhuriyeti",  },
            tld: new string[] { ".cy",  },
            latlng: new double[] { 35, 33,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Greek", iso6391: "el", iso6392: "ell"),
                new Language(name: "Turkish", iso6391: "tr", iso6392: "tur"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Cypriot", female: "Cypriot") },
                { "fra", new DemonymsGender(male: "Cypriot", female: "Cypriot") },
            }
        );

        /// <summary>
        /// create an instance of Cyprus country
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
        private Cyprus(
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
