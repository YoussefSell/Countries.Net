namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of SãoToméandPríncipe country
    /// </summary>
    public class SãoToméandPríncipe : Country
    {
        /// <summary>
        /// get the SãoToméandPríncipe country instance
        /// </summary>
        public static SãoToméandPríncipe Instance = new SãoToméandPríncipe(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Democratic Republic of São Tomé and Príncipe", common: "São Tomé and Príncipe") },
                { "por", new CountryName(official: "República Democrática do São Tomé e Príncipe", common: "São Tomé e Príncipe") },
                { "ara", new CountryName(official: "جمهورية ساو تومي وبرينسيب الديمقراطية", common: "ساو تومي وبرينسيب") },
                { "ces", new CountryName(official: "Demokratická republika Svatý Tomáš a Princův ostrov", common: "Svatý Tomáš a Princův ostrov") },
                { "cym", new CountryName(official: "Democratic Republic of São Tomé and Príncipe", common: "São Tomé and Príncipe") },
                { "deu", new CountryName(official: "Demokratische Republik São Tomé und Príncipe", common: "São Tomé und Príncipe") },
                { "est", new CountryName(official: "São Tomé ja Príncipe Demokraatlik Vabariik", common: "São Tomé ja Príncipe") },
                { "fin", new CountryName(official: "São Tomé ja Príncipen demokraattinen tasavalta", common: "São Téme ja Príncipe") },
                { "fra", new CountryName(official: "République démocratique de São Tomé et Príncipe", common: "São Tomé et Príncipe") },
                { "hrv", new CountryName(official: "Demokratska Republika São Tome i Principe", common: "Sveti Toma i Princip") },
                { "hun", new CountryName(official: "São Tomé és Príncipe Demokratikus Köztársaság", common: "São Tomé és Príncipe") },
                { "ita", new CountryName(official: "Repubblica democratica di São Tomé e Príncipe", common: "São Tomé e Príncipe") },
                { "jpn", new CountryName(official: "サントメ·プリンシペ民主共和国", common: "サントメ・プリンシペ") },
                { "kor", new CountryName(official: "상투메 프린시페 민주 공화국", common: "상투메 프린시페") },
                { "nld", new CountryName(official: "Democratische Republiek Sao Tomé en Principe", common: "Sao Tomé en Principe") },
                { "per", new CountryName(official: "جمهوری دموکراتیک سائوتومه و پرنسیپ", common: "سائوتومه و پرنسیپ") },
                { "pol", new CountryName(official: "Demokratyczna Republika Wysp Świętego Tomasza i Książęcej", common: "Wyspy Świętego Tomasza i Książęca") },
                { "rus", new CountryName(official: "Демократическая Республика Сан-Томе и Принсипи", common: "Сан-Томе и Принсипи") },
                { "slk", new CountryName(official: "Demokratická republika Svätého Tomáša A princovho ostrova", common: "Svätý Tomáš a Princov ostrov") },
                { "spa", new CountryName(official: "República Democrática de Santo Tomé y Príncipe", common: "Santo Tomé y Príncipe") },
                { "swe", new CountryName(official: "Demokratiska republiken São Tomé och Príncipe", common: "São Tomé och Príncipe") },
                { "urd", new CountryName(official: "جمہوریہ ساؤ ٹومے و پرنسپے", common: "ساؤ ٹومے و پرنسپے") },
                { "zho", new CountryName(official: "圣多美和普林西比民主共和国", common: "圣多美和普林西比") },

            },
            cca2: "ST",
            cca3: "STP",
            ccn3: "678",
            cioc: "STP",
            flag: "🇸🇹",
            region: Region.Africa,
            subregion: "Middle Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"39", }),
            borders: new string[] {  },
            capital: new string[] { "São Tomé",  },
            altSpellings: new string[] { "ST", "Democratic Republic of São Tomé and Príncipe", "Sao Tome and Principe", "República Democrática de São Tomé e Príncipe",  },
            tld: new string[] { ".st",  },
            latlng: new double[] { 1, 7,  },
            timezones: new string[] { "UTC",  },
            languages: new Language[]
            {
                new Language(name: "Portuguese", iso6391: "pt", iso6392: "por"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "STN", name: "São Tomé and Príncipe dobra", symbol: "Db"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Sao Tomean", female: "Sao Tomean") },
                { "fra", new DemonymsGender(male: "Sao Tomean", female: "Sao Tomean") },
            }
        );

        /// <summary>
        /// create an instance of SãoToméandPríncipe country
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
        private SãoToméandPríncipe(
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
