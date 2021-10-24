namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Montenegro country
    /// </summary>
    public class Montenegro : Country
    {
        /// <summary>
        /// get the Montenegro country instance
        /// </summary>
        public static Montenegro Instance = new Montenegro(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Montenegro", common: "Montenegro") },
                { "cnr", new CountryName(official: "Црна Гора", common: "Црна Гора") },
                { "ara", new CountryName(official: "الجبل الاسود", common: "الجبل الاسود") },
                { "ces", new CountryName(official: "Černá Hora", common: "Černá Hora") },
                { "cym", new CountryName(official: "Montenegro", common: "Montenegro") },
                { "deu", new CountryName(official: "Montenegro", common: "Montenegro") },
                { "est", new CountryName(official: "Montenegro", common: "Montenegro") },
                { "fin", new CountryName(official: "Montenegro", common: "Montenegro") },
                { "fra", new CountryName(official: "Monténégro", common: "Monténégro") },
                { "hrv", new CountryName(official: "Crna Gora", common: "Crna Gora") },
                { "hun", new CountryName(official: "Montenegró", common: "Montenegró") },
                { "ita", new CountryName(official: "Montenegro", common: "Montenegro") },
                { "jpn", new CountryName(official: "モンテネグロ", common: "モンテネグロ") },
                { "kor", new CountryName(official: "몬테네그로", common: "몬테네그로") },
                { "nld", new CountryName(official: "Montenegro", common: "Montenegro") },
                { "per", new CountryName(official: "مونته‌نگرو", common: "مونته‌نگرو") },
                { "pol", new CountryName(official: "Czarnogóra", common: "Czarnogóra") },
                { "por", new CountryName(official: "Montenegro", common: "Montenegro") },
                { "rus", new CountryName(official: "Черногория", common: "Черногория") },
                { "slk", new CountryName(official: "Čierna Hora", common: "Čierna Hora") },
                { "spa", new CountryName(official: "Montenegro", common: "Montenegro") },
                { "swe", new CountryName(official: "Montenegro", common: "Montenegro") },
                { "urd", new CountryName(official: "مونٹینیگرو", common: "مونٹینیگرو") },
                { "zho", new CountryName(official: "黑山", common: "黑山") },
            },
            cca2: "ME",
            cca3: "MNE",
            ccn3: "499",
            cioc: "MNE",
            flag: "🇲🇪",
            region: Region.Europe,
            subregion: "Southeast Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"82", }),
            borders: new string[] { "ALB", "BIH", "HRV", "UNK", "SRB",  },
            capital: new string[] { "Podgorica",  },
            altSpellings: new string[] { "ME", "Crna Gora",  },
            tld: new string[] { ".me",  },
            latlng: new double[] { 42.5, 19.3,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Montenegrin", iso6391: "", iso6392: "cnr"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Montenegrin", female: "Montenegrin") },
                { "fra", new DemonymsGender(male: "Montenegrin", female: "Montenegrin") },
            }
        );

        /// <summary>
        /// create an instance of Montenegro country
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
        private Montenegro(
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
