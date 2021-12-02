namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of BritishIndianOceanTerritory country
    /// </summary>
    public class BritishIndianOceanTerritory : Country
    {
        /// <summary>
        /// get the BritishIndianOceanTerritory country instance
        /// </summary>
        public static BritishIndianOceanTerritory Instance = new BritishIndianOceanTerritory(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "British Indian Ocean Territory", common: "British Indian Ocean Territory") },
                { "ara", new CountryName(official: "إقليم المحيط الهندي البريطاني", common: "إقليم المحيط الهندي البريطاني") },
                { "ces", new CountryName(official: "Britské indickooceánské území", common: "Britské indickooceánské území") },
                { "cym", new CountryName(official: "Tiriogaeth Brydeinig Cefnfor India", common: "Tiriogaeth Brydeinig Cefnfor India") },
                { "deu", new CountryName(official: "Britisches Territorium im Indischen Ozean", common: "Britisches Territorium im Indischen Ozean") },
                { "est", new CountryName(official: "Briti India ookeani ala", common: "Briti India ookeani ala") },
                { "fin", new CountryName(official: "Brittiläinen Intian valtameren alue", common: "Brittiläinen Intian valtameren alue") },
                { "fra", new CountryName(official: "Territoire britannique de l' océan Indien", common: "Territoire britannique de l'océan Indien") },
                { "hrv", new CountryName(official: "British Indian Ocean Territory", common: "Britanski Indijskooceanski teritorij") },
                { "hun", new CountryName(official: "Brit Indiai-óceáni Terület", common: "Brit Indiai-óceáni Terület") },
                { "ita", new CountryName(official: "Territorio britannico dell'Oceano Indiano", common: "Territorio britannico dell'oceano indiano") },
                { "jpn", new CountryName(official: "イギリス領インド洋地域", common: "イギリス領インド洋地域") },
                { "kor", new CountryName(official: "인도 공화국", common: "인도") },
                { "nld", new CountryName(official: "Brits Indische Oceaan Territorium", common: "Britse Gebieden in de Indische Oceaan") },
                { "per", new CountryName(official: "قلمرو بریتانیا در اقیانوس هند", common: "قلمرو بریتانیا در اقیانوس هند") },
                { "pol", new CountryName(official: "Brytyjskie Terytorium Oceanu Indyjskiego", common: "Brytyjskie Terytorium Oceanu Indyjskiego") },
                { "por", new CountryName(official: "British Indian Ocean Territory", common: "Território Britânico do Oceano Índico") },
                { "rus", new CountryName(official: "Британская территория Индийского океана", common: "Британская территория в Индийском океане") },
                { "slk", new CountryName(official: "Britské indickooceánske územie", common: "Britské indickooceánske územie") },
                { "spa", new CountryName(official: "Territorio Británico del Océano Índico", common: "Territorio Británico del Océano Índico") },
                { "swe", new CountryName(official: "Brittiska territoriet i Indiska Oceanen", common: "Brittiska territoriet i Indiska Oceanen") },
                { "urd", new CountryName(official: "برطانوی بحرہند خطہ", common: "برطانوی بحرہند خطہ") },
                { "zho", new CountryName(official: "英属印度洋领地", common: "英属印度洋领地") },
            },
            cca2: "IO",
            cca3: "IOT",
            ccn3: "086",
            cioc: "",
            flag: "🇮🇴",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"46", }),
            borders: new string[] {  },
            capital: new string[] { "Diego Garcia",  },
            altSpellings: new string[] { "IO",  },
            tld: new string[] { ".io",  },
            latlng: new double[] { -6, 71.5,  },
            timezones: new string[] { "UTC+06:00",  },
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
                { "eng", new DemonymsGender(male: "Indian", female: "Indian") },
                { "fra", new DemonymsGender(male: "Indian", female: "Indian") },
            }
        );

        /// <summary>
        /// create an instance of BritishIndianOceanTerritory country
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
        private BritishIndianOceanTerritory(
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
