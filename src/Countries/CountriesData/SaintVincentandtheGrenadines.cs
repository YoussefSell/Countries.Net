namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of SaintVincentandtheGrenadines country
    /// </summary>
    public class SaintVincentandtheGrenadines : Country
    {
        /// <summary>
        /// get the SaintVincentandtheGrenadines country instance
        /// </summary>
        public static SaintVincentandtheGrenadines Instance = new SaintVincentandtheGrenadines(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Saint Vincent and the Grenadines", common: "Saint Vincent and the Grenadines") },
                { "ara", new CountryName(official: "سانت فينسنت والغرينادين", common: "سانت فينسنت والغرينادين") },
                { "ces", new CountryName(official: "Svatý Vincenc a Grenadiny", common: "Svatý Vincenc a Grenadiny") },
                { "cym", new CountryName(official: "Saint Vincent and the Grenadines", common: "Saint Vincent and the Grenadines") },
                { "deu", new CountryName(official: "St. Vincent und die Grenadinen", common: "St. Vincent und die Grenadinen") },
                { "est", new CountryName(official: "Saint Vincent ja Grenadiinid", common: "Saint Vincent") },
                { "fin", new CountryName(official: "Saint Vincent ja Grenadiinit", common: "Saint Vincent ja Grenadiinit") },
                { "fra", new CountryName(official: "Saint-Vincent-et-les Grenadines", common: "Saint-Vincent-et-les-Grenadines") },
                { "hrv", new CountryName(official: "Sveti Vincent i Grenadini", common: "Sveti Vincent i Grenadini") },
                { "hun", new CountryName(official: "Saint Vincent és a Grenadine-szigetek", common: "Saint Vincent és a Grenadine-szigetek") },
                { "ita", new CountryName(official: "Saint Vincent e Grenadine", common: "Saint Vincent e Grenadine") },
                { "jpn", new CountryName(official: "セントビンセントおよびグレナディーン諸島", common: "セントビンセントおよびグレナディーン諸島") },
                { "kor", new CountryName(official: "세인트빈센트 그레나딘", common: "세인트빈센트 그레나딘") },
                { "nld", new CountryName(official: "Saint Vincent en de Grenadines", common: "Saint Vincent en de Grenadines") },
                { "per", new CountryName(official: "سنت وینسنت و گرنادین‌ها", common: "سنت وینسنت و گرنادین‌ها") },
                { "pol", new CountryName(official: "Saint Vincent i Grenadyny", common: "Saint Vincent i Grenadyny") },
                { "por", new CountryName(official: "São Vicente e Granadinas", common: "São Vincente e Granadinas") },
                { "rus", new CountryName(official: "Сент-Винсент и Гренадины", common: "Сент-Винсент и Гренадины") },
                { "slk", new CountryName(official: "Svätý Vincent a Grenadíny", common: "Svätý Vincent a Grenadíny") },
                { "spa", new CountryName(official: "San Vicente y las Granadinas", common: "San Vicente y Granadinas") },
                { "swe", new CountryName(official: "Saint Vincent och Grenadinerna", common: "Saint Vincent och Grenadinerna") },
                { "urd", new CountryName(official: "سینٹ وینسینٹ و گریناڈائنز", common: "سینٹ وینسینٹ و گریناڈائنز") },
                { "zho", new CountryName(official: "圣文森特和格林纳丁斯", common: "圣文森特和格林纳丁斯") },
            },
            cca2: "VC",
            cca3: "VCT",
            ccn3: "670",
            cioc: "VIN",
            flag: "🇻🇨",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"784", }),
            borders: new string[] {  },
            capital: new string[] { "Kingstown",  },
            altSpellings: new string[] { "VC",  },
            tld: new string[] { ".vc",  },
            latlng: new double[] { 13.25, -61.2,  },
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
                { "eng", new DemonymsGender(male: "Saint Vincentian", female: "Saint Vincentian") },
                { "fra", new DemonymsGender(male: "Saint Vincentian", female: "Saint Vincentian") },
            }
        );

        /// <summary>
        /// create an instance of SaintVincentandtheGrenadines country
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
        private SaintVincentandtheGrenadines(
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
