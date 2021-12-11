var table = new ConsoleTable("Official name", "Common name", "CCA2", "CCA3", "Region");
var countriesService = new CountriesService();

foreach (var country in countriesService.GetAll())
{
    table.AddRow(
        country.Name.GetName("eng", true),
        country.Name.GetName("eng", false),
        country.CCA2,
        country.CCA3,
        country.Region
    );
}

table.Write(Format.MarkDown);