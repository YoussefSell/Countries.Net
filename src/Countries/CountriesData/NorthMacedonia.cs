namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of NorthMacedonia country
    /// </summary>
    public class NorthMacedonia : Country
    {
        /// <summary>
        /// get the NorthMacedonia country instance
        /// </summary>
        public static NorthMacedonia Instance = new NorthMacedonia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of North Macedonia", common: "North Macedonia") },
                { "mkd", new CountryName(official: "Република Северна Македонија", common: "Македонија") },
                { "ara", new CountryName(official: "جمهورية شمال مقدونيا", common: "شمال مقدونيا") },
                { "ces", new CountryName(official: "Republika Severní Makedonie", common: "Severní Makedonie") },
                { "cym", new CountryName(official: "Republic of North Macedonia", common: "North Macedonia") },
                { "deu", new CountryName(official: "Republik Nordmazedonien", common: "Nordmazedonien") },
                { "est", new CountryName(official: "Põhja-Makedoonia Vabariik", common: "Põhja-Makedoonia") },
                { "fin", new CountryName(official: "Pohjois-Makedonian tasavalta", common: "Pohjois-Makedonia") },
                { "fra", new CountryName(official: "République de Macédoine du Nord", common: "Macédoine du Nord") },
                { "hrv", new CountryName(official: "Republika Sjeverna Makedonija", common: "Sjeverna Makedonija") },
                { "hun", new CountryName(official: "Észak-macedón Köztársaság", common: "Észak-Macedónia") },
                { "ita", new CountryName(official: "Repubblica di Macedonia del Nord", common: "Macedonia del Nord") },
                { "jpn", new CountryName(official: "北マケドニア共和国", common: "北マケドニア ") },
                { "kor", new CountryName(official: "북마케도니아 공화국", common: "북마케도니아") },
                { "nld", new CountryName(official: "Republiek Noord-Macedonië", common: "Noord-Macedonië") },
                { "per", new CountryName(official: "جمهوری مقدونیه شمالی", common: "مقدونیه شمالی") },
                { "pol", new CountryName(official: "Republika Macedonii Północnej", common: "Macedonia Północna") },
                { "por", new CountryName(official: "República da Macedônia do Norte", common: "Macedónia do Norte") },
                { "rus", new CountryName(official: "Республика Северная Македония", common: "Северная Македония") },
                { "slk", new CountryName(official: "Severomacedónska republika", common: "Severné Macedónsko") },
                { "spa", new CountryName(official: "República de Macedonia del Norte", common: "Macedonia del Norte") },
                { "swe", new CountryName(official: "Republiken Nordmakedonien", common: "Nordmakedonien") },
                { "urd", new CountryName(official: "جمہوریہ مقدونیہ", common: "شمالی مقدونیہ") },
                { "zho", new CountryName(official: "北馬其頓共和國", common: "北馬其頓") },
            },
            cca2: "MK",
            cca3: "MKD",
            ccn3: "807",
            cioc: "MKD",
            flag: "🇲🇰",
            region: Region.Europe,
            subregion: "Southeast Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"89", }),
            borders: new string[] { "ALB", "BGR", "GRC", "UNK", "SRB",  },
            capital: new string[] { "Skopje",  },
            altSpellings: new string[] { "MK", "The former Yugoslav Republic of Macedonia", "Republic of North Macedonia", "Macedonia, The Former Yugoslav Republic of", "Република Северна Македонија",  },
            tld: new string[] { ".mk",  },
            latlng: new double[] { 41.83333333, 22,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Macedonian", iso6391: "mk", iso6392: "mkd"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "MKD", name: "denar", symbol: "den"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Macedonian", female: "Macedonian") },
                { "fra", new DemonymsGender(male: "Macedonian", female: "Macedonian") },
            }
        );

        /// <summary>
        /// create an instance of NorthMacedonia country
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
        private NorthMacedonia(
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
