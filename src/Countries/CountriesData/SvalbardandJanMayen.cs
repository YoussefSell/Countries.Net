namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of SvalbardandJanMayen country
    /// </summary>
    public class SvalbardandJanMayen : Country
    {
        /// <summary>
        /// get the SvalbardandJanMayen country instance
        /// </summary>
        public static SvalbardandJanMayen Instance = new SvalbardandJanMayen(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Svalbard og Jan Mayen", common: "Svalbard and Jan Mayen") },
                { "nor", new CountryName(official: "Svalbard og Jan Mayen", common: "Svalbard og Jan Mayen") },
                { "ara", new CountryName(official: "سفالبارد ويان ماين", common: "سفالبارد ويان ماين") },
                { "ces", new CountryName(official: "Špicberky a Jan Mayen", common: "Špicberky a Jan Mayen") },
                { "cym", new CountryName(official: "Svalbard og Jan Mayen", common: "Svalbard and Jan Mayen") },
                { "deu", new CountryName(official: "Spitzbergen und Jan Mayen", common: "Spitzbergen und Jan Mayen") },
                { "est", new CountryName(official: "Svalbard", common: "Svalbard") },
                { "fin", new CountryName(official: "Huippuvuoret", common: "Huippuvuoret") },
                { "fra", new CountryName(official: "Jan Mayen Svalbard", common: "Svalbard et Jan Mayen") },
                { "hrv", new CountryName(official: "Svalbard og Jan Mayen", common: "Svalbard i Jan Mayen") },
                { "hun", new CountryName(official: "Svalbard és Jan Mayen", common: "Svalbard és Jan Mayen") },
                { "ita", new CountryName(official: "Svalbard og Jan Mayen", common: "Svalbard e Jan Mayen") },
                { "jpn", new CountryName(official: "スバールバル諸島OGヤンマイエン", common: "スヴァールバル諸島およびヤンマイエン島") },
                { "kor", new CountryName(official: "스발바르 얀마옌 제도", common: "스발바르 얀마옌 제도") },
                { "nld", new CountryName(official: "Svalbard og Jan Mayen", common: "Svalbard en Jan Mayen") },
                { "per", new CountryName(official: "سوالبارد و یان ماین", common: "سوالبارد و یان ماین") },
                { "pol", new CountryName(official: "Svalbard i Jan Mayen", common: "Svalbard i Jan Mayen") },
                { "por", new CountryName(official: "Svalbard og Jan Mayen", common: "Ilhas Svalbard e Jan Mayen") },
                { "rus", new CountryName(official: "Свальбарда ог Ян-Майен", common: "Шпицберген и Ян-Майен") },
                { "slk", new CountryName(official: "Svalbard a Jan Mayen", common: "Svalbard a Jan Mayen") },
                { "spa", new CountryName(official: "Svalbard og Jan Mayen", common: "Islas Svalbard y Jan Mayen") },
                { "swe", new CountryName(official: "Svalbard och Jan Mayen", common: "Svalbard och Jan Mayen") },
                { "urd", new CountryName(official: "سوالبارڈ اور جان میئن", common: "سوالبارڈ اور جان میئن") },
                { "zho", new CountryName(official: "斯瓦尔巴特", common: "斯瓦尔巴特") },
            },
            cca2: "SJ",
            cca3: "SJM",
            ccn3: "744",
            cioc: "",
            flag: "🇸🇯",
            region: Region.Europe,
            subregion: "Northern Europe",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"779", }),
            borders: new string[] {  },
            capital: new string[] { "Longyearbyen",  },
            altSpellings: new string[] { "SJ", "Svalbard and Jan Mayen Islands",  },
            tld: new string[] { ".sj",  },
            latlng: new double[] { 78, 20,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Norwegian", iso6391: "", iso6392: "nor"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "NOK", name: "krone", symbol: "kr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Norwegian", female: "Norwegian") },
                { "fra", new DemonymsGender(male: "Norwegian", female: "Norwegian") },
            }
        );

        /// <summary>
        /// create an instance of SvalbardandJanMayen country
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
        private SvalbardandJanMayen(
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
