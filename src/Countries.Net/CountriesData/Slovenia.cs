namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Slovenia country
    /// </summary>
    public class Slovenia : Country
    {
        /// <summary>
        /// get the Slovenia country instance
        /// </summary>
        public static Slovenia Instance = new Slovenia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Slovenia", common: "Slovenia") },
                { "slv", new CountryName(official: "Republika Slovenija", common: "Slovenija") },
                { "ara", new CountryName(official: "جمهورية سلوفينيا", common: "سلوفينيا") },
                { "ces", new CountryName(official: "Slovinská republika", common: "Slovinsko") },
                { "cym", new CountryName(official: "Republic of Slovenia", common: "Slovenia") },
                { "deu", new CountryName(official: "Republik Slowenien", common: "Slowenien") },
                { "est", new CountryName(official: "Sloveenia Vabariik", common: "Sloveenia") },
                { "fin", new CountryName(official: "Slovenian tasavalta", common: "Slovenia") },
                { "fra", new CountryName(official: "République de Slovénie", common: "Slovénie") },
                { "hrv", new CountryName(official: "Republika Slovenija", common: "Slovenija") },
                { "hun", new CountryName(official: "Szlovén Köztársaság", common: "Szlovénia") },
                { "ita", new CountryName(official: "Repubblica di Slovenia", common: "Slovenia") },
                { "jpn", new CountryName(official: "スロベニア共和国", common: "スロベニア") },
                { "kor", new CountryName(official: "슬로베니아 공화국", common: "슬로베니아") },
                { "nld", new CountryName(official: "Republiek Slovenië", common: "Slovenië") },
                { "per", new CountryName(official: "جمهوری اسلوونی", common: "اسلوونی") },
                { "pol", new CountryName(official: "Republika Słowenii", common: "Słowenia") },
                { "por", new CountryName(official: "República da Eslovénia", common: "Eslovénia") },
                { "rus", new CountryName(official: "Республика Словения", common: "Словения") },
                { "slk", new CountryName(official: "Slovinská republika", common: "Slovinsko") },
                { "spa", new CountryName(official: "República de Eslovenia", common: "Eslovenia") },
                { "swe", new CountryName(official: "Republiken Slovenien", common: "Slovenien") },
                { "urd", new CountryName(official: "جمہوریہ سلووینیا", common: "سلووینیا") },
                { "zho", new CountryName(official: "斯洛文尼亚共和国", common: "斯洛文尼亚") },
            },
            cca2: "SI",
            cca3: "SVN",
            ccn3: "705",
            cioc: "SLO",
            flag: "🇸🇮",
            region: Region.Europe,
            subregion: "Central Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"86", }),
            borders: new string[] { "AUT", "HRV", "ITA", "HUN",  },
            capital: new string[] { "Ljubljana",  },
            altSpellings: new string[] { "SI", "Republic of Slovenia", "Republika Slovenija",  },
            tld: new string[] { ".si",  },
            latlng: new double[] { 46.11666666, 14.81666666,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Slovene", iso6391: "sl", iso6392: "slv"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Slovene", female: "Slovene") },
                { "fra", new DemonymsGender(male: "Slovene", female: "Slovene") },
            }
        );

        /// <summary>
        /// create an instance of Slovenia country
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
        private Slovenia(
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
