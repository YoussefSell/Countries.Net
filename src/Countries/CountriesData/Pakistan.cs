namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Pakistan country
    /// </summary>
    public class Pakistan : Country
    {
        /// <summary>
        /// get the Pakistan country instance
        /// </summary>
        public static Pakistan Instance = new Pakistan(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Islamic Republic of Pakistan", common: "Pakistan") },
                { "urd", new CountryName(official: "اسلامی جمہوریۂ پاكستان", common: "پاكستان") },
                { "ara", new CountryName(official: "جمهورية باكستان الإسلامية", common: "باكستان") },
                { "ces", new CountryName(official: "Pákistánská islámská republika", common: "Pákistán") },
                { "cym", new CountryName(official: "Islamic Republic of Pakistan", common: "Pakistan") },
                { "deu", new CountryName(official: "Islamische Republik Pakistan", common: "Pakistan") },
                { "est", new CountryName(official: "Pakistani Islamivabariik", common: "Pakistan") },
                { "fin", new CountryName(official: "Pakistanin islamilainen tasavalta", common: "Pakistan") },
                { "fra", new CountryName(official: "République islamique du Pakistan", common: "Pakistan") },
                { "hrv", new CountryName(official: "Islamska Republika Pakistan", common: "Pakistan") },
                { "hun", new CountryName(official: "Pakisztán", common: "Pakisztán") },
                { "ita", new CountryName(official: "Repubblica islamica del Pakistan", common: "Pakistan") },
                { "jpn", new CountryName(official: "パキスタン", common: "パキスタン") },
                { "kor", new CountryName(official: "파키스탄 이슬람 공화국", common: "파키스탄") },
                { "nld", new CountryName(official: "Islamitische Republiek Pakistan", common: "Pakistan") },
                { "per", new CountryName(official: "جمهوری اسلامی پاکستان", common: "پاکستان") },
                { "pol", new CountryName(official: "Islamska Republika Pakistanu", common: "Pakistan") },
                { "por", new CountryName(official: "República Islâmica do Paquistão", common: "Paquistão") },
                { "rus", new CountryName(official: "Исламская Республика Пакистан", common: "Пакистан") },
                { "slk", new CountryName(official: "Pakistanská islamská republika", common: "Pakistan") },
                { "spa", new CountryName(official: "República Islámica de Pakistán", common: "Pakistán") },
                { "swe", new CountryName(official: "Islamiska republiken Pakistan", common: "Pakistan") },
                { "zho", new CountryName(official: "巴基斯坦伊斯兰共和国", common: "巴基斯坦") },

            },
            cca2: "PK",
            cca3: "PAK",
            ccn3: "586",
            cioc: "PAK",
            flag: "🇵🇰",
            region: Region.Asia,
            subregion: "Southern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"2", }),
            borders: new string[] { "AFG", "CHN", "IND", "IRN",  },
            capital: new string[] { "Islamabad",  },
            altSpellings: new string[] { "PK", "Pākistān", "Islamic Republic of Pakistan", "Islāmī Jumhūriya'eh Pākistān",  },
            tld: new string[] { ".pk",  },
            latlng: new double[] { 30, 70,  },
            timezones: new string[] { "UTC+05:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Urdu", iso6391: "ur", iso6392: "urd"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "PKR", name: "Pakistani rupee", symbol: "₨"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Pakistani", female: "Pakistani") },
                { "fra", new DemonymsGender(male: "Pakistani", female: "Pakistani") },
            }
        );

        /// <summary>
        /// create an instance of Pakistan country
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
        private Pakistan(
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
