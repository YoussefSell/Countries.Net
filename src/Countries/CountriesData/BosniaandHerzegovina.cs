namespace Countries.Data
{
    using System.Collections.Generic;
    using Domain.Entities;
    using Domain.Enums;

    /// <summary>
    /// create an instance of BosniaandHerzegovina country
    /// </summary>
    public class BosniaandHerzegovina : Country
    {
        /// <summary>
        /// get the BosniaandHerzegovina country instance
        /// </summary>
        public static BosniaandHerzegovina Instance = new BosniaandHerzegovina(
            name: new LocalizedCountryName
            {
                { "eng", new CountryName(official: "Bosnia and Herzegovina", common: "Bosnia and Herzegovina") },
                { "bos", new CountryName(official: "Bosna i Hercegovina", common: "Bosna i Hercegovina") },
                { "hrv", new CountryName(official: "Bosna i Hercegovina", common: "Bosna i Hercegovina") },
                { "srp", new CountryName(official: "Боснa и Херцеговина", common: "Боснa и Херцеговина") },
                { "ara", new CountryName(official: "جمهورية البوسنة والهرسك", common: "البوسنة والهرسك") },
                { "ces", new CountryName(official: "Bosna a Hercegovina", common: "Bosna a Hercegovina") },
                { "cym", new CountryName(official: "Bosnia a Hercegovina", common: "Bosnia a Hercegovina") },
                { "deu", new CountryName(official: "Bosnien und Herzegowina", common: "Bosnien und Herzegowina") },
                { "est", new CountryName(official: "Bosnia ja Hertsegoviina", common: "Bosnia ja Hertsegoviina") },
                { "fin", new CountryName(official: "Bosnia ja Hertsegovina", common: "Bosnia ja Hertsegovina") },
                { "fra", new CountryName(official: "Bosnie-et-Herzégovine", common: "Bosnie-Herzégovine") },
                { "hun", new CountryName(official: "Bosznia-Hercegovina", common: "Bosznia-Hercegovina") },
                { "ita", new CountryName(official: "Bosnia-Erzegovina", common: "Bosnia ed Erzegovina") },
                { "jpn", new CountryName(official: "ボスニア·ヘルツェゴビナ", common: "ボスニア・ヘルツェゴビナ") },
                { "kor", new CountryName(official: "보스니아 헤르체고비나", common: "보스니아 헤르체고비나") },
                { "nld", new CountryName(official: "Bosnië-Herzegovina", common: "Bosnië en Herzegovina") },
                { "per", new CountryName(official: "بوسنی و هرزگوین", common: "بوسنی و هرزگوین") },
                { "pol", new CountryName(official: "Bośnia i Hercegowina", common: "Bośnia i Hercegowina") },
                { "por", new CountryName(official: "Bósnia e Herzegovina", common: "Bósnia e Herzegovina") },
                { "rus", new CountryName(official: "Босния и Герцеговина", common: "Босния и Герцеговина") },
                { "slk", new CountryName(official: "Republika Bosny a Hercegoviny", common: "Bosna a Hercegovina") },
                { "spa", new CountryName(official: "Bosnia y Herzegovina", common: "Bosnia y Herzegovina") },
                { "swe", new CountryName(official: "Bosnien och Hercegovina", common: "Bosnien och Hercegovina") },
                { "urd", new CountryName(official: "بوسنیا و ہرزیگووینا", common: "بوسنیا و ہرزیگووینا") },
                { "zho", new CountryName(official: "波斯尼亚和黑塞哥维那", common: "波斯尼亚和黑塞哥维那") },

            },
            cca2: "BA",
            cca3: "BIH",
            ccn3: "070",
            cioc: "BIH",
            flag: "🇧🇦",
            region: Region.Europe,
            subregion: "Southeast Europe",
            independent: true,
            status: "officially-assigned",
            unMember: true,
            landlocked: false,
            idd: new InternationalDirectDialingInfo(root: "+3", suffixes: new string[] {"87", }),
            borders: new string[] { "HRV", "MNE", "SRB",  },
            capital: new string[] { "Sarajevo",  },
            altSpellings: new string[] { "BA", "Bosnia-Herzegovina", "Босна и Херцеговина",  },
            tld: new string[] { ".ba",  },
            latlng: new double[] { 44, 18,  },
            timezones: new string[] { "UTC+01:00",  },
            languages: new Language[]
            {
                new Language(name: "Bosnian", iso6391: "bs", iso6392: "bos"),
                new Language(name: "Croatian", iso6391: "hr", iso6392: "hrv"),
                new Language(name: "Serbian", iso6391: "sr", iso6392: "srp"),
            },
            currencies: new Currency[]
            {
                new Currency(code: "BAM", name: "Bosnia and Herzegovina convertible mark", symbol: ""),
            },
            demonyms: new Dictionary<string, DemonymsGender>
            {
                { "eng", new DemonymsGender(male: "Bosnian, Herzegovinian", female: "Bosnian, Herzegovinian") },
                { "fra", new DemonymsGender(male: "Bosnian, Herzegovinian", female: "Bosnian, Herzegovinian") },
            }
        );

        /// <summary>
        /// create an instance of BosniaandHerzegovina country
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
        private BosniaandHerzegovina(
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
