namespace Microsoft.Extensions.DependencyInjection
{
    using Countries;
    using System;

    /// <summary>
    /// the Configurations class
    /// </summary>
    public static class Configurations
    {
        /// <summary>
        /// add the countries configuration.
        /// </summary>
        /// <param name="serviceCollection">the service collection instant</param>
        /// <param name="config">the service collection instant</param>
        public static IServiceCollection AddCountries(this IServiceCollection serviceCollection, Action<CountriesConfiguration> config)
        {
            if (config is null)
                throw new ArgumentNullException(nameof(config));

            // load an apply the configuration
            var configuration = new CountriesConfiguration();
            config(configuration);
            configuration.Apply();

            // register the countries service
            return AddCountries(serviceCollection);
        }

        /// <summary>
        /// add the countries configuration.
        /// </summary>
        /// <param name="serviceCollection">the service collection instant</param>
        public static IServiceCollection AddCountries(this IServiceCollection serviceCollection)
        {
            // register the countries service
            return serviceCollection.AddSingleton<ICountriesService, CountriesService>();
        }
    }
}
