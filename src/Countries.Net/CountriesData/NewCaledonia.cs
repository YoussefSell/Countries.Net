namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of NewCaledonia country
    /// </summary>
    public class NewCaledonia : Country
    {
        /// <summary>
        /// get the NewCaledonia country instance
        /// </summary>
        public static NewCaledonia Instance = new NewCaledonia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "New Caledonia", common: "New Caledonia") },
                { "fra", new CountryName(official: "Nouvelle-Calédonie", common: "Nouvelle-Calédonie") },
                { "ara", new CountryName(official: "كاليدونيا الجديدة", common: "كاليدونيا الجديدة") },
                { "ces", new CountryName(official: "Nová Kaledonie", common: "Nová Kaledonie") },
                { "cym", new CountryName(official: "New Caledonia", common: "New Caledonia") },
                { "deu", new CountryName(official: "Neukaledonien", common: "Neukaledonien") },
                { "est", new CountryName(official: "Uus-Kaledoonia", common: "Uus-Kaledoonia") },
                { "fin", new CountryName(official: "Uusi-Kaledonia", common: "Uusi-Kaledonia") },
                { "hrv", new CountryName(official: "Nova Kaledonija", common: "Nova Kaledonija") },
                { "hun", new CountryName(official: "Új-Kaledónia", common: "Új-Kaledónia") },
                { "ita", new CountryName(official: "Nuova Caledonia", common: "Nuova Caledonia") },
                { "jpn", new CountryName(official: "ニューカレドニア", common: "ニューカレドニア") },
                { "kor", new CountryName(official: "누벨칼레도니", common: "누벨칼레도니") },
                { "nld", new CountryName(official: "nieuw -Caledonië", common: "Nieuw-Caledonië") },
                { "per", new CountryName(official: "کالدونیای جدید", common: "کالدونیای جدید") },
                { "pol", new CountryName(official: "Nowa Kaledonia", common: "Nowa Kaledonia") },
                { "por", new CountryName(official: "New Caledonia", common: "Nova Caledónia") },
                { "rus", new CountryName(official: "Новая Каледония", common: "Новая Каледония") },
                { "slk", new CountryName(official: "Nová Kaledónia", common: "Nová Kaledónia") },
                { "spa", new CountryName(official: "nueva Caledonia", common: "Nueva Caledonia") },
                { "swe", new CountryName(official: "Nya Kaledonien", common: "Nya Kaledonien") },
                { "urd", new CountryName(official: "نیو کیلیڈونیا", common: "نیو کیلیڈونیا") },
                { "zho", new CountryName(official: "新喀里多尼亚", common: "新喀里多尼亚") },

            },
            cca2: "NC",
            cca3: "NCL",
            ccn3: "540",
            cioc: "",
            flag: "🇳🇨",
            region: Region.Oceania,
            subregion: "Melanesia",
            independent: false,
            status: "officially-assigned",
            unMember: false,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"87", }),
            borders: new string[] {  },
            capital: new string[] { "Nouméa",  },
            altSpellings: new string[] { "NC",  },
            tld: new string[] { ".nc",  },
            latlng: new double[] { -21.5, 165.5,  },
            timezones: new string[] { "UTC+11:00",  },
            languages: new Language[]
            {
                new Language(name: "French", iso6391: "fr", iso6392: "fra"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "XPF", name: "CFP franc", symbol: "₣"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "New Caledonian", female: "New Caledonian") },
                { "fra", new DemonymsGender(male: "New Caledonian", female: "New Caledonian") },
            }
        );

        /// <summary>
        /// create an instance of NewCaledonia country
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
        private NewCaledonia(
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
