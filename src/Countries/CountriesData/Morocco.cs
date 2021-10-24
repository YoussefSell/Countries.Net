namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Morocco country
    /// </summary>
    public class Morocco : Country
    {
        /// <summary>
        /// get the Morocco country instance
        /// </summary>
        public static Morocco Instance = new Morocco(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Kingdom of Morocco", common: "Morocco") },
                { "ara", new CountryName(official: "المملكة المغربية", common: "المغرب") },
                { "ber", new CountryName(official: "ⵜⴰⴳⵍⴷⵉⵜ ⵏ ⵍⵎⵖⵔⵉⴱ", common: "ⵍⵎⴰⵖⵔⵉⴱ") },
                { "ces", new CountryName(official: "Marocké království", common: "Maroko") },
                { "cym", new CountryName(official: "Kingdom of Morocco", common: "Morocco") },
                { "deu", new CountryName(official: "Königreich Marokko", common: "Marokko") },
                { "est", new CountryName(official: "Maroko Kuningriik", common: "Maroko") },
                { "fin", new CountryName(official: "Marokon kuningaskunta", common: "Marokko") },
                { "fra", new CountryName(official: "Royaume du Maroc", common: "Maroc") },
                { "hrv", new CountryName(official: "Kraljevina Maroko", common: "Maroko") },
                { "hun", new CountryName(official: "Marokkói Királyság", common: "Marokkó") },
                { "ita", new CountryName(official: "Regno del Marocco", common: "Marocco") },
                { "jpn", new CountryName(official: "モロッコ王国", common: "モロッコ") },
                { "kor", new CountryName(official: "모로코 왕국", common: "모로코") },
                { "nld", new CountryName(official: "Koninkrijk Marokko", common: "Marokko") },
                { "per", new CountryName(official: "پادشاهی مراکش", common: "مراکش") },
                { "pol", new CountryName(official: "Królestwo Marokańskie", common: "Maroko") },
                { "por", new CountryName(official: "Reino de Marrocos", common: "Marrocos") },
                { "rus", new CountryName(official: "Королевство Марокко", common: "Марокко") },
                { "slk", new CountryName(official: "Marocké kniežatstvo", common: "Maroko") },
                { "spa", new CountryName(official: "Reino de Marruecos", common: "Marruecos") },
                { "swe", new CountryName(official: "Konungariket Marocko", common: "Marocko") },
                { "urd", new CountryName(official: "مملکتِ مراکش", common: "مراکش") },
                { "zho", new CountryName(official: "摩洛哥王国", common: "摩洛哥") },

            },
            cca2: "MA",
            cca3: "MAR",
            ccn3: "504",
            cioc: "MAR",
            flag: "🇲🇦",
            region: Region.Africa,
            subregion: "Northern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"12", }),
            borders: new string[] { "DZA", "ESH", "ESP",  },
            capital: new string[] { "Rabat",  },
            altSpellings: new string[] { "MA", "Kingdom of Morocco", "Al-Mamlakah al-Maġribiyah",  },
            tld: new string[] { ".ma", "المغرب.",  },
            latlng: new double[] { 32, -5,  },
            timezones: new string[] { "UTC",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
                new Language(name: "Berber", iso6391: "", iso6392: "ber"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "MAD", name: "Moroccan dirham", symbol: "د.م."),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Moroccan", female: "Moroccan") },
                { "fra", new DemonymsGender(male: "Moroccan", female: "Moroccan") },
            }
        );

        /// <summary>
        /// create an instance of Morocco country
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
        private Morocco(
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
