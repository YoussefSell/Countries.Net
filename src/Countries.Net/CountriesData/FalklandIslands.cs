namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of FalklandIslands country
    /// </summary>
    public class FalklandIslands : Country
    {
        /// <summary>
        /// get the FalklandIslands country instance
        /// </summary>
        public static FalklandIslands Instance = new FalklandIslands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Falkland Islands", common: "Falkland Islands") },
                { "ara", new CountryName(official: "جزر فوكلاند", common: "جزر فوكلاند") },
                { "ces", new CountryName(official: "Falklandské ostrovy", common: "Falklandy") },
                { "cym", new CountryName(official: "Falkland Islands", common: "Falkland Islands") },
                { "deu", new CountryName(official: "Falklandinseln", common: "Falklandinseln") },
                { "est", new CountryName(official: "Falklandi saared", common: "Falklandi saared") },
                { "fin", new CountryName(official: "Falkandinsaaret", common: "Falkandinsaaret") },
                { "fra", new CountryName(official: "Îles Malouines", common: "Îles Malouines") },
                { "hrv", new CountryName(official: "Falklandski otoci", common: "Falklandski Otoci") },
                { "hun", new CountryName(official: "Falkland-szigetek", common: "Falkland-szigetek") },
                { "ita", new CountryName(official: "Isole Falkland", common: "Isole Falkland o Isole Malvine") },
                { "jpn", new CountryName(official: "フォークランド", common: "フォークランド（マルビナス）諸島") },
                { "kor", new CountryName(official: "포클랜드 제도", common: "포클랜드 제도") },
                { "nld", new CountryName(official: "Falkland eilanden", common: "Falklandeilanden") },
                { "per", new CountryName(official: "جزایر فالکلند", common: "جزایر فالکلند") },
                { "pol", new CountryName(official: "Falklandy", common: "Falklandy") },
                { "por", new CountryName(official: "Ilhas Malvinas", common: "Ilhas Malvinas") },
                { "rus", new CountryName(official: "Фолклендские острова", common: "Фолклендские острова") },
                { "slk", new CountryName(official: "Falklandské ostrovy", common: "Falklandy") },
                { "spa", new CountryName(official: "islas Malvinas", common: "Islas Malvinas") },
                { "swe", new CountryName(official: "Falklandsöarna", common: "Falklandsöarna") },
                { "urd", new CountryName(official: "جزائر فاکلینڈ", common: "جزائر فاکلینڈ") },
                { "zho", new CountryName(official: "福克兰群岛", common: "福克兰群岛") },
            },
            cca2: "FK",
            cca3: "FLK",
            ccn3: "238",
            cioc: "",
            flag: "🇫🇰",
            region: Region.Americas,
            subregion: "South America",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"00", }),
            borders: new string[] {  },
            capital: new string[] { "Stanley",  },
            altSpellings: new string[] { "FK", "Islas Malvinas", "Falkland Islands (Malvinas)",  },
            tld: new string[] { ".fk",  },
            latlng: new double[] { -51.75, -59,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "FKP", name: "Falkland Islands pound", symbol: "£"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Falkland Islander", female: "Falkland Islander") },
                { "fra", new DemonymsGender(male: "Falkland Islander", female: "Falkland Islander") },
            }
        );

        /// <summary>
        /// create an instance of FalklandIslands country
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
        private FalklandIslands(
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
