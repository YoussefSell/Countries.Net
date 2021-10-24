namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Jamaica country
    /// </summary>
    public class Jamaica : Country
    {
        /// <summary>
        /// get the Jamaica country instance
        /// </summary>
        public static Jamaica Instance = new Jamaica(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Jamaica", common: "Jamaica") },
                { "jam", new CountryName(official: "Jamaica", common: "Jamaica") },
                { "ara", new CountryName(official: "جامايكا", common: "جامايكا") },
                { "ces", new CountryName(official: "Jamajka", common: "Jamajka") },
                { "cym", new CountryName(official: "Jamaica", common: "Jamaica") },
                { "deu", new CountryName(official: "Jamaika", common: "Jamaika") },
                { "est", new CountryName(official: "Jamaica", common: "Jamaica") },
                { "fin", new CountryName(official: "Jamaika", common: "Jamaika") },
                { "fra", new CountryName(official: "Jamaïque", common: "Jamaïque") },
                { "hrv", new CountryName(official: "Jamajka", common: "Jamajka") },
                { "hun", new CountryName(official: "Jamaica", common: "Jamaica") },
                { "ita", new CountryName(official: "Giamaica", common: "Giamaica") },
                { "jpn", new CountryName(official: "ジャマイカ", common: "ジャマイカ") },
                { "kor", new CountryName(official: "자메이카", common: "자메이카") },
                { "nld", new CountryName(official: "Jamaica", common: "Jamaica") },
                { "per", new CountryName(official: "جامائیکا", common: "جامائیکا") },
                { "pol", new CountryName(official: "Jamajka", common: "Jamajka") },
                { "por", new CountryName(official: "Jamaica", common: "Jamaica") },
                { "rus", new CountryName(official: "Ямайка", common: "Ямайка") },
                { "slk", new CountryName(official: "Jamajka", common: "Jamajka") },
                { "spa", new CountryName(official: "Jamaica", common: "Jamaica") },
                { "swe", new CountryName(official: "Jamaica", common: "Jamaica") },
                { "urd", new CountryName(official: "جمیکا", common: "جمیکا") },
                { "zho", new CountryName(official: "牙买加", common: "牙买加") },
            },
            cca2: "JM",
            cca3: "JAM",
            ccn3: "388",
            cioc: "JAM",
            flag: "🇯🇲",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"876", }),
            borders: new string[] {  },
            capital: new string[] { "Kingston",  },
            altSpellings: new string[] { "JM",  },
            tld: new string[] { ".jm",  },
            latlng: new double[] { 18.25, -77.5,  },
            timezones: new string[] { "UTC-05:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Jamaican Patois", iso6391: "", iso6392: "jam"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "JMD", name: "Jamaican dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Jamaican", female: "Jamaican") },
                { "fra", new DemonymsGender(male: "Jamaican", female: "Jamaican") },
            }
        );

        /// <summary>
        /// create an instance of Jamaica country
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
        private Jamaica(
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
