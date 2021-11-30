namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of NewZealand country
    /// </summary>
    public class NewZealand : Country
    {
        /// <summary>
        /// get the NewZealand country instance
        /// </summary>
        public static NewZealand Instance = new NewZealand(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "New Zealand", common: "New Zealand") },
                { "mri", new CountryName(official: "Aotearoa", common: "Aotearoa") },
                { "nzs", new CountryName(official: "New Zealand", common: "New Zealand") },
                { "ara", new CountryName(official: "نيوزيلندا", common: "نيوزيلندا") },
                { "ces", new CountryName(official: "Nový Zéland", common: "Nový Zéland") },
                { "cym", new CountryName(official: "New Zealand", common: "New Zealand") },
                { "deu", new CountryName(official: "Neuseeland", common: "Neuseeland") },
                { "est", new CountryName(official: "Uus-Meremaa", common: "Uus-Meremaa") },
                { "fin", new CountryName(official: "Uusi-Seelanti", common: "Uusi-Seelanti") },
                { "fra", new CountryName(official: "Nouvelle-Zélande", common: "Nouvelle-Zélande") },
                { "hrv", new CountryName(official: "Novi Zeland", common: "Novi Zeland") },
                { "hun", new CountryName(official: "Új-Zéland", common: "Új-Zéland") },
                { "ita", new CountryName(official: "Nuova Zelanda", common: "Nuova Zelanda") },
                { "jpn", new CountryName(official: "ニュージーランド", common: "ニュージーランド") },
                { "kor", new CountryName(official: "뉴질랜드", common: "뉴질랜드") },
                { "nld", new CountryName(official: "Nieuw Zeeland", common: "Nieuw-Zeeland") },
                { "per", new CountryName(official: "نیوزیلند", common: "نیوزیلند") },
                { "pol", new CountryName(official: "Nowa Zelandia", common: "Nowa Zelandia") },
                { "por", new CountryName(official: "nova Zelândia", common: "Nova Zelândia") },
                { "rus", new CountryName(official: "Новая Зеландия", common: "Новая Зеландия") },
                { "slk", new CountryName(official: "Nový Zéland", common: "Nový Zéland") },
                { "spa", new CountryName(official: "nueva Zelanda", common: "Nueva Zelanda") },
                { "swe", new CountryName(official: "Nya Zeeland", common: "Nya Zeeland") },
                { "urd", new CountryName(official: "نیوزی لینڈ", common: "نیوزی لینڈ") },
                { "zho", new CountryName(official: "新西兰", common: "新西兰") },
            },
            cca2: "NZ",
            cca3: "NZL",
            ccn3: "554",
            cioc: "NZL",
            flag: "🇳🇿",
            region: Region.Oceania,
            subregion: "Australia and New Zealand",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"4", }),
            borders: new string[] {  },
            capital: new string[] { "Wellington",  },
            altSpellings: new string[] { "NZ", "Aotearoa",  },
            tld: new string[] { ".nz",  },
            latlng: new double[] { -41, 174,  },
            timezones: new string[] { "UTC-11:00", "UTC-10:00", "UTC+12:00", "UTC+12:45", "UTC+13:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Māori", iso6391: "mi", iso6392: "mri"),
                new Language(name: "New Zealand Sign Language", iso6391: "", iso6392: "nzs"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "NZD", name: "New Zealand dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "New Zealander", female: "New Zealander") },
                { "fra", new DemonymsGender(male: "New Zealander", female: "New Zealander") },
            }
        );

        /// <summary>
        /// create an instance of NewZealand country
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
        private NewZealand(
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
