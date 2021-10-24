namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of SaudiArabia country
    /// </summary>
    public class SaudiArabia : Country
    {
        /// <summary>
        /// get the SaudiArabia country instance
        /// </summary>
        public static SaudiArabia Instance = new SaudiArabia(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Kingdom of Saudi Arabia", common: "Saudi Arabia") },
                { "ara", new CountryName(official: "المملكة العربية السعودية", common: "العربية السعودية") },
                { "ces", new CountryName(official: "Saúdskoarabské království", common: "Saúdská Arábie") },
                { "cym", new CountryName(official: "Kingdom of Saudi Arabia", common: "Saudi Arabia") },
                { "deu", new CountryName(official: "Königreich Saudi-Arabien", common: "Saudi-Arabien") },
                { "est", new CountryName(official: "Saudi Araabia Kuningriik", common: "Saudi Araabia") },
                { "fin", new CountryName(official: "Saudi-Arabian kuningaskunta", common: "Saudi-Arabia") },
                { "fra", new CountryName(official: "Royaume d'Arabie Saoudite", common: "Arabie Saoudite") },
                { "hrv", new CountryName(official: "Kraljevina Saudijska Arabija", common: "Saudijska Arabija") },
                { "hun", new CountryName(official: "Szaúd-Arábia", common: "Szaúd-Arábia") },
                { "ita", new CountryName(official: "Arabia Saudita", common: "Arabia Saudita") },
                { "jpn", new CountryName(official: "サウジアラビア王国", common: "サウジアラビア") },
                { "kor", new CountryName(official: "사우디아라비아 왕국", common: "사우디아라비아") },
                { "nld", new CountryName(official: "Koninkrijk van Saoedi-Arabië", common: "Saoedi-Arabië") },
                { "per", new CountryName(official: "پادشاهی عربی سَعودی", common: "عربستان سعودی") },
                { "pol", new CountryName(official: "Królestwo Arabii Saudyjskiej", common: "Arabia Saudyjska") },
                { "por", new CountryName(official: "Reino da Arábia Saudita", common: "Arábia Saudita") },
                { "rus", new CountryName(official: "Королевство Саудовская Аравия", common: "Саудовская Аравия") },
                { "slk", new CountryName(official: "Saudskoarabské kráľovstvo", common: "Saudská Arábia") },
                { "spa", new CountryName(official: "Reino de Arabia Saudita", common: "Arabia Saudí") },
                { "swe", new CountryName(official: "Kungadömet Saudiarabien", common: "Saudiarabien") },
                { "urd", new CountryName(official: "مملکتِ سعودی عرب", common: "سعودی عرب") },
                { "zho", new CountryName(official: "沙特阿拉伯王国", common: "沙特阿拉伯") },

            },
            cca2: "SA",
            cca3: "SAU",
            ccn3: "682",
            cioc: "KSA",
            flag: "🇸🇦",
            region: Region.Asia,
            subregion: "Western Asia",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+9", suffixes: new string[] {"66", }),
            borders: new string[] { "IRQ", "JOR", "KWT", "OMN", "QAT", "ARE", "YEM",  },
            capital: new string[] { "Riyadh",  },
            altSpellings: new string[] { "Saudi", "SA", "Kingdom of Saudi Arabia", "Al-Mamlakah al-‘Arabiyyah as-Su‘ūdiyyah",  },
            tld: new string[] { ".sa", ".السعودية",  },
            latlng: new double[] { 25, 45,  },
            timezones: new string[] { "UTC+03:00",  },
            languages: new Language[]
            {
                new Language(name: "Arabic", iso6391: "ar", iso6392: "ara"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "SAR", name: "Saudi riyal", symbol: "ر.س"),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Saudi Arabian", female: "Saudi Arabian") },
                { "fra", new DemonymsGender(male: "Saudi Arabian", female: "Saudi Arabian") },
            }
        );

        /// <summary>
        /// create an instance of SaudiArabia country
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
        private SaudiArabia(
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
