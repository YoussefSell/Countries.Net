namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Hungary country
    /// </summary>
    public class Hungary : Country
    {
        /// <summary>
        /// get the Hungary country instance
        /// </summary>
        public static Hungary Instance = new Hungary(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Hungary", common: "Hungary") },
                { "hun", new CountryName(official: "Magyarország", common: "Magyarország") },
                { "ara", new CountryName(official: "الجمهورية المجرية", common: "المجر") },
                { "ces", new CountryName(official: "Maďarsko", common: "Maďarsko") },
                { "cym", new CountryName(official: "Hungary", common: "Hungary") },
                { "deu", new CountryName(official: "Ungarn", common: "Ungarn") },
                { "est", new CountryName(official: "Ungari", common: "Ungari") },
                { "fin", new CountryName(official: "Unkari", common: "Unkari") },
                { "fra", new CountryName(official: "Hongrie", common: "Hongrie") },
                { "hrv", new CountryName(official: "Madžarska", common: "Mađarska") },
                { "ita", new CountryName(official: "Ungheria", common: "Ungheria") },
                { "jpn", new CountryName(official: "ハンガリー", common: "ハンガリー") },
                { "kor", new CountryName(official: "헝가리", common: "헝가리") },
                { "nld", new CountryName(official: "Hongarije", common: "Hongarije") },
                { "per", new CountryName(official: "مجارستان", common: "مجارستان") },
                { "pol", new CountryName(official: "Węgry", common: "Węgry") },
                { "por", new CountryName(official: "Hungria", common: "Hungria") },
                { "rus", new CountryName(official: "Венгрия", common: "Венгрия") },
                { "slk", new CountryName(official: "Maďarsko", common: "Maďarsko") },
                { "spa", new CountryName(official: "Hungría", common: "Hungría") },
                { "swe", new CountryName(official: "Ungern", common: "Ungern") },
                { "urd", new CountryName(official: "مجارستان", common: "مجارستان") },
                { "zho", new CountryName(official: "匈牙利", common: "匈牙利") },

            },
            cca2: "HU",
            cca3: "HUN",
            ccn3: "348",
            cioc: "HUN",
            flag: "🇭🇺",
            region: Region.Europe,
            subregion: "Central Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"6", }),
            borders: new string[] { "AUT", "HRV", "ROU", "SRB", "SVK", "SVN", "UKR",  },
            capital: new string[] { "Budapest",  },
            altSpellings: new string[] { "HU",  },
            tld: new string[] { ".hu",  },
            latlng: new double[] { 47, 20,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Hungarian", iso6391: "hu", iso6392: "hun"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "HUF", name: "Hungarian forint", symbol: "Ft"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Hungarian", female: "Hungarian") },
                { "fra", new DemonymsGender(male: "Hungarian", female: "Hungarian") },
            }
        );

        /// <summary>
        /// create an instance of Hungary country
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
        private Hungary(
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
