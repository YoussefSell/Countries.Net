namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of SaintHelena,AscensionandTristandaCunha country
    /// </summary>
    public class SaintHelenaAscensionandTristandaCunha : Country
    {
        /// <summary>
        /// get the SaintHelena,AscensionandTristandaCunha country instance
        /// </summary>
        public static SaintHelenaAscensionandTristandaCunha Instance = new SaintHelenaAscensionandTristandaCunha(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Saint Helena, Ascension and Tristan da Cunha", common: "Saint Helena, Ascension and Tristan da Cunha") },
                { "ara", new CountryName(official: "سانت هيلينا وأسينشين وتريستان دا كونا", common: "سانت هيلينا وأسينشين وتريستان دا كونا") },
                { "ces", new CountryName(official: "Svatá Helena, Ascension a Tristan da Cunha", common: "Svatá Helena, Ascension a Tristan da Cunha") },
                { "cym", new CountryName(official: "Saint Helena, Ascension and Tristan da Cunha", common: "Saint Helena, Ascension and Tristan da Cunha") },
                { "deu", new CountryName(official: "Sankt Helena, Ascension und Tristan da Cunha", common: "St. Helena, Ascension und Tristan da Cunha") },
                { "est", new CountryName(official: "Saint Helena, Ascension ja Tristan da Cunha", common: "Saint Helena, Ascension ja Tristan da Cunha") },
                { "fin", new CountryName(official: "Saint Helena, Ascension ja Tristan da Cunha", common: "Saint Helena, Ascension ja Tristan da Cunha") },
                { "fra", new CountryName(official: "Sainte-Hélène, Ascension et Tristan da Cunha", common: "Sainte-Hélène, Ascension et Tristan da Cunha") },
                { "hrv", new CountryName(official: "Sveta Helena", common: "Sveta Helena") },
                { "hun", new CountryName(official: "Szent Ilona", common: "Szent Ilona-sziget") },
                { "ita", new CountryName(official: "Sant'Elena, Ascensione e Tristan da Cunha", common: "Sant'Elena, Ascensione e Tristan da Cunha") },
                { "jpn", new CountryName(official: "セントヘレナ・アセンションおよびトリスタンダクーニャ", common: "セントヘレナ・アセンションおよびトリスタンダクーニャ") },
                { "kor", new CountryName(official: "세인트헬레나", common: "세인트헬레나") },
                { "nld", new CountryName(official: "Sint-Helena, Ascension en Tristan da Cunha", common: "Sint-Helena, Ascension en Tristan da Cunha") },
                { "per", new CountryName(official: "سنت هلن", common: "سنت هلن") },
                { "pol", new CountryName(official: "Wyspa Świętej Heleny, Wyspa Wniebowstąpienia i Tristan da Cunha", common: "Wyspa Świętej Heleny, Wyspa Wniebowstąpienia i Tristan da Cunha") },
                { "por", new CountryName(official: "Santa Helena, Ascensão e Tristão da Cunha", common: "Santa Helena, Ascensão e Tristão da Cunha") },
                { "rus", new CountryName(official: "Острова Святой Елены, Вознесения и Тристан-да-Кунья", common: "Острова Святой Елены, Вознесения и Тристан-да-Кунья") },
                { "slk", new CountryName(official: "Svätá Helena (zámorské územie)", common: "Svätá Helena (zámorské územie)") },
                { "spa", new CountryName(official: "Santa Elena, Ascensión y Tristán de Acuña", common: "Santa Elena, Ascensión y Tristán de Acuña") },
                { "swe", new CountryName(official: "Sankta Helena", common: "Sankta Helena") },
                { "urd", new CountryName(official: "سینٹ ہلینا، اسینشن و ترسٹان دا کونیا", common: "سینٹ ہلینا، اسینشن و ترسٹان دا کونیا") },
                { "zho", new CountryName(official: "圣赫勒拿、阿森松和特里斯坦-达库尼亚", common: "圣赫勒拿、阿森松和特里斯坦-达库尼亚") },
            },
            cca2: "SH",
            cca3: "SHN",
            ccn3: "654",
            cioc: "",
            flag: "🇸🇭",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"90", "47", }),
            borders: new string[] {  },
            capital: new string[] { "Jamestown",  },
            altSpellings: new string[] { "Saint Helena", "St. Helena, Ascension and Tristan da Cunha",  },
            tld: new string[] { ".sh", ".ac",  },
            latlng: new double[] { -15.95, -5.72,  },
            timezones: new string[] { "UTC+00:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "GBP", name: "Pound sterling", symbol: "£"),
                new Currency(code: "SHP", name: "Saint Helena pound", symbol: "£"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Saint Helenian", female: "Saint Helenian") },
                { "fra", new DemonymsGender(male: "Saint Helenian", female: "Saint Helenian") },
            }
        );

        /// <summary>
        /// create an instance of SaintHelena,AscensionandTristandaCunha country
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
        private SaintHelenaAscensionandTristandaCunha(
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
