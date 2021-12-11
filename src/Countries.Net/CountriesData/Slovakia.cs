namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Slovakia country
    /// </summary>
    public class Slovakia : Country
    {
        /// <summary>
        /// get the Slovakia country instance
        /// </summary>
        public static Slovakia Instance = new Slovakia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Slovak Republic", common: "Slovakia") },
                { "slk", new CountryName(official: "Slovenská republika", common: "Slovensko") },
                { "ara", new CountryName(official: "جمهورية سلوفاكيا", common: "سلوفاكيا") },
                { "ces", new CountryName(official: "Slovenská republika", common: "Slovensko") },
                { "cym", new CountryName(official: "Slovak Republic", common: "Slovakia") },
                { "deu", new CountryName(official: "Slowakische Republik", common: "Slowakei") },
                { "est", new CountryName(official: "Slovaki Vabariik", common: "Slovakkia") },
                { "fin", new CountryName(official: "Slovakian tasavalta", common: "Slovakia") },
                { "fra", new CountryName(official: "République slovaque", common: "Slovaquie") },
                { "hrv", new CountryName(official: "slovačka", common: "Slovačka") },
                { "hun", new CountryName(official: "Szlovák Köztársaság", common: "Szlovákia") },
                { "ita", new CountryName(official: "Repubblica slovacca", common: "Slovacchia") },
                { "jpn", new CountryName(official: "スロバキア共和国", common: "スロバキア") },
                { "kor", new CountryName(official: "슬로바키아 공화국", common: "슬로바키아") },
                { "nld", new CountryName(official: "Slowaakse Republiek", common: "Slowakije") },
                { "per", new CountryName(official: "جمهوری اسلواکی", common: "اِسلُواکی") },
                { "pol", new CountryName(official: "Republika Słowacka", common: "Słowacja") },
                { "por", new CountryName(official: "República Eslovaca", common: "Eslováquia") },
                { "rus", new CountryName(official: "Словацкая Республика", common: "Словакия") },
                { "spa", new CountryName(official: "República Eslovaca", common: "República Eslovaca") },
                { "swe", new CountryName(official: "Republiken Slovakien", common: "Slovakien") },
                { "urd", new CountryName(official: "جمہوریہ سلوواکیہ", common: "سلوواکیہ") },
                { "zho", new CountryName(official: "斯洛伐克共和国", common: "斯洛伐克") },

            },
            cca2: "SK",
            cca3: "SVK",
            ccn3: "703",
            cioc: "SVK",
            flag: "🇸🇰",
            region: Region.Europe,
            subregion: "Central Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"21", }),
            borders: new string[] { "AUT", "CZE", "HUN", "POL", "UKR",  },
            capital: new string[] { "Bratislava",  },
            altSpellings: new string[] { "SK", "Slovak Republic", "Slovenská republika",  },
            tld: new string[] { ".sk",  },
            latlng: new double[] { 48.66666666, 19.5,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Slovak", iso6391: "sk", iso6392: "slk"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Slovak", female: "Slovak") },
                { "fra", new DemonymsGender(male: "Slovak", female: "Slovak") },
            }
        );

        /// <summary>
        /// create an instance of Slovakia country
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
        private Slovakia(
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
