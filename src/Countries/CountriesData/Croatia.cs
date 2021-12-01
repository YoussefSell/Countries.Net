namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Croatia country
    /// </summary>
    public class Croatia : Country
    {
        /// <summary>
        /// get the Croatia country instance
        /// </summary>
        public static Croatia Instance = new Croatia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Croatia", common: "Croatia") },
                { "hrv", new CountryName(official: "Republika Hrvatska", common: "Hrvatska") },
                { "ara", new CountryName(official: "جمهورية كرواتيا", common: "كرواتيا") },
                { "ces", new CountryName(official: "Chorvatská republika", common: "Chorvatsko") },
                { "cym", new CountryName(official: "Gweriniaeth Croatia", common: "Croatia") },
                { "deu", new CountryName(official: "Republik Kroatien", common: "Kroatien") },
                { "est", new CountryName(official: "Horvaatia Vabariik", common: "Horvaatia") },
                { "fin", new CountryName(official: "Kroatian tasavalta", common: "Kroatia") },
                { "fra", new CountryName(official: "République de Croatie", common: "Croatie") },
                { "hun", new CountryName(official: "Horvát Köztársaság", common: "Horvátország") },
                { "ita", new CountryName(official: "Repubblica di Croazia", common: "Croazia") },
                { "jpn", new CountryName(official: "クロアチア共和国", common: "クロアチア") },
                { "kor", new CountryName(official: "크로아티아 공화국", common: "크로아티아") },
                { "nld", new CountryName(official: "Republiek Kroatië", common: "Kroatië") },
                { "per", new CountryName(official: "جمهوری کرواسی", common: "کرُواسی") },
                { "pol", new CountryName(official: "Republika Chorwacji", common: "Chorwacja") },
                { "por", new CountryName(official: "República da Croácia", common: "Croácia") },
                { "rus", new CountryName(official: "Республика Хорватия", common: "Хорватия") },
                { "slk", new CountryName(official: "Chorvátska republika", common: "Chorvátsko") },
                { "spa", new CountryName(official: "República de Croacia", common: "Croacia") },
                { "swe", new CountryName(official: "Republiken Kroatien", common: "Kroatien") },
                { "urd", new CountryName(official: "جمہوریہ کرویئشا", common: "کرویئشا") },
                { "zho", new CountryName(official: "克罗地亚共和国", common: "克罗地亚") },

            },
            cca2: "HR",
            cca3: "HRV",
            ccn3: "191",
            cioc: "CRO",
            flag: "🇭🇷",
            region: Region.Europe,
            subregion: "Southeast Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"85", }),
            borders: new string[] { "BIH", "HUN", "MNE", "SRB", "SVN",  },
            capital: new string[] { "Zagreb",  },
            altSpellings: new string[] { "HR", "Hrvatska", "Republic of Croatia", "Republika Hrvatska",  },
            tld: new string[] { ".hr",  },
            latlng: new double[] { 45.16666666, 15.5,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Croatian", iso6391: "hr", iso6392: "hrv"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "HRK", name: "Croatian kuna", symbol: "kn"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Croatian", female: "Croatian") },
                { "fra", new DemonymsGender(male: "Croatian", female: "Croatian") },
            }
        );

        /// <summary>
        /// create an instance of Croatia country
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
        private Croatia(
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
