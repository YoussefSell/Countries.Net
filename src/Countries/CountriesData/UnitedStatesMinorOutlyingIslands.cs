namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of UnitedStatesMinorOutlyingIslands country
    /// </summary>
    public class UnitedStatesMinorOutlyingIslands : Country
    {
        /// <summary>
        /// get the UnitedStatesMinorOutlyingIslands country instance
        /// </summary>
        public static UnitedStatesMinorOutlyingIslands Instance = new UnitedStatesMinorOutlyingIslands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "United States Minor Outlying Islands", common: "United States Minor Outlying Islands") },
                { "ara", new CountryName(official: "جزر الولايات المتحدة الصغيرة النائية", common: "جزر الولايات المتحدة الصغيرة النائية") },
                { "ces", new CountryName(official: "Menší odlehlé ostrovy Spojených států amerických", common: "Menší odlehlé ostrovy USA") },
                { "cym", new CountryName(official: "United States Minor Outlying Islands", common: "United States Minor Outlying Islands") },
                { "deu", new CountryName(official: "USA, kleinere ausgelagerte Inseln", common: "Kleinere Inselbesitzungen der Vereinigten Staaten") },
                { "est", new CountryName(official: "Ühendriikide väikesed hajasaared", common: "Ühendriikide hajasaared") },
                { "fin", new CountryName(official: "Yhdysvaltain asumattomat saaret", common: "Yhdysvaltain asumattomat saaret") },
                { "fra", new CountryName(official: "Îles mineures éloignées des États-Unis", common: "Îles mineures éloignées des États-Unis") },
                { "hrv", new CountryName(official: "Mali udaljeni otoci SAD-a", common: "Mali udaljeni otoci SAD-a") },
                { "hun", new CountryName(official: "Az Amerikai Egyesült Államok lakatlan külbirtokai", common: "Az Amerikai Egyesült Államok lakatlan külbirtokai") },
                { "ita", new CountryName(official: "Stati Uniti Isole Minori", common: "Isole minori esterne degli Stati Uniti d'America") },
                { "jpn", new CountryName(official: "アメリカ合衆国外諸島", common: "合衆国領有小離島") },
                { "kor", new CountryName(official: "미국령 군소 제도", common: "미국령 군소 제도") },
                { "nld", new CountryName(official: "Kleine afgelegen eilanden van de Verenigde Staten", common: "Kleine afgelegen eilanden van de Verenigde Staten") },
                { "per", new CountryName(official: "جزایر کوچک حاشیه‌ای ایالات متحده آمریکا", common: "جزایر کوچک حاشیه‌ای ایالات متحده آمریکا") },
                { "pol", new CountryName(official: "Dalekie Wyspy Mniejsze Stanów Zjednoczonych", common: "Dalekie Wyspy Mniejsze Stanów Zjednoczonych") },
                { "por", new CountryName(official: "Estados Unidos Ilhas Menores Distantes", common: "Ilhas Menores Distantes dos Estados Unidos") },
                { "rus", new CountryName(official: "Внешние малые острова США", common: "Внешние малые острова США") },
                { "slk", new CountryName(official: "Menšie odľahlé ostrovy Spjoených štátov", common: "Menšie odľahlé ostrovy USA") },
                { "spa", new CountryName(official: "Estados Unidos Islas menores alejadas de", common: "Islas Ultramarinas Menores de Estados Unidos") },
                { "swe", new CountryName(official: "Förenta staternas mindre öar i Oceanien och Västindien", common: "Förenta staternas mindre öar i Oceanien och Västindien") },
                { "urd", new CountryName(official: "امریکی چھوٹے بیرونی جزائر", common: "امریکی چھوٹے بیرونی جزائر") },
                { "zho", new CountryName(official: "美国本土外小岛屿", common: "美国本土外小岛屿") },
            },
            cca2: "UM",
            cca3: "UMI",
            ccn3: "581",
            cioc: "",
            flag: "🇺🇲",
            region: Region.Americas,
            subregion: "North America",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"68", }),
            borders: new string[] {  },
            capital: new string[] {  },
            altSpellings: new string[] { "UM",  },
            tld: new string[] { ".us",  },
            latlng: new double[] { 19.3, 166.633333,  },
            timezones: new string[] { "UTC-11:00", "UTC-10:00", "UTC+12:00",  },
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
                { "eng", new DemonymsGender(male: "American Islander", female: "American Islander") },
                { "fra", new DemonymsGender(male: "American Islander", female: "American Islander") },
            }
        );

        /// <summary>
        /// create an instance of UnitedStatesMinorOutlyingIslands country
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
        private UnitedStatesMinorOutlyingIslands(
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
