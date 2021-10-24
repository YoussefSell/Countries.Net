namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of PapuaNewGuinea country
    /// </summary>
    public class PapuaNewGuinea : Country
    {
        /// <summary>
        /// get the PapuaNewGuinea country instance
        /// </summary>
        public static PapuaNewGuinea Instance = new PapuaNewGuinea(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Independent State of Papua New Guinea", common: "Papua New Guinea") },
                { "hmo", new CountryName(official: "Independen Stet bilong Papua Niugini", common: "Papua Niu Gini") },
                { "tpi", new CountryName(official: "Independen Stet bilong Papua Niugini", common: "Papua Niugini") },
                { "ara", new CountryName(official: "دولة بابوا غينيا الجديدة", common: "بابوا غينيا الجديدة") },
                { "ces", new CountryName(official: "Nezávislý stát Papua Nová Guinea", common: "Papua-Nová Guinea") },
                { "cym", new CountryName(official: "Independent State of Papua New Guinea", common: "Papua New Guinea") },
                { "deu", new CountryName(official: "Unabhängiger Staat Papua-Neuguinea", common: "Papua-Neuguinea") },
                { "est", new CountryName(official: "Paapua Uus-Guinea Iseseisvusriik", common: "Paapua Uus-Guinea") },
                { "fin", new CountryName(official: "Papua-Uuden-Guinean Itsenäinen valtio", common: "Papua-Uusi-Guinea") },
                { "fra", new CountryName(official: "État indépendant de Papouasie-Nouvelle-Guinée", common: "Papouasie-Nouvelle-Guinée") },
                { "hrv", new CountryName(official: "Nezavisna Država Papui Novoj Gvineji", common: "Papua Nova Gvineja") },
                { "hun", new CountryName(official: "Pápua Új-Guinea Független Állam", common: "Pápua Új-Guinea") },
                { "ita", new CountryName(official: "Stato indipendente di Papua Nuova Guinea", common: "Papua Nuova Guinea") },
                { "jpn", new CountryName(official: "パプアニューギニア独立国", common: "パプアニューギニア") },
                { "kor", new CountryName(official: "파푸아뉴기니 독립국", common: "파푸아뉴기니") },
                { "nld", new CountryName(official: "Onafhankelijke Staat Papoea -Nieuw-Guinea", common: "Papoea-Nieuw-Guinea") },
                { "per", new CountryName(official: "مملکت مستقل پاپوآ گینهٔ نو", common: "پاپوآ گینه نو") },
                { "pol", new CountryName(official: "Niezależne Państwo Papui-Nowej Gwinei", common: "Papua-Nowa Gwinea") },
                { "por", new CountryName(official: "Estado Independente da Papua Nova Guiné", common: "Papua Nova Guiné") },
                { "rus", new CountryName(official: "Независимое Государство Папуа-Новой Гвинеи", common: "Папуа — Новая Гвинея") },
                { "slk", new CountryName(official: "Nezávislý štát Papua-Nová Guinea", common: "Papua-Nová Guinea") },
                { "spa", new CountryName(official: "Estado Independiente de Papúa Nueva Guinea", common: "Papúa Nueva Guinea") },
                { "swe", new CountryName(official: "Den oberoende staten Papua Nya Guinea", common: "Papua Nya Guinea") },
                { "urd", new CountryName(official: "آزاد ریاستِ پاپوا نیو گنی", common: "پاپوا نیو گنی") },
                { "zho", new CountryName(official: "巴布亚新几内亚", common: "巴布亚新几内亚") },
            },
            cca2: "PG",
            cca3: "PNG",
            ccn3: "598",
            cioc: "PNG",
            flag: "🇵🇬",
            region: Region.Oceania,
            subregion: "Melanesia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+6", suffixes: new string[] {"75", }),
            borders: new string[] { "IDN",  },
            capital: new string[] { "Port Moresby",  },
            altSpellings: new string[] { "PG", "Independent State of Papua New Guinea", "Independen Stet bilong Papua Niugini",  },
            tld: new string[] { ".pg",  },
            latlng: new double[] { -6, 147,  },
            timezones: new string[] { "UTC+10:00",  },
            languages: new Language[]
            {
                new Language(name: "English", iso6391: "en", iso6392: "eng"),
                new Language(name: "Hiri Motu", iso6391: "", iso6392: "hmo"),
                new Language(name: "Tok Pisin", iso6391: "", iso6392: "tpi"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "PGK", name: "Papua New Guinean kina", symbol: "K"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Papua New Guinean", female: "Papua New Guinean") },
                { "fra", new DemonymsGender(male: "Papua New Guinean", female: "Papua New Guinean") },
            }
        );

        /// <summary>
        /// create an instance of PapuaNewGuinea country
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
        private PapuaNewGuinea(
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
