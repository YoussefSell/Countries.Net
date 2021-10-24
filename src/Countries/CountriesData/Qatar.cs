namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Qatar country
    /// </summary>
    public class Qatar : Country
    {
        /// <summary>
        /// get the Qatar country instance
        /// </summary>
        public static Qatar Instance = new Qatar(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "State of Qatar", common: "Qatar") },
                { "ara", new CountryName(official: "دولة قطر", common: "قطر") },
                { "ces", new CountryName(official: "Stát Katar", common: "Katar") },
                { "cym", new CountryName(official: "State of Qatar", common: "Qatar") },
                { "deu", new CountryName(official: "Staat Katar", common: "Katar") },
                { "est", new CountryName(official: "Katari Riik", common: "Katar") },
                { "fin", new CountryName(official: "Qatarin valtio", common: "Qatar") },
                { "fra", new CountryName(official: "État du Qatar", common: "Qatar") },
                { "hrv", new CountryName(official: "Država Katar", common: "Katar") },
                { "hun", new CountryName(official: "Katari Állam", common: "Katar") },
                { "ita", new CountryName(official: "Stato del Qatar", common: "Qatar") },
                { "jpn", new CountryName(official: "カタール国", common: "カタール") },
                { "kor", new CountryName(official: "카타르국", common: "카타르") },
                { "nld", new CountryName(official: "Staat Qatar", common: "Qatar") },
                { "per", new CountryName(official: "دولت قطر", common: "قطر") },
                { "pol", new CountryName(official: "Państwo Katar", common: "Katar") },
                { "por", new CountryName(official: "Estado do Qatar", common: "Catar") },
                { "rus", new CountryName(official: "Государство Катар", common: "Катар") },
                { "slk", new CountryName(official: "Katarský štát", common: "Katar") },
                { "spa", new CountryName(official: "Estado de Qatar", common: "Catar") },
                { "swe", new CountryName(official: "Staten Qatar", common: "Qatar") },
                { "urd", new CountryName(official: "ریاستِ قطر", common: "قطر") },
                { "zho", new CountryName(official: "卡塔尔国", common: "卡塔尔") },

            },
            cca2: "QA",
            cca3: "QAT",
            ccn3: "634",
            cioc: "QAT",
            flag: "🇶🇦",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"74", }),
            borders: new string[] { "SAU",  },
            capital: new string[] { "Doha",  },
            altSpellings: new string[] { "QA", "State of Qatar", "Dawlat Qaṭar",  },
            tld: new string[] { ".qa", "قطر.",  },
            latlng: new double[] { 25.5, 51.25,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "QAR", name: "Qatari riyal", symbol: "ر.ق"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Qatari", female: "Qatari") },
                { "fra", new DemonymsGender(male: "Qatari", female: "Qatari") },
            }
        );

        /// <summary>
        /// create an instance of Qatar country
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
        private Qatar(
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
