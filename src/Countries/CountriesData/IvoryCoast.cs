namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of IvoryCoast country
    /// </summary>
    public class IvoryCoast : Country
    {
        /// <summary>
        /// get the IvoryCoast country instance
        /// </summary>
        public static IvoryCoast Instance = new IvoryCoast(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Côte d'Ivoire", common: "Ivory Coast") },
                { "fra", new CountryName(official: "République de Côte d'Ivoire", common: "Côte d'Ivoire") },
                { "ara", new CountryName(official: "جمهورية ساحل العاج", common: "ساحل العاج") },
                { "ces", new CountryName(official: "Republika Pobřeží slonoviny", common: "Pobřeží slonoviny") },
                { "cym", new CountryName(official: "Republic of Côte d'Ivoire", common: "Ivory Coast") },
                { "deu", new CountryName(official: "Republik Côte d'Ivoire", common: "Elfenbeinküste") },
                { "est", new CountryName(official: "Côte d’Ivoire’i Vabariik", common: "Elevandiluurannik") },
                { "fin", new CountryName(official: "Norsunluurannikon tasavalta", common: "Norsunluurannikko") },
                { "hrv", new CountryName(official: "Republika Côte d'Ivoire", common: "Obala Bjelokosti") },
                { "hun", new CountryName(official: "Elefántcsontparti Köztársaság", common: "Elefántcsontpart") },
                { "ita", new CountryName(official: "Repubblica della Costa d'Avorio", common: "Costa d'Avorio") },
                { "jpn", new CountryName(official: "コートジボワール共和国", common: "コートジボワール") },
                { "kor", new CountryName(official: "코트디부아르 공화국", common: "코트디부아르") },
                { "nld", new CountryName(official: "Republiek Ivoorkust", common: "Ivoorkust") },
                { "per", new CountryName(official: "جمهوری ساحل عاج", common: "ساحل عاج") },
                { "pol", new CountryName(official: "Republika WybrzeŻa Kości Słoniowej", common: "WybrzeŻe Kości Słoniowej") },
                { "por", new CountryName(official: "República da Côte d'Ivoire", common: "Costa do Marfim") },
                { "rus", new CountryName(official: "Республика Кот-д'Ивуаре", common: "Кот-д’Ивуар") },
                { "slk", new CountryName(official: "Republika Pobrežie Slonoviny", common: "Pobržie Slonoviny") },
                { "spa", new CountryName(official: "República de Côte d'Ivoire", common: "Costa de Marfil") },
                { "swe", new CountryName(official: "Republiken Elfenbenskusten", common: "Elfenbenskusten") },
                { "urd", new CountryName(official: "جمہوریہ کوت دیواغ", common: "آئیوری کوسٹ") },
                { "zho", new CountryName(official: "科特迪瓦共和国", common: "科特迪瓦") },

            },
            cca2: "CI",
            cca3: "CIV",
            ccn3: "384",
            cioc: "CIV",
            flag: "🇨🇮",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"25", }),
            borders: new string[] { "BFA", "GHA", "GIN", "LBR", "MLI",  },
            capital: new string[] { "Yamoussoukro",  },
            altSpellings: new string[] { "CI", "Côte d'Ivoire", "Ivory Coast", "Republic of Côte d'Ivoire", "République de Côte d'Ivoire",  },
            tld: new string[] { ".ci",  },
            latlng: new double[] { 8, -5,  },
            timezones: new string[] { "UTC",  },
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
                { "eng", new DemonymsGender(male: "Ivorian", female: "Ivorian") },
                { "fra", new DemonymsGender(male: "Ivorian", female: "Ivorian") },
            }
        );

        /// <summary>
        /// create an instance of IvoryCoast country
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
        private IvoryCoast(
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
