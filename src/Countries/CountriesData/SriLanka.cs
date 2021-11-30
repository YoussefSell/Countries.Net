namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of SriLanka country
    /// </summary>
    public class SriLanka : Country
    {
        /// <summary>
        /// get the SriLanka country instance
        /// </summary>
        public static SriLanka Instance = new SriLanka(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Democratic Socialist Republic of Sri Lanka", common: "Sri Lanka") },
                { "sin", new CountryName(official: "ශ්‍රී ලංකා ප්‍රජාතාන්ත්‍රික සමාජවාදී ජනරජය", common: "ශ්‍රී ලංකාව") },
                { "tam", new CountryName(official: "இலங்கை சனநாயக சோசலிசக் குடியரசு", common: "இலங்கை") },
                { "ara", new CountryName(official: "جمهورية سريلانكا الديمقراطية الشعبية", common: "سريلانكا") },
                { "ces", new CountryName(official: "Srílanská demokratická socialistická republika", common: "Srí Lanka") },
                { "cym", new CountryName(official: "Democratic Socialist Republic of Sri Lanka", common: "Sri Lanka") },
                { "deu", new CountryName(official: "Demokratische Sozialistische Republik Sri Lanka", common: "Sri Lanka") },
                { "est", new CountryName(official: "Sri Lanka Demokraatlik Sotsialistlik Vabariik", common: "Sri Lanka") },
                { "fin", new CountryName(official: "Sri Lankan demokraattinen sosialistinen tasavalta", common: "Sri Lanka") },
                { "fra", new CountryName(official: "République démocratique socialiste du Sri Lanka", common: "Sri Lanka") },
                { "hrv", new CountryName(official: "Demokratska Socijalističke Republike Šri Lanke", common: "Šri Lanka") },
                { "hun", new CountryName(official: "Srí Lanka-i Demokratikus Szocialista Köztársaság", common: "Srí Lanka") },
                { "ita", new CountryName(official: "Repubblica democratica socialista dello Sri Lanka", common: "Sri Lanka") },
                { "jpn", new CountryName(official: "スリランカ民主社会主義共和国", common: "スリランカ") },
                { "kor", new CountryName(official: "스리랑카 민주 사회주의 공화국", common: "스리랑카") },
                { "nld", new CountryName(official: "Democratische Socialistische Republiek Sri Lanka", common: "Sri Lanka") },
                { "per", new CountryName(official: "جمهوری دموکراتیک سوسیالیستی سری‌لانکا", common: "سری‌لانکا") },
                { "pol", new CountryName(official: "Demokratyczno-Socjalistyczna Republika Sri Lanki", common: "Sri Lanka") },
                { "por", new CountryName(official: "República Democrática Socialista do Sri Lanka", common: "Sri Lanka") },
                { "rus", new CountryName(official: "Демократическая Социалистическая Республика Шри-Ланка", common: "Шри-Ланка") },
                { "slk", new CountryName(official: "Srílanská demokratická socialistická republika", common: "Srí Lanka") },
                { "spa", new CountryName(official: "República Democrática Socialista de Sri Lanka", common: "Sri Lanka") },
                { "swe", new CountryName(official: "Demokratiska socialistiska republiken Sri Lanka", common: "Sri Lanka") },
                { "urd", new CountryName(official: "جمہوری و اشتراکی جمہوریہ سری لنکا", common: "سری لنکا") },
                { "zho", new CountryName(official: "斯里兰卡民主社会主义共和国", common: "斯里兰卡") },
            },
            cca2: "LK",
            cca3: "LKA",
            ccn3: "144",
            cioc: "SRI",
            flag: "🇱🇰",
            region: Region.Asia,
            subregion: "Southern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"4", }),
            borders: new string[] { "IND",  },
            capital: new string[] { "Sri Jayawardenepura Kotte",  },
            altSpellings: new string[] { "LK", "ilaṅkai", "Democratic Socialist Republic of Sri Lanka",  },
            tld: new string[] { ".lk", ".இலங்கை", ".ලංකා",  },
            latlng: new double[] { 7, 81,  },
            timezones: new string[] { "UTC+05:30",  },
            languages: new Language[]
            {
                new Language(name: "Sinhala", iso6391: "si", iso6392: "sin"),
                new Language(name: "Tamil", iso6391: "ta", iso6392: "tam"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "LKR", name: "Sri Lankan rupee", symbol: "Rs  රු"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Sri Lankan", female: "Sri Lankan") },
                { "fra", new DemonymsGender(male: "Sri Lankan", female: "Sri Lankan") },
            }
        );

        /// <summary>
        /// create an instance of SriLanka country
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
        private SriLanka(
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
