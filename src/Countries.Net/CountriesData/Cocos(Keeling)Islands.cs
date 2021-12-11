namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Cocos(Keeling)Islands country
    /// </summary>
    public class CocosKeelingIslands : Country
    {
        /// <summary>
        /// get the Cocos(Keeling)Islands country instance
        /// </summary>
        public static CocosKeelingIslands Instance = new CocosKeelingIslands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Territory of the Cocos (Keeling) Islands", common: "Cocos (Keeling) Islands") },
                { "ara", new CountryName(official: "إقليم جزر كوكوس", common: "جزر كوكوس") },
                { "ces", new CountryName(official: "Kokosové ostrovy", common: "Kokosové ostrovy") },
                { "cym", new CountryName(official: "Tiriogaeth yr Ynysoedd Cocos (Keeling)", common: "Ynysoedd Cocos") },
                { "deu", new CountryName(official: "Gebiet der Kokos- (Keeling-) Inseln", common: "Kokosinseln") },
                { "est", new CountryName(official: "Kookossaarte ala", common: "Kookossaared") },
                { "fin", new CountryName(official: "Kookossaaret", common: "Kookossaaret") },
                { "fra", new CountryName(official: "Territoire des îles Cocos (Keeling)", common: "Îles Cocos") },
                { "hrv", new CountryName(official: "Teritoriju Kokosovi (Keeling) Islands", common: "Kokosovi Otoci") },
                { "hun", new CountryName(official: "Kókusz-szigetek", common: "Kókusz-szigetek") },
                { "ita", new CountryName(official: "Territorio della (Keeling) Isole Cocos", common: "Isole Cocos e Keeling") },
                { "jpn", new CountryName(official: "ココス諸島の領土", common: "ココス（キーリング）諸島") },
                { "kor", new CountryName(official: "코코스 제도", common: "코코스 제도") },
                { "nld", new CountryName(official: "Grondgebied van de Eilanden Cocos (Keeling )", common: "Cocoseilanden") },
                { "per", new CountryName(official: "جزایر کوکوس", common: "جزایر کوکوس") },
                { "pol", new CountryName(official: "Wyspy Kokosowe", common: "Wyspy Kokosowe") },
                { "por", new CountryName(official: "Território dos Cocos (Keeling)", common: "Ilhas Cocos (Keeling)") },
                { "rus", new CountryName(official: "Территория Кокосовые (Килинг) острова", common: "Кокосовые острова") },
                { "slk", new CountryName(official: "Kokosové ostrovy", common: "Kokosové ostrovy") },
                { "spa", new CountryName(official: "Territorio de los (Keeling) Islas Cocos", common: "Islas Cocos o Islas Keeling") },
                { "swe", new CountryName(official: "Kokosöarna", common: "Kokosöarna") },
                { "urd", new CountryName(official: "جزائر (کیلنگ) کوکوس", common: "جزائر کوکوس") },
                { "zho", new CountryName(official: "科科斯", common: "科科斯") },
            },
            cca2: "CC",
            cca3: "CCK",
            ccn3: "166",
            cioc: "",
            flag: "🇨🇨",
            region: Region.Oceania,
            subregion: "Australia and New Zealand",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"1", }),
            borders: new string[] {  },
            capital: new string[] { "West Island",  },
            altSpellings: new string[] { "CC", "Keeling Islands", "Cocos Islands",  },
            tld: new string[] { ".cc",  },
            latlng: new double[] { -12.5, 96.83333333,  },
            timezones: new string[] { "UTC+06:30",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "AUD", name: "Australian dollar", symbol: "$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Cocos Islander", female: "Cocos Islander") },
                { "fra", new DemonymsGender(male: "Cocos Islander", female: "Cocos Islander") },
            }
        );

        /// <summary>
        /// create an instance of Cocos(Keeling)Islands country
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
        private CocosKeelingIslands(
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
