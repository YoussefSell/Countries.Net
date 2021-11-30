namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Afghanistan country
    /// </summary>
    public class Afghanistan : Country
    {
        /// <summary>
        /// get the Afghanistan country instance
        /// </summary>
        public static Afghanistan Instance = new Afghanistan(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Islamic Republic of Afghanistan", common: "Afghanistan") },
                { "prs", new CountryName(official: "جمهوری اسلامی افغانستان", common: "افغانستان") },
                { "pus", new CountryName(official: "د افغانستان اسلامي جمهوریت", common: "افغانستان") },
                { "tuk", new CountryName(official: "Owganystan Yslam Respublikasy", common: "Owganystan") },
                { "ara", new CountryName(official: "جمهورية أففانستان الإسلامية", common: "أفغانستان") },
                { "ces", new CountryName(official: "Afghánská islámská republika", common: "Afghánistán") },
                { "cym", new CountryName(official: "Gweriniaeth Islamaidd Affganistan", common: "Affganistan") },
                { "deu", new CountryName(official: "Islamische Republik Afghanistan", common: "Afghanistan") },
                { "est", new CountryName(official: "Afganistani Islamivabariik", common: "Afganistan") },
                { "fin", new CountryName(official: "Afganistanin islamilainen tasavalta", common: "Afganistan") },
                { "fra", new CountryName(official: "République islamique d'Afghanistan", common: "Afghanistan") },
                { "hrv", new CountryName(official: "Islamska Republika Afganistan", common: "Afganistan") },
                { "hun", new CountryName(official: "Afganisztáni Iszlám Köztársaság", common: "Afganisztán") },
                { "ita", new CountryName(official: "Repubblica islamica dell'Afghanistan", common: "Afghanistan") },
                { "jpn", new CountryName(official: "アフガニスタン·イスラム共和国", common: "アフガニスタン") },
                { "kor", new CountryName(official: "아프가니스탄 이슬람 공화국", common: "아프가니스탄") },
                { "nld", new CountryName(official: "Islamitische Republiek Afghanistan", common: "Afghanistan") },
                { "per", new CountryName(official: "جمهوری اسلامی افغانستان", common: "افغانستان") },
                { "pol", new CountryName(official: "Islamska Republika Afganistanu", common: "Afganistan") },
                { "por", new CountryName(official: "República Islâmica do Afeganistão", common: "Afeganistão") },
                { "rus", new CountryName(official: "Исламская Республика Афганистан", common: "Афганистан") },
                { "slk", new CountryName(official: "Afgánsky islamský štát", common: "Afganistan") },
                { "spa", new CountryName(official: "República Islámica de Afganistán", common: "Afganistán") },
                { "swe", new CountryName(official: "Islamiska republiken Afghanistan", common: "Afghanistan") },
                { "urd", new CountryName(official: "اسلامی جمہوریہ افغانستان", common: "افغانستان") },
                { "zho", new CountryName(official: "阿富汗伊斯兰共和国", common: "阿富汗") },
            },
            cca2: "AF",
            cca3: "AFG",
            ccn3: "004",
            cioc: "AFG",
            flag: "🇦🇫",
            region: Region.Asia,
            subregion: "Southern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"3", }),
            borders: new string[] { "IRN", "PAK", "TKM", "UZB", "TJK", "CHN",  },
            capital: new string[] { "Kabul",  },
            altSpellings: new string[] { "AF", "Afġānistān",  },
            tld: new string[] { ".af",  },
            latlng: new double[] { 33, 65,  },
            timezones: new string[] { "UTC+04:30",  },
            languages: new Language[]
            {
                new Language(name: "Dari", iso6391: "prs", iso6392: "prs"),
                new Language(name: "Pashto", iso6391: "ps", iso6392: "pus"),
                new Language(name: "Turkmen", iso6391: "tk", iso6392: "tuk"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "AFN", name: "Afghan afghani", symbol: "؋"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Afghan", female: "Afghan") },
                { "fra", new DemonymsGender(male: "Afghan", female: "Afghan") },
            }
        );

        /// <summary>
        /// create an instance of Afghanistan country
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
        private Afghanistan(
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
