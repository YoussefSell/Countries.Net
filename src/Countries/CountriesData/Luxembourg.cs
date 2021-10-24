namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of Luxembourg country
    /// </summary>
    public class Luxembourg : Country
    {
        /// <summary>
        /// get the Luxembourg country instance
        /// </summary>
        public static Luxembourg Instance = new Luxembourg(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Grand Duchy of Luxembourg", common: "Luxembourg") },
                { "deu", new CountryName(official: "Großherzogtum Luxemburg", common: "Luxemburg") },
                { "fra", new CountryName(official: "Grand-Duché de Luxembourg", common: "Luxembourg") },
                { "ltz", new CountryName(official: "Groussherzogtum Lëtzebuerg", common: "Lëtzebuerg") },
                { "ara", new CountryName(official: "دوقية لوكسمبورغ", common: "لوكسمبورغ") },
                { "ces", new CountryName(official: "Lucemburské velkovévodství", common: "Lucembursko") },
                { "cym", new CountryName(official: "Grand Duchy of Luxembourg", common: "Luxembourg") },
                { "est", new CountryName(official: "Luksemburgi Suurhertsogiriik", common: "Luksemburg") },
                { "fin", new CountryName(official: "Luxemburgin suurherttuakunta", common: "Luxemburg") },
                { "hrv", new CountryName(official: "Veliko Vojvodstvo Luksemburg", common: "Luksemburg") },
                { "hun", new CountryName(official: "Luxemburgi Nagyhercegség", common: "Luxemburg") },
                { "ita", new CountryName(official: "Granducato di Lussemburgo", common: "Lussemburgo") },
                { "jpn", new CountryName(official: "ルクセンブルク大公国", common: "ルクセンブルク") },
                { "kor", new CountryName(official: "룩셈부르크 대공국", common: "룩셈부르크") },
                { "nld", new CountryName(official: "Groothertogdom Luxemburg", common: "Luxemburg") },
                { "per", new CountryName(official: "دوک‌نشین لوکزامبورگ", common: "لوکزامبورگ") },
                { "pol", new CountryName(official: "Wielkie Księstwo Luksemburga", common: "Luksemburg") },
                { "por", new CountryName(official: "Grão-Ducado do Luxemburgo", common: "Luxemburgo") },
                { "rus", new CountryName(official: "Великое Герцогство Люксембург", common: "Люксембург") },
                { "slk", new CountryName(official: "Luxemburské veľkovojvodstvo", common: "Luxembursko") },
                { "spa", new CountryName(official: "Gran Ducado de Luxemburgo", common: "Luxemburgo") },
                { "swe", new CountryName(official: "Storhertigdömet Luxemburg", common: "Luxemburg") },
                { "urd", new CountryName(official: "دوقیہ کبیرلکسمبرگ", common: "لکسمبرگ") },
                { "zho", new CountryName(official: "卢森堡大公国", common: "卢森堡") },

            },
            cca2: "LU",
            cca3: "LUX",
            ccn3: "442",
            cioc: "LUX",
            flag: "🇱🇺",
            region: Region.Europe,
            subregion: "Western Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: true,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"52", }),
            borders: new string[] { "BEL", "FRA", "DEU",  },
            capital: new string[] { "Luxembourg",  },
            altSpellings: new string[] { "LU", "Grand Duchy of Luxembourg", "Grand-Duché de Luxembourg", "Großherzogtum Luxemburg", "Groussherzogtum Lëtzebuerg",  },
            tld: new string[] { ".lu",  },
            latlng: new double[] { 49.75, 6.16666666,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "German", iso6391: "de", iso6392: "deu"),
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
                new Language(name: "Luxembourgish", iso6391: "lb", iso6392: "ltz"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Luxembourger", female: "Luxembourger") },
                { "fra", new DemonymsGender(male: "Luxembourger", female: "Luxembourger") },
            }
        );

        /// <summary>
        /// create an instance of Luxembourg country
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
        private Luxembourg(
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
