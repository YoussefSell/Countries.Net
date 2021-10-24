namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Guyana country
    /// </summary>
    public class Guyana : Country
    {
        /// <summary>
        /// get the Guyana country instance
        /// </summary>
        public static Guyana Instance = new Guyana(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Co-operative Republic of Guyana", common: "Guyana") },
                { "ara", new CountryName(official: "جمهورية غيانا التعاونية", common: "غيانا") },
                { "ces", new CountryName(official: "Kooperativní republika Guyana", common: "Guyana") },
                { "cym", new CountryName(official: "Co-operative Republic of Guyana", common: "Guyana") },
                { "deu", new CountryName(official: "Kooperative Republik Guyana", common: "Guyana") },
                { "est", new CountryName(official: "Guyana Vabariik", common: "Guyana") },
                { "fin", new CountryName(official: "Guayanan osuustoiminnallinen tasavalta", common: "Guayana") },
                { "fra", new CountryName(official: "République coopérative de Guyana", common: "Guyana") },
                { "hrv", new CountryName(official: "Zadruga Republika Gvajana", common: "Gvajana") },
                { "hun", new CountryName(official: "Guyanai Szövetkezeti Köztársaság", common: "Guyana") },
                { "ita", new CountryName(official: "Co -operative Republic of Guyana", common: "Guyana") },
                { "jpn", new CountryName(official: "ガイアナの協同共和国", common: "ガイアナ") },
                { "kor", new CountryName(official: "가이아나 협동 공화국", common: "가이아나") },
                { "nld", new CountryName(official: "Coöperatieve Republiek Guyana", common: "Guyana") },
                { "per", new CountryName(official: "جمهوری تعاونی گویان", common: "گویان") },
                { "pol", new CountryName(official: "Kooperacyjna Republika Gujany", common: "Gujana") },
                { "por", new CountryName(official: "Co -operative República da Guiana", common: "Guiana") },
                { "rus", new CountryName(official: "Кооперативная Республика Гайана", common: "Гайана") },
                { "slk", new CountryName(official: "Guyanská kooperatívna republika", common: "Guyana") },
                { "spa", new CountryName(official: "República Cooperativa de Guyana", common: "Guyana") },
                { "swe", new CountryName(official: "Kooperativa republiken Guyana", common: "Guyana") },
                { "urd", new CountryName(official: "تعاونی جمہوریہ گیانا", common: "گیانا") },
                { "zho", new CountryName(official: "圭亚那共和国", common: "圭亚那") },
            },
            cca2: "GY",
            cca3: "GUY",
            ccn3: "328",
            cioc: "GUY",
            flag: "🇬🇾",
            region: Region.Americas,
            subregion: "South America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"92", }),
            borders: new string[] { "BRA", "SUR", "VEN",  },
            capital: new string[] { "Georgetown",  },
            altSpellings: new string[] { "GY", "Co-operative Republic of Guyana",  },
            tld: new string[] { ".gy",  },
            latlng: new double[] { 5, -59,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "GYD", name: "Guyanese dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Guyanese", female: "Guyanese") },
                { "fra", new DemonymsGender(male: "Guyanese", female: "Guyanese") },
            }
        );

        /// <summary>
        /// create an instance of Guyana country
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
        private Guyana(
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
