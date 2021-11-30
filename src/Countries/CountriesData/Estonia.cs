namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Estonia country
    /// </summary>
    public class Estonia : Country
    {
        /// <summary>
        /// get the Estonia country instance
        /// </summary>
        public static Estonia Instance = new Estonia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Estonia", common: "Estonia") },
                { "est", new CountryName(official: "Eesti Vabariik", common: "Eesti") },
                { "ara", new CountryName(official: "جمهورية إستونيا", common: "إستونيا") },
                { "ces", new CountryName(official: "Estonská republika", common: "Estonsko") },
                { "cym", new CountryName(official: "Gweriniaeth Estonia", common: "Estonia") },
                { "deu", new CountryName(official: "Republik Estland", common: "Estland") },
                { "fin", new CountryName(official: "Viron tasavalta", common: "Viro") },
                { "fra", new CountryName(official: "République d'Estonie", common: "Estonie") },
                { "hrv", new CountryName(official: "Republika Estonija", common: "Estonija") },
                { "hun", new CountryName(official: "Észt Köztársaság", common: "Észtország") },
                { "ita", new CountryName(official: "Repubblica di Estonia", common: "Estonia") },
                { "jpn", new CountryName(official: "エストニア共和国", common: "エストニア") },
                { "kor", new CountryName(official: "에스토니아 공화국", common: "에스토니아") },
                { "nld", new CountryName(official: "Republiek Estland", common: "Estland") },
                { "per", new CountryName(official: "جمهوری استونی", common: "اِستونی") },
                { "pol", new CountryName(official: "Republika Estońska", common: "Estonia") },
                { "por", new CountryName(official: "República da Estónia", common: "Estónia") },
                { "rus", new CountryName(official: "Эстонская Республика", common: "Эстония") },
                { "slk", new CountryName(official: "Estónska republika", common: "Estónsko") },
                { "spa", new CountryName(official: "República de Estonia", common: "Estonia") },
                { "swe", new CountryName(official: "Republiken Estland", common: "Estland") },
                { "urd", new CountryName(official: "جمہوریہ اسٹونیا", common: "اسٹونیا") },
                { "zho", new CountryName(official: "爱沙尼亚共和国", common: "爱沙尼亚") },

            },
            cca2: "EE",
            cca3: "EST",
            ccn3: "233",
            cioc: "EST",
            flag: "🇪🇪",
            region: Region.Europe,
            subregion: "Northern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"72", }),
            borders: new string[] { "LVA", "RUS",  },
            capital: new string[] { "Tallinn",  },
            altSpellings: new string[] { "EE", "Eesti", "Republic of Estonia", "Eesti Vabariik",  },
            tld: new string[] { ".ee",  },
            latlng: new double[] { 59, 26,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Estonian", iso6391: "et", iso6392: "est"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Estonian", female: "Estonian") },
                { "fra", new DemonymsGender(male: "Estonian", female: "Estonian") },
            }
        );

        /// <summary>
        /// create an instance of Estonia country
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
        private Estonia(
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
