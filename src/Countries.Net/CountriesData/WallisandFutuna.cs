namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of WallisandFutuna country
    /// </summary>
    public class WallisandFutuna : Country
    {
        /// <summary>
        /// get the WallisandFutuna country instance
        /// </summary>
        public static WallisandFutuna Instance = new WallisandFutuna(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Territory of the Wallis and Futuna Islands", common: "Wallis and Futuna") },
                { "fra", new CountryName(official: "Territoire des îles Wallis et Futuna", common: "Wallis et Futuna") },
                { "ara", new CountryName(official: "إقليم جزر واليس وفوتونا", common: "واليس وفوتونا") },
                { "ces", new CountryName(official: "Teritorium ostrovů Wallis a Futuna", common: "Wallis a Futuna") },
                { "cym", new CountryName(official: "Territory of the Wallis and Futuna Islands", common: "Wallis and Futuna") },
                { "deu", new CountryName(official: "Gebiet der Wallis und Futuna", common: "Wallis und Futuna") },
                { "est", new CountryName(official: "Wallise ja Futuna ala", common: "Wallis ja Futuna") },
                { "fin", new CountryName(official: "Wallisin ja Futunan yhteisö", common: "Wallis ja Futuna") },
                { "hrv", new CountryName(official: "Teritoriju Wallis i Futuna", common: "Wallis i Fortuna") },
                { "hun", new CountryName(official: "Wallis és Futuna", common: "Wallis és Futuna") },
                { "ita", new CountryName(official: "Territorio delle Isole Wallis e Futuna", common: "Wallis e Futuna") },
                { "jpn", new CountryName(official: "ウォリス·フツナ諸島の領土", common: "ウォリス・フツナ") },
                { "kor", new CountryName(official: "왈리스 퓌튀나", common: "왈리스 퓌튀나") },
                { "nld", new CountryName(official: "Grondgebied van de Wallis en Futuna", common: "Wallis en Futuna") },
                { "per", new CountryName(official: "جزایر والیس و فوتونا", common: "والیس و فوتونا") },
                { "pol", new CountryName(official: "Terytorium Wysp Wallis i Futuna", common: "Wallis i Futuna") },
                { "por", new CountryName(official: "Território das Ilhas Wallis e Futuna", common: "Wallis e Futuna") },
                { "rus", new CountryName(official: "Территория Уоллис и Футуна острова", common: "Уоллис и Футуна") },
                { "slk", new CountryName(official: "Teritórium ostrovov Wallis a Futuna", common: "Wallis a Futuna") },
                { "spa", new CountryName(official: "Territorio de las Islas Wallis y Futuna", common: "Wallis y Futuna") },
                { "swe", new CountryName(official: "Territoriet Wallis- och Futunaöarna", common: "Wallis- och Futunaöarna") },
                { "urd", new CountryName(official: "سر زمینِ والس و فتونہ جزائر", common: "والس و فتونہ") },
                { "zho", new CountryName(official: "瓦利斯和富图纳群岛", common: "瓦利斯和富图纳群岛") },

            },
            cca2: "WF",
            cca3: "WLF",
            ccn3: "876",
            cioc: "",
            flag: "🇼🇫",
            region: Region.Oceania,
            subregion: "Polynesia",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"81", }),
            borders: new string[] {  },
            capital: new string[] { "Mata-Utu",  },
            altSpellings: new string[] { "WF", "Territory of the Wallis and Futuna Islands", "Territoire des îles Wallis et Futuna",  },
            tld: new string[] { ".wf",  },
            latlng: new double[] { -13.3, -176.2,  },
            timezones: new string[] { "UTC+12:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XPF", name: "CFP franc", symbol: "₣"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Wallis and Futuna Islander", female: "Wallis and Futuna Islander") },
                { "fra", new DemonymsGender(male: "Wallis and Futuna Islander", female: "Wallis and Futuna Islander") },
            }
        );

        /// <summary>
        /// create an instance of WallisandFutuna country
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
        private WallisandFutuna(
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
