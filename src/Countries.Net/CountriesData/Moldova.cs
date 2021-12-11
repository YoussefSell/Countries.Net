namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Moldova country
    /// </summary>
    public class Moldova : Country
    {
        /// <summary>
        /// get the Moldova country instance
        /// </summary>
        public static Moldova Instance = new Moldova(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Moldova", common: "Moldova") },
                { "ron", new CountryName(official: "Republica Moldova", common: "Moldova") },
                { "ara", new CountryName(official: "جمهورية مولدوڤا", common: "مولدوڤا") },
                { "ces", new CountryName(official: "Moldavská republika", common: "Moldavsko") },
                { "cym", new CountryName(official: "Republic of Moldova", common: "Moldova") },
                { "deu", new CountryName(official: "Republik Moldau", common: "Moldawien") },
                { "est", new CountryName(official: "Moldova Vabariik", common: "Moldova") },
                { "fin", new CountryName(official: "Moldovan tasavalta", common: "Moldova") },
                { "fra", new CountryName(official: "République de Moldavie", common: "Moldavie") },
                { "hrv", new CountryName(official: "Moldavija", common: "Moldova") },
                { "hun", new CountryName(official: "Moldovai Köztársaság", common: "Moldova") },
                { "ita", new CountryName(official: "Repubblica di Moldova", common: "Moldavia") },
                { "jpn", new CountryName(official: "モルドバ共和国", common: "モルドバ共和国") },
                { "kor", new CountryName(official: "몰도바 공화국", common: "몰도바") },
                { "nld", new CountryName(official: "Republiek Moldavië", common: "Moldavië") },
                { "per", new CountryName(official: "جمهوری مولداوی", common: "مولداوی") },
                { "pol", new CountryName(official: "Republika Mołdawii", common: "Mołdawia") },
                { "por", new CountryName(official: "República da Moldávia", common: "Moldávia") },
                { "rus", new CountryName(official: "Молдова", common: "Молдавия") },
                { "slk", new CountryName(official: "Moldavská republika", common: "Moldavsko") },
                { "spa", new CountryName(official: "República de Moldova", common: "Moldavia") },
                { "swe", new CountryName(official: "Republiken Moldavien", common: "Moldavien") },
                { "urd", new CountryName(official: "جمہوریہ مالدووا", common: "مالدووا") },
                { "zho", new CountryName(official: "摩尔多瓦共和国", common: "摩尔多瓦") },
            },
            cca2: "MD",
            cca3: "MDA",
            ccn3: "498",
            cioc: "MDA",
            flag: "🇲🇩",
            region: Region.Europe,
            subregion: "Eastern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"73", }),
            borders: new string[] { "ROU", "UKR",  },
            capital: new string[] { "Chișinău",  },
            altSpellings: new string[] { "MD", "Moldova, Republic of", "Republic of Moldova", "Republica Moldova",  },
            tld: new string[] { ".md",  },
            latlng: new double[] { 47, 29,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Moldavian", iso6391: "ro", iso6392: "ron"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "MDL", name: "Moldovan leu", symbol: "L"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Moldovan", female: "Moldovan") },
                { "fra", new DemonymsGender(male: "Moldovan", female: "Moldovan") },
            }
        );

        /// <summary>
        /// create an instance of Moldova country
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
        private Moldova(
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
