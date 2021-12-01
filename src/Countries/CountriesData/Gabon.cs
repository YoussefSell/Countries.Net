namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Gabon country
    /// </summary>
    public class Gabon : Country
    {
        /// <summary>
        /// get the Gabon country instance
        /// </summary>
        public static Gabon Instance = new Gabon(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Gabonese Republic", common: "Gabon") },
                { "fra", new CountryName(official: "République gabonaise", common: "Gabon") },
                { "ara", new CountryName(official: "جمهورية الغابون", common: "الغابون") },
                { "ces", new CountryName(official: "Gabonská republika", common: "Gabon") },
                { "cym", new CountryName(official: "Gabonese Republic", common: "Gabon") },
                { "deu", new CountryName(official: "Gabunische Republik", common: "Gabun") },
                { "est", new CountryName(official: "Gaboni Vabariik", common: "Gabon") },
                { "fin", new CountryName(official: "Gabonin tasavalta", common: "Gabon") },
                { "hrv", new CountryName(official: "Gabon Republika", common: "Gabon") },
                { "hun", new CountryName(official: "Gaboni Köztársaság", common: "Gabon") },
                { "ita", new CountryName(official: "Repubblica gabonese", common: "Gabon") },
                { "jpn", new CountryName(official: "ガボン共和国", common: "ガボン") },
                { "kor", new CountryName(official: "가봉 공화국", common: "가봉") },
                { "nld", new CountryName(official: "Republiek Gabon", common: "Gabon") },
                { "per", new CountryName(official: "جمهوری گابُن", common: "گابن") },
                { "pol", new CountryName(official: "Republika Gabońska", common: "Gabon") },
                { "por", new CountryName(official: "República do Gabão", common: "Gabão") },
                { "rus", new CountryName(official: "Габона Республика", common: "Габон") },
                { "slk", new CountryName(official: "Gabonská republika", common: "Gabon") },
                { "spa", new CountryName(official: "República de Gabón", common: "Gabón") },
                { "swe", new CountryName(official: "Republiken Gabon", common: "Gabon") },
                { "urd", new CountryName(official: "جمہوریہ گیبون", common: "گیبون") },
                { "zho", new CountryName(official: "加蓬共和国", common: "加蓬") },

            },
            cca2: "GA",
            cca3: "GAB",
            ccn3: "266",
            cioc: "GAB",
            flag: "🇬🇦",
            region: Region.Africa,
            subregion: "Middle Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"41", }),
            borders: new string[] { "CMR", "COG", "GNQ",  },
            capital: new string[] { "Libreville",  },
            altSpellings: new string[] { "GA", "Gabonese Republic", "République Gabonaise",  },
            tld: new string[] { ".ga",  },
            latlng: new double[] { -1, 11.75,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XAF", name: "Central African CFA franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Gabonese", female: "Gabonese") },
                { "fra", new DemonymsGender(male: "Gabonese", female: "Gabonese") },
            }
        );

        /// <summary>
        /// create an instance of Gabon country
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
        private Gabon(
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
