namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Angola country
    /// </summary>
    public class Angola : Country
    {
        /// <summary>
        /// get the Angola country instance
        /// </summary>
        public static Angola Instance = new Angola(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Angola", common: "Angola") },
                { "por", new CountryName(official: "República de Angola", common: "Angola") },
                { "ara", new CountryName(official: "أنغولا", common: "جمهورية أنغولا") },
                { "ces", new CountryName(official: "Angolská republika", common: "Angola") },
                { "cym", new CountryName(official: "Gweriniaeth Angola", common: "Angola") },
                { "deu", new CountryName(official: "Republik Angola", common: "Angola") },
                { "est", new CountryName(official: "Angola Vabariik", common: "Angola") },
                { "fin", new CountryName(official: "Angolan tasavalta", common: "Angola") },
                { "fra", new CountryName(official: "République d'Angola", common: "Angola") },
                { "hrv", new CountryName(official: "Republika Angola", common: "Angola") },
                { "hun", new CountryName(official: "Angola", common: "Angola") },
                { "ita", new CountryName(official: "Repubblica dell'Angola", common: "Angola") },
                { "jpn", new CountryName(official: "アンゴラ共和国", common: "アンゴラ") },
                { "kor", new CountryName(official: "앙골라 공화국", common: "앙골라") },
                { "nld", new CountryName(official: "Republiek Angola", common: "Angola") },
                { "per", new CountryName(official: "جمهوری آنگولا", common: "آنگولا") },
                { "pol", new CountryName(official: "Republika Angoli", common: "Angola") },
                { "rus", new CountryName(official: "Республика Ангола", common: "Ангола") },
                { "slk", new CountryName(official: "Angolská republika", common: "Angola") },
                { "spa", new CountryName(official: "República de Angola", common: "Angola") },
                { "swe", new CountryName(official: "Republiken Angola", common: "Angola") },
                { "urd", new CountryName(official: "جمہوریہ انگولہ", common: "انگولہ") },
                { "zho", new CountryName(official: "安哥拉共和国", common: "安哥拉") },

            },
            cca2: "AO",
            cca3: "AGO",
            ccn3: "024",
            cioc: "ANG",
            flag: "🇦🇴",
            region: Region.Africa,
            subregion: "Middle Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"44", }),
            borders: new string[] { "COG", "COD", "ZMB", "NAM",  },
            capital: new string[] { "Luanda",  },
            altSpellings: new string[] { "AO", "República de Angola", "ʁɛpublika de an'ɡɔla",  },
            tld: new string[] { ".ao",  },
            latlng: new double[] { -12.5, 18.5,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Portuguese", iso6391: "pt", iso6392: "por"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "AOA", name: "Angolan kwanza", symbol: "Kz"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Angolan", female: "Angolan") },
                { "fra", new DemonymsGender(male: "Angolan", female: "Angolan") },
            }
        );

        /// <summary>
        /// create an instance of Angola country
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
        private Angola(
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
