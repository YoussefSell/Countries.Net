namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Belarus country
    /// </summary>
    public class Belarus : Country
    {
        /// <summary>
        /// get the Belarus country instance
        /// </summary>
        public static Belarus Instance = new Belarus(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Belarus", common: "Belarus") },
                { "bel", new CountryName(official: "Рэспубліка Беларусь", common: "Белару́сь") },
                { "rus", new CountryName(official: "Республика Беларусь", common: "Беларусь") },
                { "ara", new CountryName(official: "جمهورية بيلاروسيا", common: "بيلاروسيا") },
                { "ces", new CountryName(official: "Běloruská republika", common: "Bělorusko") },
                { "cym", new CountryName(official: "Gweriniaeth Belarws", common: "Belarws") },
                { "deu", new CountryName(official: "Republik Belarus", common: "Weißrussland") },
                { "est", new CountryName(official: "Valgevene Vabariik", common: "Valgevene") },
                { "fin", new CountryName(official: "Valko-Venäjän tasavalta", common: "Valko-Venäjä") },
                { "fra", new CountryName(official: "République de Biélorussie", common: "Biélorussie") },
                { "hrv", new CountryName(official: "Republika Bjelorusija", common: "Bjelorusija") },
                { "hun", new CountryName(official: "Fehérorosz Köztársaság", common: "Fehéroroszország") },
                { "ita", new CountryName(official: "Repubblica di Belarus", common: "Bielorussia") },
                { "jpn", new CountryName(official: "ベラルーシ共和国", common: "ベラルーシ") },
                { "kor", new CountryName(official: "벨라루스 공화국", common: "벨라루스") },
                { "nld", new CountryName(official: "Republiek Belarus", common: "Wit-Rusland") },
                { "per", new CountryName(official: "جمهوری بلاروس", common: "بلاروس") },
                { "pol", new CountryName(official: "Republika Białorusi", common: "Białoruś") },
                { "por", new CountryName(official: "República da Bielorrússia", common: "Bielorússia") },
                { "slk", new CountryName(official: "Bieloruská republika", common: "Bielorusko") },
                { "spa", new CountryName(official: "República de Belarús", common: "Bielorrusia") },
                { "swe", new CountryName(official: "Republiken Vitryssland", common: "Belarus") },
                { "urd", new CountryName(official: "جمہوریہ بیلاروس", common: "بیلاروس") },
                { "zho", new CountryName(official: "白俄罗斯共和国", common: "白俄罗斯") },

            },
            cca2: "BY",
            cca3: "BLR",
            ccn3: "112",
            cioc: "BLR",
            flag: "🇧🇾",
            region: Region.Europe,
            subregion: "Eastern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"75", }),
            borders: new string[] { "LVA", "LTU", "POL", "RUS", "UKR",  },
            capital: new string[] { "Minsk",  },
            altSpellings: new string[] { "BY", "Bielaruś", "Republic of Belarus", "Белоруссия", "Республика Белоруссия",  },
            tld: new string[] { ".by",  },
            latlng: new double[] { 53, 28,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "Belarusian", iso6391: "be", iso6392: "bel"),
                new Language(name: "Russian", iso6391: "ru", iso6392: "rus"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "BYN", name: "Belarusian ruble", symbol: "Br"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Belarusian", female: "Belarusian") },
                { "fra", new DemonymsGender(male: "Belarusian", female: "Belarusian") },
            }
        );

        /// <summary>
        /// create an instance of Belarus country
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
        private Belarus(
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
