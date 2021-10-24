namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Nigeria country
    /// </summary>
    public class Nigeria : Country
    {
        /// <summary>
        /// get the Nigeria country instance
        /// </summary>
        public static Nigeria Instance = new Nigeria(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Federal Republic of Nigeria", common: "Nigeria") },
                { "ara", new CountryName(official: "جمهورية نيجيريا الاتحادية", common: "نيجيريا") },
                { "ces", new CountryName(official: "Nigerijská federativní republika", common: "Nigérie") },
                { "cym", new CountryName(official: "Federal Republic of Nigeria", common: "Nigeria") },
                { "deu", new CountryName(official: "Bundesrepublik Nigeria", common: "Nigeria") },
                { "est", new CountryName(official: "Nigeeria Liitvabariik", common: "Nigeeria") },
                { "fin", new CountryName(official: "Nigerian liittotasavalta", common: "Nigeria") },
                { "fra", new CountryName(official: "République fédérale du Nigeria", common: "Nigéria") },
                { "hrv", new CountryName(official: "Savezna Republika Nigerija", common: "Nigerija") },
                { "hun", new CountryName(official: "Nigéria", common: "Nigéria") },
                { "ita", new CountryName(official: "Repubblica federale di Nigeria", common: "Nigeria") },
                { "jpn", new CountryName(official: "ナイジェリア連邦共和国", common: "ナイジェリア") },
                { "kor", new CountryName(official: "나이지리아 연방 공화국", common: "나이지리아") },
                { "nld", new CountryName(official: "Federale Republiek Nigeria", common: "Nigeria") },
                { "per", new CountryName(official: "جمهوری فدرال نیجریه", common: "نیجریه") },
                { "pol", new CountryName(official: "Federalna Republika Nigerii", common: "Nigeria") },
                { "por", new CountryName(official: "República Federal da Nigéria", common: "Nigéria") },
                { "rus", new CountryName(official: "Федеративная Республика Нигерия", common: "Нигерия") },
                { "slk", new CountryName(official: "Nigérijská federatívna republika", common: "Nigéria") },
                { "spa", new CountryName(official: "República Federal de Nigeria", common: "Nigeria") },
                { "swe", new CountryName(official: "Förbundsrepubliken Nigeria", common: "Nigeria") },
                { "urd", new CountryName(official: "وفاقی جمہوریہ نائجیریا", common: "نائجیریا") },
                { "zho", new CountryName(official: "尼日利亚联邦共和国", common: "尼日利亚") },
            },
            cca2: "NG",
            cca3: "NGA",
            ccn3: "566",
            cioc: "NGR",
            flag: "🇳🇬",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"34", }),
            borders: new string[] { "BEN", "CMR", "TCD", "NER",  },
            capital: new string[] { "Abuja",  },
            altSpellings: new string[] { "NG", "Nijeriya", "Naíjíríà", "Federal Republic of Nigeria",  },
            tld: new string[] { ".ng",  },
            latlng: new double[] { 10, 8,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "NGN", name: "Nigerian naira", symbol: "₦"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Nigerian", female: "Nigerian") },
                { "fra", new DemonymsGender(male: "Nigerian", female: "Nigerian") },
            }
        );

        /// <summary>
        /// create an instance of Nigeria country
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
        private Nigeria(
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
