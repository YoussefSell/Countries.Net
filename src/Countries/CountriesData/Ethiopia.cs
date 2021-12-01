namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Ethiopia country
    /// </summary>
    public class Ethiopia : Country
    {
        /// <summary>
        /// get the Ethiopia country instance
        /// </summary>
        public static Ethiopia Instance = new Ethiopia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Federal Democratic Republic of Ethiopia", common: "Ethiopia") },
                { "amh", new CountryName(official: "የኢትዮጵያ ፌዴራላዊ ዲሞክራሲያዊ ሪፐብሊክ", common: "ኢትዮጵያ") },
                { "ara", new CountryName(official: "جمهورية إثيوبيا الفدرالية الديموقراطية", common: "إثيوبيا") },
                { "ces", new CountryName(official: "Etiopská federativní demokratická republika", common: "Etiopie") },
                { "cym", new CountryName(official: "Gweriniaeth Ddemocrataidd Ffederal Ethiopia", common: "Ethiopia") },
                { "deu", new CountryName(official: "Demokratische Bundesrepublik Äthiopien", common: "Äthiopien") },
                { "est", new CountryName(official: "Etioopia Demokraatlik Liitvabariik", common: "Etioopia") },
                { "fin", new CountryName(official: "Etiopian demokraattinen liittotasavalta", common: "Etiopia") },
                { "fra", new CountryName(official: "République fédérale démocratique d'Éthiopie", common: "Éthiopie") },
                { "hrv", new CountryName(official: "Savezna Demokratska Republika Etiopija", common: "Etiopija") },
                { "hun", new CountryName(official: "Etióp Szövetségi Demokratikus Köztársaság", common: "Etiópia") },
                { "ita", new CountryName(official: "Repubblica federale democratica di Etiopia", common: "Etiopia") },
                { "jpn", new CountryName(official: "エチオピア連邦民主共和国", common: "エチオピア") },
                { "kor", new CountryName(official: "에티오피아 연방 민주 공화국", common: "에티오피아") },
                { "nld", new CountryName(official: "Federale Democratische Republiek Ethiopië", common: "Ethiopië") },
                { "per", new CountryName(official: "جمهوری فدرال دموکراتیک اتیوپی", common: "اِتیوپی") },
                { "pol", new CountryName(official: "Federalna Demokratyczna Republika Etiopii", common: "Etiopia") },
                { "por", new CountryName(official: "República Federal Democrática da Etiópia", common: "Etiópia") },
                { "rus", new CountryName(official: "Федеративная Демократическая Республика Эфиопия", common: "Эфиопия") },
                { "slk", new CountryName(official: "Etiópska federatívna demokratická republika", common: "Etiópia") },
                { "spa", new CountryName(official: "República Democrática Federal de Etiopía", common: "Etiopía") },
                { "swe", new CountryName(official: "Demokratiska förbundsrepubliken Etiopien", common: "Etiopien") },
                { "urd", new CountryName(official: "وفاقی جمہوری جمہوریہ ایتھوپیا", common: "ایتھوپیا") },
                { "zho", new CountryName(official: "埃塞俄比亚联邦民主共和国", common: "埃塞俄比亚") },
            },
            cca2: "ET",
            cca3: "ETH",
            ccn3: "231",
            cioc: "ETH",
            flag: "🇪🇹",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"51", }),
            borders: new string[] { "DJI", "ERI", "KEN", "SOM", "SSD", "SDN",  },
            capital: new string[] { "Addis Ababa",  },
            altSpellings: new string[] { "ET", "ʾĪtyōṗṗyā", "Federal Democratic Republic of Ethiopia", "የኢትዮጵያ ፌዴራላዊ ዲሞክራሲያዊ ሪፐብሊክ",  },
            tld: new string[] { ".et",  },
            latlng: new double[] { 8, 38,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "Amharic", iso6391: "am", iso6392: "amh"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "ETB", name: "Ethiopian birr", symbol: "Br"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Ethiopian", female: "Ethiopian") },
                { "fra", new DemonymsGender(male: "Ethiopian", female: "Ethiopian") },
            }
        );

        /// <summary>
        /// create an instance of Ethiopia country
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
        private Ethiopia(
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
