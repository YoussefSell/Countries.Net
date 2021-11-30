namespace Countries.NET.Loader
{
    using System.Globalization;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            var outDirectory = Utility.GetOutDirectory();
            var cultures = CultureInfo.GetCultures(CultureTypes.AllCultures);

            foreach (var country in Utility.LoadDataFromRestCountries().OrderBy(e => e.Name.Official))
            {
                var countryName = country.Name.Common.Replace(" ", "");
                File.WriteAllText(Path.Combine(outDirectory, $"{countryName}.cs"), CountryClassTemplate.Load(country, countryName, cultures));
            }
        }
    }
}


