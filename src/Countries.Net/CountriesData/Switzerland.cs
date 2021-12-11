namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Switzerland country
    /// </summary>
    public class Switzerland : Country
    {
        /// <summary>
        /// get the Switzerland country instance
        /// </summary>
        public static Switzerland Instance = new Switzerland(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Swiss Confederation", common: "Switzerland") },
                { "fra", new CountryName(official: "Confédération suisse", common: "Suisse") },
                { "gsw", new CountryName(official: "Schweizerische Eidgenossenschaft", common: "Schweiz") },
                { "ita", new CountryName(official: "Confederazione Svizzera", common: "Svizzera") },
                { "roh", new CountryName(official: "Confederaziun svizra", common: "Svizra") },
                { "ara", new CountryName(official: "الاتحاد السويسري", common: "سويسرا") },
                { "ces", new CountryName(official: "Švýcarská konfederace", common: "Švýcarsko") },
                { "cym", new CountryName(official: "Swiss Confederation", common: "Switzerland") },
                { "deu", new CountryName(official: "Schweizerische Eidgenossenschaft", common: "Schweiz") },
                { "est", new CountryName(official: "Šveitsi Konföderatsioon", common: "Šveits") },
                { "fin", new CountryName(official: "Sveitsin valaliitto", common: "Sveitsi") },
                { "hrv", new CountryName(official: "švicarska Konfederacija", common: "Švicarska") },
                { "hun", new CountryName(official: "Svájc", common: "Svájc") },
                { "jpn", new CountryName(official: "スイス連邦", common: "スイス") },
                { "kor", new CountryName(official: "스위스 연방", common: "스위스") },
                { "nld", new CountryName(official: "Zwitserse Confederatie", common: "Zwitserland") },
                { "per", new CountryName(official: "کنفدراسیون سوئیس", common: "سوئیس") },
                { "pol", new CountryName(official: "Konfederacja Szwajcarska", common: "Szwajcaria") },
                { "por", new CountryName(official: "Confederação Suíça", common: "Suíça") },
                { "rus", new CountryName(official: "Швейцарская Конфедерация", common: "Швейцария") },
                { "slk", new CountryName(official: "Švajčiarska konfederácia", common: "Švajčiarsko") },
                { "spa", new CountryName(official: "Confederación Suiza", common: "Suiza") },
                { "swe", new CountryName(official: "Schweiziska edsförbundet", common: "Schweiz") },
                { "urd", new CountryName(official: "سوئیس  متحدہ", common: "سویٹذرلینڈ") },
                { "zho", new CountryName(official: "瑞士联邦", common: "瑞士") },

            },
            cca2: "CH",
            cca3: "CHE",
            ccn3: "756",
            cioc: "SUI",
            flag: "🇨🇭",
            region: Region.Europe,
            subregion: "Western Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+4", suffixes: new string[] {"1", }),
            borders: new string[] { "AUT", "FRA", "ITA", "LIE", "DEU",  },
            capital: new string[] { "Bern",  },
            altSpellings: new string[] { "CH", "Swiss Confederation", "Schweiz", "Suisse", "Svizzera", "Svizra",  },
            tld: new string[] { ".ch",  },
            latlng: new double[] { 47, 8,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
                new Language(name: "Swiss German", iso6391: "gsw", iso6392: "gsw"),
                new Language(name: "Italian", iso6391: "it", iso6392: "ita"),
                new Language(name: "Romansh", iso6391: "rm", iso6392: "roh"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "CHF", name: "Swiss franc", symbol: "Fr."),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Swiss", female: "Swiss") },
                { "fra", new DemonymsGender(male: "Swiss", female: "Swiss") },
            }
        );

        /// <summary>
        /// create an instance of Switzerland country
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
        private Switzerland(
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
