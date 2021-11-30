namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Mali country
    /// </summary>
    public class Mali : Country
    {
        /// <summary>
        /// get the Mali country instance
        /// </summary>
        public static Mali Instance = new Mali(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Mali", common: "Mali") },
                { "fra", new CountryName(official: "République du Mali", common: "Mali") },
                { "ara", new CountryName(official: "جمهورية مالي", common: "مالي") },
                { "ces", new CountryName(official: "Republika Mali", common: "Mali") },
                { "cym", new CountryName(official: "Republic of Mali", common: "Mali") },
                { "deu", new CountryName(official: "Republik Mali", common: "Mali") },
                { "est", new CountryName(official: "Mali Vabariik", common: "Mali") },
                { "fin", new CountryName(official: "Malin tasavalta", common: "Mali") },
                { "hrv", new CountryName(official: "Republika Mali", common: "Mali") },
                { "hun", new CountryName(official: "Mali Köztársaság", common: "Mali") },
                { "ita", new CountryName(official: "Repubblica del Mali", common: "Mali") },
                { "jpn", new CountryName(official: "マリ共和国", common: "マリ") },
                { "kor", new CountryName(official: "말리 공화국", common: "말리") },
                { "nld", new CountryName(official: "Republiek Mali", common: "Mali") },
                { "per", new CountryName(official: "جمهوری مالی", common: "مالی") },
                { "pol", new CountryName(official: "Republika Mali", common: "Mali") },
                { "por", new CountryName(official: "República do Mali", common: "Mali") },
                { "rus", new CountryName(official: "Республика Мали", common: "Мали") },
                { "slk", new CountryName(official: "Malijská republika", common: "Mali") },
                { "spa", new CountryName(official: "República de Malí", common: "Mali") },
                { "swe", new CountryName(official: "Republiken Mali", common: "Mali") },
                { "urd", new CountryName(official: "جمہوریہ مالی", common: "مالی") },
                { "zho", new CountryName(official: "马里共和国", common: "马里") },

            },
            cca2: "ML",
            cca3: "MLI",
            ccn3: "466",
            cioc: "MLI",
            flag: "🇲🇱",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"23", }),
            borders: new string[] { "DZA", "BFA", "GIN", "CIV", "MRT", "NER", "SEN",  },
            capital: new string[] { "Bamako",  },
            altSpellings: new string[] { "ML", "Republic of Mali", "République du Mali",  },
            tld: new string[] { ".ml",  },
            latlng: new double[] { 17, -4,  },
            timezones: new string[] { "UTC",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XOF", name: "West African CFA franc", symbol: "Fr"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Malian", female: "Malian") },
                { "fra", new DemonymsGender(male: "Malian", female: "Malian") },
            }
        );

        /// <summary>
        /// create an instance of Mali country
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
        private Mali(
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
