namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of UnitedKingdom country
    /// </summary>
    public class UnitedKingdom : Country
    {
        /// <summary>
        /// get the UnitedKingdom country instance
        /// </summary>
        public static UnitedKingdom Instance = new UnitedKingdom(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "United Kingdom of Great Britain and Northern Ireland", common: "United Kingdom") },
                { "ara", new CountryName(official: "المملكة المتحدة لبريطانيا العظمى وايرلندا الشمالية", common: "المملكة المتحدة") },
                { "ces", new CountryName(official: "Spojené království Velké Británie a Severního Irska", common: "Spojené království") },
                { "cym", new CountryName(official: "United Kingdom of Great Britain and Northern Ireland", common: "United Kingdom") },
                { "deu", new CountryName(official: "Vereinigtes Königreich Großbritannien und Nordirland", common: "Vereinigtes Königreich") },
                { "est", new CountryName(official: "Suurbritannia ja Põhja-Iiri Ühendkuningriik", common: "Suurbritannia") },
                { "fin", new CountryName(official: "Ison-Britannian ja Pohjois-Irlannin yhdistynyt kuningaskunta", common: "Yhdistynyt kuningaskunta") },
                { "fra", new CountryName(official: "Royaume-Uni de Grande-Bretagne et d'Irlande du Nord", common: "Royaume-Uni") },
                { "hrv", new CountryName(official: "Ujedinjeno Kraljevstvo Velike Britanije i Sjeverne Irske", common: "Ujedinjeno Kraljevstvo") },
                { "hun", new CountryName(official: "Nagy-Britannia és Észak-Írország Egyesült Királysága", common: "Egyesült Királyság") },
                { "ita", new CountryName(official: "Regno Unito di Gran Bretagna e Irlanda del Nord", common: "Regno Unito") },
                { "jpn", new CountryName(official: "グレート·ブリテンおよび北アイルランド連合王国", common: "イギリス") },
                { "kor", new CountryName(official: "그레이트브리튼 북아일랜드 연합 왕국", common: "영국") },
                { "nld", new CountryName(official: "Verenigd Koninkrijk van Groot-Brittannië en Noord-Ierland", common: "Verenigd Koninkrijk") },
                { "per", new CountryName(official: "پادشاهی متحد بریتانیای کبیر و ایرلند شمالی", common: "انگلیس") },
                { "pol", new CountryName(official: "Zjednoczone Królestwo Wielkiej Brytanii i Irlandii Północnej", common: "Zjednoczone Krłlestwo") },
                { "por", new CountryName(official: "Reino Unido da Grã-Bretanha e Irlanda do Norte", common: "Reino Unido") },
                { "rus", new CountryName(official: "Соединенное Королевство Великобритании и Северной Ирландии", common: "Великобритания") },
                { "slk", new CountryName(official: "Spojené kráľovstvo Veľkej Británie a SevernéhoÌrska", common: "Veľká Británia (Spojené kráľovstvo)") },
                { "spa", new CountryName(official: "Reino Unido de Gran Bretaña e Irlanda del Norte", common: "Reino Unido") },
                { "swe", new CountryName(official: "Förenade konungariket Storbritannien och Nordirland", common: "Storbritannien") },
                { "urd", new CountryName(official: "مملکتِ متحدہ برطانیہ عظمی و شمالی آئرلینڈ", common: "مملکتِ متحدہ") },
                { "zho", new CountryName(official: "大不列颠及北爱尔兰联合王国", common: "英国") },
            },
            cca2: "GB",
            cca3: "GBR",
            ccn3: "826",
            cioc: "GBR",
            flag: "🇬🇧",
            region: Region.Europe,
            subregion: "Northern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"4", }),
            borders: new string[] { "IRL",  },
            capital: new string[] { "London",  },
            altSpellings: new string[] { "GB", "UK", "Great Britain",  },
            tld: new string[] { ".uk",  },
            latlng: new double[] { 54, -2,  },
            timezones: new string[] { "UTC-08:00", "UTC-05:00", "UTC-04:00", "UTC-03:00", "UTC-02:00", "UTC", "UTC+01:00", "UTC+02:00", "UTC+06:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "GBP", name: "British pound", symbol: "£"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "British", female: "British") },
                { "fra", new DemonymsGender(male: "British", female: "British") },
            }
        );

        /// <summary>
        /// create an instance of UnitedKingdom country
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
        private UnitedKingdom(
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
