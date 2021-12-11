namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of TurksandCaicosIslands country
    /// </summary>
    public class TurksandCaicosIslands : Country
    {
        /// <summary>
        /// get the TurksandCaicosIslands country instance
        /// </summary>
        public static TurksandCaicosIslands Instance = new TurksandCaicosIslands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Turks and Caicos Islands", common: "Turks and Caicos Islands") },
                { "ara", new CountryName(official: "جزر توركس وكايكوس", common: "جزر توركس وكايكوس") },
                { "ces", new CountryName(official: "Turks a Caicos", common: "Turks a Caicos") },
                { "cym", new CountryName(official: "Turks and Caicos Islands", common: "Turks and Caicos Islands") },
                { "deu", new CountryName(official: "Turks und Caicos Inseln", common: "Turks-und Caicosinseln") },
                { "est", new CountryName(official: "Turksi ja Caicose saared", common: "Turks ja Caicos") },
                { "fin", new CountryName(official: "Turks-ja Caicossaaret", common: "Turks-ja Caicossaaret") },
                { "fra", new CountryName(official: "Îles Turques et Caïques", common: "Îles Turques-et-Caïques") },
                { "hrv", new CountryName(official: "Otoci Turks i Caicos", common: "Otoci Turks i Caicos") },
                { "hun", new CountryName(official: "Turks- és Caicos-szigetek", common: "Turks- és Caicos-szigetek") },
                { "ita", new CountryName(official: "Turks e Caicos", common: "Isole Turks e Caicos") },
                { "jpn", new CountryName(official: "タークス·カイコス諸島", common: "タークス・カイコス諸島") },
                { "kor", new CountryName(official: "터크스 케이커스 제도", common: "터크스 케이커스 제도") },
                { "nld", new CountryName(official: "Turks-en Caicoseilanden", common: "Turks-en Caicoseilanden") },
                { "per", new CountryName(official: "جزایر تورکس و کایکوس", common: "جزایر تورکس و کایکوس") },
                { "pol", new CountryName(official: "Turks i Caicos", common: "Turks i Caicos") },
                { "por", new CountryName(official: "Ilhas Turks e Caicos", common: "Ilhas Turks e Caicos") },
                { "rus", new CountryName(official: "Теркс и Кайкос острова", common: "Теркс и Кайкос") },
                { "slk", new CountryName(official: "Ostrovy Turks a Caicos", common: "Turks a Caicos") },
                { "spa", new CountryName(official: "Islas Turcas y Caicos", common: "Islas Turks y Caicos") },
                { "swe", new CountryName(official: "Turks- och Caicosöarna", common: "Turks- och Caicosöarna") },
                { "urd", new CountryName(official: "جزائر کیکس و ترکیہ", common: "جزائر کیکس و ترکیہ") },
                { "zho", new CountryName(official: "特克斯和凯科斯群岛", common: "特克斯和凯科斯群岛") },
            },
            cca2: "TC",
            cca3: "TCA",
            ccn3: "796",
            cioc: "",
            flag: "🇹🇨",
            region: Region.Americas,
            subregion: "Caribbean",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+1", suffixes: new string[] {"649", }),
            borders: new string[] {  },
            capital: new string[] { "Cockburn Town",  },
            altSpellings: new string[] { "TC",  },
            tld: new string[] { ".tc",  },
            latlng: new double[] { 21.75, -71.58333333,  },
            timezones: new string[] { "UTC-04:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "USD", name: "United States dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Turks and Caicos Islander", female: "Turks and Caicos Islander") },
                { "fra", new DemonymsGender(male: "Turks and Caicos Islander", female: "Turks and Caicos Islander") },
            }
        );

        /// <summary>
        /// create an instance of TurksandCaicosIslands country
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
        private TurksandCaicosIslands(
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
