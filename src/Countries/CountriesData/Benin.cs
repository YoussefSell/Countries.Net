namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Benin country
    /// </summary>
    public class Benin : Country
    {
        /// <summary>
        /// get the Benin country instance
        /// </summary>
        public static Benin Instance = new Benin(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Benin", common: "Benin") },
                { "fra", new CountryName(official: "République du Bénin", common: "Bénin") },
                { "ara", new CountryName(official: "جمهورية بنين", common: "بنين") },
                { "ces", new CountryName(official: "Beninská republika", common: "Benin") },
                { "cym", new CountryName(official: "Gweriniaeth Benin", common: "Benin") },
                { "deu", new CountryName(official: "Republik Benin", common: "Benin") },
                { "est", new CountryName(official: "Benini Vabariik", common: "Benin") },
                { "fin", new CountryName(official: "Beninin tasavalta", common: "Benin") },
                { "hrv", new CountryName(official: "Republika Benin", common: "Benin") },
                { "hun", new CountryName(official: "Benini Köztársaság", common: "Benin") },
                { "ita", new CountryName(official: "Repubblica del Benin", common: "Benin") },
                { "jpn", new CountryName(official: "ベナン共和国", common: "ベナン") },
                { "kor", new CountryName(official: "베냉 공화국", common: "베냉") },
                { "nld", new CountryName(official: "Republiek Benin", common: "Benin") },
                { "per", new CountryName(official: "جمهوری بنین", common: "بنین") },
                { "pol", new CountryName(official: "Benin", common: "Benin") },
                { "por", new CountryName(official: "República do Benin", common: "Benin") },
                { "rus", new CountryName(official: "Республика Бенин", common: "Бенин") },
                { "slk", new CountryName(official: "Beninská republika", common: "Benin") },
                { "spa", new CountryName(official: "República de Benin", common: "Benín") },
                { "swe", new CountryName(official: "Republiken Benin", common: "Benin") },
                { "urd", new CountryName(official: "جمہوریہ بینن", common: "بینن") },
                { "zho", new CountryName(official: "贝宁共和国", common: "贝宁") },

            },
            cca2: "BJ",
            cca3: "BEN",
            ccn3: "204",
            cioc: "BEN",
            flag: "🇧🇯",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"29", }),
            borders: new string[] { "BFA", "NER", "NGA", "TGO",  },
            capital: new string[] { "Porto-Novo",  },
            altSpellings: new string[] { "BJ", "Republic of Benin", "République du Bénin",  },
            tld: new string[] { ".bj",  },
            latlng: new double[] { 9.5, 2.25,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XOF", name: "West African CFA franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Beninese", female: "Beninese") },
                { "fra", new DemonymsGender(male: "Beninese", female: "Beninese") },
            }
        );

        /// <summary>
        /// create an instance of Benin country
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
        private Benin(
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
