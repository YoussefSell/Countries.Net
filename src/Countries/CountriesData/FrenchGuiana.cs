namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of FrenchGuiana country
    /// </summary>
    public class FrenchGuiana : Country
    {
        /// <summary>
        /// get the FrenchGuiana country instance
        /// </summary>
        public static FrenchGuiana Instance = new FrenchGuiana(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Guiana", common: "French Guiana") },
                { "fra", new CountryName(official: "Guyane", common: "Guyane française") },
                { "ara", new CountryName(official: "غويانا الفرنسية", common: "غويانا") },
                { "ces", new CountryName(official: "Francouzská Guyana", common: "Francouzská Guyana") },
                { "cym", new CountryName(official: "Guiana", common: "French Guiana") },
                { "deu", new CountryName(official: "Französisch-Guayana", common: "Französisch-Guayana") },
                { "est", new CountryName(official: "Guajaana departemang", common: "Prantsuse Guajaana") },
                { "fin", new CountryName(official: "Ranskan Guayana", common: "Ranskan Guayana") },
                { "hrv", new CountryName(official: "Gijana", common: "Francuska Gvajana") },
                { "hun", new CountryName(official: "Francia Guyana", common: "Francia Guyana") },
                { "ita", new CountryName(official: "Guiana", common: "Guyana francese") },
                { "jpn", new CountryName(official: "ギアナ", common: "フランス領ギアナ") },
                { "kor", new CountryName(official: "프랑스령 기아나", common: "프랑스령 기아나") },
                { "nld", new CountryName(official: "Guyana", common: "Frans-Guyana") },
                { "per", new CountryName(official: "گویان فرانسه", common: "گویان فرانسه") },
                { "pol", new CountryName(official: "Gujana Francuska", common: "Gujana Francuska") },
                { "por", new CountryName(official: "Guiana", common: "Guiana Francesa") },
                { "rus", new CountryName(official: "Гвиана", common: "Французская Гвиана") },
                { "slk", new CountryName(official: "Francúzska Guyana", common: "Guyana") },
                { "spa", new CountryName(official: "Guayana", common: "Guayana Francesa") },
                { "swe", new CountryName(official: "Franska Guyana", common: "Franska Guyana") },
                { "urd", new CountryName(official: "گیانا", common: "فرانسیسی گیانا") },
                { "zho", new CountryName(official: "法属圭亚那", common: "法属圭亚那") },

            },
            cca2: "GF",
            cca3: "GUF",
            ccn3: "254",
            cioc: "",
            flag: "🇬🇫",
            region: Region.Americas,
            subregion: "South America",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"94", }),
            borders: new string[] { "BRA", "SUR",  },
            capital: new string[] { "Cayenne",  },
            altSpellings: new string[] { "GF", "Guiana", "Guyane",  },
            tld: new string[] { ".gf",  },
            latlng: new double[] { 4, -53,  },
            timezones: new string[] { "UTC-03:00",  },
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
                { "eng", new DemonymsGender(male: "Guianan", female: "Guianan") },
                { "fra", new DemonymsGender(male: "Guianan", female: "Guianan") },
            }
        );

        /// <summary>
        /// create an instance of FrenchGuiana country
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
        private FrenchGuiana(
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
