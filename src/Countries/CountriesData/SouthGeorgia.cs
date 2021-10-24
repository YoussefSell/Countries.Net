namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of SouthGeorgia country
    /// </summary>
    public class SouthGeorgia : Country
    {
        /// <summary>
        /// get the SouthGeorgia country instance
        /// </summary>
        public static SouthGeorgia Instance = new SouthGeorgia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "South Georgia and the South Sandwich Islands", common: "South Georgia") },
                { "ara", new CountryName(official: "جورجيا الجنوبية وجزر ساندوتش الجنوبية", common: "جورجيا الجنوبية") },
                { "ces", new CountryName(official: "Jižní Georgie a Jižní Sandwichovy ostrovy", common: "Jižní Georgie a Jižní Sandwichovy ostrovy") },
                { "cym", new CountryName(official: "South Georgia and the South Sandwich Islands", common: "South Georgia") },
                { "deu", new CountryName(official: "Südgeorgien und die Südlichen Sandwichinseln", common: "Südgeorgien und die Südlichen Sandwichinseln") },
                { "est", new CountryName(official: "Lõuna-Georgia ja Lõuna-Sandwichi saared", common: "Lõuna-Georgia ja Lõuna-Sandwichi saared") },
                { "fin", new CountryName(official: "Etelä-Georgia ja Eteläiset Sandwichsaaret", common: "Etelä-Georgia ja Eteläiset Sandwichsaaret") },
                { "fra", new CountryName(official: "Géorgie du Sud et les îles Sandwich du Sud", common: "Géorgie du Sud-et-les Îles Sandwich du Sud") },
                { "hrv", new CountryName(official: "Južna Džordžija i Otoci Južni Sendvič", common: "Južna Georgija i otočje Južni Sandwich") },
                { "hun", new CountryName(official: "Déli-Georgia és Déli-Sandwich-szigetek", common: "Déli-Georgia és Déli-Sandwich-szigetek") },
                { "ita", new CountryName(official: "Georgia del Sud e isole Sandwich del Sud", common: "Georgia del Sud e Isole Sandwich Meridionali") },
                { "jpn", new CountryName(official: "サウスジョージア·サウスサンドウィッチ諸島", common: "サウスジョージア・サウスサンドウィッチ諸島") },
                { "kor", new CountryName(official: "조지아", common: "조지아") },
                { "nld", new CountryName(official: "Zuid-Georgië en de Zuidelijke Sandwich-eilanden", common: "Zuid-Georgia en Zuidelijke Sandwicheilanden") },
                { "per", new CountryName(official: "جزایر جورجیای جنوبی و ساندویچ جنوبی", common: "جزایر جورجیای جنوبی و ساندویچ جنوبی") },
                { "pol", new CountryName(official: "Georgia Południowa i Sandwich Południowy", common: "Georgia Południowa i Sandwich Południowy") },
                { "por", new CountryName(official: "Geórgia do Sul e Sandwich do Sul", common: "Ilhas Geórgia do Sul e Sandwich do Sul") },
                { "rus", new CountryName(official: "Южная Георгия и Южные Сандвичевы острова", common: "Южная Георгия и Южные Сандвичевы острова") },
                { "slk", new CountryName(official: "Južná Georgia a Južné Sandwichove ostrovy", common: "Južná Georgia a Južné Sandwichove ostrovy") },
                { "spa", new CountryName(official: "Georgia del Sur y las Islas Sandwich del Sur", common: "Islas Georgias del Sur y Sandwich del Sur") },
                { "swe", new CountryName(official: "Sydgeorgien", common: "Sydgeorgien") },
                { "urd", new CountryName(official: "جنوبی جارجیا و جزائر جنوبی سینڈوچ", common: "جنوبی جارجیا") },
                { "zho", new CountryName(official: "南乔治亚岛和南桑威奇群岛", common: "南乔治亚") },
            },
            cca2: "GS",
            cca3: "SGS",
            ccn3: "239",
            cioc: "",
            flag: "🇬🇸",
            region: Region.Antarctic,
            subregion: "",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"00", }),
            borders: new string[] {  },
            capital: new string[] { "King Edward Point",  },
            altSpellings: new string[] { "GS", "South Georgia and the South Sandwich Islands",  },
            tld: new string[] { ".gs",  },
            latlng: new double[] { -54.5, -37,  },
            timezones: new string[] { "UTC-02:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "SHP", name: "Saint Helena pound", symbol: "£"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "South Georgian South Sandwich Islander", female: "South Georgian South Sandwich Islander") },
                { "fra", new DemonymsGender(male: "South Georgian South Sandwich Islander", female: "South Georgian South Sandwich Islander") },
            }
        );

        /// <summary>
        /// create an instance of SouthGeorgia country
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
        private SouthGeorgia(
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
