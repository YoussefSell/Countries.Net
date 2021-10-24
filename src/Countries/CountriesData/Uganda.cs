namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Uganda country
    /// </summary>
    public class Uganda : Country
    {
        /// <summary>
        /// get the Uganda country instance
        /// </summary>
        public static Uganda Instance = new Uganda(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Uganda", common: "Uganda") },
                { "swa", new CountryName(official: "Republic of Uganda", common: "Uganda") },
                { "ara", new CountryName(official: "جمهورية أوغندا", common: "أوغندا") },
                { "ces", new CountryName(official: "Ugandská republika", common: "Uganda") },
                { "cym", new CountryName(official: "Republic of Uganda", common: "Uganda") },
                { "deu", new CountryName(official: "Republik Uganda", common: "Uganda") },
                { "est", new CountryName(official: "Uganda Vabariik", common: "Uganda") },
                { "fin", new CountryName(official: "Ugandan tasavalta", common: "Uganda") },
                { "fra", new CountryName(official: "République de l'Ouganda", common: "Ouganda") },
                { "hrv", new CountryName(official: "Republika Uganda", common: "Uganda") },
                { "hun", new CountryName(official: "Ugandai Köztársaság", common: "Uganda") },
                { "ita", new CountryName(official: "Repubblica di Uganda", common: "Uganda") },
                { "jpn", new CountryName(official: "ウガンダ共和国", common: "ウガンダ") },
                { "kor", new CountryName(official: "우간다 공화국", common: "우간다") },
                { "nld", new CountryName(official: "Republiek Uganda", common: "Oeganda") },
                { "per", new CountryName(official: "جمهوری اوگاندا", common: "اوگاندا") },
                { "pol", new CountryName(official: "Republika Ugandy", common: "Uganda") },
                { "por", new CountryName(official: "República do Uganda", common: "Uganda") },
                { "rus", new CountryName(official: "Республика Уганда", common: "Уганда") },
                { "slk", new CountryName(official: "Ugandská republika", common: "Uganda") },
                { "spa", new CountryName(official: "República de Uganda", common: "Uganda") },
                { "swe", new CountryName(official: "Republiken Uganda", common: "Uganda") },
                { "urd", new CountryName(official: "جمہوریہ یوگنڈا", common: "یوگنڈا") },
                { "zho", new CountryName(official: "乌干达共和国", common: "乌干达") },
            },
            cca2: "UG",
            cca3: "UGA",
            ccn3: "800",
            cioc: "UGA",
            flag: "🇺🇬",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"56", }),
            borders: new string[] { "COD", "KEN", "RWA", "SSD", "TZA",  },
            capital: new string[] { "Kampala",  },
            altSpellings: new string[] { "UG", "Republic of Uganda", "Jamhuri ya Uganda",  },
            tld: new string[] { ".ug",  },
            latlng: new double[] { 1, 32,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Swahili", iso6391: "sw", iso6392: "swa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "UGX", name: "Ugandan shilling", symbol: "Sh"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Ugandan", female: "Ugandan") },
                { "fra", new DemonymsGender(male: "Ugandan", female: "Ugandan") },
            }
        );

        /// <summary>
        /// create an instance of Uganda country
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
        private Uganda(
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
