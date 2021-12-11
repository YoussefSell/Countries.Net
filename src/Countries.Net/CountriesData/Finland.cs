namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Finland country
    /// </summary>
    public class Finland : Country
    {
        /// <summary>
        /// get the Finland country instance
        /// </summary>
        public static Finland Instance = new Finland(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Finland", common: "Finland") },
                { "fin", new CountryName(official: "Suomen tasavalta", common: "Suomi") },
                { "swe", new CountryName(official: "Republiken Finland", common: "Finland") },
                { "ara", new CountryName(official: "جمهورية فنلندا", common: "فنلندا") },
                { "ces", new CountryName(official: "Finská republika", common: "Finsko") },
                { "cym", new CountryName(official: "Republic of Finland", common: "Finland") },
                { "deu", new CountryName(official: "Republik Finnland", common: "Finnland") },
                { "est", new CountryName(official: "Soome Vabariik", common: "Soome") },
                { "fra", new CountryName(official: "République de Finlande", common: "Finlande") },
                { "hrv", new CountryName(official: "Republika Finska", common: "Finska") },
                { "hun", new CountryName(official: "Finn Köztársaság", common: "Finnország") },
                { "ita", new CountryName(official: "Repubblica di Finlandia", common: "Finlandia") },
                { "jpn", new CountryName(official: "フィンランド共和国", common: "フィンランド") },
                { "kor", new CountryName(official: "핀란드 공화국", common: "핀란드") },
                { "nld", new CountryName(official: "Republiek Finland", common: "Finland") },
                { "per", new CountryName(official: "جمهوری فنلاند", common: "فنلاند") },
                { "pol", new CountryName(official: "Republika Finlandii", common: "Finlandia") },
                { "por", new CountryName(official: "República da Finlândia", common: "Finlândia") },
                { "rus", new CountryName(official: "Финляндская Республика", common: "Финляндия") },
                { "slk", new CountryName(official: "Fínska republika", common: "Fínsko") },
                { "spa", new CountryName(official: "República de Finlandia", common: "Finlandia") },
                { "urd", new CountryName(official: "جمہوریہ فن لینڈ", common: "فن لینڈ") },
                { "zho", new CountryName(official: "芬兰共和国", common: "芬兰") },

            },
            cca2: "FI",
            cca3: "FIN",
            ccn3: "246",
            cioc: "FIN",
            flag: "🇫🇮",
            region: Region.Europe,
            subregion: "Northern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"58", }),
            borders: new string[] { "NOR", "SWE", "RUS",  },
            capital: new string[] { "Helsinki",  },
            altSpellings: new string[] { "FI", "Suomi", "Republic of Finland", "Suomen tasavalta", "Republiken Finland",  },
            tld: new string[] { ".fi",  },
            latlng: new double[] { 64, 26,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Finnish", iso6391: "fi", iso6392: "fin"),
                new Language(name: "Swedish", iso6391: "sv", iso6392: "swe"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Finnish", female: "Finnish") },
                { "fra", new DemonymsGender(male: "Finnish", female: "Finnish") },
            }
        );

        /// <summary>
        /// create an instance of Finland country
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
        private Finland(
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
