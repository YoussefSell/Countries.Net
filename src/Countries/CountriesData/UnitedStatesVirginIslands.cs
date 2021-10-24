namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of UnitedStatesVirginIslands country
    /// </summary>
    public class UnitedStatesVirginIslands : Country
    {
        /// <summary>
        /// get the UnitedStatesVirginIslands country instance
        /// </summary>
        public static UnitedStatesVirginIslands Instance = new UnitedStatesVirginIslands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Virgin Islands of the United States", common: "United States Virgin Islands") },
                { "ara", new CountryName(official: "جزر العذراء الامريكية", common: "جزر العذراء الامريكية") },
                { "ces", new CountryName(official: "Americké Panenské ostrovy", common: "Americké Panenské ostrovy") },
                { "cym", new CountryName(official: "Virgin Islands of the United States", common: "United States Virgin Islands") },
                { "deu", new CountryName(official: "Amerikanische Jungferninseln", common: "Amerikanische Jungferninseln") },
                { "est", new CountryName(official: "Ühendriikide Neitsisaared", common: "Neitsisaared, USA") },
                { "fin", new CountryName(official: "Yhdysvaltain Neitsytsaaret", common: "Neitsytsaaret") },
                { "fra", new CountryName(official: "Îles Vierges des États-Unis", common: "Îles Vierges des États-Unis") },
                { "hrv", new CountryName(official: "Djevičanski Otoci SAD", common: "Američki Djevičanski Otoci") },
                { "hun", new CountryName(official: "Amerikai Virgin-szigetek", common: "Amerikai Virgin-szigetek") },
                { "ita", new CountryName(official: "Isole Vergini degli Stati Uniti", common: "Isole Vergini americane") },
                { "jpn", new CountryName(official: "米国のバージン諸島", common: "アメリカ領ヴァージン諸島") },
                { "kor", new CountryName(official: "미국령 버진아일랜드", common: "미국령 버진아일랜드") },
                { "nld", new CountryName(official: "Maagdeneilanden van de Verenigde Staten", common: "Amerikaanse Maagdeneilanden") },
                { "per", new CountryName(official: "جزایر ویرجین ایالات متحده آمریکا", common: "جزایر ویرجین ایالات متحده آمریکا") },
                { "pol", new CountryName(official: "Wyspy Dziewicze Stanów Zjednoczonych", common: "Wyspy Dziewicze Stanów Zjednoczonych") },
                { "por", new CountryName(official: "Ilhas Virgens dos Estados Unidos", common: "Ilhas Virgens dos Estados Unidos") },
                { "rus", new CountryName(official: "Виргинские острова Соединенных Штатов", common: "Виргинские Острова") },
                { "slk", new CountryName(official: "Americké Panenské ostrovy", common: "Americké Panenské ostrovy") },
                { "spa", new CountryName(official: "Islas Vírgenes de los Estados Unidos", common: "Islas Vírgenes de los Estados Unidos") },
                { "swe", new CountryName(official: "Amerikanska Jungfruöarna", common: "Amerikanska Jungfruöarna") },
                { "urd", new CountryName(official: "امریکی جزائر ورجن", common: "امریکی جزائر ورجن") },
                { "zho", new CountryName(official: "美属维尔京群岛", common: "美属维尔京群岛") },
            },
            cca2: "VI",
            cca3: "VIR",
            ccn3: "850",
            cioc: "ISV",
            flag: "🇻🇮",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"340", }),
            borders: new string[] {  },
            capital: new string[] { "Charlotte Amalie",  },
            altSpellings: new string[] { "VI", "Virgin Islands, U.S.",  },
            tld: new string[] { ".vi",  },
            latlng: new double[] { 18.35, -64.933333,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "USD", name: "United States dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Virgin Islander", female: "Virgin Islander") },
                { "fra", new DemonymsGender(male: "Virgin Islander", female: "Virgin Islander") },
            }
        );

        /// <summary>
        /// create an instance of UnitedStatesVirginIslands country
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
        private UnitedStatesVirginIslands(
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
