namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Russia country
    /// </summary>
    public class Russia : Country
    {
        /// <summary>
        /// get the Russia country instance
        /// </summary>
        public static Russia Instance = new Russia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Russian Federation", common: "Russia") },
                { "rus", new CountryName(official: "Российская Федерация", common: "Россия") },
                { "ara", new CountryName(official: "روسيا الاتحادية", common: "روسيا") },
                { "ces", new CountryName(official: "Ruská federace", common: "Rusko") },
                { "cym", new CountryName(official: "Russian Federation", common: "Russia") },
                { "deu", new CountryName(official: "Russische Föderation", common: "Russland") },
                { "est", new CountryName(official: "Venemaa Föderatsioon", common: "Venemaa") },
                { "fin", new CountryName(official: "Venäjän federaatio", common: "Venäjä") },
                { "fra", new CountryName(official: "Fédération de Russie", common: "Russie") },
                { "hrv", new CountryName(official: "Ruska Federacija", common: "Rusija") },
                { "hun", new CountryName(official: "Oroszországi Föderáció", common: "Oroszország") },
                { "ita", new CountryName(official: "Federazione russa", common: "Russia") },
                { "jpn", new CountryName(official: "ロシア連邦", common: "ロシア連邦") },
                { "kor", new CountryName(official: "러시아 연방", common: "러시아") },
                { "nld", new CountryName(official: "Russische Federatie", common: "Rusland") },
                { "per", new CountryName(official: "فدراسیون روسیه", common: "روسیه") },
                { "pol", new CountryName(official: "Federacja Rosyjska", common: "Rosja") },
                { "por", new CountryName(official: "Federação Russa", common: "Rússia") },
                { "slk", new CountryName(official: "Ruská federácia", common: "Rusko") },
                { "spa", new CountryName(official: "Federación de Rusia", common: "Rusia") },
                { "swe", new CountryName(official: "Ryska federationen", common: "Ryssland") },
                { "urd", new CountryName(official: "روسی وفاق", common: "روس") },
                { "zho", new CountryName(official: "俄罗斯联邦", common: "俄罗斯") },

            },
            cca2: "RU",
            cca3: "RUS",
            ccn3: "643",
            cioc: "RUS",
            flag: "🇷🇺",
            region: Region.Europe,
            subregion: "Eastern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+7", suffixes: new string[] {"3", "4", "5", "8", "9", }),
            borders: new string[] { "AZE", "BLR", "CHN", "EST", "FIN", "GEO", "KAZ", "PRK", "LVA", "LTU", "MNG", "NOR", "POL", "UKR",  },
            capital: new string[] { "Moscow",  },
            altSpellings: new string[] { "RU", "Russian Federation", "Российская Федерация",  },
            tld: new string[] { ".ru", ".su", ".рф",  },
            latlng: new double[] { 60, 100,  },
            timezones: new string[] { "UTC+03:00", "UTC+04:00", "UTC+06:00", "UTC+07:00", "UTC+08:00", "UTC+09:00", "UTC+10:00", "UTC+11:00", "UTC+12:00",  },
            languages: new Language[]
            {
                new Language(name: "Russian", iso6391: "ru", iso6392: "rus"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "RUB", name: "Russian ruble", symbol: "₽"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Russian", female: "Russian") },
                { "fra", new DemonymsGender(male: "Russian", female: "Russian") },
            }
        );

        /// <summary>
        /// create an instance of Russia country
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
        private Russia(
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
