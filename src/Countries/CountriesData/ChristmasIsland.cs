namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of ChristmasIsland country
    /// </summary>
    public class ChristmasIsland : Country
    {
        /// <summary>
        /// get the ChristmasIsland country instance
        /// </summary>
        public static ChristmasIsland Instance = new ChristmasIsland(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Territory of Christmas Island", common: "Christmas Island") },
                { "ara", new CountryName(official: "جزيرة كريسماس", common: "جزيرة كريسماس") },
                { "ces", new CountryName(official: "Teritorium Vánočního ostrova", common: "Vánoční ostrov") },
                { "cym", new CountryName(official: "Tiriogaeth yr Ynys y Nadolig", common: "Ynys y Nadolig") },
                { "deu", new CountryName(official: "Gebiet der Weihnachtsinsel", common: "Weihnachtsinsel") },
                { "est", new CountryName(official: "Jõulusaare ala", common: "Jõulusaar") },
                { "fin", new CountryName(official: "Joulusaaren alue", common: "Joulusaari") },
                { "fra", new CountryName(official: "Territoire de l'île Christmas", common: "Île Christmas") },
                { "hrv", new CountryName(official: "Teritorij Božićni otok", common: "Božićni otok") },
                { "hun", new CountryName(official: "Karácsony-sziget", common: "Karácsony-sziget") },
                { "ita", new CountryName(official: "Territorio di Christmas Island", common: "Isola di Natale") },
                { "jpn", new CountryName(official: "クリスマス島の領土", common: "クリスマス島") },
                { "kor", new CountryName(official: "크리스마스 섬", common: "크리스마스 섬") },
                { "nld", new CountryName(official: "Grondgebied van Christmas Island", common: "Christmaseiland") },
                { "per", new CountryName(official: "جزیرهٔ کریسمس", common: "جزیرهٔ کریسمس") },
                { "pol", new CountryName(official: "Wyspa Bożego Narodzenia", common: "Wyspa Bożego Narodzenia") },
                { "por", new CountryName(official: "Território da Ilha Christmas", common: "Ilha do Natal") },
                { "rus", new CountryName(official: "Территория острова Рождества", common: "Остров Рождества") },
                { "slk", new CountryName(official: "Teritórium Vianočného ostrova", common: "Vianočnú ostrov") },
                { "spa", new CountryName(official: "Territorio de la Isla de Navidad", common: "Isla de Navidad") },
                { "swe", new CountryName(official: "Julön", common: "Julön") },
                { "urd", new CountryName(official: "ریاستِ جزیرہ کرسمس", common: "جزیرہ کرسمس") },
                { "zho", new CountryName(official: "圣诞岛", common: "圣诞岛") },
            },
            cca2: "CX",
            cca3: "CXR",
            ccn3: "162",
            cioc: "",
            flag: "🇨🇽",
            region: Region.Oceania,
            subregion: "Australia and New Zealand",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"1", }),
            borders: new string[] {  },
            capital: new string[] { "Flying Fish Cove",  },
            altSpellings: new string[] { "CX", "Territory of Christmas Island",  },
            tld: new string[] { ".cx",  },
            latlng: new double[] { -10.5, 105.66666666,  },
            timezones: new string[] { "UTC+07:00",  },
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
                { "eng", new DemonymsGender(male: "Christmas Islander", female: "Christmas Islander") },
                { "fra", new DemonymsGender(male: "Christmas Islander", female: "Christmas Islander") },
            }
        );

        /// <summary>
        /// create an instance of ChristmasIsland country
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
        private ChristmasIsland(
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
