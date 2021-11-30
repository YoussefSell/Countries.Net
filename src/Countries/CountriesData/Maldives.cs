namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Maldives country
    /// </summary>
    public class Maldives : Country
    {
        /// <summary>
        /// get the Maldives country instance
        /// </summary>
        public static Maldives Instance = new Maldives(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of the Maldives", common: "Maldives") },
                { "div", new CountryName(official: "ދިވެހިރާއްޖޭގެ ޖުމްހޫރިއްޔާ", common: "ދިވެހިރާއްޖޭގެ") },
                { "ara", new CountryName(official: "جمهورية المالديف", common: "المالديف") },
                { "ces", new CountryName(official: "Maledivská republika", common: "Maledivy") },
                { "cym", new CountryName(official: "Republic of the Maldives", common: "Maldives") },
                { "deu", new CountryName(official: "Republik Malediven", common: "Malediven") },
                { "est", new CountryName(official: "Maldiivi Vabariik", common: "Maldiivid") },
                { "fin", new CountryName(official: "Malediivien tasavalta", common: "Malediivit") },
                { "fra", new CountryName(official: "République des Maldives", common: "Maldives") },
                { "hrv", new CountryName(official: "Republika Maldivi", common: "Maldivi") },
                { "hun", new CountryName(official: "Maldív-szigetek", common: "Maldív-szigetek") },
                { "ita", new CountryName(official: "Repubblica delle Maldive", common: "Maldive") },
                { "jpn", new CountryName(official: "モルディブ共和国", common: "モルディブ") },
                { "kor", new CountryName(official: "몰디브 공화국", common: "몰디브") },
                { "nld", new CountryName(official: "Republiek van de Malediven", common: "Maldiven") },
                { "per", new CountryName(official: "جمهوری مالدیو", common: "مالدیو") },
                { "pol", new CountryName(official: "Republika Malediwów", common: "Malediwy") },
                { "por", new CountryName(official: "República das Maldivas", common: "Maldivas") },
                { "rus", new CountryName(official: "Республика Мальдивы", common: "Мальдивы") },
                { "slk", new CountryName(official: "Maldivská republika", common: "Maldivy") },
                { "spa", new CountryName(official: "República de las Maldivas", common: "Maldivas") },
                { "swe", new CountryName(official: "Republiken Maldiverna", common: "Maldiverna") },
                { "urd", new CountryName(official: "جمہوریہ مالدیپ", common: "مالدیپ") },
                { "zho", new CountryName(official: "马尔代夫共和国", common: "马尔代夫") },
            },
            cca2: "MV",
            cca3: "MDV",
            ccn3: "462",
            cioc: "MDV",
            flag: "🇲🇻",
            region: Region.Asia,
            subregion: "Southern Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"60", }),
            borders: new string[] {  },
            capital: new string[] { "Malé",  },
            altSpellings: new string[] { "MV", "Maldive Islands", "Republic of the Maldives", "Dhivehi Raajjeyge Jumhooriyya",  },
            tld: new string[] { ".mv",  },
            latlng: new double[] { 3.25, 73,  },
            timezones: new string[] { "UTC+05:00",  },
            languages: new Language[]
            {
                new Language(name: "Maldivian", iso6391: "dv", iso6392: "div"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "MVR", name: "Maldivian rufiyaa", symbol: ".ރ"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Maldivan", female: "Maldivan") },
                { "fra", new DemonymsGender(male: "Maldivan", female: "Maldivan") },
            }
        );

        /// <summary>
        /// create an instance of Maldives country
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
        private Maldives(
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
