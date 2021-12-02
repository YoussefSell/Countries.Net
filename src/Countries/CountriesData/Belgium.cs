namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Belgium country
    /// </summary>
    public class Belgium : Country
    {
        /// <summary>
        /// get the Belgium country instance
        /// </summary>
        public static Belgium Instance = new Belgium(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Kingdom of Belgium", common: "Belgium") },
                { "deu", new CountryName(official: "Königreich Belgien", common: "Belgien") },
                { "fra", new CountryName(official: "Royaume de Belgique", common: "Belgique") },
                { "nld", new CountryName(official: "Koninkrijk België", common: "België") },
                { "ara", new CountryName(official: "مملكة بلجيكا", common: "بلجيكا") },
                { "ces", new CountryName(official: "Belgické království", common: "Belgie") },
                { "cym", new CountryName(official: "Teyrnas Gwlad Belg", common: "Gwlad Belg") },
                { "est", new CountryName(official: "Belgia Kuningriik", common: "Belgia") },
                { "fin", new CountryName(official: "Belgian kuningaskunta", common: "Belgia") },
                { "hrv", new CountryName(official: "Kraljevina Belgija", common: "Belgija") },
                { "hun", new CountryName(official: "Belga Királyság", common: "Belgium") },
                { "ita", new CountryName(official: "Regno del Belgio", common: "Belgio") },
                { "jpn", new CountryName(official: "ベルギー王国", common: "ベルギー") },
                { "kor", new CountryName(official: "벨기에 왕국", common: "벨기에") },
                { "per", new CountryName(official: "پادشاهی بلژیک", common: "بلژیک") },
                { "pol", new CountryName(official: "Królestwo Belgii", common: "Belgia") },
                { "por", new CountryName(official: "Reino da Bélgica", common: "Bélgica") },
                { "rus", new CountryName(official: "Королевство Бельгия", common: "Бельгия") },
                { "slk", new CountryName(official: "Belgické kráľovstvo", common: "Belgicko") },
                { "spa", new CountryName(official: "Reino de Bélgica", common: "Bélgica") },
                { "swe", new CountryName(official: "Konungariket Belgien", common: "Belgien") },
                { "urd", new CountryName(official: "مملکتِ بلجئیم", common: "بلجئیم") },
                { "zho", new CountryName(official: "比利时王国", common: "比利时") },

            },
            cca2: "BE",
            cca3: "BEL",
            ccn3: "056",
            cioc: "BEL",
            flag: "🇧🇪",
            region: Region.Europe,
            subregion: "Western Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"2", }),
            borders: new string[] { "FRA", "DEU", "LUX", "NLD",  },
            capital: new string[] { "Brussels",  },
            altSpellings: new string[] { "BE", "België", "Belgie", "Belgien", "Belgique", "Kingdom of Belgium", "Koninkrijk België", "Royaume de Belgique", "Königreich Belgien",  },
            tld: new string[] { ".be",  },
            latlng: new double[] { 50.83333333, 4,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "German", iso6391: "de", iso6392: "deu"),
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
                new Language(name: "Dutch", iso6391: "nl", iso6392: "nld"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Belgian", female: "Belgian") },
                { "fra", new DemonymsGender(male: "Belgian", female: "Belgian") },
            }
        );

        /// <summary>
        /// create an instance of Belgium country
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
        private Belgium(
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
