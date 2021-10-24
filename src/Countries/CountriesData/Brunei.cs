namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Brunei country
    /// </summary>
    public class Brunei : Country
    {
        /// <summary>
        /// get the Brunei country instance
        /// </summary>
        public static Brunei Instance = new Brunei(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Nation of Brunei, Abode of Peace", common: "Brunei") },
                { "msa", new CountryName(official: "Nation of Brunei, Abode Damai", common: "Negara Brunei Darussalam") },
                { "ara", new CountryName(official: "بروناي دار السلام", common: "بروناي") },
                { "ces", new CountryName(official: "Sultanát Brunej", common: "Brunej") },
                { "cym", new CountryName(official: "Teyrnas Brwnei", common: "Brunei") },
                { "deu", new CountryName(official: "Sultanat Brunei Darussalam", common: "Brunei") },
                { "est", new CountryName(official: "Brunei Darussalami Riik", common: "Brunei") },
                { "fin", new CountryName(official: "Brunei Darussalamin valtio", common: "Brunei") },
                { "fra", new CountryName(official: "État de Brunei Darussalam", common: "Brunei") },
                { "hrv", new CountryName(official: "Nacija od Bruneja, Kuću Mira", common: "Brunej") },
                { "hun", new CountryName(official: "Brunei Szultanátus", common: "Brunei") },
                { "ita", new CountryName(official: "Nazione di Brunei, Dimora della Pace", common: "Brunei") },
                { "jpn", new CountryName(official: "ブルネイ、平和の精舎の国家", common: "ブルネイ・ダルサラーム") },
                { "kor", new CountryName(official: "브루나이 다루살람국", common: "브루나이") },
                { "nld", new CountryName(official: "Natie van Brunei, de verblijfplaats van de Vrede", common: "Brunei") },
                { "per", new CountryName(official: "برونئی سرای صلح", common: "برونئی") },
                { "pol", new CountryName(official: "Państwo Brunei Darussalam", common: "Brunei") },
                { "por", new CountryName(official: "Nação do Brunei, Morada da Paz", common: "Brunei") },
                { "rus", new CountryName(official: "Нация Бруней, обитель мира", common: "Бруней") },
                { "slk", new CountryName(official: "Brunejský sultanât", common: "Brunej") },
                { "spa", new CountryName(official: "Nación de Brunei, Morada de la Paz", common: "Brunei") },
                { "swe", new CountryName(official: "Brunei Darussalam", common: "Brunei") },
                { "urd", new CountryName(official: "ریاستِ برونائی دارالسلام", common: "برونائی") },
                { "zho", new CountryName(official: "文莱和平之国", common: "文莱") },
            },
            cca2: "BN",
            cca3: "BRN",
            ccn3: "096",
            cioc: "BRU",
            flag: "🇧🇳",
            region: Region.Asia,
            subregion: "South-Eastern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"73", }),
            borders: new string[] { "MYS",  },
            capital: new string[] { "Bandar Seri Begawan",  },
            altSpellings: new string[] { "BN", "Brunei Darussalam", "Nation of Brunei", "the Abode of Peace",  },
            tld: new string[] { ".bn",  },
            latlng: new double[] { 4.5, 114.66666666,  },
            timezones: new string[] { "UTC+08:00",  },
            languages: new Language[]
            {
                new Language(name: "Malay", iso6391: "ms", iso6392: "msa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "BND", name: "Brunei dollar", symbol: "$"),
                new Currency(code: "SGD", name: "Singapore dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Bruneian", female: "Bruneian") },
                { "fra", new DemonymsGender(male: "Bruneian", female: "Bruneian") },
            }
        );

        /// <summary>
        /// create an instance of Brunei country
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
        private Brunei(
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
