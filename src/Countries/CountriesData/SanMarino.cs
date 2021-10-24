namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of SanMarino country
    /// </summary>
    public class SanMarino : Country
    {
        /// <summary>
        /// get the SanMarino country instance
        /// </summary>
        public static SanMarino Instance = new SanMarino(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of San Marino", common: "San Marino") },
                { "ita", new CountryName(official: "Repubblica di San Marino", common: "San Marino") },
                { "ara", new CountryName(official: "جمهورية سان مارينو", common: "سان مارينو") },
                { "ces", new CountryName(official: "Republika San Marino", common: "San Marino") },
                { "cym", new CountryName(official: "Republic of San Marino", common: "San Marino") },
                { "deu", new CountryName(official: "Republik San Marino", common: "San Marino") },
                { "est", new CountryName(official: "San Marino Vabariik", common: "San Marino") },
                { "fin", new CountryName(official: "San Marinon seesteinen tasavalta", common: "San Marino") },
                { "fra", new CountryName(official: "République de Saint-Marin", common: "Saint-Marin") },
                { "hrv", new CountryName(official: "Većina Serene Republika San Marino", common: "San Marino") },
                { "hun", new CountryName(official: "San Marino Köztársaság", common: "San Marino") },
                { "jpn", new CountryName(official: "サンマリノのほとんどセリーヌ共和国", common: "サンマリノ") },
                { "kor", new CountryName(official: "산마리노 공화국", common: "산마리노") },
                { "nld", new CountryName(official: "Meest Serene Republiek San Marino", common: "San Marino") },
                { "per", new CountryName(official: "جمهوری سان مارینو", common: "سان مارینو") },
                { "pol", new CountryName(official: "Republika San Marino", common: "San Marino") },
                { "por", new CountryName(official: "Sereníssima República de San Marino", common: "San Marino") },
                { "rus", new CountryName(official: "Большинство Serene Республика Сан-Марино", common: "Сан-Марино") },
                { "slk", new CountryName(official: "Sanmarínska republika", common: "San Maríno") },
                { "spa", new CountryName(official: "Serenísima República de San Marino", common: "San Marino") },
                { "swe", new CountryName(official: "Republiken San Marino", common: "San Marino") },
                { "urd", new CountryName(official: "جمہوریہ سان مارینو", common: "سان مارینو") },
                { "zho", new CountryName(official: "圣马力诺共和国", common: "圣马力诺") },

            },
            cca2: "SM",
            cca3: "SMR",
            ccn3: "674",
            cioc: "SMR",
            flag: "🇸🇲",
            region: Region.Europe,
            subregion: "Southern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"78", }),
            borders: new string[] { "ITA",  },
            capital: new string[] { "City of San Marino",  },
            altSpellings: new string[] { "SM", "Republic of San Marino", "Repubblica di San Marino",  },
            tld: new string[] { ".sm",  },
            latlng: new double[] { 43.76666666, 12.41666666,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Italian", iso6391: "it", iso6392: "ita"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Sammarinese", female: "Sammarinese") },
                { "fra", new DemonymsGender(male: "Sammarinese", female: "Sammarinese") },
            }
        );

        /// <summary>
        /// create an instance of SanMarino country
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
        private SanMarino(
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
