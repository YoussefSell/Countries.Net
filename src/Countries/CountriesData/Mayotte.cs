namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Mayotte country
    /// </summary>
    public class Mayotte : Country
    {
        /// <summary>
        /// get the Mayotte country instance
        /// </summary>
        public static Mayotte Instance = new Mayotte(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Department of Mayotte", common: "Mayotte") },
                { "fra", new CountryName(official: "Département de Mayotte", common: "Mayotte") },
                { "ara", new CountryName(official: "مايوت", common: "مايوت") },
                { "ces", new CountryName(official: "Mayotte", common: "Mayotte") },
                { "cym", new CountryName(official: "Department of Mayotte", common: "Mayotte") },
                { "deu", new CountryName(official: "Übersee-Département Mayotte", common: "Mayotte") },
                { "est", new CountryName(official: "Mayotte", common: "Mayotte") },
                { "fin", new CountryName(official: "Mayotte", common: "Mayotte") },
                { "hrv", new CountryName(official: "Odjel Mayotte", common: "Mayotte") },
                { "hun", new CountryName(official: "Mayotte", common: "Mayotte") },
                { "ita", new CountryName(official: "Dipartimento di Mayotte", common: "Mayotte") },
                { "jpn", new CountryName(official: "マヨット科", common: "マヨット") },
                { "kor", new CountryName(official: "마요트", common: "마요트") },
                { "nld", new CountryName(official: "Afdeling Mayotte", common: "Mayotte") },
                { "per", new CountryName(official: "مجموعه شهرستانی مایوت", common: "مایوت") },
                { "pol", new CountryName(official: "Majotta", common: "Majotta") },
                { "por", new CountryName(official: "Departamento de Mayotte", common: "Mayotte") },
                { "rus", new CountryName(official: "Департамент Майотта", common: "Майотта") },
                { "slk", new CountryName(official: "Department Mayotte", common: "Mayotte") },
                { "spa", new CountryName(official: "Departamento de Mayotte", common: "Mayotte") },
                { "swe", new CountryName(official: "Departementsområdet Mayotte", common: "Mayotte") },
                { "urd", new CountryName(official: "مایوٹ", common: "مایوٹ") },
                { "zho", new CountryName(official: "马约特", common: "马约特") },

            },
            cca2: "YT",
            cca3: "MYT",
            ccn3: "175",
            cioc: "",
            flag: "🇾🇹",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"62", }),
            borders: new string[] {  },
            capital: new string[] { "Mamoudzou",  },
            altSpellings: new string[] { "YT", "Department of Mayotte", "Département de Mayotte",  },
            tld: new string[] { ".yt",  },
            latlng: new double[] { -12.83333333, 45.16666666,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Mahoran", female: "Mahoran") },
                { "fra", new DemonymsGender(male: "Mahoran", female: "Mahoran") },
            }
        );

        /// <summary>
        /// create an instance of Mayotte country
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
        private Mayotte(
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
