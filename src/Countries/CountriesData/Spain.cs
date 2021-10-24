namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Spain country
    /// </summary>
    public class Spain : Country
    {
        /// <summary>
        /// get the Spain country instance
        /// </summary>
        public static Spain Instance = new Spain(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Kingdom of Spain", common: "Spain") },
                { "spa", new CountryName(official: "Reino de España", common: "España") },
                { "ara", new CountryName(official: "مملكة إسبانيا", common: "إسبانيا") },
                { "ces", new CountryName(official: "Španělské království", common: "Španělsko") },
                { "cym", new CountryName(official: "Kingdom of Spain", common: "Spain") },
                { "deu", new CountryName(official: "Königreich Spanien", common: "Spanien") },
                { "est", new CountryName(official: "Hispaania Kuningriik", common: "Hispaania") },
                { "fin", new CountryName(official: "Espanjan kuningaskunta", common: "Espanja") },
                { "fra", new CountryName(official: "Royaume d'Espagne", common: "Espagne") },
                { "hrv", new CountryName(official: "Kraljevina Španjolska", common: "Španjolska") },
                { "hun", new CountryName(official: "Spanyol Királyság", common: "Spanyolország") },
                { "ita", new CountryName(official: "Regno di Spagna", common: "Spagna") },
                { "jpn", new CountryName(official: "スペイン王国", common: "スペイン") },
                { "kor", new CountryName(official: "에스파냐 왕국", common: "스페인") },
                { "nld", new CountryName(official: "Koninkrijk Spanje", common: "Spanje") },
                { "per", new CountryName(official: "پادشاهی اسپانیا", common: "اسپانیا") },
                { "pol", new CountryName(official: "Królestwo Hiszpanii ", common: "Hiszpania") },
                { "por", new CountryName(official: "Reino de Espanha", common: "Espanha") },
                { "rus", new CountryName(official: "Королевство Испания", common: "Испания") },
                { "slk", new CountryName(official: "Španielske kráľovstvo", common: "Španielsko") },
                { "swe", new CountryName(official: "Konungariket Spanien", common: "Spanien") },
                { "urd", new CountryName(official: "مملکتِ ہسپانیہ", common: "ہسپانیہ") },
                { "zho", new CountryName(official: "西班牙王国", common: "西班牙") },

            },
            cca2: "ES",
            cca3: "ESP",
            ccn3: "724",
            cioc: "ESP",
            flag: "🇪🇸",
            region: Region.Europe,
            subregion: "Southern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"4", }),
            borders: new string[] { "AND", "FRA", "GIB", "PRT", "MAR",  },
            capital: new string[] { "Madrid",  },
            altSpellings: new string[] { "ES", "Kingdom of Spain", "Reino de España",  },
            tld: new string[] { ".es",  },
            latlng: new double[] { 40, -4,  },
            timezones: new string[] { "UTC", "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Spanish", female: "Spanish") },
                { "fra", new DemonymsGender(male: "Spanish", female: "Spanish") },
            }
        );

        /// <summary>
        /// create an instance of Spain country
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
        private Spain(
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
