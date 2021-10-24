namespace Countries.Loader
{
    using Newtonsoft.Json;
    using RestSharp;
    using System;
    using System.IO;

    /// <summary>
    /// Utility 
    /// </summary>
    public static class Utility
    {
        public static string GetOutDirectory()
        {
            var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Data");
            Directory.CreateDirectory(folder);
            return folder;
        }

        public static Country[] LoadDataFromRestCountries()
        {
            var client = new RestClient("https://restcountries.com/v3.1");
            var response = client.Get(new RestRequest("all", DataFormat.Json));
            return JsonConvert.DeserializeObject<Country[]>(response.Content);
        }
    }
}
