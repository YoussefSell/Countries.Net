namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Vietnam country
    /// </summary>
    public class Vietnam : Country
    {
        /// <summary>
        /// get the Vietnam country instance
        /// </summary>
        public static Vietnam Instance = new Vietnam(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Socialist Republic of Vietnam", common: "Vietnam") },
                { "vie", new CountryName(official: "Cộng hòa xã hội chủ nghĩa Việt Nam", common: "Việt Nam") },
                { "ara", new CountryName(official: "جمهورية فيتنام الاشتراكية", common: "فيتنام") },
                { "ces", new CountryName(official: "Vietnamská socialistická republika", common: "Vietnam") },
                { "cym", new CountryName(official: "Socialist Republic of Vietnam", common: "Vietnam") },
                { "deu", new CountryName(official: "Sozialistische Republik Vietnam", common: "Vietnam") },
                { "est", new CountryName(official: "Vietnami Sotsialistlik Vabariik", common: "Vietnam") },
                { "fin", new CountryName(official: "Vietnamin sosialistinen tasavalta", common: "Vietnam") },
                { "fra", new CountryName(official: "République socialiste du Viêt Nam", common: "Viêt Nam") },
                { "hrv", new CountryName(official: "Socijalistička Republika Vijetnam", common: "Vijetnam") },
                { "hun", new CountryName(official: "Vietnámi Szocialista Köztársaság", common: "Vietnám") },
                { "ita", new CountryName(official: "Repubblica socialista del Vietnam", common: "Vietnam") },
                { "jpn", new CountryName(official: "ベトナム社会主義共和国", common: "ベトナム") },
                { "kor", new CountryName(official: "베트남 사회주의 공화국", common: "베트남") },
                { "nld", new CountryName(official: "Socialistische Republiek Vietnam", common: "Vietnam") },
                { "per", new CountryName(official: "جمهوری سوسیالیستی ویتنام", common: "ویتنام") },
                { "pol", new CountryName(official: "Socjalistyczna Republika Wietnamu", common: "Wietnam") },
                { "por", new CountryName(official: "República Socialista do Vietname", common: "Vietname") },
                { "rus", new CountryName(official: "Социалистическая Республика Вьетнам", common: "Вьетнам") },
                { "slk", new CountryName(official: "Vietnamská socialistická republika", common: "Vietnam") },
                { "spa", new CountryName(official: "República Socialista de Vietnam", common: "Vietnam") },
                { "swe", new CountryName(official: "Socialistiska republiken Vietnam", common: "Vietnam") },
                { "urd", new CountryName(official: "اشتراکی جمہوریہ ویتنام", common: "ویتنام") },
                { "zho", new CountryName(official: "越南社会主义共和国", common: "越南") },
            },
            cca2: "VN",
            cca3: "VNM",
            ccn3: "704",
            cioc: "VIE",
            flag: "🇻🇳",
            region: Region.Asia,
            subregion: "South-Eastern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+8", suffixes: new string[] {"4", }),
            borders: new string[] { "KHM", "CHN", "LAO",  },
            capital: new string[] { "Hanoi",  },
            altSpellings: new string[] { "VN", "Socialist Republic of Vietnam", "Cộng hòa Xã hội chủ nghĩa Việt Nam", "Viet Nam",  },
            tld: new string[] { ".vn",  },
            latlng: new double[] { 16.16666666, 107.83333333,  },
            timezones: new string[] { "UTC+07:00",  },
            languages: new Language[]
            {
                new Language(name: "Vietnamese", iso6391: "vi", iso6392: "vie"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "VND", name: "Vietnamese đồng", symbol: "₫"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Vietnamese", female: "Vietnamese") },
                { "fra", new DemonymsGender(male: "Vietnamese", female: "Vietnamese") },
            }
        );

        /// <summary>
        /// create an instance of Vietnam country
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
        private Vietnam(
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
