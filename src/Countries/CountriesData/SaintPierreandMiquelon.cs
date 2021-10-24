namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of SaintPierreandMiquelon country
    /// </summary>
    public class SaintPierreandMiquelon : Country
    {
        /// <summary>
        /// get the SaintPierreandMiquelon country instance
        /// </summary>
        public static SaintPierreandMiquelon Instance = new SaintPierreandMiquelon(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Saint Pierre and Miquelon", common: "Saint Pierre and Miquelon") },
                { "fra", new CountryName(official: "Collectivité territoriale de Saint-Pierre-et-Miquelon", common: "Saint-Pierre-et-Miquelon") },
                { "ara", new CountryName(official: "سان بيير وميكلون", common: "سان بيير وميكلون") },
                { "ces", new CountryName(official: "Saint-Pierre a Miquelon", common: "Saint-Pierre a Miquelon") },
                { "cym", new CountryName(official: "Saint Pierre and Miquelon", common: "Saint Pierre and Miquelon") },
                { "deu", new CountryName(official: "St. Pierre und Miquelon", common: "St. Pierre und Miquelon") },
                { "est", new CountryName(official: "Saint-Pierre’i ja Miqueloni territoriaalühendus", common: "Saint-Pierre ja Miquelon") },
                { "fin", new CountryName(official: "Saint-Pierre ja Miquelon", common: "Saint-Pierre ja Miquelon") },
                { "hrv", new CountryName(official: "Saint Pierre i Miquelon", common: "Sveti Petar i Mikelon") },
                { "hun", new CountryName(official: "Saint-Pierre és Miquelon", common: "Saint-Pierre és Miquelon") },
                { "ita", new CountryName(official: "Saint Pierre e Miquelon", common: "Saint-Pierre e Miquelon") },
                { "jpn", new CountryName(official: "サンピエール島·ミクロン島", common: "サンピエール島・ミクロン島") },
                { "kor", new CountryName(official: "생피에르 미클롱", common: "생피에르 미클롱") },
                { "nld", new CountryName(official: "Saint-Pierre en Miquelon", common: "Saint Pierre en Miquelon") },
                { "per", new CountryName(official: "سن-پیر-ا-میکلون", common: "سن-پیِر و میکلُن") },
                { "pol", new CountryName(official: "Saint-Pierre i Miquelon", common: "Saint-Pierre i Miquelon") },
                { "por", new CountryName(official: "Saint Pierre e Miquelon", common: "Saint-Pierre e Miquelon") },
                { "rus", new CountryName(official: "Сен-Пьер и Микелон", common: "Сен-Пьер и Микелон") },
                { "slk", new CountryName(official: "Ostrovy Saint Pierre a Miquelon", common: "Saint Pierre a Miquelon") },
                { "spa", new CountryName(official: "San Pedro y Miquelón", common: "San Pedro y Miquelón") },
                { "swe", new CountryName(official: "Saint-Pierre och Miquelon", common: "Saint-Pierre och Miquelon") },
                { "urd", new CountryName(official: "سینٹ پیئر و میکیلون", common: "سینٹ پیئر و میکیلون") },
                { "zho", new CountryName(official: "圣皮埃尔和密克隆", common: "圣皮埃尔和密克隆") },

            },
            cca2: "PM",
            cca3: "SPM",
            ccn3: "666",
            cioc: "",
            flag: "🇵🇲",
            region: Region.Americas,
            subregion: "North America",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+5", suffixes: new string[] {"08", }),
            borders: new string[] {  },
            capital: new string[] { "Saint-Pierre",  },
            altSpellings: new string[] { "PM", "Collectivité territoriale de Saint-Pierre-et-Miquelon",  },
            tld: new string[] { ".pm",  },
            latlng: new double[] { 46.83333333, -56.33333333,  },
            timezones: new string[] { "UTC-03:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Saint-Pierrais, Miquelonnais", female: "Saint-Pierrais, Miquelonnais") },
                { "fra", new DemonymsGender(male: "Saint-Pierrais, Miquelonnais", female: "Saint-Pierrais, Miquelonnais") },
            }
        );

        /// <summary>
        /// create an instance of SaintPierreandMiquelon country
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
        private SaintPierreandMiquelon(
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
