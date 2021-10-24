namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Andorra country
    /// </summary>
    public class Andorra : Country
    {
        /// <summary>
        /// get the Andorra country instance
        /// </summary>
        public static Andorra Instance = new Andorra(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Principality of Andorra", common: "Andorra") },
                { "cat", new CountryName(official: "Principat d'Andorra", common: "Andorra") },
                { "ara", new CountryName(official: "إمارة أندورا", common: "أندورا") },
                { "ces", new CountryName(official: "Andorrské knížectví", common: "Andorra") },
                { "cym", new CountryName(official: "Tywysogaeth Andorra", common: "Andorra") },
                { "deu", new CountryName(official: "Fürstentum Andorra", common: "Andorra") },
                { "est", new CountryName(official: "Andorra Vürstiriik", common: "Andorra") },
                { "fin", new CountryName(official: "Andorran ruhtinaskunta", common: "Andorra") },
                { "fra", new CountryName(official: "Principauté d'Andorre", common: "Andorre") },
                { "hrv", new CountryName(official: "Kneževina Andora", common: "Andora") },
                { "hun", new CountryName(official: "Andorra", common: "Andorra") },
                { "ita", new CountryName(official: "Principato di Andorra", common: "Andorra") },
                { "jpn", new CountryName(official: "アンドラ公国", common: "アンドラ") },
                { "kor", new CountryName(official: "안도라 공국", common: "안도라") },
                { "nld", new CountryName(official: "Prinsdom Andorra", common: "Andorra") },
                { "per", new CountryName(official: "شاهزاده‌نشین آندورا", common: "آندورا") },
                { "pol", new CountryName(official: "Księstwo Andory", common: "Andora") },
                { "por", new CountryName(official: "Principado de Andorra", common: "Andorra") },
                { "rus", new CountryName(official: "Княжество Андорра", common: "Андорра") },
                { "slk", new CountryName(official: "Andorrské kniežatstvo", common: "Andorra") },
                { "spa", new CountryName(official: "Principado de Andorra", common: "Andorra") },
                { "swe", new CountryName(official: "Furstendömet Andorra", common: "Andorra") },
                { "urd", new CountryName(official: "اماراتِ انڈورا", common: "انڈورا") },
                { "zho", new CountryName(official: "安道尔公国", common: "安道尔") },
            },
            cca2: "AD",
            cca3: "AND",
            ccn3: "020",
            cioc: "AND",
            flag: "🇦🇩",
            region: Region.Europe,
            subregion: "Southern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"76", }),
            borders: new string[] { "FRA", "ESP",  },
            capital: new string[] { "Andorra la Vella",  },
            altSpellings: new string[] { "AD", "Principality of Andorra", "Principat d'Andorra",  },
            tld: new string[] { ".ad",  },
            latlng: new double[] { 42.5, 1.5,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Catalan", iso6391: "ca", iso6392: "cat"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Andorran", female: "Andorran") },
                { "fra", new DemonymsGender(male: "Andorran", female: "Andorran") },
            }
        );

        /// <summary>
        /// create an instance of Andorra country
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
        private Andorra(
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
