namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Algeria country
    /// </summary>
    public class Algeria : Country
    {
        /// <summary>
        /// get the Algeria country instance
        /// </summary>
        public static Algeria Instance = new Algeria(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "People's Democratic Republic of Algeria", common: "Algeria") },
                { "ara", new CountryName(official: "الجمهورية الديمقراطية الشعبية الجزائرية", common: "الجزائر") },
                { "ces", new CountryName(official: "Alžírská demokratická a lidová republika", common: "Alžírsko") },
                { "cym", new CountryName(official: "Gweriniaeth Ddemocrataidd Pobl Algeria", common: "Algeria") },
                { "deu", new CountryName(official: "Demokratische Volksrepublik Algerien", common: "Algerien") },
                { "est", new CountryName(official: "Alžeeria Demokraatlik Rahvavabariik", common: "Alžeeria") },
                { "fin", new CountryName(official: "Algerian demokraattinen kansantasavalta", common: "Algeria") },
                { "fra", new CountryName(official: "République démocratique et populaire d'Algérie", common: "Algérie") },
                { "hrv", new CountryName(official: "Narodna Demokratska Republika Alžir", common: "Alžir") },
                { "hun", new CountryName(official: "Algériai Népi Demokratikus Köztársaság", common: "Algéria") },
                { "ita", new CountryName(official: "Repubblica popolare democratica di Algeria", common: "Algeria") },
                { "jpn", new CountryName(official: "アルジェリア人民民主共和国", common: "アルジェリア") },
                { "kor", new CountryName(official: "알제리 인민 민주 공화국", common: "알제리") },
                { "nld", new CountryName(official: "Democratische Volksrepubliek Algerije", common: "Algerije") },
                { "per", new CountryName(official: "جمهوری دموکراتیک خلق الجزایر", common: "الجزایر") },
                { "pol", new CountryName(official: "Algierska Republika Ludowo-Demokratyczna", common: "Algieria") },
                { "por", new CountryName(official: "República Argelina Democrática e Popular", common: "Argélia") },
                { "rus", new CountryName(official: "Народно-Демократическая Республика Алжир", common: "Алжир") },
                { "slk", new CountryName(official: "Alžírska demokratická ľudová republika", common: "Alžírsko") },
                { "spa", new CountryName(official: "República Argelina Democrática y Popular", common: "Argelia") },
                { "swe", new CountryName(official: "Demokratiska folkrepubliken Algeriet", common: "Algeriet") },
                { "urd", new CountryName(official: "عوامی جمہوری جمہوریہ الجزائر", common: "الجزائر") },
                { "zho", new CountryName(official: "阿尔及利亚人民民主共和国", common: "阿尔及利亚") },

            },
            cca2: "DZ",
            cca3: "DZA",
            ccn3: "012",
            cioc: "ALG",
            flag: "🇩🇿",
            region: Region.Africa,
            subregion: "Northern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"13", }),
            borders: new string[] { "TUN", "LBY", "NER", "ESH", "MRT", "MLI", "MAR",  },
            capital: new string[] { "Algiers",  },
            altSpellings: new string[] { "DZ", "Dzayer", "Algérie",  },
            tld: new string[] { ".dz", "الجزائر.",  },
            latlng: new double[] { 28, 3,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "DZD", name: "Algerian dinar", symbol: "د.ج"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Algerian", female: "Algerian") },
                { "fra", new DemonymsGender(male: "Algerian", female: "Algerian") },
            }
        );

        /// <summary>
        /// create an instance of Algeria country
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
        private Algeria(
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
