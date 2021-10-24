namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of FaroeIslands country
    /// </summary>
    public class FaroeIslands : Country
    {
        /// <summary>
        /// get the FaroeIslands country instance
        /// </summary>
        public static FaroeIslands Instance = new FaroeIslands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Faroe Islands", common: "Faroe Islands") },
                { "dan", new CountryName(official: "Færøerne", common: "Færøerne") },
                { "fao", new CountryName(official: "Føroyar", common: "Føroyar") },
                { "ara", new CountryName(official: "جزر فارو", common: "جزر فارو") },
                { "ces", new CountryName(official: "Faerské ostrovy", common: "Faerské ostrovy") },
                { "cym", new CountryName(official: "Faroe Islands", common: "Faroe Islands") },
                { "deu", new CountryName(official: "Färöer", common: "Färöer-Inseln") },
                { "est", new CountryName(official: "Fääri saared", common: "Fääri saared") },
                { "fin", new CountryName(official: "Färsaaret", common: "Färsaaret") },
                { "fra", new CountryName(official: "Îles Féroé", common: "Îles Féroé") },
                { "hrv", new CountryName(official: "Farski Otoci", common: "Farski Otoci") },
                { "hun", new CountryName(official: "Feröer", common: "Feröer") },
                { "ita", new CountryName(official: "Isole Faroe", common: "Isole Far Oer") },
                { "jpn", new CountryName(official: "フェロー諸島", common: "フェロー諸島") },
                { "kor", new CountryName(official: "페로 제도", common: "페로 제도") },
                { "nld", new CountryName(official: "Faeröer", common: "Faeröer") },
                { "per", new CountryName(official: "جزایر فاروئه", common: "جزایر فاروئه") },
                { "pol", new CountryName(official: "Wyspy Owcze", common: "Wyspy Owcze") },
                { "por", new CountryName(official: "Ilhas Faroe", common: "Ilhas Faroé") },
                { "rus", new CountryName(official: "Фарерские острова", common: "Фарерские острова") },
                { "slk", new CountryName(official: "Faerské ostrovy", common: "Faerské ostrovy") },
                { "spa", new CountryName(official: "Islas Feroe", common: "Islas Faroe") },
                { "swe", new CountryName(official: "Färöarna", common: "Färöarna") },
                { "urd", new CountryName(official: "جزائر فارو", common: "جزائر فارو") },
                { "zho", new CountryName(official: "法罗群岛", common: "法罗群岛") },
            },
            cca2: "FO",
            cca3: "FRO",
            ccn3: "234",
            cioc: "",
            flag: "🇫🇴",
            region: Region.Europe,
            subregion: "Northern Europe",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"98", }),
            borders: new string[] {  },
            capital: new string[] { "Tórshavn",  },
            altSpellings: new string[] { "FO", "Føroyar", "Færøerne",  },
            tld: new string[] { ".fo",  },
            latlng: new double[] { 62, -7,  },
            timezones: new string[] { "UTC+00:00",  },
            languages: new Language[]
            {
                new Language(name: "Danish", iso6391: "da", iso6392: "dan"),
                new Language(name: "Faroese", iso6391: "fo", iso6392: "fao"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "DKK", name: "Danish krone", symbol: "kr"),
                new Currency(code: "FOK", name: "Faroese króna", symbol: "kr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Faroese", female: "Faroese") },
                { "fra", new DemonymsGender(male: "Faroese", female: "Faroese") },
            }
        );

        /// <summary>
        /// create an instance of FaroeIslands country
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
        private FaroeIslands(
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
