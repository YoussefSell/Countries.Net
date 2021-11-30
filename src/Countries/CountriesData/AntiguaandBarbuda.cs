namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of AntiguaandBarbuda country
    /// </summary>
    public class AntiguaandBarbuda : Country
    {
        /// <summary>
        /// get the AntiguaandBarbuda country instance
        /// </summary>
        public static AntiguaandBarbuda Instance = new AntiguaandBarbuda(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Antigua and Barbuda", common: "Antigua and Barbuda") },
                { "ara", new CountryName(official: "أنتيغوا وباربودا", common: "أنتيغوا وباربودا") },
                { "ces", new CountryName(official: "Antigua a Barbuda", common: "Antigua a Barbuda") },
                { "cym", new CountryName(official: "Antigwa a Barbiwda", common: "Antigwa a Barbiwda") },
                { "deu", new CountryName(official: "Antigua und Barbuda", common: "Antigua und Barbuda") },
                { "est", new CountryName(official: "Antigua ja Barbuda", common: "Antigua ja Barbuda") },
                { "fin", new CountryName(official: "Antigua ja Barbuda", common: "Antigua ja Barbuda") },
                { "fra", new CountryName(official: "Antigua -et-Barbuda", common: "Antigua-et-Barbuda") },
                { "hrv", new CountryName(official: "Antigva i Barbuda", common: "Antigva i Barbuda") },
                { "hun", new CountryName(official: "Antigua és Barbuda", common: "Antigua és Barbuda") },
                { "ita", new CountryName(official: "Antigua e Barbuda", common: "Antigua e Barbuda") },
                { "jpn", new CountryName(official: "アンチグアバーブーダ", common: "アンティグア・バーブーダ") },
                { "kor", new CountryName(official: "앤티가 바부다", common: "앤티가 바부다") },
                { "nld", new CountryName(official: "Antigua en Barbuda", common: "Antigua en Barbuda") },
                { "per", new CountryName(official: "آنتیگوا و باربودا", common: "آنتیگوا و باربودا") },
                { "pol", new CountryName(official: "Antigua i Barbuda", common: "Antigua i Barbuda") },
                { "por", new CountryName(official: "Antigua e Barbuda", common: "Antígua e Barbuda") },
                { "rus", new CountryName(official: "Антигуа и Барбуда", common: "Антигуа и Барбуда") },
                { "slk", new CountryName(official: "Antigua a Barbuda", common: "Antigua a Barbuda") },
                { "spa", new CountryName(official: "Antigua y Barbuda", common: "Antigua y Barbuda") },
                { "swe", new CountryName(official: "Antigua och Barbuda", common: "Antigua och Barbuda") },
                { "urd", new CountryName(official: "اینٹیگوا و باربوڈا", common: "اینٹیگوا و باربوڈا") },
                { "zho", new CountryName(official: "安提瓜和巴布达", common: "安提瓜和巴布达") },
            },
            cca2: "AG",
            cca3: "ATG",
            ccn3: "028",
            cioc: "ANT",
            flag: "🇦🇬",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"268", }),
            borders: new string[] {  },
            capital: new string[] { "Saint John's",  },
            altSpellings: new string[] { "AG",  },
            tld: new string[] { ".ag",  },
            latlng: new double[] { 17.05, -61.8,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XCD", name: "Eastern Caribbean dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Antiguan, Barbudan", female: "Antiguan, Barbudan") },
                { "fra", new DemonymsGender(male: "Antiguan, Barbudan", female: "Antiguan, Barbudan") },
            }
        );

        /// <summary>
        /// create an instance of AntiguaandBarbuda country
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
        private AntiguaandBarbuda(
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
