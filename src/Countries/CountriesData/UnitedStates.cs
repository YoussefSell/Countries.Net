namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of UnitedStates country
    /// </summary>
    public class UnitedStates : Country
    {
        /// <summary>
        /// get the UnitedStates country instance
        /// </summary>
        public static UnitedStates Instance = new UnitedStates(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "United States of America", common: "United States") },
                { "ara", new CountryName(official: "الولايات المتحدة الامريكية", common: "الولايات المتحدة") },
                { "ces", new CountryName(official: "Spojené státy americké", common: "Spojené státy") },
                { "cym", new CountryName(official: "United States of America", common: "United States") },
                { "deu", new CountryName(official: "Vereinigte Staaten von Amerika", common: "Vereinigte Staaten") },
                { "est", new CountryName(official: "Ameerika Ühendriigid", common: "Ameerika Ühendriigid") },
                { "fin", new CountryName(official: "Amerikan yhdysvallat", common: "Yhdysvallat") },
                { "fra", new CountryName(official: "Les états-unis d'Amérique", common: "États-Unis") },
                { "hrv", new CountryName(official: "Sjedinjene Države Amerike", common: "Sjedinjene Američke Države") },
                { "hun", new CountryName(official: "Amerikai Egyesült Államok", common: "Amerikai Egyesült Államok") },
                { "ita", new CountryName(official: "Stati Uniti d'America", common: "Stati Uniti d'America") },
                { "jpn", new CountryName(official: "アメリカ合衆国", common: "アメリカ合衆国") },
                { "kor", new CountryName(official: "아메리카 합중국", common: "미국") },
                { "nld", new CountryName(official: "Verenigde Staten van Amerika", common: "Verenigde Staten") },
                { "per", new CountryName(official: "ایالات متحده آمریکا", common: "ایالات متحده آمریکا") },
                { "pol", new CountryName(official: "Stany Zjednoczone Ameryki", common: "Stany Zjednoczone") },
                { "por", new CountryName(official: "Estados Unidos da América", common: "Estados Unidos") },
                { "rus", new CountryName(official: "Соединенные Штаты Америки", common: "Соединённые Штаты Америки") },
                { "slk", new CountryName(official: "Spojené štáty Americké", common: "Spojené štáty americké") },
                { "spa", new CountryName(official: "Estados Unidos de América", common: "Estados Unidos") },
                { "swe", new CountryName(official: "Amerikas förenta stater", common: "USA") },
                { "urd", new CountryName(official: "ریاستہائے متحدہ امریکا", common: "ریاستہائے متحدہ") },
                { "zho", new CountryName(official: "美利坚合众国", common: "美国") },
            },
            cca2: "US",
            cca3: "USA",
            ccn3: "840",
            cioc: "USA",
            flag: "🇺🇸",
            region: Region.Americas,
            subregion: "North America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"201", "202", "203", "205", "206", "207", "208", "209", "210", "212", "213", "214", "215", "216", "217", "218", "219", "220", "224", "225", "227", "228", "229", "231", "234", "239", "240", "248", "251", "252", "253", "254", "256", "260", "262", "267", "269", "270", "272", "274", "276", "281", "283", "301", "302", "303", "304", "305", "307", "308", "309", "310", "312", "313", "314", "315", "316", "317", "318", "319", "320", "321", "323", "325", "327", "330", "331", "334", "336", "337", "339", "346", "347", "351", "352", "360", "361", "364", "380", "385", "386", "401", "402", "404", "405", "406", "407", "408", "409", "410", "412", "413", "414", "415", "417", "419", "423", "424", "425", "430", "432", "434", "435", "440", "442", "443", "447", "458", "463", "464", "469", "470", "475", "478", "479", "480", "484", "501", "502", "503", "504", "505", "507", "508", "509", "510", "512", "513", "515", "516", "517", "518", "520", "530", "531", "534", "539", "540", "541", "551", "559", "561", "562", "563", "564", "567", "570", "571", "573", "574", "575", "580", "585", "586", "601", "602", "603", "605", "606", "607", "608", "609", "610", "612", "614", "615", "616", "617", "618", "619", "620", "623", "626", "628", "629", "630", "631", "636", "641", "646", "650", "651", "657", "660", "661", "662", "667", "669", "678", "681", "682", "701", "702", "703", "704", "706", "707", "708", "712", "713", "714", "715", "716", "717", "718", "719", "720", "724", "725", "727", "730", "731", "732", "734", "737", "740", "743", "747", "754", "757", "760", "762", "763", "765", "769", "770", "772", "773", "774", "775", "779", "781", "785", "786", "801", "802", "803", "804", "805", "806", "808", "810", "812", "813", "814", "815", "816", "817", "818", "828", "830", "831", "832", "843", "845", "847", "848", "850", "854", "856", "857", "858", "859", "860", "862", "863", "864", "865", "870", "872", "878", "901", "903", "904", "906", "907", "908", "909", "910", "912", "913", "914", "915", "916", "917", "918", "919", "920", "925", "928", "929", "930", "931", "934", "936", "937", "938", "940", "941", "947", "949", "951", "952", "954", "956", "959", "970", "971", "972", "973", "975", "978", "979", "980", "984", "985", "989", }),
            borders: new string[] { "CAN", "MEX",  },
            capital: new string[] { "Washington, D.C.",  },
            altSpellings: new string[] { "US", "USA", "United States of America",  },
            tld: new string[] { ".us",  },
            latlng: new double[] { 38, -97,  },
            timezones: new string[] { "UTC-12:00", "UTC-11:00", "UTC-10:00", "UTC-09:00", "UTC-08:00", "UTC-07:00", "UTC-06:00", "UTC-05:00", "UTC-04:00", "UTC+10:00", "UTC+12:00",  },
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
                { "eng", new DemonymsGender(male: "American", female: "American") },
                { "fra", new DemonymsGender(male: "American", female: "American") },
            }
        );

        /// <summary>
        /// create an instance of UnitedStates country
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
        private UnitedStates(
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
