namespace Countries.NET.Database
{
    using System.Collections.Generic;
    
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of Greece country
    /// </summary>
    public class Greece : Country
    {
        /// <summary>
        /// get the Greece country instance
        /// </summary>
        public static Greece Instance = new Greece(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Hellenic Republic", common: "Greece") },
                { "ell", new CountryName(official: "Ελληνική Δημοκρατία", common: "Ελλάδα") },
                { "ara", new CountryName(official: "الجمهورية الهيلينية", common: "اليونان") },
                { "ces", new CountryName(official: "Řecká republika", common: "Řecko") },
                { "cym", new CountryName(official: "Hellenic Republic", common: "Greece") },
                { "deu", new CountryName(official: "Hellenische Republik", common: "Griechenland") },
                { "est", new CountryName(official: "Kreeka Vabariik", common: "Kreeka") },
                { "fin", new CountryName(official: "Helleenien tasavalta", common: "Kreikka") },
                { "fra", new CountryName(official: "République hellénique", common: "Grèce") },
                { "hrv", new CountryName(official: "Helenska Republika", common: "Grčka") },
                { "hun", new CountryName(official: "Görög Köztársaság", common: "Görögország") },
                { "ita", new CountryName(official: "Repubblica ellenica", common: "Grecia") },
                { "jpn", new CountryName(official: "ギリシャ共和国", common: "ギリシャ") },
                { "kor", new CountryName(official: "그리스 공화국", common: "그리스") },
                { "nld", new CountryName(official: "Helleense Republiek", common: "Griekenland") },
                { "per", new CountryName(official: "جمهوری یونان", common: "یونان") },
                { "pol", new CountryName(official: "Republika Grecka", common: "Grecja") },
                { "por", new CountryName(official: "República Helénica", common: "Grécia") },
                { "rus", new CountryName(official: "Греческая Республика", common: "Греция") },
                { "slk", new CountryName(official: "Grécka republika", common: "Greécko") },
                { "spa", new CountryName(official: "República Helénica", common: "Grecia") },
                { "swe", new CountryName(official: "Republiken Grekland", common: "Grekland") },
                { "urd", new CountryName(official: "جمہوریہ ہیلینیہ", common: "یونان") },
                { "zho", new CountryName(official: "希腊共和国", common: "希腊") },
            },
            cca2: "GR",
            cca3: "GRC",
            ccn3: "300",
            cioc: "GRE",
            flag: "🇬🇷",
            region: Region.Europe,
            subregion: "Southern Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"0", }),
            borders: new string[] { "ALB", "BGR", "TUR", "MKD",  },
            capital: new string[] { "Athens",  },
            altSpellings: new string[] { "GR", "Elláda", "Hellenic Republic", "Ελληνική Δημοκρατία",  },
            tld: new string[] { ".gr",  },
            latlng: new double[] { 39, 22,  },
            timezones: new string[] { "UTC+02:00",  },
            languages: new Language[]
            {
                new Language(name: "Greek", iso6391: "el", iso6392: "ell"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "EUR", name: "Euro", symbol: "€"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Greek", female: "Greek") },
                { "fra", new DemonymsGender(male: "Greek", female: "Greek") },
            }
        );

        /// <summary>
        /// create an instance of Greece country
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
        private Greece(
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
