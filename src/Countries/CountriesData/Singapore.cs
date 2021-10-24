namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Singapore country
    /// </summary>
    public class Singapore : Country
    {
        /// <summary>
        /// get the Singapore country instance
        /// </summary>
        public static Singapore Instance = new Singapore(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Singapore", common: "Singapore") },
                { "zho", new CountryName(official: "新加坡共和国", common: "新加坡") },
                { "msa", new CountryName(official: "Republik Singapura", common: "Singapura") },
                { "tam", new CountryName(official: "சிங்கப்பூர் குடியரசு", common: "சிங்கப்பூர்") },
                { "ara", new CountryName(official: "جمهورية سنغافورة", common: "سنغافورة") },
                { "ces", new CountryName(official: "Singapurská republika", common: "Singapur") },
                { "cym", new CountryName(official: "Republic of Singapore", common: "Singapore") },
                { "deu", new CountryName(official: "Republik Singapur", common: "Singapur") },
                { "est", new CountryName(official: "Singapuri Vabariik", common: "Singapur") },
                { "fin", new CountryName(official: "Singaporen tasavalta", common: "Singapore") },
                { "fra", new CountryName(official: "République de Singapour", common: "Singapour") },
                { "hrv", new CountryName(official: "Republika Singapur", common: "Singapur") },
                { "hun", new CountryName(official: "Szingapúri Köztársaság", common: "Szingapúr") },
                { "ita", new CountryName(official: "Repubblica di Singapore", common: "Singapore") },
                { "jpn", new CountryName(official: "シンガポール共和国", common: "シンガポール") },
                { "kor", new CountryName(official: "싱가포르 공화국", common: "싱가포르") },
                { "nld", new CountryName(official: "Republiek Singapore", common: "Singapore") },
                { "per", new CountryName(official: "جمهوری سنگاپور", common: "سنگاپور") },
                { "pol", new CountryName(official: "Republika Singapuru", common: "Singapur") },
                { "por", new CountryName(official: "República de Singapura", common: "Singapura") },
                { "rus", new CountryName(official: "Республика Сингапур", common: "Сингапур") },
                { "slk", new CountryName(official: "Singapurská republika", common: "Singapur") },
                { "spa", new CountryName(official: "República de Singapur", common: "Singapur") },
                { "swe", new CountryName(official: "Republiken Singapore", common: "Singapore") },
                { "urd", new CountryName(official: "جمہوریہ سنگاپور", common: "سنگاپور") },
            },
            cca2: "SG",
            cca3: "SGP",
            ccn3: "702",
            cioc: "SGP",
            flag: "🇸🇬",
            region: Region.Asia,
            subregion: "South-Eastern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"5", }),
            borders: new string[] {  },
            capital: new string[] { "Singapore",  },
            altSpellings: new string[] { "SG", "Singapura", "Republik Singapura", "新加坡共和国",  },
            tld: new string[] { ".sg", ".新加坡", ".சிங்கப்பூர்",  },
            latlng: new double[] { 1.36666666, 103.8,  },
            timezones: new string[] { "UTC+08:00",  },
            languages: new Language[]
            {
                new Language(name: "Chinese", iso6391: "zh", iso6392: "zho"),
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Malay", iso6391: "ms", iso6392: "msa"),
                new Language(name: "Tamil", iso6391: "ta", iso6392: "tam"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "SGD", name: "Singapore dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Singaporean", female: "Singaporean") },
                { "fra", new DemonymsGender(male: "Singaporean", female: "Singaporean") },
            }
        );

        /// <summary>
        /// create an instance of Singapore country
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
        private Singapore(
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
