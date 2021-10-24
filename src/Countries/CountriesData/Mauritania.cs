namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Mauritania country
    /// </summary>
    public class Mauritania : Country
    {
        /// <summary>
        /// get the Mauritania country instance
        /// </summary>
        public static Mauritania Instance = new Mauritania(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Islamic Republic of Mauritania", common: "Mauritania") },
                { "ara", new CountryName(official: "الجمهورية الإسلامية الموريتانية", common: "موريتانيا") },
                { "ces", new CountryName(official: "Mauritánská islámská republika", common: "Mauritánie") },
                { "cym", new CountryName(official: "Islamic Republic of Mauritania", common: "Mauritania") },
                { "deu", new CountryName(official: "Islamische Republik Mauretanien", common: "Mauretanien") },
                { "est", new CountryName(official: "Mauritaania Islamivabariik", common: "Mauritaania") },
                { "fin", new CountryName(official: "Mauritanian islamilainen tasavalta", common: "Mauritania") },
                { "fra", new CountryName(official: "République islamique de Mauritanie", common: "Mauritanie") },
                { "hrv", new CountryName(official: "Islamska Republika Mauritanija", common: "Mauritanija") },
                { "hun", new CountryName(official: "Mauritániai Iszlám Köztársaság", common: "Mauritánia") },
                { "ita", new CountryName(official: "Repubblica islamica di Mauritania", common: "Mauritania") },
                { "jpn", new CountryName(official: "モーリタニア·イスラム共和国", common: "モーリタニア") },
                { "kor", new CountryName(official: "모리타니 이슬람 공화국", common: "모리타니") },
                { "nld", new CountryName(official: "Islamitische Republiek Mauritanië", common: "Mauritanië") },
                { "per", new CountryName(official: "جمهوری اسلامی موریتانی", common: "موریتانی") },
                { "pol", new CountryName(official: "Islamska Republika Mauretańska", common: "Mauretania") },
                { "por", new CountryName(official: "República Islâmica da Mauritânia", common: "Mauritânia") },
                { "rus", new CountryName(official: "Исламская Республика Мавритания", common: "Мавритания") },
                { "slk", new CountryName(official: "Mauritánska islamská republika", common: "Mauritánia") },
                { "spa", new CountryName(official: "República Islámica de Mauritania", common: "Mauritania") },
                { "swe", new CountryName(official: "Islamiska republiken Mauretanien", common: "Mauretanien") },
                { "urd", new CountryName(official: "اسلامی جمہوریہ موریتانیہ", common: "موریتانیہ") },
                { "zho", new CountryName(official: "毛里塔尼亚伊斯兰共和国", common: "毛里塔尼亚") },

            },
            cca2: "MR",
            cca3: "MRT",
            ccn3: "478",
            cioc: "MTN",
            flag: "🇲🇷",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"22", }),
            borders: new string[] { "DZA", "MLI", "SEN", "ESH",  },
            capital: new string[] { "Nouakchott",  },
            altSpellings: new string[] { "MR", "Islamic Republic of Mauritania", "al-Jumhūriyyah al-ʾIslāmiyyah al-Mūrītāniyyah",  },
            tld: new string[] { ".mr",  },
            latlng: new double[] { 20, -12,  },
            timezones: new string[] { "UTC",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "MRU", name: "Mauritanian ouguiya", symbol: "UM"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Mauritanian", female: "Mauritanian") },
                { "fra", new DemonymsGender(male: "Mauritanian", female: "Mauritanian") },
            }
        );

        /// <summary>
        /// create an instance of Mauritania country
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
        private Mauritania(
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
