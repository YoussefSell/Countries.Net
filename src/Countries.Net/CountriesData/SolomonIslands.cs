namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of SolomonIslands country
    /// </summary>
    public class SolomonIslands : Country
    {
        /// <summary>
        /// get the SolomonIslands country instance
        /// </summary>
        public static SolomonIslands Instance = new SolomonIslands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Solomon Islands", common: "Solomon Islands") },
                { "ara", new CountryName(official: "جزر سليمان", common: "جزر سليمان") },
                { "ces", new CountryName(official: "Šalamounovy ostrovy", common: "Šalamounovy ostrovy") },
                { "cym", new CountryName(official: "Solomon Islands", common: "Solomon Islands") },
                { "deu", new CountryName(official: "Salomonen", common: "Salomonen") },
                { "est", new CountryName(official: "Saalomoni Saared", common: "Saalomoni Saared") },
                { "fin", new CountryName(official: "Salomonsaaret", common: "Salomonsaaret") },
                { "fra", new CountryName(official: "Îles Salomon", common: "Îles Salomon") },
                { "hrv", new CountryName(official: "Solomonski Otoci", common: "Solomonski Otoci") },
                { "hun", new CountryName(official: "Salamon-szigetek", common: "Salamon-szigetek") },
                { "ita", new CountryName(official: "Isole Salomone", common: "Isole Salomone") },
                { "jpn", new CountryName(official: "ソロモン諸島", common: "ソロモン諸島") },
                { "kor", new CountryName(official: "솔로몬 제도", common: "솔로몬 제도") },
                { "nld", new CountryName(official: "Solomon eilanden", common: "Salomonseilanden") },
                { "per", new CountryName(official: "جزایر سلیمان", common: "جزایر سلیمان") },
                { "pol", new CountryName(official: "Wyspy Salomona", common: "Wyspy Salomona") },
                { "por", new CountryName(official: "Ilhas Salomão", common: "Ilhas Salomão") },
                { "rus", new CountryName(official: "Соломоновы острова", common: "Соломоновы Острова") },
                { "slk", new CountryName(official: "Salomonove ostrovy", common: "Salomonove ostrovy") },
                { "spa", new CountryName(official: "islas Salomón", common: "Islas Salomón") },
                { "swe", new CountryName(official: "Salomonöarna", common: "Salomonöarna") },
                { "urd", new CountryName(official: "جزائر سلیمان", common: "جزائر سلیمان") },
                { "zho", new CountryName(official: "所罗门群岛", common: "所罗门群岛") },
            },
            cca2: "SB",
            cca3: "SLB",
            ccn3: "090",
            cioc: "SOL",
            flag: "🇸🇧",
            region: Region.Oceania,
            subregion: "Melanesia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"77", }),
            borders: new string[] {  },
            capital: new string[] { "Honiara",  },
            altSpellings: new string[] { "SB",  },
            tld: new string[] { ".sb",  },
            latlng: new double[] { -8, 159,  },
            timezones: new string[] { "UTC+11:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "SBD", name: "Solomon Islands dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Solomon Islander", female: "Solomon Islander") },
                { "fra", new DemonymsGender(male: "Solomon Islander", female: "Solomon Islander") },
            }
        );

        /// <summary>
        /// create an instance of SolomonIslands country
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
        private SolomonIslands(
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
