namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Mongolia country
    /// </summary>
    public class Mongolia : Country
    {
        /// <summary>
        /// get the Mongolia country instance
        /// </summary>
        public static Mongolia Instance = new Mongolia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Mongolia", common: "Mongolia") },
                { "mon", new CountryName(official: "Монгол улс", common: "Монгол улс") },
                { "ara", new CountryName(official: "جمهورية منغوليا", common: "منغوليا") },
                { "ces", new CountryName(official: "Stát Mongolsko", common: "Mongolsko") },
                { "cym", new CountryName(official: "Mongolia", common: "Mongolia") },
                { "deu", new CountryName(official: "Mongolei", common: "Mongolei") },
                { "est", new CountryName(official: "Mongoolia", common: "Mongoolia") },
                { "fin", new CountryName(official: "Mongolian tasavalta", common: "Mongolia") },
                { "fra", new CountryName(official: "Mongolie", common: "Mongolie") },
                { "hrv", new CountryName(official: "Mongolija", common: "Mongolija") },
                { "hun", new CountryName(official: "Mongólia", common: "Mongólia") },
                { "ita", new CountryName(official: "Mongolia", common: "Mongolia") },
                { "jpn", new CountryName(official: "モンゴル", common: "モンゴル") },
                { "kor", new CountryName(official: "몽골", common: "몽골국") },
                { "nld", new CountryName(official: "Mongolië", common: "Mongolië") },
                { "per", new CountryName(official: "مغولستان", common: "مغولستان") },
                { "pol", new CountryName(official: "Mongolia", common: "Mongolia") },
                { "por", new CountryName(official: "Mongólia", common: "Mongólia") },
                { "rus", new CountryName(official: "Монголия", common: "Монголия") },
                { "slk", new CountryName(official: "Mongolsko", common: "Mongolsko") },
                { "spa", new CountryName(official: "Mongolia", common: "Mongolia") },
                { "swe", new CountryName(official: "Mongoliet", common: "Mongoliet") },
                { "urd", new CountryName(official: "منگولیا", common: "منگولیا") },
                { "zho", new CountryName(official: "蒙古", common: "蒙古") },
            },
            cca2: "MN",
            cca3: "MNG",
            ccn3: "496",
            cioc: "MGL",
            flag: "🇲🇳",
            region: Region.Asia,
            subregion: "Eastern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"76", }),
            borders: new string[] { "CHN", "RUS",  },
            capital: new string[] { "Ulan Bator",  },
            altSpellings: new string[] { "MN",  },
            tld: new string[] { ".mn",  },
            latlng: new double[] { 46, 105,  },
            timezones: new string[] { "UTC+07:00", "UTC+08:00",  },
            languages: new Language[]
            {
                new Language(name: "Mongolian", iso6391: "mn", iso6392: "mon"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "MNT", name: "Mongolian tögrög", symbol: "₮"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Mongolian", female: "Mongolian") },
                { "fra", new DemonymsGender(male: "Mongolian", female: "Mongolian") },
            }
        );

        /// <summary>
        /// create an instance of Mongolia country
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
        private Mongolia(
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
