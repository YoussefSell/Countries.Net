namespace Countries.NET.Loader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Extensions
    {
        public static string GetName(this Country country)
        {
            var sb = new StringBuilder();
            var keys = new List<string>();

            sb.AppendLine(@$"{{ ""eng"", new CountryName(official: ""{country.Name.Official}"", common: ""{country.Name.Common}"") }},");
            keys.Add("eng");

            if (!(country.Name.NativeName is null))
            {
                foreach (var item in country.Name.NativeName)
                {
                    if (keys.Contains(item.Key))
                        continue;

                    sb.AppendLine(@$"                {{ ""{item.Key}"", new CountryName(official: ""{item.Value.Official}"", common: ""{item.Value.Common}"") }},");
                    keys.Add(item.Key);
                }
            }

            var index = 0;
            foreach (var item in country.Translations)
            {
                if (keys.Contains(item.Key))
                    continue;

                var isLast = index + 1 == country.Translations.Count;

                if (isLast)
                {
                    sb.Append(@$"                {{ ""{item.Key}"", new CountryName(official: ""{item.Value.Official}"", common: ""{item.Value.Common}"") }},");
                }
                else
                {
                    sb.AppendLine(@$"                {{ ""{item.Key}"", new CountryName(official: ""{item.Value.Official}"", common: ""{item.Value.Common}"") }},");
                }

                index++;
                keys.Add(item.Key);
            }

            return sb.ToString();
        }

        public static string GetIddSuffixes(this Country country)
        {
            if (country.Idd is null || country.Idd.Suffixes is null)
                return "";

            var sb = new StringBuilder();

            foreach (var item in country.Idd.Suffixes)
            {
                sb.Append(@$"""{item}"", ");
            }

            return sb.ToString();
        }

        public static string GetBorders(this Country country)
        {
            if (country.Borders is null)
                return "";

            var sb = new StringBuilder();

            foreach (var item in country.Borders)
            {
                sb.Append(@$"""{item}"", ");
            }

            return sb.ToString();
        }

        public static string GetCapitals(this Country country)
        {
            if (country.Capital is null)
                return "";

            var sb = new StringBuilder();

            foreach (var item in country.Capital)
            {
                sb.Append(@$"""{item}"", ");
            }

            return sb.ToString();
        }

        public static string GetAltSpellings(this Country country)
        {
            if (country.AltSpellings is null)
                return "";

            var sb = new StringBuilder();

            foreach (var item in country.AltSpellings)
            {
                sb.Append(@$"""{item}"", ");
            }

            return sb.ToString();
        }

        public static string Gettld(this Country country)
        {
            if (country.Tld is null)
                return "";

            var sb = new StringBuilder();

            foreach (var item in country.Tld)
            {
                sb.Append(@$"""{item}"", ");
            }

            return sb.ToString();
        }
        public static string Getlatlng(this Country country)
        {
            if (country.Latlng is null)
                return "";

            var sb = new StringBuilder();

            foreach (var item in country.Latlng)
            {
                sb.Append(@$"{item}, ");
            }

            return sb.ToString();
        }
        public static string Gettimezones(this Country country)
        {
            if (country.Timezones is null)
                return "";

            var sb = new StringBuilder();

            foreach (var item in country.Timezones)
            {
                sb.Append($@"""{item}"", ");
            }

            return sb.ToString();
        }
        public static string Getlanguages(this Country country, System.Globalization.CultureInfo[] a)
        {
            if (country.Languages is null)
                return "";

            var sb = new StringBuilder();

            var index = 0;
            foreach (var item in country.Languages)
            {
                var isLast = index + 1 == country.Languages.Count;
                var space = index == 0
                    ? ""
                    : "                ";

                var c = a.Where(e => e.ThreeLetterISOLanguageName.Equals(item.Key, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                if (c is null)
                {
                    switch (item.Key)
                    {
                        case "hat":
                            if (isLast)
                            {
                                sb.Append($@"{space}new Language(name: ""{item.Value}"", iso6391: ""ht"", iso6392: ""{item.Key}""),");
                            }
                            else
                            {
                                sb.AppendLine($@"{space}new Language(name: ""{item.Value}"", iso6391: ""ht"", iso6392: ""{item.Key}""),");
                            }
                            break;
                        case "smo":
                            if (isLast)
                            {
                                sb.Append($@"{space}new Language(name: ""{item.Value}"", iso6391: ""sm"", iso6392: ""{item.Key}""),");
                            }
                            else
                            {
                                sb.AppendLine($@"{space}new Language(name: ""{item.Value}"", iso6391: ""sm"", iso6392: ""{item.Key}""),");
                            }
                            break;
                        case "her":
                            if (isLast)
                            {
                                sb.Append($@"{space}new Language(name: ""{item.Value}"", iso6391: ""hz"", iso6392: ""{item.Key}""),");
                            }
                            else
                            {
                                sb.AppendLine($@"{space}new Language(name: ""{item.Value}"", iso6391: ""hz"", iso6392: ""{item.Key}""),");
                            }
                            break;
                        case "ndo":
                            if (isLast)
                            {
                                sb.Append($@"{space}new Language(name: ""{item.Value}"", iso6391: ""ng"", iso6392: ""{item.Key}""),");
                            }
                            else
                            {
                                sb.AppendLine($@"{space}new Language(name: ""{item.Value}"", iso6391: ""ng"", iso6392: ""{item.Key}""),");
                            }
                            break;
                        default:
                            if (isLast)
                            {
                                sb.Append($@"{space}new Language(name: ""{item.Value}"", iso6391: """", iso6392: ""{item.Key}""),");
                            }
                            else
                            {
                                sb.AppendLine($@"{space}new Language(name: ""{item.Value}"", iso6391: """", iso6392: ""{item.Key}""),");
                            }
                            break;
                    }
                }
                else
                {
                    if (isLast)
                    {
                        sb.Append($@"{space}new Language(name: ""{item.Value}"", iso6391: ""{c.TwoLetterISOLanguageName}"", iso6392: ""{item.Key}""),");
                    }
                    else
                    {
                        sb.AppendLine($@"{space}new Language(name: ""{item.Value}"", iso6391: ""{c.TwoLetterISOLanguageName}"", iso6392: ""{item.Key}""),");
                    }
                }

                index++;
            }

            return sb.ToString();
        }
        public static string Getcurrencies(this Country country)
        {
            if (country.Currencies is null)
                return "";

            var sb = new StringBuilder();
            var index = 0;
            foreach (var item in country.Currencies)
            {
                var isLast = index + 1 == country.Currencies.Count;
                var space = index == 0
                       ? ""
                       : "                ";

                if (isLast)
                {
                    sb.Append($@"{space}new Currency(code: ""{item.Key}"", name: ""{item.Value.Name}"", symbol: ""{item.Value.Symbol}""),");
                }
                else
                {
                    sb.AppendLine($@"{space}new Currency(code: ""{item.Key}"", name: ""{item.Value.Name}"", symbol: ""{item.Value.Symbol}""),");
                }

                index++;
            }

            return sb.ToString();
        }
        public static string Getdemonyms(this Country country)
        {
            if (country.Demonyms is null)
                return "";

            var sb = new StringBuilder();

            if (!(country.Demonyms.Eng is null))
            {
                sb.AppendLine($@"{{ ""eng"", new DemonymsGender(male: ""{country.Demonyms.Eng.M}"", female: ""{country.Demonyms.Eng.F}"") }},");
                sb.Append($@"                {{ ""fra"", new DemonymsGender(male: ""{country.Demonyms.Eng.M}"", female: ""{country.Demonyms.Eng.F}"") }},");
            }

            return sb.ToString();
        }
    }
}
