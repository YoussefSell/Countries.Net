namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Romania country
    /// </summary>
    public class Romania : Country
    {
        /// <summary>
        /// get the Romania country instance
        /// </summary>
        public static Romania Instance = new Romania(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Romania", common: "Romania") },
                { "ron", new CountryName(official: "România", common: "România") },
                { "ara", new CountryName(official: "رومانيا", common: "رومانيا") },
                { "ces", new CountryName(official: "Rumunsko", common: "Rumunsko") },
                { "cym", new CountryName(official: "Romania", common: "Romania") },
                { "deu", new CountryName(official: "Rumänien", common: "Rumänien") },
                { "est", new CountryName(official: "Rumeenia", common: "Rumeenia") },
                { "fin", new CountryName(official: "Romania", common: "Romania") },
                { "fra", new CountryName(official: "Roumanie", common: "Roumanie") },
                { "hrv", new CountryName(official: "Rumunija", common: "Rumunjska") },
                { "hun", new CountryName(official: "Románia", common: "Románia") },
                { "ita", new CountryName(official: "Romania", common: "Romania") },
                { "jpn", new CountryName(official: "ルーマニア", common: "ルーマニア") },
                { "kor", new CountryName(official: "루마니아", common: "루마니아") },
                { "nld", new CountryName(official: "Roemenië", common: "Roemenië") },
                { "per", new CountryName(official: "رومانی", common: "رومانی") },
                { "pol", new CountryName(official: "Rumunia", common: "Rumunia") },
                { "por", new CountryName(official: "Romênia", common: "Roménia") },
                { "rus", new CountryName(official: "Румыния", common: "Румыния") },
                { "slk", new CountryName(official: "Rumunsko", common: "Rumunsko") },
                { "spa", new CountryName(official: "Rumania", common: "Rumania") },
                { "swe", new CountryName(official: "Rumänien", common: "Rumänien") },
                { "urd", new CountryName(official: "رومانیہ", common: "رومانیہ") },
                { "zho", new CountryName(official: "罗马尼亚", common: "罗马尼亚") },
            },
            cca2: "RO",
            cca3: "ROU",
            ccn3: "642",
            cioc: "ROU",
            flag: "🇷🇴",
            region: Region.Europe,
            subregion: "Southeast Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"0", }),
            borders: new string[] { "BGR", "HUN", "MDA", "SRB", "UKR",  },
            capital: new string[] { "Bucharest",  },
            altSpellings: new string[] { "RO", "Rumania", "Roumania", "România",  },
            tld: new string[] { ".ro",  },
            latlng: new double[] { 46, 25,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Romanian", iso6391: "ro", iso6392: "ron"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "RON", name: "Romanian leu", symbol: "lei"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Romanian", female: "Romanian") },
                { "fra", new DemonymsGender(male: "Romanian", female: "Romanian") },
            }
        );

        /// <summary>
        /// create an instance of Romania country
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
        private Romania(
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
