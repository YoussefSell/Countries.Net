namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Bulgaria country
    /// </summary>
    public class Bulgaria : Country
    {
        /// <summary>
        /// get the Bulgaria country instance
        /// </summary>
        public static Bulgaria Instance = new Bulgaria(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Bulgaria", common: "Bulgaria") },
                { "bul", new CountryName(official: "Република България", common: "България") },
                { "ara", new CountryName(official: "جمهورية بلغاريا", common: "بلغاريا") },
                { "ces", new CountryName(official: "Bulharská republika", common: "Bulharsko") },
                { "cym", new CountryName(official: "Gweriniaeth Bwlgaria", common: "Bwlgaria") },
                { "deu", new CountryName(official: "Republik Bulgarien", common: "Bulgarien") },
                { "est", new CountryName(official: "Bulgaaria Vabariik", common: "Bulgaaria") },
                { "fin", new CountryName(official: "Bulgarian tasavalta", common: "Bulgaria") },
                { "fra", new CountryName(official: "République de Bulgarie", common: "Bulgarie") },
                { "hrv", new CountryName(official: "Republika Bugarska", common: "Bugarska") },
                { "hun", new CountryName(official: "Bolgár Köztársaság", common: "Bulgária") },
                { "ita", new CountryName(official: "Repubblica di Bulgaria", common: "Bulgaria") },
                { "jpn", new CountryName(official: "ブルガリア共和国", common: "ブルガリア") },
                { "kor", new CountryName(official: "불가리아 공화국", common: "불가리아") },
                { "nld", new CountryName(official: "Republiek Bulgarije", common: "Bulgarije") },
                { "per", new CountryName(official: "جمهوری بلغارستان", common: "بلغارستان") },
                { "pol", new CountryName(official: "Republika Bułgarii", common: "Bułgaria") },
                { "por", new CountryName(official: "República da Bulgária", common: "Bulgária") },
                { "rus", new CountryName(official: "Республика Болгария", common: "Болгария") },
                { "slk", new CountryName(official: "Bulharská republika", common: "Bulharsko") },
                { "spa", new CountryName(official: "República de Bulgaria", common: "Bulgaria") },
                { "swe", new CountryName(official: "Republiken Bulgarien", common: "Bulgarien") },
                { "urd", new CountryName(official: "جمہوریہ بلغاریہ", common: "بلغاریہ") },
                { "zho", new CountryName(official: "保加利亚共和国", common: "保加利亚") },
            },
            cca2: "BG",
            cca3: "BGR",
            ccn3: "100",
            cioc: "BUL",
            flag: "🇧🇬",
            region: Region.Europe,
            subregion: "Southeast Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"59", }),
            borders: new string[] { "GRC", "MKD", "ROU", "SRB", "TUR",  },
            capital: new string[] { "Sofia",  },
            altSpellings: new string[] { "BG", "Republic of Bulgaria", "Република България",  },
            tld: new string[] { ".bg",  },
            latlng: new double[] { 43, 25,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Bulgarian", iso6391: "bg", iso6392: "bul"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "BGN", name: "Bulgarian lev", symbol: "лв"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Bulgarian", female: "Bulgarian") },
                { "fra", new DemonymsGender(male: "Bulgarian", female: "Bulgarian") },
            }
        );

        /// <summary>
        /// create an instance of Bulgaria country
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
        private Bulgaria(
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
