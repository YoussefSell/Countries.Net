namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of EquatorialGuinea country
    /// </summary>
    public class EquatorialGuinea : Country
    {
        /// <summary>
        /// get the EquatorialGuinea country instance
        /// </summary>
        public static EquatorialGuinea Instance = new EquatorialGuinea(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Equatorial Guinea", common: "Equatorial Guinea") },
                { "fra", new CountryName(official: "République de la Guinée Équatoriale", common: "Guinée équatoriale") },
                { "por", new CountryName(official: "República da Guiné Equatorial", common: "Guiné Equatorial") },
                { "spa", new CountryName(official: "República de Guinea Ecuatorial", common: "Guinea Ecuatorial") },
                { "ara", new CountryName(official: "جمهورية غينيا الاستوائية", common: "غينيا الاستوائية") },
                { "ces", new CountryName(official: "Republika Rovníková Guinea", common: "Rovníková Guinea") },
                { "cym", new CountryName(official: "Gweriniaeth Gini Gyhydeddol", common: "Gini Gyhydeddol") },
                { "deu", new CountryName(official: "Republik Äquatorialguinea", common: "Äquatorialguinea") },
                { "est", new CountryName(official: "Ekvatoriaal-Guinea Vabariik", common: "Ekvatoriaal-Guinea") },
                { "fin", new CountryName(official: "Päiväntasaajan Guinean tasavalta", common: "Päiväntasaajan Guinea") },
                { "hrv", new CountryName(official: "Republika Ekvatorska Gvineja", common: "Ekvatorijalna Gvineja") },
                { "hun", new CountryName(official: "Egyenlítői-Guinea-i Köztársaság", common: "Egyenlítői-Guinea") },
                { "ita", new CountryName(official: "Repubblica della Guinea Equatoriale", common: "Guinea Equatoriale") },
                { "jpn", new CountryName(official: "赤道ギニア共和国", common: "赤道ギニア") },
                { "kor", new CountryName(official: "적도 기니 공화국", common: "적도 기니") },
                { "nld", new CountryName(official: "Republiek Equatoriaal-Guinea", common: "Equatoriaal-Guinea") },
                { "per", new CountryName(official: "جمهوری گینه استوایی", common: "گینه استوایی") },
                { "pol", new CountryName(official: "Republika Gwinei Równikowej", common: "Gwinea Równikowa") },
                { "rus", new CountryName(official: "Республика Экваториальная Гвинея", common: "Экваториальная Гвинея") },
                { "slk", new CountryName(official: "Republika rovníkovej Guiney", common: "Rovníková Guinea") },
                { "swe", new CountryName(official: "Republiken Ekvatorialguinea", common: "Ekvatorialguinea") },
                { "urd", new CountryName(official: "جمہوریہ استوائی گنی", common: "استوائی گنی") },
                { "zho", new CountryName(official: "赤道几内亚共和国", common: "赤道几内亚") },

            },
            cca2: "GQ",
            cca3: "GNQ",
            ccn3: "226",
            cioc: "GEQ",
            flag: "🇬🇶",
            region: Region.Africa,
            subregion: "Middle Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"40", }),
            borders: new string[] { "CMR", "GAB",  },
            capital: new string[] { "Malabo",  },
            altSpellings: new string[] { "GQ", "Republic of Equatorial Guinea", "República de Guinea Ecuatorial", "République de Guinée équatoriale", "República da Guiné Equatorial",  },
            tld: new string[] { ".gq",  },
            latlng: new double[] { 2, 10,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
                new Language(name: "Portuguese", iso6391: "pt", iso6392: "por"),
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XAF", name: "Central African CFA franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Equatorial Guinean", female: "Equatorial Guinean") },
                { "fra", new DemonymsGender(male: "Equatorial Guinean", female: "Equatorial Guinean") },
            }
        );

        /// <summary>
        /// create an instance of EquatorialGuinea country
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
        private EquatorialGuinea(
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
