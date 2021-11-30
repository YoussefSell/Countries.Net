namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Montserrat country
    /// </summary>
    public class Montserrat : Country
    {
        /// <summary>
        /// get the Montserrat country instance
        /// </summary>
        public static Montserrat Instance = new Montserrat(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Montserrat", common: "Montserrat") },
                { "ara", new CountryName(official: "مونتسرات", common: "مونتسرات") },
                { "ces", new CountryName(official: "Montserrat", common: "Montserrat") },
                { "cym", new CountryName(official: "Montserrat", common: "Montserrat") },
                { "deu", new CountryName(official: "Montserrat", common: "Montserrat") },
                { "est", new CountryName(official: "Montserrat", common: "Montserrat") },
                { "fin", new CountryName(official: "Montserrat", common: "Montserrat") },
                { "fra", new CountryName(official: "Montserrat", common: "Montserrat") },
                { "hrv", new CountryName(official: "Montserrat", common: "Montserrat") },
                { "hun", new CountryName(official: "Montserrat", common: "Montserrat") },
                { "ita", new CountryName(official: "Montserrat", common: "Montserrat") },
                { "jpn", new CountryName(official: "モントセラト", common: "モントセラト") },
                { "kor", new CountryName(official: "몬트세랫", common: "몬트세랫") },
                { "nld", new CountryName(official: "Montserrat", common: "Montserrat") },
                { "per", new CountryName(official: "مونتسرات", common: "مونتسرات") },
                { "pol", new CountryName(official: "Montserrat", common: "Montserrat") },
                { "por", new CountryName(official: "Montserrat", common: "Montserrat") },
                { "rus", new CountryName(official: "Монтсеррат", common: "Монтсеррат") },
                { "slk", new CountryName(official: "Montserrat", common: "Montserrat") },
                { "spa", new CountryName(official: "Montserrat", common: "Montserrat") },
                { "swe", new CountryName(official: "Montserrat", common: "Montserrat") },
                { "urd", new CountryName(official: "مانٹسریٹ", common: "مانٹسریٹ") },
                { "zho", new CountryName(official: "蒙特塞拉特", common: "蒙特塞拉特") },
            },
            cca2: "MS",
            cca3: "MSR",
            ccn3: "500",
            cioc: "",
            flag: "🇲🇸",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"664", }),
            borders: new string[] {  },
            capital: new string[] { "Plymouth",  },
            altSpellings: new string[] { "MS",  },
            tld: new string[] { ".ms",  },
            latlng: new double[] { 16.75, -62.2,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XCD", name: "Eastern Caribbean dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Montserratian", female: "Montserratian") },
                { "fra", new DemonymsGender(male: "Montserratian", female: "Montserratian") },
            }
        );

        /// <summary>
        /// create an instance of Montserrat country
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
        private Montserrat(
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
