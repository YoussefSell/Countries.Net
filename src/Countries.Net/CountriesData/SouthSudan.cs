namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of SouthSudan country
    /// </summary>
    public class SouthSudan : Country
    {
        /// <summary>
        /// get the SouthSudan country instance
        /// </summary>
        public static SouthSudan Instance = new SouthSudan(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of South Sudan", common: "South Sudan") },
                { "ara", new CountryName(official: "جمهورية جنوب السودان", common: "جنوب السودان") },
                { "ces", new CountryName(official: "Jihosúdánská republika", common: "Jižní Súdán") },
                { "cym", new CountryName(official: "Republic of South Sudan", common: "South Sudan") },
                { "deu", new CountryName(official: "Republik Südsudan", common: "Südsudan") },
                { "est", new CountryName(official: "Lõuna-Sudaani Vabariik", common: "Lõuna-Sudaan") },
                { "fin", new CountryName(official: "Etelä-Sudanin tasavalta", common: "Etelä-Sudan") },
                { "fra", new CountryName(official: "République du Soudan du Sud", common: "Soudan du Sud") },
                { "hrv", new CountryName(official: "Republika Južni Sudan", common: "Južni Sudan") },
                { "hun", new CountryName(official: "Dél-szudáni Köztársaság", common: "Dél-Szudán") },
                { "ita", new CountryName(official: "Repubblica del Sudan del Sud", common: "Sudan del sud") },
                { "jpn", new CountryName(official: "南スーダン共和国", common: "南スーダン") },
                { "kor", new CountryName(official: "남수단 공화국", common: "남수단") },
                { "nld", new CountryName(official: "Republiek Zuid-Soedan", common: "Zuid-Soedan") },
                { "per", new CountryName(official: "جمهوری سودان جنوبی", common: "سودان جنوبی") },
                { "pol", new CountryName(official: "Republika Sudanu", common: "Sudan") },
                { "por", new CountryName(official: "República do Sudão do Sul", common: "Sudão do Sul") },
                { "rus", new CountryName(official: "Республика Южный Судан", common: "Южный Судан") },
                { "slk", new CountryName(official: "Juhosudánska republika", common: "Južný Sudán") },
                { "spa", new CountryName(official: "República de Sudán del Sur", common: "Sudán del Sur") },
                { "swe", new CountryName(official: "Republiken Sydsudan", common: "Sydsudan") },
                { "urd", new CountryName(official: "جمہوریہ جنوبی سوڈان", common: "جنوبی سوڈان") },
                { "zho", new CountryName(official: "南苏丹共和国", common: "南苏丹") },
            },
            cca2: "SS",
            cca3: "SSD",
            ccn3: "728",
            cioc: "",
            flag: "🇸🇸",
            region: Region.Africa,
            subregion: "Middle Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"11", }),
            borders: new string[] { "CAF", "COD", "ETH", "KEN", "SDN", "UGA",  },
            capital: new string[] { "Juba",  },
            altSpellings: new string[] { "SS",  },
            tld: new string[] { ".ss",  },
            latlng: new double[] { 7, 30,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "SSP", name: "South Sudanese pound", symbol: "£"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "South Sudanese", female: "South Sudanese") },
                { "fra", new DemonymsGender(male: "South Sudanese", female: "South Sudanese") },
            }
        );

        /// <summary>
        /// create an instance of SouthSudan country
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
        private SouthSudan(
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
