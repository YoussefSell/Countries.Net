namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of NorthernMarianaIslands country
    /// </summary>
    public class NorthernMarianaIslands : Country
    {
        /// <summary>
        /// get the NorthernMarianaIslands country instance
        /// </summary>
        public static NorthernMarianaIslands Instance = new NorthernMarianaIslands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Commonwealth of the Northern Mariana Islands", common: "Northern Mariana Islands") },
                { "cal", new CountryName(official: "Commonwealth of the Northern Mariana Islands", common: "Northern Mariana Islands") },
                { "cha", new CountryName(official: "Sankattan Siha Na Islas Mariånas", common: "Na Islas Mariånas") },
                { "ara", new CountryName(official: "كومونولث جزر ماريانا الشمالية", common: "جزر ماريانا الشمالية") },
                { "ces", new CountryName(official: "Společenství Severních Marian", common: "Severní Mariany") },
                { "cym", new CountryName(official: "Commonwealth of the Northern Mariana Islands", common: "Northern Mariana Islands") },
                { "deu", new CountryName(official: "Commonwealth der Nördlichen Marianen", common: "Nördliche Marianen") },
                { "est", new CountryName(official: "Põhja-Mariaani Ühendus", common: "Põhja-Mariaanid") },
                { "fin", new CountryName(official: "Pohjois-Mariaanit", common: "Pohjois-Mariaanit") },
                { "fra", new CountryName(official: "Commonwealth des îles Mariannes du Nord", common: "Îles Mariannes du Nord") },
                { "hrv", new CountryName(official: "Zajednica je Sjeverni Marijanski otoci", common: "Sjevernomarijanski otoci") },
                { "hun", new CountryName(official: "Északi-Mariana-szigetek", common: "Északi-Mariana-szigetek") },
                { "ita", new CountryName(official: "Commonwealth delle Isole Marianne Settentrionali", common: "Isole Marianne Settentrionali") },
                { "jpn", new CountryName(official: "北マリアナ諸島", common: "北マリアナ諸島") },
                { "kor", new CountryName(official: "북마리아나 제도", common: "북마리아나 제도") },
                { "nld", new CountryName(official: "Commonwealth van de Noordelijke Marianen", common: "Noordelijke Marianeneilanden") },
                { "per", new CountryName(official: "جزایر ماریانای شمالی", common: "جزایر ماریانای شمالی") },
                { "pol", new CountryName(official: "Wspólnota Marianów Północnych", common: "Mariany Północne") },
                { "por", new CountryName(official: "Comunidade das Ilhas Marianas do Norte", common: "Marianas Setentrionais") },
                { "rus", new CountryName(official: "Содружество Северных Марианских островов", common: "Северные Марианские острова") },
                { "slk", new CountryName(official: "Spoločenstvo ostrovov Severné Mariány", common: "Severné Mariány") },
                { "spa", new CountryName(official: "Mancomunidad de las Islas Marianas del Norte", common: "Islas Marianas del Norte") },
                { "swe", new CountryName(official: "Nordmarianerna", common: "Nordmarianerna") },
                { "urd", new CountryName(official: "دولتِ مشترکہ جزائر شمالی ماریانا", common: "جزائر شمالی ماریانا") },
                { "zho", new CountryName(official: "北马里亚纳群岛", common: "北马里亚纳群岛") },
            },
            cca2: "MP",
            cca3: "MNP",
            ccn3: "580",
            cioc: "",
            flag: "🇲🇵",
            region: Region.Oceania,
            subregion: "Micronesia",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"670", }),
            borders: new string[] {  },
            capital: new string[] { "Saipan",  },
            altSpellings: new string[] { "MP", "Commonwealth of the Northern Mariana Islands", "Sankattan Siha Na Islas Mariånas",  },
            tld: new string[] { ".mp",  },
            latlng: new double[] { 15.2, 145.75,  },
            timezones: new string[] { "UTC+10:00",  },
            languages: new Language[]
            {
                new Language(name: "Carolinian", iso6391: "", iso6392: "cal"),
                new Language(name: "Chamorro", iso6391: "", iso6392: "cha"),
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "USD", name: "United States dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "American", female: "American") },
                { "fra", new DemonymsGender(male: "American", female: "American") },
            }
        );

        /// <summary>
        /// create an instance of NorthernMarianaIslands country
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
        private NorthernMarianaIslands(
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
