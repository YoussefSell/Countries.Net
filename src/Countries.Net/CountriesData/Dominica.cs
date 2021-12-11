namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Dominica country
    /// </summary>
    public class Dominica : Country
    {
        /// <summary>
        /// get the Dominica country instance
        /// </summary>
        public static Dominica Instance = new Dominica(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Commonwealth of Dominica", common: "Dominica") },
                { "ara", new CountryName(official: "كومونولث دومينيكا", common: "دومينيكا") },
                { "ces", new CountryName(official: "Dominikánské společenství", common: "Dominika") },
                { "cym", new CountryName(official: "Cymanwlad Dominica", common: "Dominica") },
                { "deu", new CountryName(official: "Commonwealth von Dominica", common: "Dominica") },
                { "est", new CountryName(official: "Dominica Ühendus", common: "Dominica") },
                { "fin", new CountryName(official: "Dominican liittovaltio", common: "Dominica") },
                { "fra", new CountryName(official: "Commonwealth de la Dominique", common: "Dominique") },
                { "hrv", new CountryName(official: "Zajednica Dominika", common: "Dominika") },
                { "hun", new CountryName(official: "Dominikai Közösség", common: "Dominikai Közösség") },
                { "ita", new CountryName(official: "Commonwealth di Dominica", common: "Dominica") },
                { "jpn", new CountryName(official: "ドミニカ国", common: "ドミニカ国") },
                { "kor", new CountryName(official: "도미니카 공화국", common: "도미니카 공화국") },
                { "nld", new CountryName(official: "Gemenebest Dominica", common: "Dominica") },
                { "per", new CountryName(official: "قلمرو همسود دومینیکا", common: "دومینیکا") },
                { "pol", new CountryName(official: "Wspólnota Dominiki", common: "Dominika") },
                { "por", new CountryName(official: "Comunidade da Dominica", common: "Dominica") },
                { "rus", new CountryName(official: "Содружество Доминики", common: "Доминика") },
                { "slk", new CountryName(official: "Dominické spoločenstvo", common: "Dominika") },
                { "spa", new CountryName(official: "Mancomunidad de Dominica", common: "Dominica") },
                { "swe", new CountryName(official: "Samväldet Dominica", common: "Dominica") },
                { "urd", new CountryName(official: "دولتِ مشترکہ ڈومینیکا", common: "ڈومینیکا") },
                { "zho", new CountryName(official: "多米尼加共和国", common: "多米尼加") },
            },
            cca2: "DM",
            cca3: "DMA",
            ccn3: "212",
            cioc: "DMA",
            flag: "🇩🇲",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"767", }),
            borders: new string[] {  },
            capital: new string[] { "Roseau",  },
            altSpellings: new string[] { "DM", "Dominique", "Wai‘tu kubuli", "Commonwealth of Dominica",  },
            tld: new string[] { ".dm",  },
            latlng: new double[] { 15.41666666, -61.33333333,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XCD", name: "Eastern Caribbean dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Dominican", female: "Dominican") },
                { "fra", new DemonymsGender(male: "Dominican", female: "Dominican") },
            }
        );

        /// <summary>
        /// create an instance of Dominica country
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
        private Dominica(
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
