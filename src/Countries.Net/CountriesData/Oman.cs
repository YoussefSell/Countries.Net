namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Oman country
    /// </summary>
    public class Oman : Country
    {
        /// <summary>
        /// get the Oman country instance
        /// </summary>
        public static Oman Instance = new Oman(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Sultanate of Oman", common: "Oman") },
                { "ara", new CountryName(official: "سلطنة عمان", common: "عمان") },
                { "ces", new CountryName(official: "Sultanát Omán", common: "Omán") },
                { "cym", new CountryName(official: "Sultanate of Oman", common: "Oman") },
                { "deu", new CountryName(official: "Sultanat Oman", common: "Oman") },
                { "est", new CountryName(official: "Omaani Sultaniriik", common: "Omaan") },
                { "fin", new CountryName(official: "Omanin sulttaanikunta", common: "Oman") },
                { "fra", new CountryName(official: "Sultanat d'Oman", common: "Oman") },
                { "hrv", new CountryName(official: "Sultanat Oman", common: "Oman") },
                { "hun", new CountryName(official: "Ománi Szultanátus", common: "Omán") },
                { "ita", new CountryName(official: "Sultanato dell'Oman", common: "oman") },
                { "jpn", new CountryName(official: "オマーン·スルタン国", common: "オマーン") },
                { "kor", new CountryName(official: "오만 술탄국", common: "오만") },
                { "nld", new CountryName(official: "Sultanaat van Oman", common: "Oman") },
                { "per", new CountryName(official: "سلطان‌نشین عُمان", common: "عمان") },
                { "pol", new CountryName(official: "Sułtanat Omanu", common: "Oman") },
                { "por", new CountryName(official: "Sultanato de Omã", common: "Omã") },
                { "rus", new CountryName(official: "Султанат Оман", common: "Оман") },
                { "slk", new CountryName(official: "Ománsky sultanát", common: "Omán") },
                { "spa", new CountryName(official: "Sultanato de Omán", common: "Omán") },
                { "swe", new CountryName(official: "Sultanatet Oman", common: "Oman") },
                { "urd", new CountryName(official: "سلطنت عمان", common: "عمان") },
                { "zho", new CountryName(official: "阿曼苏丹国", common: "阿曼") },

            },
            cca2: "OM",
            cca3: "OMN",
            ccn3: "512",
            cioc: "OMA",
            flag: "🇴🇲",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"68", }),
            borders: new string[] { "SAU", "ARE", "YEM",  },
            capital: new string[] { "Muscat",  },
            altSpellings: new string[] { "OM", "Sultanate of Oman", "Salṭanat ʻUmān",  },
            tld: new string[] { ".om",  },
            latlng: new double[] { 21, 57,  },
            timezones: new string[] { "UTC+04:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "OMR", name: "Omani rial", symbol: "ر.ع."),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Omani", female: "Omani") },
                { "fra", new DemonymsGender(male: "Omani", female: "Omani") },
            }
        );

        /// <summary>
        /// create an instance of Oman country
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
        private Oman(
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
