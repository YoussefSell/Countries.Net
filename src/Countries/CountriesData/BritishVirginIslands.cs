namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of BritishVirginIslands country
    /// </summary>
    public class BritishVirginIslands : Country
    {
        /// <summary>
        /// get the BritishVirginIslands country instance
        /// </summary>
        public static BritishVirginIslands Instance = new BritishVirginIslands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Virgin Islands", common: "British Virgin Islands") },
                { "ara", new CountryName(official: "جزر العذراء البريطانية", common: "جزر العذراء") },
                { "ces", new CountryName(official: "Britské Panenské ostrovy", common: "Britské Panenské ostrovy") },
                { "cym", new CountryName(official: "Virgin Islands", common: "British Virgin Islands") },
                { "deu", new CountryName(official: "Jungferninseln", common: "Britische Jungferninseln") },
                { "est", new CountryName(official: "Neitsisaared", common: "Briti Neitsisaared") },
                { "fin", new CountryName(official: "Brittiläiset Neitsytsaaret", common: "Neitsytsaaret") },
                { "fra", new CountryName(official: "îles Vierges", common: "Îles Vierges britanniques") },
                { "hrv", new CountryName(official: "Djevičanski Otoci", common: "Britanski Djevičanski Otoci") },
                { "hun", new CountryName(official: "Brit Virgin-szigetek", common: "Brit Virgin-szigetek") },
                { "ita", new CountryName(official: "Isole Vergini", common: "Isole Vergini Britanniche") },
                { "jpn", new CountryName(official: "バージン諸島", common: "イギリス領ヴァージン諸島") },
                { "kor", new CountryName(official: "영국령 버진아일랜드", common: "영국령 버진아일랜드") },
                { "nld", new CountryName(official: "Maagdeneilanden", common: "Britse Maagdeneilanden") },
                { "per", new CountryName(official: "جزایر ویرجین بریتانیا", common: "جزایر ویرجین بریتانیا") },
                { "pol", new CountryName(official: "Brytyjskie Wyspy Dziewicze", common: "Brytyjskie Wyspy Dziewicze") },
                { "por", new CountryName(official: "Ilhas Virgens", common: "Ilhas Virgens") },
                { "rus", new CountryName(official: "Виргинские острова", common: "Британские Виргинские острова") },
                { "slk", new CountryName(official: "Panenské ostrovy", common: "Panenské ostrovy") },
                { "spa", new CountryName(official: "Islas Vírgenes", common: "Islas Vírgenes del Reino Unido") },
                { "swe", new CountryName(official: "Brittiska Jungfruöarna", common: "Brittiska Jungfruöarna") },
                { "urd", new CountryName(official: "برطانوی جزائر ورجن", common: "برطانوی جزائر ورجن") },
                { "zho", new CountryName(official: "英属维尔京群岛", common: "英属维尔京群岛") },
            },
            cca2: "VG",
            cca3: "VGB",
            ccn3: "092",
            cioc: "IVB",
            flag: "🇻🇬",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"284", }),
            borders: new string[] {  },
            capital: new string[] { "Road Town",  },
            altSpellings: new string[] { "VG", "Virgin Islands, British",  },
            tld: new string[] { ".vg",  },
            latlng: new double[] { 18.431383, -64.62305,  },
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
        /// create an instance of BritishVirginIslands country
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
        private BritishVirginIslands(
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
