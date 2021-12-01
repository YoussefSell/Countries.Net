namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Austria country
    /// </summary>
    public class Austria : Country
    {
        /// <summary>
        /// get the Austria country instance
        /// </summary>
        public static Austria Instance = new Austria(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Austria", common: "Austria") },
                { "bar", new CountryName(official: "Republik Österreich", common: "Österreich") },
                { "ara", new CountryName(official: "جمهورية النمسا", common: "النمسا") },
                { "ces", new CountryName(official: "Rakouská republika", common: "Rakousko") },
                { "cym", new CountryName(official: "Gweriniaeth Awstria", common: "Awstria") },
                { "deu", new CountryName(official: "Republik Österreich", common: "Österreich") },
                { "est", new CountryName(official: "Austria Vabariik", common: "Austria") },
                { "fin", new CountryName(official: "Itävallan tasavalta", common: "Itävalta") },
                { "fra", new CountryName(official: "République d'Autriche", common: "Autriche") },
                { "hrv", new CountryName(official: "Republika Austrija", common: "Austrija") },
                { "hun", new CountryName(official: "Ausztria", common: "Ausztria") },
                { "ita", new CountryName(official: "Repubblica d'Austria", common: "Austria") },
                { "jpn", new CountryName(official: "オーストリア共和国", common: "オーストリア") },
                { "kor", new CountryName(official: "오스트리아 공화국", common: "오스트리아") },
                { "nld", new CountryName(official: "Republiek Oostenrijk", common: "Oostenrijk") },
                { "per", new CountryName(official: "جمهوری اتریش", common: "اتریش") },
                { "pol", new CountryName(official: "Republika Austrii", common: "Austria") },
                { "por", new CountryName(official: "República da Áustria", common: "Áustria") },
                { "rus", new CountryName(official: "Австрийская Республика", common: "Австрия") },
                { "slk", new CountryName(official: "Rakúska republika", common: "Rakúsko") },
                { "spa", new CountryName(official: "República de Austria", common: "Austria") },
                { "swe", new CountryName(official: "Republiken Österrike", common: "Österrike") },
                { "urd", new CountryName(official: "جمہوریہ آسٹریا", common: "آسٹریا") },
                { "zho", new CountryName(official: "奥地利共和国", common: "奥地利") },
            },
            cca2: "AT",
            cca3: "AUT",
            ccn3: "040",
            cioc: "AUT",
            flag: "🇦🇹",
            region: Region.Europe,
            subregion: "Central Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"3", }),
            borders: new string[] { "CZE", "DEU", "HUN", "ITA", "LIE", "SVK", "SVN", "CHE",  },
            capital: new string[] { "Vienna",  },
            altSpellings: new string[] { "AT", "Osterreich", "Oesterreich",  },
            tld: new string[] { ".at",  },
            latlng: new double[] { 47.33333333, 13.33333333,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Austro-Bavarian German", iso6391: "", iso6392: "bar"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Austrian", female: "Austrian") },
                { "fra", new DemonymsGender(male: "Austrian", female: "Austrian") },
            }
        );

        /// <summary>
        /// create an instance of Austria country
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
        private Austria(
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
