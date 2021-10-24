namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Guatemala country
    /// </summary>
    public class Guatemala : Country
    {
        /// <summary>
        /// get the Guatemala country instance
        /// </summary>
        public static Guatemala Instance = new Guatemala(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Guatemala", common: "Guatemala") },
                { "spa", new CountryName(official: "República de Guatemala", common: "Guatemala") },
                { "ara", new CountryName(official: "جمهورية غواتيمالا", common: "غواتيمالا") },
                { "ces", new CountryName(official: "Republika Guatemala", common: "Guatemala") },
                { "cym", new CountryName(official: "Republic of Guatemala", common: "Guatemala") },
                { "deu", new CountryName(official: "Republik Guatemala", common: "Guatemala") },
                { "est", new CountryName(official: "Guatemala Vabariik", common: "Guatemala") },
                { "fin", new CountryName(official: "Guatemalan tasavalta", common: "Guatemala") },
                { "fra", new CountryName(official: "République du Guatemala", common: "Guatemala") },
                { "hrv", new CountryName(official: "Republika Gvatemala", common: "Gvatemala") },
                { "hun", new CountryName(official: "Guatemalai Köztársaság", common: "Guatemala") },
                { "ita", new CountryName(official: "Repubblica del Guatemala", common: "Guatemala") },
                { "jpn", new CountryName(official: "グアテマラ共和国", common: "グアテマラ") },
                { "kor", new CountryName(official: "과테말라 공화국", common: "과테말라") },
                { "nld", new CountryName(official: "Republiek Guatemala", common: "Guatemala") },
                { "per", new CountryName(official: "جمهوری گواتِمالا", common: "گواتِمالا") },
                { "pol", new CountryName(official: "Republika Gwatemali", common: "Gwatemala") },
                { "por", new CountryName(official: "República da Guatemala", common: "Guatemala") },
                { "rus", new CountryName(official: "Республика Гватемала", common: "Гватемала") },
                { "slk", new CountryName(official: "Guatemalská republika", common: "Guatemala") },
                { "swe", new CountryName(official: "Republiken Guatemala", common: "Guatemala") },
                { "urd", new CountryName(official: "جمہوریہ گواتیمالا", common: "گواتیمالا") },
                { "zho", new CountryName(official: "危地马拉共和国", common: "危地马拉") },

            },
            cca2: "GT",
            cca3: "GTM",
            ccn3: "320",
            cioc: "GUA",
            flag: "🇬🇹",
            region: Region.Americas,
            subregion: "Central America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"02", }),
            borders: new string[] { "BLZ", "SLV", "HND", "MEX",  },
            capital: new string[] { "Guatemala City",  },
            altSpellings: new string[] { "GT",  },
            tld: new string[] { ".gt",  },
            latlng: new double[] { 15.5, -90.25,  },
            timezones: new string[] { "UTC-06:00",  },
            languages: new Language[]
            {
                new Language(name: "Spanish", iso6391: "es", iso6392: "spa"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "GTQ", name: "Guatemalan quetzal", symbol: "Q"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Guatemalan", female: "Guatemalan") },
                { "fra", new DemonymsGender(male: "Guatemalan", female: "Guatemalan") },
            }
        );

        /// <summary>
        /// create an instance of Guatemala country
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
        private Guatemala(
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
