namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Philippines country
    /// </summary>
    public class Philippines : Country
    {
        /// <summary>
        /// get the Philippines country instance
        /// </summary>
        public static Philippines Instance = new Philippines(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of the Philippines", common: "Philippines") },
                { "fil", new CountryName(official: "Republic of the Philippines", common: "Pilipinas") },
                { "ara", new CountryName(official: "جمهورية الفلبين", common: "الفلبين") },
                { "ces", new CountryName(official: "Filipínská republika", common: "Filipíny") },
                { "cym", new CountryName(official: "Republic of the Philippines", common: "Philippines") },
                { "deu", new CountryName(official: "Republik der Philippinen", common: "Philippinen") },
                { "est", new CountryName(official: "Filipiini Vabariik", common: "Filipiinid") },
                { "fin", new CountryName(official: "Filippiinien tasavalta", common: "Filippiinit") },
                { "fra", new CountryName(official: "République des Philippines", common: "Philippines") },
                { "hrv", new CountryName(official: "Republika Filipini", common: "Filipini") },
                { "hun", new CountryName(official: "Fülöp-szigeteki Köztársaság", common: "Fülöp-szigetek") },
                { "ita", new CountryName(official: "Repubblica delle Filippine", common: "Filippine") },
                { "jpn", new CountryName(official: "フィリピン共和国", common: "フィリピン") },
                { "kor", new CountryName(official: "필리핀 공화국", common: "필리핀") },
                { "nld", new CountryName(official: "Republiek der Filipijnen", common: "Filipijnen") },
                { "per", new CountryName(official: "جمهوری فیلیپین", common: "فیلیپین") },
                { "pol", new CountryName(official: "Republika Filipin", common: "Filipiny") },
                { "por", new CountryName(official: "República das Filipinas", common: "Filipinas") },
                { "rus", new CountryName(official: "Республика Филиппины", common: "Филиппины") },
                { "slk", new CountryName(official: "Filipínska republika", common: "Filipíny") },
                { "spa", new CountryName(official: "República de las Filipinas", common: "Filipinas") },
                { "swe", new CountryName(official: "Republiken Filippinerna", common: "Filippinerna") },
                { "urd", new CountryName(official: "جمہوریہ فلپائن", common: "فلپائن") },
                { "zho", new CountryName(official: "菲律宾共和国", common: "菲律宾") },
            },
            cca2: "PH",
            cca3: "PHL",
            ccn3: "608",
            cioc: "PHI",
            flag: "🇵🇭",
            region: Region.Asia,
            subregion: "South-Eastern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"3", }),
            borders: new string[] {  },
            capital: new string[] { "Manila",  },
            altSpellings: new string[] { "PH", "Republic of the Philippines", "Repúblika ng Pilipinas",  },
            tld: new string[] { ".ph",  },
            latlng: new double[] { 13, 122,  },
            timezones: new string[] { "UTC+08:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Filipino", iso6391: "fil", iso6392: "fil"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "PHP", name: "Philippine peso", symbol: "₱"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Filipino", female: "Filipino") },
                { "fra", new DemonymsGender(male: "Filipino", female: "Filipino") },
            }
        );

        /// <summary>
        /// create an instance of Philippines country
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
        private Philippines(
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
