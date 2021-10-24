namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Somalia country
    /// </summary>
    public class Somalia : Country
    {
        /// <summary>
        /// get the Somalia country instance
        /// </summary>
        public static Somalia Instance = new Somalia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Federal Republic of Somalia", common: "Somalia") },
                { "ara", new CountryName(official: "جمهورية الصومال‎‎", common: "الصومال‎‎") },
                { "som", new CountryName(official: "Jamhuuriyadda Federaalka Soomaaliya", common: "Soomaaliya") },
                { "ces", new CountryName(official: "Somálská demokratická republika", common: "Somálsko") },
                { "cym", new CountryName(official: "Federal Republic of Somalia", common: "Somalia") },
                { "deu", new CountryName(official: "Bundesrepublik Somalia", common: "Somalia") },
                { "est", new CountryName(official: "Somaalia Liitvabariik", common: "Somaalia") },
                { "fin", new CountryName(official: "Somalian liittotasavalta", common: "Somalia") },
                { "fra", new CountryName(official: "République fédérale de Somalie", common: "Somalie") },
                { "hrv", new CountryName(official: "Savezna Republika Somaliji", common: "Somalija") },
                { "hun", new CountryName(official: "Szomáli Szövetségi Köztársaság", common: "Szomália") },
                { "ita", new CountryName(official: "Repubblica federale di Somalia", common: "Somalia") },
                { "jpn", new CountryName(official: "ソマリア連邦共和国", common: "ソマリア") },
                { "kor", new CountryName(official: " 소말리아 연방 공화국", common: "소말리아") },
                { "nld", new CountryName(official: "Federale Republiek Somalië", common: "Somalië") },
                { "per", new CountryName(official: "جمهوری فدرال سومالی", common: "سومالی") },
                { "pol", new CountryName(official: "Federalna Republika Somalii", common: "Somalia") },
                { "por", new CountryName(official: "República Federal da Somália", common: "Somália") },
                { "rus", new CountryName(official: "Федеративная Республика Сомали", common: "Сомали") },
                { "slk", new CountryName(official: "Somálska federatívna republika", common: "Somálsko") },
                { "spa", new CountryName(official: "República Federal de Somalia", common: "Somalia") },
                { "swe", new CountryName(official: "Förbundsrepubliken Somalia", common: "Somalia") },
                { "urd", new CountryName(official: "وفاقی جمہوریہ صومالیہ", common: "صومالیہ") },
                { "zho", new CountryName(official: "索马里共和国", common: "索马里") },

            },
            cca2: "SO",
            cca3: "SOM",
            ccn3: "706",
            cioc: "SOM",
            flag: "🇸🇴",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"52", }),
            borders: new string[] { "DJI", "ETH", "KEN",  },
            capital: new string[] { "Mogadishu",  },
            altSpellings: new string[] { "SO", "aṣ-Ṣūmāl", "Federal Republic of Somalia", "Jamhuuriyadda Federaalka Soomaaliya", "Jumhūriyyat aṣ-Ṣūmāl al-Fiderāliyya",  },
            tld: new string[] { ".so",  },
            latlng: new double[] { 10, 49,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
                new Language(name: "Somali", iso6391: "so", iso6392: "som"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "SOS", name: "Somali shilling", symbol: "Sh"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Somali", female: "Somali") },
                { "fra", new DemonymsGender(male: "Somali", female: "Somali") },
            }
        );

        /// <summary>
        /// create an instance of Somalia country
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
        private Somalia(
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
