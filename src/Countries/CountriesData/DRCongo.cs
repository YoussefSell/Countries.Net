namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of DRCongo country
    /// </summary>
    public class DRCongo : Country
    {
        /// <summary>
        /// get the DRCongo country instance
        /// </summary>
        public static DRCongo Instance = new DRCongo(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Democratic Republic of the Congo", common: "DR Congo") },
                { "fra", new CountryName(official: "République démocratique du Congo", common: "RD Congo") },
                { "kon", new CountryName(official: "Repubilika ya Kongo Demokratiki", common: "Repubilika ya Kongo Demokratiki") },
                { "lin", new CountryName(official: "Republiki ya Kongó Demokratiki", common: "Republiki ya Kongó Demokratiki") },
                { "lua", new CountryName(official: "Ditunga dia Kongu wa Mungalaata", common: "Ditunga dia Kongu wa Mungalaata") },
                { "swa", new CountryName(official: "Jamhuri ya Kidemokrasia ya Kongo", common: "Jamhuri ya Kidemokrasia ya Kongo") },
                { "ara", new CountryName(official: "جمهورية الكونغو الديمقراطية", common: "الكونغو") },
                { "ces", new CountryName(official: "Demokratická republika Kongo", common: "DR Kongo") },
                { "cym", new CountryName(official: "Gweriniaeth Ddemocrataidd Congo", common: "Gweriniaeth Ddemocrataidd Congo") },
                { "deu", new CountryName(official: "Demokratische Republik Kongo", common: "Kongo (Dem. Rep.)") },
                { "est", new CountryName(official: "Kongo Demokraatlik Vabariik", common: "Kongo DV") },
                { "fin", new CountryName(official: "Kongon demokraattinen tasavalta", common: "Kongon demokraattinen tasavalta") },
                { "hrv", new CountryName(official: "Demokratska Republika Kongo", common: "Kongo, Demokratska Republika") },
                { "hun", new CountryName(official: "Kongói Demokratikus Köztársaság", common: "Kongói Demokratikus Köztársaság") },
                { "ita", new CountryName(official: "Repubblica Democratica del Congo", common: "Congo (Rep. Dem.)") },
                { "jpn", new CountryName(official: "コンゴ民主共和国", common: "コンゴ民主共和国") },
                { "kor", new CountryName(official: "콩고 민주 공화국", common: "콩고 민주 공화국") },
                { "nld", new CountryName(official: "Democratische Republiek Congo", common: "Congo (DRC)") },
                { "per", new CountryName(official: "جمهوری دموکراتیک کنگو", common: "کنگو دموکراتیک") },
                { "pol", new CountryName(official: "Demokratyczna Republika Konga", common: "Demokratyczna Republika Konga") },
                { "por", new CountryName(official: "República Democrática do Congo", common: "República Democrática do Congo") },
                { "rus", new CountryName(official: "Демократическая Республика Конго", common: "Демократическая Республика Конго") },
                { "slk", new CountryName(official: "Konžská demokratická republika", common: "Kongo") },
                { "spa", new CountryName(official: "República Democrática del Congo", common: "Congo (Rep. Dem.)") },
                { "swe", new CountryName(official: "Demokratiska republiken Kongo", common: "Kongo-Kinshasa") },
                { "urd", new CountryName(official: "جمہوری جمہوریہ کانگو", common: "کانگو") },
                { "zho", new CountryName(official: "刚果民主共和国", common: "民主刚果") },

            },
            cca2: "CD",
            cca3: "COD",
            ccn3: "180",
            cioc: "COD",
            flag: "🇨🇩",
            region: Region.Africa,
            subregion: "Middle Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"43", }),
            borders: new string[] { "AGO", "BDI", "CAF", "COG", "RWA", "SSD", "TZA", "UGA", "ZMB",  },
            capital: new string[] { "Kinshasa",  },
            altSpellings: new string[] { "CD", "DR Congo", "Congo-Kinshasa", "Congo, the Democratic Republic of the", "DRC",  },
            tld: new string[] { ".cd",  },
            latlng: new double[] { 0, 25,  },
            timezones: new string[] { "UTC+01:00", "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
                new Language(name: "Kikongo", iso6391: "", iso6392: "kon"),
                new Language(name: "Lingala", iso6391: "ln", iso6392: "lin"),
                new Language(name: "Tshiluba", iso6391: "", iso6392: "lua"),
                new Language(name: "Swahili", iso6391: "sw", iso6392: "swa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "CDF", name: "Congolese franc", symbol: "FC"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Congolese", female: "Congolese") },
                { "fra", new DemonymsGender(male: "Congolese", female: "Congolese") },
            }
        );

        /// <summary>
        /// create an instance of DRCongo country
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
        private DRCongo(
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
