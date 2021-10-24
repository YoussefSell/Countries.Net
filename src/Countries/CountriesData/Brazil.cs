namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Brazil country
    /// </summary>
    public class Brazil : Country
    {
        /// <summary>
        /// get the Brazil country instance
        /// </summary>
        public static Brazil Instance = new Brazil(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Federative Republic of Brazil", common: "Brazil") },
                { "por", new CountryName(official: "República Federativa do Brasil", common: "Brasil") },
                { "ara", new CountryName(official: "جمهورية البرازيل الاتحادية", common: "البرازيل") },
                { "ces", new CountryName(official: "Brazilská federativní republika", common: "Brazílie") },
                { "cym", new CountryName(official: "Gweriniaeth Ffederal Brasil", common: "Brasil") },
                { "deu", new CountryName(official: "Föderative Republik Brasilien", common: "Brasilien") },
                { "est", new CountryName(official: "Brasiilia Liitvabariik", common: "Brasiilia") },
                { "fin", new CountryName(official: "Brasilian liittotasavalta", common: "Brasilia") },
                { "fra", new CountryName(official: "République fédérative du Brésil", common: "Brésil") },
                { "hrv", new CountryName(official: "Savezne Republike Brazil", common: "Brazil") },
                { "hun", new CountryName(official: "Brazil Szövetségi Köztársaság", common: "Brazília") },
                { "ita", new CountryName(official: "Repubblica federativa del Brasile", common: "Brasile") },
                { "jpn", new CountryName(official: "ブラジル連邦共和国", common: "ブラジル") },
                { "kor", new CountryName(official: "브라질 연방 공화국", common: "브라질") },
                { "nld", new CountryName(official: "Federale Republiek Brazilië", common: "Brazilië") },
                { "per", new CountryName(official: "جمهوری فدراتیو برزیل", common: "برزیل") },
                { "pol", new CountryName(official: "Federacyjna Republika Brazylii", common: "Brazylia") },
                { "rus", new CountryName(official: "Федеративная Республика Бразилия", common: "Бразилия") },
                { "slk", new CountryName(official: "Brazílska federatívna republika", common: "Brazília") },
                { "spa", new CountryName(official: "República Federativa del Brasil", common: "Brasil") },
                { "swe", new CountryName(official: "Förbundsrepubliken Brasilien", common: "Brasilien") },
                { "urd", new CountryName(official: "وفاقی جمہوریہ برازیل", common: "برازیل") },
                { "zho", new CountryName(official: "巴西联邦共和国", common: "巴西") },

            },
            cca2: "BR",
            cca3: "BRA",
            ccn3: "076",
            cioc: "BRA",
            flag: "🇧🇷",
            region: Region.Americas,
            subregion: "South America",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"5", }),
            borders: new string[] { "ARG", "BOL", "COL", "GUF", "GUY", "PRY", "PER", "SUR", "URY", "VEN",  },
            capital: new string[] { "Brasília",  },
            altSpellings: new string[] { "BR", "Brasil", "Federative Republic of Brazil", "República Federativa do Brasil",  },
            tld: new string[] { ".br",  },
            latlng: new double[] { -10, -55,  },
            timezones: new string[] { "UTC-05:00", "UTC-04:00", "UTC-03:00", "UTC-02:00",  },
            languages: new Language[]
            {
                new Language(name: "Portuguese", iso6391: "pt", iso6392: "por"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "BRL", name: "Brazilian real", symbol: "R$"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Brazilian", female: "Brazilian") },
                { "fra", new DemonymsGender(male: "Brazilian", female: "Brazilian") },
            }
        );

        /// <summary>
        /// create an instance of Brazil country
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
        private Brazil(
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
