namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of VaticanCity country
    /// </summary>
    public class VaticanCity : Country
    {
        /// <summary>
        /// get the VaticanCity country instance
        /// </summary>
        public static VaticanCity Instance = new VaticanCity(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Vatican City State", common: "Vatican City") },
                { "ita", new CountryName(official: "Stato della Città del Vaticano", common: "Vaticano") },
                { "lat", new CountryName(official: "Status Civitatis Vaticanæ", common: "Vaticanæ") },
                { "ara", new CountryName(official: "دولة مدينة الفاتيكان", common: "مدينة الفاتيكان") },
                { "ces", new CountryName(official: "Městský stát Vatikán", common: "Vatikán") },
                { "cym", new CountryName(official: "Vatican City State", common: "Vatican City") },
                { "deu", new CountryName(official: "Staat Vatikanstadt", common: "Vatikanstadt") },
                { "est", new CountryName(official: "Vatikani Linnriik", common: "Vatikan") },
                { "fin", new CountryName(official: "Vatikaanin kaupunkivaltio", common: "Vatikaani") },
                { "fra", new CountryName(official: "Cité du Vatican", common: "Cité du Vatican") },
                { "hrv", new CountryName(official: "Vatikan", common: "Vatikan") },
                { "hun", new CountryName(official: "Vatikán Állam", common: "Vatikán") },
                { "jpn", new CountryName(official: "バチカン市国の状態", common: "バチカン市国") },
                { "kor", new CountryName(official: "바티칸 시국", common: "바티칸") },
                { "nld", new CountryName(official: "Vaticaanstad", common: "Vaticaanstad") },
                { "per", new CountryName(official: "دولت‌شهر واتیکان", common: "واتیکان") },
                { "pol", new CountryName(official: "Państwo Watykańskie", common: "Watykan") },
                { "por", new CountryName(official: "Cidade do Vaticano", common: "Cidade do Vaticano") },
                { "rus", new CountryName(official: "Город-государство Ватикан", common: "Ватикан") },
                { "slk", new CountryName(official: "Svätá stolica (Vatikánsky mestský štát", common: "Vatikán") },
                { "spa", new CountryName(official: "Ciudad del Vaticano", common: "Ciudad del Vaticano") },
                { "swe", new CountryName(official: "Vatikanstaten", common: "Vatikanstaten") },
                { "urd", new CountryName(official: "ویٹیکن سٹی", common: "ویٹیکن سٹی") },
                { "zho", new CountryName(official: "梵蒂冈城国", common: "梵蒂冈") },

            },
            cca2: "VA",
            cca3: "VAT",
            ccn3: "336",
            cioc: "",
            flag: "🇻🇦",
            region: Region.Europe,
            subregion: "Southern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"906698", "79", }),
            borders: new string[] { "ITA",  },
            capital: new string[] { "Vatican City",  },
            altSpellings: new string[] { "VA", "Holy See (Vatican City State)", "Vatican City State", "Stato della Città del Vaticano",  },
            tld: new string[] { ".va",  },
            latlng: new double[] { 41.9, 12.45,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Italian", iso6391: "it", iso6392: "ita"),
                new Language(name: "Latin", iso6391: "la", iso6392: "lat"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Vatican", female: "Vatican") },
                { "fra", new DemonymsGender(male: "Vatican", female: "Vatican") },
            }
        );

        /// <summary>
        /// create an instance of VaticanCity country
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
        private VaticanCity(
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
