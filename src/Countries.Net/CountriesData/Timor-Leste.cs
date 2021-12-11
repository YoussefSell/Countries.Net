namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Timor-Leste country
    /// </summary>
    public class TimorLeste : Country
    {
        /// <summary>
        /// get the Timor-Leste country instance
        /// </summary>
        public static TimorLeste Instance = new TimorLeste(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Democratic Republic of Timor-Leste", common: "Timor-Leste") },
                { "por", new CountryName(official: "República Democrática de Timor-Leste", common: "Timor-Leste") },
                { "tet", new CountryName(official: "Repúblika Demokrátika Timór-Leste", common: "Timór-Leste") },
                { "ara", new CountryName(official: "جمهورية تيمور الشرقية الديمقراطية", common: "تيمور الشرقية") },
                { "ces", new CountryName(official: "Demokratická republika Východní Timor", common: "Východní Timor") },
                { "cym", new CountryName(official: "Democratic Republic of Timor-Leste", common: "Timor-Leste") },
                { "deu", new CountryName(official: "Demokratische Republik Timor-Leste", common: "Osttimor") },
                { "est", new CountryName(official: "Timor-Leste Demokraatlik Vabariik", common: "Ida-Timor") },
                { "fin", new CountryName(official: "Itä-Timorin demokraattinen tasavalta", common: "Itä-Timor") },
                { "fra", new CountryName(official: "République démocratique du Timor oriental", common: "Timor oriental") },
                { "hrv", new CountryName(official: "Demokratska Republika Timor-Leste", common: "Istočni Timor") },
                { "hun", new CountryName(official: "Kelet-timori Demokratikus Köztársaság", common: "Kelet-Timor") },
                { "ita", new CountryName(official: "Repubblica Democratica di Timor Est", common: "Timor Est") },
                { "jpn", new CountryName(official: "東ティモール民主共和国", common: "東ティモール") },
                { "kor", new CountryName(official: "동티모르 민주 공화국", common: "동티모르") },
                { "nld", new CountryName(official: "Democratische Republiek Oost-Timor", common: "Oost-Timor") },
                { "per", new CountryName(official: "جمهوری دموکراتیک تیمور شرقی", common: "تیمور شرقی") },
                { "pol", new CountryName(official: "Demokratyczna Republika Timoru Wschodniego", common: "Timor Wschodni") },
                { "rus", new CountryName(official: "Демократическая Республика Тимор -Лешти", common: "Восточный Тимор") },
                { "slk", new CountryName(official: "Východotimorská demokratická republika", common: "Východný Timor") },
                { "spa", new CountryName(official: "República Democrática de Timor-Leste", common: "Timor Oriental") },
                { "swe", new CountryName(official: "Demokratiska republiken Östtimor", common: "Östtimor") },
                { "urd", new CountryName(official: "جمہوری جمہوریہ مشرقی تیمور", common: "مشرقی تیمور") },
                { "zho", new CountryName(official: "东帝汶民主共和国", common: "东帝汶") },

            },
            cca2: "TL",
            cca3: "TLS",
            ccn3: "626",
            cioc: "TLS",
            flag: "🇹🇱",
            region: Region.Asia,
            subregion: "South-Eastern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"70", }),
            borders: new string[] { "IDN",  },
            capital: new string[] { "Dili",  },
            altSpellings: new string[] { "TL", "East Timor", "Democratic Republic of Timor-Leste", "República Democrática de Timor-Leste", "Repúblika Demokrátika Timór-Leste", "Timór Lorosa'e", "Timor Lorosae",  },
            tld: new string[] { ".tl",  },
            latlng: new double[] { -8.83333333, 125.91666666,  },
            timezones: new string[] { "UTC+09:00",  },
            languages: new Language[]
            {
                new Language(name: "Portuguese", iso6391: "pt", iso6392: "por"),
                new Language(name: "Tetum", iso6391: "", iso6392: "tet"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "USD", name: "United States dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "East Timorese", female: "East Timorese") },
                { "fra", new DemonymsGender(male: "East Timorese", female: "East Timorese") },
            }
        );

        /// <summary>
        /// create an instance of Timor-Leste country
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
        private TimorLeste(
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
