namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Indonesia country
    /// </summary>
    public class Indonesia : Country
    {
        /// <summary>
        /// get the Indonesia country instance
        /// </summary>
        public static Indonesia Instance = new Indonesia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Indonesia", common: "Indonesia") },
                { "ind", new CountryName(official: "Republik Indonesia", common: "Indonesia") },
                { "ara", new CountryName(official: "جمهورية إندونيسيا", common: "إندونيسيا") },
                { "ces", new CountryName(official: "Indonéská republika", common: "Indonésie") },
                { "cym", new CountryName(official: "Republic of Indonesia", common: "Indonesia") },
                { "deu", new CountryName(official: "Republik Indonesien", common: "Indonesien") },
                { "est", new CountryName(official: "Indoneesia Vabariik", common: "Indoneesia") },
                { "fin", new CountryName(official: "Indonesian tasavalta", common: "Indonesia") },
                { "fra", new CountryName(official: "République d'Indonésie", common: "Indonésie") },
                { "hrv", new CountryName(official: "Republika Indonezija", common: "Indonezija") },
                { "hun", new CountryName(official: "Indonéz Köztársaság", common: "Indonézia") },
                { "ita", new CountryName(official: "Repubblica di Indonesia", common: "Indonesia") },
                { "jpn", new CountryName(official: "インドネシア共和国", common: "インドネシア") },
                { "kor", new CountryName(official: "인도네시아 공화국", common: "인도네시아") },
                { "nld", new CountryName(official: "Republiek Indonesië", common: "Indonesië") },
                { "per", new CountryName(official: "جمهوری اندونزی", common: "اندونزی") },
                { "pol", new CountryName(official: "Republika Indonezji", common: "Indonezja") },
                { "por", new CountryName(official: "República da Indonésia", common: "Indonésia") },
                { "rus", new CountryName(official: "Республика Индонезия", common: "Индонезия") },
                { "slk", new CountryName(official: "Indonézska republika", common: "Indonézia") },
                { "spa", new CountryName(official: "República de Indonesia", common: "Indonesia") },
                { "swe", new CountryName(official: "Republiken Indonesien", common: "Indonesien") },
                { "urd", new CountryName(official: "جمہوریہ انڈونیشیا", common: "انڈونیشیا") },
                { "zho", new CountryName(official: "印度尼西亚共和国", common: "印度尼西亚") },
            },
            cca2: "ID",
            cca3: "IDN",
            ccn3: "360",
            cioc: "INA",
            flag: "🇮🇩",
            region: Region.Asia,
            subregion: "South-Eastern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"2", }),
            borders: new string[] { "TLS", "MYS", "PNG",  },
            capital: new string[] { "Jakarta",  },
            altSpellings: new string[] { "ID", "Republic of Indonesia", "Republik Indonesia",  },
            tld: new string[] { ".id",  },
            latlng: new double[] { -5, 120,  },
            timezones: new string[] { "UTC+07:00", "UTC+08:00", "UTC+09:00",  },
            languages: new Language[]
            {
                new Language(name: "Indonesian", iso6391: "id", iso6392: "ind"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "IDR", name: "Indonesian rupiah", symbol: "Rp"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Indonesian", female: "Indonesian") },
                { "fra", new DemonymsGender(male: "Indonesian", female: "Indonesian") },
            }
        );

        /// <summary>
        /// create an instance of Indonesia country
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
        private Indonesia(
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
