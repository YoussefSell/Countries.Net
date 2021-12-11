namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Armenia country
    /// </summary>
    public class Armenia : Country
    {
        /// <summary>
        /// get the Armenia country instance
        /// </summary>
        public static Armenia Instance = new Armenia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Armenia", common: "Armenia") },
                { "hye", new CountryName(official: "Հայաստանի Հանրապետություն", common: "Հայաստան") },
                { "ara", new CountryName(official: "جمهورية أرمينيا", common: "أرمينيا") },
                { "ces", new CountryName(official: "Arménská republika", common: "Arménie") },
                { "cym", new CountryName(official: "Gweriniaeth Armenia", common: "Armenia") },
                { "deu", new CountryName(official: "Republik Armenien", common: "Armenien") },
                { "est", new CountryName(official: "Armeenia Vabariik", common: "Armeenia") },
                { "fin", new CountryName(official: "Armenian tasavalta", common: "Armenia") },
                { "fra", new CountryName(official: "République d'Arménie", common: "Arménie") },
                { "hrv", new CountryName(official: "Republika Armenija", common: "Armenija") },
                { "hun", new CountryName(official: "Örményország", common: "Örményország") },
                { "ita", new CountryName(official: "Repubblica di Armenia", common: "Armenia") },
                { "jpn", new CountryName(official: "アルメニア共和国", common: "アルメニア") },
                { "kor", new CountryName(official: "아르메니아 공화국", common: "아르메니아") },
                { "nld", new CountryName(official: "Republiek Armenië", common: "Armenië") },
                { "per", new CountryName(official: "جمهوری ارمنستان", common: "ارمنستان") },
                { "pol", new CountryName(official: "Republika Armenii", common: "Armenia") },
                { "por", new CountryName(official: "República da Arménia", common: "Arménia") },
                { "rus", new CountryName(official: "Республика Армения", common: "Армения") },
                { "slk", new CountryName(official: "Arménska republika", common: "Arménsko") },
                { "spa", new CountryName(official: "República de Armenia", common: "Armenia") },
                { "swe", new CountryName(official: "Republiken Armenien", common: "Armenien") },
                { "urd", new CountryName(official: "جمہوریہ آرمینیا", common: "آرمینیا") },
                { "zho", new CountryName(official: "亚美尼亚共和国", common: "亚美尼亚") },
            },
            cca2: "AM",
            cca3: "ARM",
            ccn3: "051",
            cioc: "ARM",
            flag: "🇦🇲",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"74", }),
            borders: new string[] { "AZE", "GEO", "IRN", "TUR",  },
            capital: new string[] { "Yerevan",  },
            altSpellings: new string[] { "AM", "Hayastan", "Republic of Armenia", "Հայաստանի Հանրապետություն",  },
            tld: new string[] { ".am",  },
            latlng: new double[] { 40, 45,  },
            timezones: new string[] { "UTC+04:00",  },
            languages: new Language[]
            {
                new Language(name: "Armenian", iso6391: "hy", iso6392: "hye"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "AMD", name: "Armenian dram", symbol: "֏"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Armenian", female: "Armenian") },
                { "fra", new DemonymsGender(male: "Armenian", female: "Armenian") },
            }
        );

        /// <summary>
        /// create an instance of Armenia country
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
        private Armenia(
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
