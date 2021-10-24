namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of CapeVerde country
    /// </summary>
    public class CapeVerde : Country
    {
        /// <summary>
        /// get the CapeVerde country instance
        /// </summary>
        public static CapeVerde Instance = new CapeVerde(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Republic of Cabo Verde", common: "Cape Verde") },
                { "por", new CountryName(official: "República de Cabo Verde", common: "Cabo Verde") },
                { "ara", new CountryName(official: "جمهورية كابو فيردي", common: "كابو فيردي") },
                { "ces", new CountryName(official: "Kapverdská republika", common: "Kapverdy") },
                { "cym", new CountryName(official: "Gweriniaeth Cabo Verde", common: "Penrhyn Verde") },
                { "deu", new CountryName(official: "Republik Cabo Verde", common: "Kap Verde") },
                { "est", new CountryName(official: "Cabo Verde Vabariik", common: "Roheneemesaared") },
                { "fin", new CountryName(official: "Kap Verden tasavalta", common: "Kap Verde") },
                { "fra", new CountryName(official: "République du Cap-Vert", common: "Îles du Cap-Vert") },
                { "hrv", new CountryName(official: "Republika Cabo Verde", common: "Zelenortska Republika") },
                { "hun", new CountryName(official: "Zöld-foki Köztársaság", common: "Zöld-foki Köztársaság") },
                { "ita", new CountryName(official: "Repubblica di Capo Verde", common: "Capo Verde") },
                { "jpn", new CountryName(official: "カーボベルデ共和国", common: "カーボベルデ") },
                { "kor", new CountryName(official: "카보베르데 공화국", common: "카보베르데") },
                { "nld", new CountryName(official: "Republiek van Cabo Verde", common: "Kaapverdië") },
                { "per", new CountryName(official: "جمهوری کبو ورد", common: "دماغهٔ سبز") },
                { "pol", new CountryName(official: "Republika Zielonego Przylądka", common: "Republika Zielonego Przylądka") },
                { "rus", new CountryName(official: "Республика Кабо -Верде", common: "Кабо-Верде") },
                { "slk", new CountryName(official: "Kapverdská republika", common: "Kapverdy") },
                { "spa", new CountryName(official: "República de Cabo Verde", common: "Cabo Verde") },
                { "swe", new CountryName(official: "Republiken Kap Verde", common: "Kap Verde") },
                { "urd", new CountryName(official: "جمہوریہ کیپ ورڈی", common: "کیپ ورڈی") },
                { "zho", new CountryName(official: "佛得角共和国", common: "佛得角") },

            },
            cca2: "CV",
            cca3: "CPV",
            ccn3: "132",
            cioc: "CPV",
            flag: "🇨🇻",
            region: Region.Africa,
            subregion: "Western Africa",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+2", suffixes: new string[] {"38", }),
            borders: new string[] {  },
            capital: new string[] { "Praia",  },
            altSpellings: new string[] { "CV", "Republic of Cabo Verde", "República de Cabo Verde",  },
            tld: new string[] { ".cv",  },
            latlng: new double[] { 16, -24,  },
            timezones: new string[] { "UTC-01:00",  },
            languages: new Language[]
            {
                new Language(name: "Portuguese", iso6391: "pt", iso6392: "por"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "CVE", name: "Cape Verdean escudo", symbol: "Esc"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Cape Verdian", female: "Cape Verdian") },
                { "fra", new DemonymsGender(male: "Cape Verdian", female: "Cape Verdian") },
            }
        );

        /// <summary>
        /// create an instance of CapeVerde country
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
        private CapeVerde(
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
