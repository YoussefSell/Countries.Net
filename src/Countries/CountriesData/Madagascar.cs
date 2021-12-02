namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Madagascar country
    /// </summary>
    public class Madagascar : Country
    {
        /// <summary>
        /// get the Madagascar country instance
        /// </summary>
        public static Madagascar Instance = new Madagascar(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Madagascar", common: "Madagascar") },
                { "fra", new CountryName(official: "République de Madagascar", common: "Madagascar") },
                { "mlg", new CountryName(official: "Repoblikan'i Madagasikara", common: "Madagasikara") },
                { "ara", new CountryName(official: "جمهورية مدغشقر", common: "مدغشقر") },
                { "ces", new CountryName(official: "Madagaskarská republika", common: "Madagaskar") },
                { "cym", new CountryName(official: "Republic of Madagascar", common: "Madagascar") },
                { "deu", new CountryName(official: "Republik Madagaskar", common: "Madagaskar") },
                { "est", new CountryName(official: "Madagaskari Vabariik", common: "Madagaskar") },
                { "fin", new CountryName(official: "Madagaskarin tasavalta", common: "Madagaskar") },
                { "hrv", new CountryName(official: "Republika Madagaskar", common: "Madagaskar") },
                { "hun", new CountryName(official: "Madagaszkári Köztársaság", common: "Madagaszkár") },
                { "ita", new CountryName(official: "Repubblica del Madagascar", common: "Madagascar") },
                { "jpn", new CountryName(official: "マダガスカル共和国", common: "マダガスカル") },
                { "kor", new CountryName(official: "마다가스카르 공화국", common: "마다가스카르") },
                { "nld", new CountryName(official: "Republiek Madagaskar", common: "Madagaskar") },
                { "per", new CountryName(official: "جمهوری ماداگاسکار", common: "ماداگاسکار") },
                { "pol", new CountryName(official: "Republika Madagaskaru", common: "Madagaskar") },
                { "por", new CountryName(official: "República de Madagáscar", common: "Madagáscar") },
                { "rus", new CountryName(official: "Республика Мадагаскар", common: "Мадагаскар") },
                { "slk", new CountryName(official: "Madagaskarská republika", common: "Madagaskar") },
                { "spa", new CountryName(official: "República de Madagascar", common: "Madagascar") },
                { "swe", new CountryName(official: "Republiken Madagaskar", common: "Madagaskar") },
                { "urd", new CountryName(official: "جمہوریہ مڈغاسکر", common: "مڈغاسکر") },
                { "zho", new CountryName(official: "马达加斯加共和国", common: "马达加斯加") },

            },
            cca2: "MG",
            cca3: "MDG",
            ccn3: "450",
            cioc: "MAD",
            flag: "🇲🇬",
            region: Region.Africa,
            subregion: "Eastern Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"61", }),
            borders: new string[] {  },
            capital: new string[] { "Antananarivo",  },
            altSpellings: new string[] { "MG", "Republic of Madagascar", "Repoblikan'i Madagasikara", "République de Madagascar",  },
            tld: new string[] { ".mg",  },
            latlng: new double[] { -20, 47,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
                new Language(name: "Malagasy", iso6391: "mg", iso6392: "mlg"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "MGA", name: "Malagasy ariary", symbol: "Ar"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Malagasy", female: "Malagasy") },
                { "fra", new DemonymsGender(male: "Malagasy", female: "Malagasy") },
            }
        );

        /// <summary>
        /// create an instance of Madagascar country
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
        private Madagascar(
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
