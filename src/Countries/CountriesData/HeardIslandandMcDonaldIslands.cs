namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of HeardIslandandMcDonaldIslands country
    /// </summary>
    public class HeardIslandandMcDonaldIslands : Country
    {
        /// <summary>
        /// get the HeardIslandandMcDonaldIslands country instance
        /// </summary>
        public static HeardIslandandMcDonaldIslands Instance = new HeardIslandandMcDonaldIslands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Heard Island and McDonald Islands", common: "Heard Island and McDonald Islands") },
                { "ara", new CountryName(official: "جزيرة هيرد وجزر ماكدونالد", common: "جزيرة هيرد وجزر ماكدونالد") },
                { "ces", new CountryName(official: "Heardův ostrov a McDonaldovy ostrovy", common: "Heardův ostrov a McDonaldovy ostrovy") },
                { "cym", new CountryName(official: "Heard Island and McDonald Islands", common: "Heard Island and McDonald Islands") },
                { "deu", new CountryName(official: "Heard und McDonaldinseln", common: "Heard und die McDonaldinseln") },
                { "est", new CountryName(official: "Heardi ja McDonaldi saarte ala", common: "Heard ja McDonald") },
                { "fin", new CountryName(official: "Heard ja McDonaldinsaaret", common: "Heard ja McDonaldinsaaret") },
                { "fra", new CountryName(official: "Des îles Heard et McDonald", common: "Îles Heard-et-MacDonald") },
                { "hrv", new CountryName(official: "Otok Heard i otočje McDonald", common: "Otok Heard i otočje McDonald") },
                { "hun", new CountryName(official: "Heard-sziget és McDonald-szigetek", common: "Heard-sziget és McDonald-szigetek") },
                { "ita", new CountryName(official: "Isole Heard e McDonald", common: "Isole Heard e McDonald") },
                { "jpn", new CountryName(official: "ハード島とマクドナルド諸島", common: "ハード島とマクドナルド諸島") },
                { "kor", new CountryName(official: "허드 맥도널드 제도", common: "허드 맥도널드 제도") },
                { "nld", new CountryName(official: "Heard en McDonaldeilanden", common: "Heard-en McDonaldeilanden") },
                { "per", new CountryName(official: "جزیره هرد و جزایر مک‌دونالد", common: "جزیره هرد و جزایر مک‌دونالد") },
                { "pol", new CountryName(official: "Terytorium Wysp Heard i McDonalda", common: "Wyspy Heard i McDonalda") },
                { "por", new CountryName(official: "Ilha Heard e Ilhas McDonald", common: "Ilha Heard e Ilhas McDonald") },
                { "rus", new CountryName(official: "Остров Херд и острова Макдональд", common: "Остров Херд и острова Макдональд") },
                { "slk", new CountryName(official: "Teritórium Heardovho ostrova a Macdonaldových ostrovov", common: "Heardov ostrov") },
                { "spa", new CountryName(official: "Islas Heard y McDonald", common: "Islas Heard y McDonald") },
                { "swe", new CountryName(official: "Heard- och McDonaldöarna", common: "Heard- och McDonaldöarna") },
                { "urd", new CountryName(official: "جزیرہ ہرڈ و جزائر مکڈونلڈ", common: "جزیرہ ہرڈ و جزائر مکڈونلڈ") },
                { "zho", new CountryName(official: "赫德岛和麦当劳群岛", common: "赫德岛和麦当劳群岛") },
            },
            cca2: "HM",
            cca3: "HMD",
            ccn3: "334",
            cioc: "",
            flag: "🇭🇲",
            region: Region.Antarctic,
            subregion: "",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "", suffixes: new string[] {}),
            borders: new string[] {  },
            capital: new string[] {  },
            altSpellings: new string[] { "HM", "Heard Island and McDonald Islands",  },
            tld: new string[] { ".hm", ".aq",  },
            latlng: new double[] { -53.1, 72.51666666,  },
            timezones: new string[] { "UTC+05:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Heard and McDonald Islander", female: "Heard and McDonald Islander") },
                { "fra", new DemonymsGender(male: "Heard and McDonald Islander", female: "Heard and McDonald Islander") },
            }
        );

        /// <summary>
        /// create an instance of HeardIslandandMcDonaldIslands country
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
        private HeardIslandandMcDonaldIslands(
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
