namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Denmark country
    /// </summary>
    public class Denmark : Country
    {
        /// <summary>
        /// get the Denmark country instance
        /// </summary>
        public static Denmark Instance = new Denmark(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Kingdom of Denmark", common: "Denmark") },
                { "dan", new CountryName(official: "Kongeriget Danmark", common: "Danmark") },
                { "ara", new CountryName(official: "مملكة الدنمارك", common: "الدنمارك") },
                { "ces", new CountryName(official: "Dánské království", common: "Dánsko") },
                { "cym", new CountryName(official: "Teyrnas Denmarc", common: "Denmarc") },
                { "deu", new CountryName(official: "Königreich Dänemark", common: "Dänemark") },
                { "est", new CountryName(official: "Taani Kuningriik", common: "Taani") },
                { "fin", new CountryName(official: "Tanskan kuningaskunta", common: "Tanska") },
                { "fra", new CountryName(official: "Royaume du Danemark", common: "Danemark") },
                { "hrv", new CountryName(official: "Kraljevina Danska", common: "Danska") },
                { "hun", new CountryName(official: "Dán Királyság", common: "Dánia") },
                { "ita", new CountryName(official: "Regno di Danimarca", common: "Danimarca") },
                { "jpn", new CountryName(official: "デンマーク王国", common: "デンマーク") },
                { "kor", new CountryName(official: "덴마크 왕국", common: "덴마크") },
                { "nld", new CountryName(official: "Koninkrijk Denemarken", common: "Denemarken") },
                { "per", new CountryName(official: "پادشاهی دانمارک", common: "دانمارک") },
                { "pol", new CountryName(official: "Królestwo Danii", common: "Dania") },
                { "por", new CountryName(official: "Reino da Dinamarca", common: "Dinamarca") },
                { "rus", new CountryName(official: "Королевство Дания", common: "Дания") },
                { "slk", new CountryName(official: "Dánske kráľovstvo", common: "Dánsko") },
                { "spa", new CountryName(official: "Reino de Dinamarca", common: "Dinamarca") },
                { "swe", new CountryName(official: "Konungariket Danmark", common: "Danmark") },
                { "urd", new CountryName(official: "مملکتِ ڈنمارک", common: "ڈنمارک") },
                { "zho", new CountryName(official: "丹麦王国", common: "丹麦") },
            },
            cca2: "DK",
            cca3: "DNK",
            ccn3: "208",
            cioc: "DEN",
            flag: "🇩🇰",
            region: Region.Europe,
            subregion: "Northern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"5", }),
            borders: new string[] { "DEU",  },
            capital: new string[] { "Copenhagen",  },
            altSpellings: new string[] { "DK", "Danmark", "Kingdom of Denmark", "Kongeriget Danmark",  },
            tld: new string[] { ".dk",  },
            latlng: new double[] { 56, 10,  },
            timezones: new string[] { "UTC-04:00", "UTC-03:00", "UTC-01:00", "UTC", "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Danish", iso6391: "da", iso6392: "dan"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "DKK", name: "Danish krone", symbol: "kr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Danish", female: "Danish") },
                { "fra", new DemonymsGender(male: "Danish", female: "Danish") },
            }
        );

        /// <summary>
        /// create an instance of Denmark country
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
        private Denmark(
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
