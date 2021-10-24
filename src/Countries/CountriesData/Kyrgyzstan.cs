namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Kyrgyzstan country
    /// </summary>
    public class Kyrgyzstan : Country
    {
        /// <summary>
        /// get the Kyrgyzstan country instance
        /// </summary>
        public static Kyrgyzstan Instance = new Kyrgyzstan(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Kyrgyz Republic", common: "Kyrgyzstan") },
                { "kir", new CountryName(official: "Кыргыз Республикасы", common: "Кыргызстан") },
                { "rus", new CountryName(official: "Кыргызская Республика", common: "Киргизия") },
                { "ara", new CountryName(official: "الجمهورية القيرغيزية", common: "قيرغيزستان") },
                { "ces", new CountryName(official: "Kyrgyzská republika", common: "Kyrgyzstán") },
                { "cym", new CountryName(official: "Kyrgyz Republic", common: "Kyrgyzstan") },
                { "deu", new CountryName(official: "Kirgisische Republik", common: "Kirgisistan") },
                { "est", new CountryName(official: "Kirgiisi Vabariik", common: "Kõrgõzstan") },
                { "fin", new CountryName(official: "Kirgisian tasavalta", common: "Kirgisia") },
                { "fra", new CountryName(official: "République kirghize", common: "Kirghizistan") },
                { "hrv", new CountryName(official: "Kirgistanu", common: "Kirgistan") },
                { "hun", new CountryName(official: "Kirgiz Köztársaság", common: "Kirgizisztán") },
                { "ita", new CountryName(official: "Kirghizistan", common: "Kirghizistan") },
                { "jpn", new CountryName(official: "キルギス共和国", common: "キルギス") },
                { "kor", new CountryName(official: "키르기스 공화국", common: "키르기스스탄") },
                { "nld", new CountryName(official: "Kirgizische Republiek", common: "Kirgizië") },
                { "per", new CountryName(official: "جمهوری قِرقیزستان", common: "قرقیزستان") },
                { "pol", new CountryName(official: "Republika Kirgiska", common: "Kirgistan") },
                { "por", new CountryName(official: "República do Quirguistão", common: "Quirguistão") },
                { "slk", new CountryName(official: "Kirgizská republika", common: "Kirgizsko") },
                { "spa", new CountryName(official: "República Kirguisa", common: "Kirguizistán") },
                { "swe", new CountryName(official: "Republiken Kirgizistan", common: "Kirgizistan") },
                { "urd", new CountryName(official: "جمہوریہ کرغیزستان", common: "کرغیزستان") },
                { "zho", new CountryName(official: "吉尔吉斯斯坦共和国", common: "吉尔吉斯斯坦") },

            },
            cca2: "KG",
            cca3: "KGZ",
            ccn3: "417",
            cioc: "KGZ",
            flag: "🇰🇬",
            region: Region.Asia,
            subregion: "Central Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"96", }),
            borders: new string[] { "CHN", "KAZ", "TJK", "UZB",  },
            capital: new string[] { "Bishkek",  },
            altSpellings: new string[] { "KG", "Киргизия", "Kyrgyz Republic", "Кыргыз Республикасы", "Kyrgyz Respublikasy",  },
            tld: new string[] { ".kg",  },
            latlng: new double[] { 41, 75,  },
            timezones: new string[] { "UTC+06:00",  },
            languages: new Language[]
            {
                new Language(name: "Kyrgyz", iso6391: "ky", iso6392: "kir"),
                new Language(name: "Russian", iso6391: "ru", iso6392: "rus"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "KGS", name: "Kyrgyzstani som", symbol: "с"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Kirghiz", female: "Kirghiz") },
                { "fra", new DemonymsGender(male: "Kirghiz", female: "Kirghiz") },
            }
        );

        /// <summary>
        /// create an instance of Kyrgyzstan country
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
        private Kyrgyzstan(
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
