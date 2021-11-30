namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of SaintKittsandNevis country
    /// </summary>
    public class SaintKittsandNevis : Country
    {
        /// <summary>
        /// get the SaintKittsandNevis country instance
        /// </summary>
        public static SaintKittsandNevis Instance = new SaintKittsandNevis(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Federation of Saint Christopher and Nevis", common: "Saint Kitts and Nevis") },
                { "ara", new CountryName(official: "اتحاد القديس كريستوفر ونيفيس", common: "سانت كيتس ونيفيس") },
                { "ces", new CountryName(official: "Federace Sv. Kryštof a Nevis", common: "Svatý Kryštof a Nevis") },
                { "cym", new CountryName(official: "Federation of Saint Christopher and Nevis", common: "Saint Kitts and Nevis") },
                { "deu", new CountryName(official: "Föderation von St. Kitts und Nevis", common: "St. Kitts und Nevis") },
                { "est", new CountryName(official: "Saint Kittsi ja Nevise Föderatsioon", common: "Saint Kitts ja Nevis") },
                { "fin", new CountryName(official: "Saint Christopherin ja Nevisin federaatio", common: "Saint Kitts ja Nevis") },
                { "fra", new CountryName(official: "Fédération de Saint-Christophe-et-Niévès", common: "Saint-Christophe-et-Niévès") },
                { "hrv", new CountryName(official: "Federacija Sv.Kristofora i Nevisa", common: "Sveti Kristof i Nevis") },
                { "hun", new CountryName(official: "Saint Christopher és Nevis Államszövetség", common: "Saint Kitts és Nevis") },
                { "ita", new CountryName(official: "Federazione di Saint Christopher e Nevis", common: "Saint Kitts e Nevis") },
                { "jpn", new CountryName(official: "セントクリストファーNevis連盟", common: "セントクリストファー・ネイビス") },
                { "kor", new CountryName(official: "세인트키츠 네비스 연방", common: "세인트키츠 네비스") },
                { "nld", new CountryName(official: "Federatie van Saint Kitts en Nevis", common: "Saint Kitts en Nevis") },
                { "per", new CountryName(official: "فدراسیون سنت کیتس و نویس", common: "سنت کیتس و نویس") },
                { "pol", new CountryName(official: "Federacja Saint Kitts i Nevis", common: "Saint Kitts i Nevis") },
                { "por", new CountryName(official: "Federação de São Cristóvão e Nevis", common: "São Cristóvão e Nevis") },
                { "rus", new CountryName(official: "Федерация Сент-Кристофер и Н е в и с", common: "Сент-Китс и Невис") },
                { "slk", new CountryName(official: "Feder໡cia Svätého Krištofa a Nevisu", common: "Svätý Krištof a Nevis") },
                { "spa", new CountryName(official: "Federación de San Cristóbal y Nevis", common: "San Cristóbal y Nieves") },
                { "swe", new CountryName(official: "Federationen Saint Kitts och Nevis", common: "Saint Kitts och Nevis") },
                { "urd", new CountryName(official: "وفاقِ سینٹ کیٹز و ناویس", common: "سینٹ کیٹز و ناویس") },
                { "zho", new CountryName(official: "圣克里斯托弗和尼维斯联邦", common: "圣基茨和尼维斯") },
            },
            cca2: "KN",
            cca3: "KNA",
            ccn3: "659",
            cioc: "SKN",
            flag: "🇰🇳",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"869", }),
            borders: new string[] {  },
            capital: new string[] { "Basseterre",  },
            altSpellings: new string[] { "KN", "Federation of Saint Christopher and Nevis",  },
            tld: new string[] { ".kn",  },
            latlng: new double[] { 17.33333333, -62.75,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XCD", name: "Eastern Caribbean dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Kittitian or Nevisian", female: "Kittitian or Nevisian") },
                { "fra", new DemonymsGender(male: "Kittitian or Nevisian", female: "Kittitian or Nevisian") },
            }
        );

        /// <summary>
        /// create an instance of SaintKittsandNevis country
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
        private SaintKittsandNevis(
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
