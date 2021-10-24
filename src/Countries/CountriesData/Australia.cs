namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Australia country
    /// </summary>
    public class Australia : Country
    {
        /// <summary>
        /// get the Australia country instance
        /// </summary>
        public static Australia Instance = new Australia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Commonwealth of Australia", common: "Australia") },
                { "ara", new CountryName(official: "كومونولث أستراليا", common: "أستراليا") },
                { "ces", new CountryName(official: "Australské společenství", common: "Austrálie") },
                { "cym", new CountryName(official: "Cymanwlad Awstralia", common: "Awstralia") },
                { "deu", new CountryName(official: "Commonwealth Australien", common: "Australien") },
                { "est", new CountryName(official: "Austraalia Ühendus", common: "Austraalia") },
                { "fin", new CountryName(official: "Australian liittovaltio", common: "Australia") },
                { "fra", new CountryName(official: "Australie", common: "Australie") },
                { "hrv", new CountryName(official: "Commonwealth of Australia", common: "Australija") },
                { "hun", new CountryName(official: "Ausztrál Államszövetség", common: "Ausztrália") },
                { "ita", new CountryName(official: "Commonwealth dell'Australia", common: "Australia") },
                { "jpn", new CountryName(official: "オーストラリア連邦", common: "オーストラリア") },
                { "kor", new CountryName(official: "오스트레일리아 연방", common: "호주") },
                { "nld", new CountryName(official: "Gemenebest van Australië", common: "Australië") },
                { "per", new CountryName(official: "قلمرو همسود استرالیا", common: "استرالیا") },
                { "pol", new CountryName(official: "Związek Australijski", common: "Australia") },
                { "por", new CountryName(official: "Comunidade da Austrália", common: "Austrália") },
                { "rus", new CountryName(official: "Содружество Австралии", common: "Австралия") },
                { "slk", new CountryName(official: "Austrálsky zväz", common: "Austrália") },
                { "spa", new CountryName(official: "Mancomunidad de Australia", common: "Australia") },
                { "swe", new CountryName(official: "Australiska statsförbundet", common: "Australien") },
                { "urd", new CountryName(official: "دولتِ مشترکہ آسٹریلیا", common: "آسٹریلیا") },
                { "zho", new CountryName(official: "澳大利亚联邦", common: "澳大利亚") },
            },
            cca2: "AU",
            cca3: "AUS",
            ccn3: "036",
            cioc: "AUS",
            flag: "🇦🇺",
            region: Region.Oceania,
            subregion: "Australia and New Zealand",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"1", }),
            borders: new string[] {  },
            capital: new string[] { "Canberra",  },
            altSpellings: new string[] { "AU",  },
            tld: new string[] { ".au",  },
            latlng: new double[] { -27, 133,  },
            timezones: new string[] { "UTC+05:00", "UTC+06:30", "UTC+07:00", "UTC+08:00", "UTC+09:30", "UTC+10:00", "UTC+10:30", "UTC+11:30",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "AUD", name: "Australian dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Australian", female: "Australian") },
                { "fra", new DemonymsGender(male: "Australian", female: "Australian") },
            }
        );

        /// <summary>
        /// create an instance of Australia country
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
        private Australia(
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
