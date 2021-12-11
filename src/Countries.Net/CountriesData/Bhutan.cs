namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Bhutan country
    /// </summary>
    public class Bhutan : Country
    {
        /// <summary>
        /// get the Bhutan country instance
        /// </summary>
        public static Bhutan Instance = new Bhutan(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Kingdom of Bhutan", common: "Bhutan") },
                { "dzo", new CountryName(official: "འབྲུག་རྒྱལ་ཁབ་", common: "འབྲུག་ཡུལ་") },
                { "ara", new CountryName(official: "مملكة بوتان", common: "بوتان") },
                { "ces", new CountryName(official: "Bhútánské království", common: "Bhútán") },
                { "cym", new CountryName(official: "Teyrnas Bhwtan", common: "Bhwtan") },
                { "deu", new CountryName(official: "Königreich Bhutan", common: "Bhutan") },
                { "est", new CountryName(official: "Bhutani Kuningriik", common: "Bhutan") },
                { "fin", new CountryName(official: "Bhutanin kuningaskunta", common: "Bhutan") },
                { "fra", new CountryName(official: "Royaume du Bhoutan", common: "Bhoutan") },
                { "hrv", new CountryName(official: "Kraljevina Butan", common: "Butan") },
                { "hun", new CountryName(official: "Bhutáni Királyság", common: "Bhután") },
                { "ita", new CountryName(official: "Regno del Bhutan", common: "Bhutan") },
                { "jpn", new CountryName(official: "ブータン王国", common: "ブータン") },
                { "kor", new CountryName(official: "부탄 왕국", common: "부탄") },
                { "nld", new CountryName(official: "Koninkrijk Bhutan", common: "Bhutan") },
                { "per", new CountryName(official: "پادشاهی بوتان", common: "بوتان") },
                { "pol", new CountryName(official: "Bhutan", common: "Bhutan") },
                { "por", new CountryName(official: "Reino do Butão", common: "Butão") },
                { "rus", new CountryName(official: "Королевство Бутан", common: "Бутан") },
                { "slk", new CountryName(official: "Bhutánske krâľovstvo", common: "Bhután") },
                { "spa", new CountryName(official: "Reino de Bután", common: "Bután") },
                { "swe", new CountryName(official: "Konungariket Bhutan", common: "Bhutan") },
                { "urd", new CountryName(official: "سلطنت بھوٹان", common: "بھوٹان") },
                { "zho", new CountryName(official: "不丹王国", common: "不丹") },
            },
            cca2: "BT",
            cca3: "BTN",
            ccn3: "064",
            cioc: "BHU",
            flag: "🇧🇹",
            region: Region.Asia,
            subregion: "Southern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"75", }),
            borders: new string[] { "CHN", "IND",  },
            capital: new string[] { "Thimphu",  },
            altSpellings: new string[] { "BT", "Kingdom of Bhutan",  },
            tld: new string[] { ".bt",  },
            latlng: new double[] { 27.5, 90.5,  },
            timezones: new string[] { "UTC+06:00",  },
            languages: new Language[]
            {
                new Language(name: "Dzongkha", iso6391: "dz", iso6392: "dzo"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "BTN", name: "Bhutanese ngultrum", symbol: "Nu."),
                new Currency(code: "INR", name: "Indian rupee", symbol: "₹"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Bhutanese", female: "Bhutanese") },
                { "fra", new DemonymsGender(male: "Bhutanese", female: "Bhutanese") },
            }
        );

        /// <summary>
        /// create an instance of Bhutan country
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
        private Bhutan(
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
