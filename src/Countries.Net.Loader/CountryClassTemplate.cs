namespace Countries.NET.Loader
{
    public static class CountryClassTemplate
    {
        public static string Load(Country country, string name, System.Globalization.CultureInfo[] cultures)
        {
            return @$"namespace Countries.Data
{{
    using System.Collections.Generic;
    using Countries.NET.Enums;

    /// <summary>
    /// create an instance of {name} country
    /// </summary>
    public class {name} : Country
    {{
        /// <summary>
        /// get the {name} country instance
        /// </summary>
        public static {name} Instance = new {name}(
            name: new LocalizedCountryName
            {{
                {country.GetName()}
            }},
            cca2: ""{country.Cca2}"",
            cca3: ""{country.Cca3}"",
            ccn3: ""{country.Ccn3}"",
            cioc: ""{country.Cioc}"",
            flag: ""{country.Flag}"",
            region: Region.{country.Region},
            subregion: ""{country.Subregion}"",
            independent: {(country.Independent ?? false).ToString().ToLower()},
            status: ""{country.Status}"",
            unMember: {country.UnMember.ToString().ToLower()},
            landlocked: {country.Landlocked.ToString().ToLower()},
            idd: new InternationalDirectDialingInfo(root: ""{country.Idd.Root}"", suffixes: new string[] {{{country.GetIddSuffixes()}}}),
            borders: new string[] {{ {country.GetBorders()} }},
            capital: new string[] {{ {country.GetCapitals()} }},
            altSpellings: new string[] {{ {country.GetAltSpellings()} }},
            tld: new string[] {{ {country.Gettld()} }},
            latlng: new double[] {{ {country.Getlatlng()} }},
            timezones: new string[] {{ {country.Gettimezones()} }},
            languages: new Language[]
            {{
                {country.Getlanguages(cultures)}
            }},
            currencies: new Currency[]
            {{
                {country.Getcurrencies()}
            }},
            demonyms: new Dictionary<string, DemonymsGender>
            {{
                {country.Getdemonyms()}
            }}
        );

        /// <summary>
        /// create an instance of {name} country
        /// </summary>
        /// <param name=""name""></param>
        /// <param name=""cca2""></param>
        /// <param name=""cca3""></param>
        /// <param name=""ccn3""></param>
        /// <param name=""cioc""></param>
        /// <param name=""flag""></param>
        /// <param name=""region""></param>
        /// <param name=""subregion""></param>
        /// <param name=""independent""></param>
        /// <param name=""status""></param>
        /// <param name=""unMember""></param>
        /// <param name=""landlocked""></param>
        /// <param name=""idd""></param>
        /// <param name=""borders""></param>
        /// <param name=""capital""></param>
        /// <param name=""altSpellings""></param>
        /// <param name=""tld""></param>
        /// <param name=""latlng""></param>
        /// <param name=""timezones""></param>
        /// <param name=""languages""></param>
        /// <param name=""currencies""></param>
        /// <param name=""demonyms""></param>
        private {name}(
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
            : base(name, cca2, cca3, ccn3, cioc, flag, region, subregion, independent, status, unMember, landlocked, idd, borders, capital, altSpellings, tld, latlng, timezones, languages, currencies, demonyms) {{ }}
    }}
}}
";
        }
    }
}
