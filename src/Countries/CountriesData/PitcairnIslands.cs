namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of PitcairnIslands country
    /// </summary>
    public class PitcairnIslands : Country
    {
        /// <summary>
        /// get the PitcairnIslands country instance
        /// </summary>
        public static PitcairnIslands Instance = new PitcairnIslands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Pitcairn Group of Islands", common: "Pitcairn Islands") },
                { "ara", new CountryName(official: "جزر بيتكيرن", common: "جزر بيتكيرن") },
                { "ces", new CountryName(official: "Pitcairnovy ostrovy", common: "Pitcairnovy ostrovy") },
                { "cym", new CountryName(official: "Pitcairn Group of Islands", common: "Pitcairn Islands") },
                { "deu", new CountryName(official: "Pitcairninseln", common: "Pitcairninseln") },
                { "est", new CountryName(official: "Pitcairni, Hendersoni, Ducie ja Oeno saar", common: "Pitcairn") },
                { "fin", new CountryName(official: "Pitcairn", common: "Pitcairn") },
                { "fra", new CountryName(official: "Groupe d'îles Pitcairn", common: "Îles Pitcairn") },
                { "hrv", new CountryName(official: "Pitcairn skupine otoka", common: "Pitcairnovo otočje") },
                { "hun", new CountryName(official: "Pitcairn-szigetek", common: "Pitcairn-szigetek") },
                { "ita", new CountryName(official: "Pitcairn gruppo di isole", common: "Isole Pitcairn") },
                { "jpn", new CountryName(official: "島のピトケアングループ", common: "ピトケアン") },
                { "kor", new CountryName(official: "핏케언 제도", common: "핏케언 제도") },
                { "nld", new CountryName(official: "Pitcairn groep eilanden", common: "Pitcairneilanden") },
                { "per", new CountryName(official: "جزایر پیت‌کرن", common: "جزایر پیت‌کرن") },
                { "pol", new CountryName(official: "Wyspy Pitcairn, Henderson, Ducie i Oeno", common: "Pitcairn") },
                { "por", new CountryName(official: "Pitcairn grupo de ilhas", common: "Ilhas Pitcairn") },
                { "rus", new CountryName(official: "Питкэрн группа островов", common: "Острова Питкэрн") },
                { "slk", new CountryName(official: "Pitcairnove ostrovy", common: "Pitcairnove ostrovy") },
                { "spa", new CountryName(official: "Grupo de Islas Pitcairn", common: "Islas Pitcairn") },
                { "swe", new CountryName(official: "Pitcairnöarna", common: "Pitcairnöarna") },
                { "urd", new CountryName(official: "پٹکیرن جزائر", common: "جزائر پٹکیرن") },
                { "zho", new CountryName(official: "皮特凯恩群岛", common: "皮特凯恩群岛") },
            },
            cca2: "PN",
            cca3: "PCN",
            ccn3: "612",
            cioc: "",
            flag: "🇵🇳",
            region: Region.Oceania,
            subregion: "Polynesia",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"4", }),
            borders: new string[] {  },
            capital: new string[] { "Adamstown",  },
            altSpellings: new string[] { "PN", "Pitcairn", "Pitcairn Henderson Ducie and Oeno Islands",  },
            tld: new string[] { ".pn",  },
            latlng: new double[] { -25.06666666, -130.1,  },
            timezones: new string[] { "UTC-08:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "NZD", name: "New Zealand dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Pitcairn Islander", female: "Pitcairn Islander") },
                { "fra", new DemonymsGender(male: "Pitcairn Islander", female: "Pitcairn Islander") },
            }
        );

        /// <summary>
        /// create an instance of PitcairnIslands country
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
        private PitcairnIslands(
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
