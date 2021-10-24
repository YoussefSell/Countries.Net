namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Germany country
    /// </summary>
    public class Germany : Country
    {
        /// <summary>
        /// get the Germany country instance
        /// </summary>
        public static Germany Instance = new Germany(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Federal Republic of Germany", common: "Germany") },
                { "deu", new CountryName(official: "Bundesrepublik Deutschland", common: "Deutschland") },
                { "ara", new CountryName(official: "جمهورية ألمانيا الاتحادية", common: "ألمانيا") },
                { "ces", new CountryName(official: "Spolková republika Německo", common: "Německo") },
                { "cym", new CountryName(official: "Federal Republic of Germany", common: "Germany") },
                { "est", new CountryName(official: "Saksamaa Liitvabariik", common: "Saksamaa") },
                { "fin", new CountryName(official: "Saksan liittotasavalta", common: "Saksa") },
                { "fra", new CountryName(official: "République fédérale d'Allemagne", common: "Allemagne") },
                { "hrv", new CountryName(official: "Njemačka Federativna Republika", common: "Njemačka") },
                { "hun", new CountryName(official: "Német Szövetségi Köztársaság", common: "Németország") },
                { "ita", new CountryName(official: "Repubblica federale di Germania", common: "Germania") },
                { "jpn", new CountryName(official: "ドイツ連邦共和国", common: "ドイツ") },
                { "kor", new CountryName(official: "독일 연방 공화국", common: "독일") },
                { "nld", new CountryName(official: "Bondsrepubliek Duitsland", common: "Duitsland") },
                { "per", new CountryName(official: "جمهوری فدرال آلمان", common: "آلمان") },
                { "pol", new CountryName(official: "Republika Federalna Niemiec", common: "Niemcy") },
                { "por", new CountryName(official: "República Federal da Alemanha", common: "Alemanha") },
                { "rus", new CountryName(official: "Федеративная Республика Германия", common: "Германия") },
                { "slk", new CountryName(official: "Nemecká spolková republika", common: "Nemecko") },
                { "spa", new CountryName(official: "República Federal de Alemania", common: "Alemania") },
                { "swe", new CountryName(official: "Förbundsrepubliken Tyskland", common: "Tyskland") },
                { "urd", new CountryName(official: "وفاقی جمہوریہ جرمنی", common: "جرمنی") },
                { "zho", new CountryName(official: "德意志联邦共和国", common: "德国") },

            },
            cca2: "DE",
            cca3: "DEU",
            ccn3: "276",
            cioc: "GER",
            flag: "🇩🇪",
            region: Region.Europe,
            subregion: "Western Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"9", }),
            borders: new string[] { "AUT", "BEL", "CZE", "DNK", "FRA", "LUX", "NLD", "POL", "CHE",  },
            capital: new string[] { "Berlin",  },
            altSpellings: new string[] { "DE", "Federal Republic of Germany", "Bundesrepublik Deutschland",  },
            tld: new string[] { ".de",  },
            latlng: new double[] { 51, 9,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "German", iso6391: "de", iso6392: "deu"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "German", female: "German") },
                { "fra", new DemonymsGender(male: "German", female: "German") },
            }
        );

        /// <summary>
        /// create an instance of Germany country
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
        private Germany(
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
