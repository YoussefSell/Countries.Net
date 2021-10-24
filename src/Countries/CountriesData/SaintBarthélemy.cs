namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of SaintBarthélemy country
    /// </summary>
    public class SaintBarthélemy : Country
    {
        /// <summary>
        /// get the SaintBarthélemy country instance
        /// </summary>
        public static SaintBarthélemy Instance = new SaintBarthélemy(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Collectivity of Saint Barthélemy", common: "Saint Barthélemy") },
                { "fra", new CountryName(official: "Collectivité de Saint-Barthélemy", common: "Saint-Barthélemy") },
                { "ara", new CountryName(official: "التجمع الإقليمي لسانت بارتيليمي", common: "سان بارتليمي") },
                { "ces", new CountryName(official: "Svatý Bartoloměj", common: "Svatý Bartoloměj") },
                { "cym", new CountryName(official: "Collectivity of Saint Barthélemy", common: "Saint Barthélemy") },
                { "deu", new CountryName(official: "Gebietskörperschaft Saint-Barthélemy", common: "Saint-Barthélemy") },
                { "est", new CountryName(official: "Saint-Barthélemy territoriaalühendus", common: "Saint-Barthélemy") },
                { "fin", new CountryName(official: "Saint-Barthélemyn yhteisö", common: "Saint-Barthélemy") },
                { "hrv", new CountryName(official: "Kolektivnost sv Barthélemy", common: "Saint Barthélemy") },
                { "hun", new CountryName(official: "Saint-Barthélemy", common: "Saint-Barthélemy") },
                { "ita", new CountryName(official: "Collettività di Saint Barthélemy", common: "Antille Francesi") },
                { "jpn", new CountryName(official: "サン·バルテルミー島の集合体", common: "サン・バルテルミー") },
                { "kor", new CountryName(official: "생바르텔레미", common: "생바르텔레미") },
                { "nld", new CountryName(official: "Gemeenschap Saint Barthélemy", common: "Saint Barthélemy") },
                { "per", new CountryName(official: "سن بارتلمی", common: "سن بارتلمی") },
                { "pol", new CountryName(official: "Saint-Barthélemy", common: "Saint-Barthélemy") },
                { "por", new CountryName(official: "Coletividade de Saint Barthélemy", common: "São Bartolomeu") },
                { "rus", new CountryName(official: "Коллективность Санкт -Бартельми", common: "Сен-Бартелеми") },
                { "slk", new CountryName(official: "Svätý Bartolomej", common: "Svätý Bartolomej") },
                { "spa", new CountryName(official: "Colectividad de San Barthélemy", common: "San Bartolomé") },
                { "swe", new CountryName(official: "Saint-Barthélemy", common: "Saint-Barthélemy") },
                { "urd", new CountryName(official: "سینٹ بارتھیملے", common: "سینٹ بارتھیملے") },
                { "zho", new CountryName(official: "圣巴泰勒米集体", common: "圣巴泰勒米") },

            },
            cca2: "BL",
            cca3: "BLM",
            ccn3: "652",
            cioc: "",
            flag: "🇧🇱",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"90", }),
            borders: new string[] {  },
            capital: new string[] { "Gustavia",  },
            altSpellings: new string[] { "BL", "St. Barthelemy", "Collectivity of Saint Barthélemy", "Collectivité de Saint-Barthélemy",  },
            tld: new string[] { ".bl",  },
            latlng: new double[] { 18.5, -63.41666666,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Saint Barthélemy Islander", female: "Saint Barthélemy Islander") },
                { "fra", new DemonymsGender(male: "Saint Barthélemy Islander", female: "Saint Barthélemy Islander") },
            }
        );

        /// <summary>
        /// create an instance of SaintBarthélemy country
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
        private SaintBarthélemy(
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
