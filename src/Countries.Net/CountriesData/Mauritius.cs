namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Mauritius country
    /// </summary>
    public class Mauritius : Country
    {
        /// <summary>
        /// get the Mauritius country instance
        /// </summary>
        public static Mauritius Instance = new Mauritius(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Mauritius", common: "Mauritius") },
                { "fra", new CountryName(official: "République de Maurice", common: "Maurice") },
                { "mfe", new CountryName(official: "Republik Moris", common: "Moris") },
                { "ara", new CountryName(official: "جمهورية موريشيوس", common: "موريشيوس") },
                { "ces", new CountryName(official: "Mauricijská republika", common: "Mauricius") },
                { "cym", new CountryName(official: "Republic of Mauritius", common: "Mauritius") },
                { "deu", new CountryName(official: "Republik Mauritius", common: "Mauritius") },
                { "est", new CountryName(official: "Mauritiuse Vabariik", common: "Mauritius") },
                { "fin", new CountryName(official: "Mauritiuksen tasavalta", common: "Mauritius") },
                { "hrv", new CountryName(official: "Republika Mauricijus", common: "Mauricijus") },
                { "hun", new CountryName(official: "Mauritiusi Köztársaság", common: "Mauritius") },
                { "ita", new CountryName(official: "Repubblica di Mauritius", common: "Mauritius") },
                { "jpn", new CountryName(official: "モーリシャス共和国", common: "モーリシャス") },
                { "kor", new CountryName(official: "모리셔스 공화국", common: "모리셔스") },
                { "nld", new CountryName(official: "Republiek Mauritius", common: "Mauritius") },
                { "per", new CountryName(official: "جمهوری موریس", common: "موریس") },
                { "pol", new CountryName(official: "Republika Mauritiusu", common: "Mauritius") },
                { "por", new CountryName(official: "República das Maurícias", common: "Maurício") },
                { "rus", new CountryName(official: "Республика Маврикий", common: "Маврикий") },
                { "slk", new CountryName(official: "Maurícijská republika", common: "Maurícius") },
                { "spa", new CountryName(official: "República de Mauricio", common: "Mauricio") },
                { "swe", new CountryName(official: "Republiken Mauritius", common: "Mauritius") },
                { "urd", new CountryName(official: "جمہوریہ موریشس", common: "موریشس") },
                { "zho", new CountryName(official: "毛里求斯共和国", common: "毛里求斯") },

            },
            cca2: "MU",
            cca3: "MUS",
            ccn3: "480",
            cioc: "MRI",
            flag: "🇲🇺",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"30", }),
            borders: new string[] {  },
            capital: new string[] { "Port Louis",  },
            altSpellings: new string[] { "MU", "Republic of Mauritius", "République de Maurice",  },
            tld: new string[] { ".mu",  },
            latlng: new double[] { -20.28333333, 57.55,  },
            timezones: new string[] { "UTC+04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
                new Language(name: "Mauritian Creole", iso6391: "mfe", iso6392: "mfe"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "MUR", name: "Mauritian rupee", symbol: "₨"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Mauritian", female: "Mauritian") },
                { "fra", new DemonymsGender(male: "Mauritian", female: "Mauritian") },
            }
        );

        /// <summary>
        /// create an instance of Mauritius country
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
        private Mauritius(
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
