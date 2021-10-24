namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Ghana country
    /// </summary>
    public class Ghana : Country
    {
        /// <summary>
        /// get the Ghana country instance
        /// </summary>
        public static Ghana Instance = new Ghana(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Ghana", common: "Ghana") },
                { "ara", new CountryName(official: "جمهورية غانا", common: "غانا") },
                { "ces", new CountryName(official: "Ghanská republika", common: "Ghana") },
                { "cym", new CountryName(official: "Republic of Ghana", common: "Ghana") },
                { "deu", new CountryName(official: "Republik Ghana", common: "Ghana") },
                { "est", new CountryName(official: "Ghana Vabariik", common: "Ghana") },
                { "fin", new CountryName(official: "Ghanan tasavalta", common: "Ghana") },
                { "fra", new CountryName(official: "République du Ghana", common: "Ghana") },
                { "hrv", new CountryName(official: "Republika Gana", common: "Gana") },
                { "hun", new CountryName(official: "Ghánai Köztársaság", common: "Ghána") },
                { "ita", new CountryName(official: "Repubblica del Ghana", common: "Ghana") },
                { "jpn", new CountryName(official: "ガーナ共和国", common: "ガーナ") },
                { "kor", new CountryName(official: "가나 공화국", common: "가나") },
                { "nld", new CountryName(official: "Republiek Ghana", common: "Ghana") },
                { "per", new CountryName(official: "جمهوری غنا", common: "غنا") },
                { "pol", new CountryName(official: "Republika Ghany", common: "Ghana") },
                { "por", new CountryName(official: "República do Gana", common: "Gana") },
                { "rus", new CountryName(official: "Республика Гана", common: "Гана") },
                { "slk", new CountryName(official: "Ghanská republika", common: "Ghana") },
                { "spa", new CountryName(official: "República de Ghana", common: "Ghana") },
                { "swe", new CountryName(official: "Republiken Ghana", common: "Ghana") },
                { "urd", new CountryName(official: "جمہوریہ گھانا", common: "گھانا") },
                { "zho", new CountryName(official: "加纳共和国", common: "加纳") },
            },
            cca2: "GH",
            cca3: "GHA",
            ccn3: "288",
            cioc: "GHA",
            flag: "🇬🇭",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"33", }),
            borders: new string[] { "BFA", "CIV", "TGO",  },
            capital: new string[] { "Accra",  },
            altSpellings: new string[] { "GH",  },
            tld: new string[] { ".gh",  },
            latlng: new double[] { 8, -2,  },
            timezones: new string[] { "UTC",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "GHS", name: "Ghanaian cedi", symbol: "₵"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Ghanaian", female: "Ghanaian") },
                { "fra", new DemonymsGender(male: "Ghanaian", female: "Ghanaian") },
            }
        );

        /// <summary>
        /// create an instance of Ghana country
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
        private Ghana(
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
