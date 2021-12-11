namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of FrenchSouthernandAntarcticLands country
    /// </summary>
    public class FrenchSouthernandAntarcticLands : Country
    {
        /// <summary>
        /// get the FrenchSouthernandAntarcticLands country instance
        /// </summary>
        public static FrenchSouthernandAntarcticLands Instance = new FrenchSouthernandAntarcticLands(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Territory of the French Southern and Antarctic Lands", common: "French Southern and Antarctic Lands") },
                { "fra", new CountryName(official: "Territoire des Terres australes et antarctiques françaises", common: "Terres australes et antarctiques françaises") },
                { "ara", new CountryName(official: "مقاطعات وأقاليم ما وراء البحار الفرنسية", common: "أراض فرنسية جنوبية وأنتارتيكية") },
                { "ces", new CountryName(official: "Teritorium Francouzská jižní a antarktická území", common: "Francouzská jižní a antarktická území") },
                { "cym", new CountryName(official: "Territory of the French Southern and Antarctic Lands", common: "French Southern and Antarctic Lands") },
                { "deu", new CountryName(official: "Gebiet der Französisch Süd- und Antarktisgebiete", common: "Französische Süd- und Antarktisgebiete") },
                { "est", new CountryName(official: "Prantsuse Lõunaalad", common: "Prantsuse Lõunaalad") },
                { "fin", new CountryName(official: "Ranskan eteläiset ja antarktiset alueet", common: "Ranskan eteläiset ja antarktiset alueet") },
                { "hrv", new CountryName(official: "Teritoriju Francuski južni i antarktički teritoriji", common: "Francuski južni i antarktički teritoriji") },
                { "hun", new CountryName(official: "Francia déli és antarktiszi területek", common: "Francia déli és antarktiszi területek") },
                { "ita", new CountryName(official: "Territorio della australi e antartiche francesi Terre", common: "Territori Francesi del Sud") },
                { "jpn", new CountryName(official: "フランス領南方·南極地域の領土", common: "フランス領南方・南極地域") },
                { "kor", new CountryName(official: "프랑스령 남부와 남극 지역", common: "프랑스령 남부와 남극 지역") },
                { "nld", new CountryName(official: "Grondgebied van de Franse Zuidelijke en Antarctische gebieden", common: "Franse Gebieden in de zuidelijke Indische Oceaan") },
                { "per", new CountryName(official: "سرزمین‌های جنوبی و جنوبگانی فرانسه", common: "سرزمین‌های جنوبی و جنوبگانی فرانسه") },
                { "pol", new CountryName(official: "Francuskie Terytoria Południowe i Antarktyczne", common: "Francuskie Terytoria Południowe i Antarktyczne") },
                { "por", new CountryName(official: "Território do Sul e Antártica Francesa", common: "Terras Austrais e Antárticas Francesas") },
                { "rus", new CountryName(official: "Территория Французские Южные и Антарктические земли", common: "Французские Южные и Антарктические территории") },
                { "slk", new CountryName(official: "Francúzske južné a antarktické územia", common: "Francúzske juŽné a antarktické územia") },
                { "spa", new CountryName(official: "Territorio del Francés Tierras australes y antárticas", common: "Tierras Australes y Antárticas Francesas") },
                { "swe", new CountryName(official: "Franska syd- och Antarktisterritorierna", common: "Franska södra territorierna") },
                { "urd", new CountryName(official: "سرزمینِ جنوبی فرانسیسیہ و انٹارکٹیکہ", common: "سرزمین جنوبی فرانسیسیہ و انٹارکٹیکا") },
                { "zho", new CountryName(official: "法国南部和南极土地", common: "法国南部和南极土地") },

            },
            cca2: "TF",
            cca3: "ATF",
            ccn3: "260",
            cioc: "",
            flag: "🇹🇫",
            region: Region.Antarctic,
            subregion: "",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"62", }),
            borders: new string[] {  },
            capital: new string[] { "Port-aux-Français",  },
            altSpellings: new string[] { "TF", "French Southern Territories",  },
            tld: new string[] { ".tf",  },
            latlng: new double[] { -49.25, 69.167,  },
            timezones: new string[] { "UTC+05:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "French", female: "French") },
                { "fra", new DemonymsGender(male: "French", female: "French") },
            }
        );

        /// <summary>
        /// create an instance of FrenchSouthernandAntarcticLands country
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
        private FrenchSouthernandAntarcticLands(
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
