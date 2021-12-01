namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of BurkinaFaso country
    /// </summary>
    public class BurkinaFaso : Country
    {
        /// <summary>
        /// get the BurkinaFaso country instance
        /// </summary>
        public static BurkinaFaso Instance = new BurkinaFaso(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Burkina Faso", common: "Burkina Faso") },
                { "fra", new CountryName(official: "République du Burkina", common: "Burkina Faso") },
                { "ara", new CountryName(official: "بوركينا فاسو", common: "بوركينا فاسو") },
                { "ces", new CountryName(official: "Burkina Faso", common: "Burkina Faso") },
                { "cym", new CountryName(official: "Bwrcina Ffaso", common: "Bwrcina Ffaso") },
                { "deu", new CountryName(official: "Burkina Faso", common: "Burkina Faso") },
                { "est", new CountryName(official: "Burkina Faso", common: "Burkina Faso") },
                { "fin", new CountryName(official: "Burkina Faso", common: "Burkina Faso") },
                { "hrv", new CountryName(official: "Burkina Faso", common: "Burkina Faso") },
                { "hun", new CountryName(official: "Burkina Faso", common: "Burkina") },
                { "ita", new CountryName(official: "Burkina Faso", common: "Burkina Faso") },
                { "jpn", new CountryName(official: "ブルキナファソ", common: "ブルキナファソ") },
                { "kor", new CountryName(official: "부르키나파소", common: "부르키나파소") },
                { "nld", new CountryName(official: "Burkina Faso", common: "Burkina Faso") },
                { "per", new CountryName(official: "بورکینافاسو", common: "بورکینافاسو") },
                { "pol", new CountryName(official: "Burkina Faso", common: "Burkina Faso") },
                { "por", new CountryName(official: "Burkina Faso", common: "Burkina Faso") },
                { "rus", new CountryName(official: "Буркина -Фасо", common: "Буркина-Фасо") },
                { "slk", new CountryName(official: "Burkina Faso", common: "Burkina Faso") },
                { "spa", new CountryName(official: "Burkina Faso", common: "Burkina Faso") },
                { "swe", new CountryName(official: "Burkina Faso", common: "Burkina Faso") },
                { "urd", new CountryName(official: "برکینا فاسو", common: "برکینا فاسو") },
                { "zho", new CountryName(official: "布基纳法索", common: "布基纳法索") },

            },
            cca2: "BF",
            cca3: "BFA",
            ccn3: "854",
            cioc: "BUR",
            flag: "🇧🇫",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"26", }),
            borders: new string[] { "BEN", "CIV", "GHA", "MLI", "NER", "TGO",  },
            capital: new string[] { "Ouagadougou",  },
            altSpellings: new string[] { "BF",  },
            tld: new string[] { ".bf",  },
            latlng: new double[] { 13, -2,  },
            timezones: new string[] { "UTC",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XOF", name: "West African CFA franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Burkinabe", female: "Burkinabe") },
                { "fra", new DemonymsGender(male: "Burkinabe", female: "Burkinabe") },
            }
        );

        /// <summary>
        /// create an instance of BurkinaFaso country
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
        private BurkinaFaso(
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
