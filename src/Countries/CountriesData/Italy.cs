namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Italy country
    /// </summary>
    public class Italy : Country
    {
        /// <summary>
        /// get the Italy country instance
        /// </summary>
        public static Italy Instance = new Italy(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Italian Republic", common: "Italy") },
                { "ita", new CountryName(official: "Repubblica italiana", common: "Italia") },
                { "ara", new CountryName(official: "الجمهورية الإيطالية", common: "إيطاليا") },
                { "ces", new CountryName(official: "Italská republika", common: "Itálie") },
                { "cym", new CountryName(official: "Italian Republic", common: "Italy") },
                { "deu", new CountryName(official: "Italienische Republik", common: "Italien") },
                { "est", new CountryName(official: "Itaalia Vabariik", common: "Itaalia") },
                { "fin", new CountryName(official: "Italian tasavalta", common: "Italia") },
                { "fra", new CountryName(official: "République italienne", common: "Italie") },
                { "hrv", new CountryName(official: "talijanska Republika", common: "Italija") },
                { "hun", new CountryName(official: "Olasz Köztársaság", common: "Olaszország") },
                { "jpn", new CountryName(official: "イタリア共和国", common: "イタリア") },
                { "kor", new CountryName(official: "이탈리아 공화국", common: "이탈리아") },
                { "nld", new CountryName(official: "Italiaanse Republiek", common: "Italië") },
                { "per", new CountryName(official: "جمهوری ایتالیا", common: "ایتالیا") },
                { "pol", new CountryName(official: "Republika Włoska", common: "Włochy") },
                { "por", new CountryName(official: "República Italiana", common: "Itália") },
                { "rus", new CountryName(official: "итальянская Республика", common: "Италия") },
                { "slk", new CountryName(official: "Talianska republika", common: "Taliansko") },
                { "spa", new CountryName(official: "República Italiana", common: "Italia") },
                { "swe", new CountryName(official: "Republiken Italien", common: "Italien") },
                { "urd", new CountryName(official: "جمہوریہ اطالیہ", common: "اطالیہ") },
                { "zho", new CountryName(official: "意大利共和国", common: "意大利") },

            },
            cca2: "IT",
            cca3: "ITA",
            ccn3: "380",
            cioc: "ITA",
            flag: "🇮🇹",
            region: Region.Europe,
            subregion: "Southern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"9", }),
            borders: new string[] { "AUT", "FRA", "SMR", "SVN", "CHE", "VAT",  },
            capital: new string[] { "Rome",  },
            altSpellings: new string[] { "IT", "Italian Republic", "Repubblica italiana",  },
            tld: new string[] { ".it",  },
            latlng: new double[] { 42.83333333, 12.83333333,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Italian", iso6391: "it", iso6392: "ita"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Italian", female: "Italian") },
                { "fra", new DemonymsGender(male: "Italian", female: "Italian") },
            }
        );

        /// <summary>
        /// create an instance of Italy country
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
        private Italy(
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
