namespace Countries.NET
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// the extension methods for Enumerable
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        /// exclude the given countries from the list of countries
        /// </summary>
        /// <param name="source">the list of countries</param>
        /// <param name="countries">the countries CCA2 codes to exclude</param>
        /// <returns>An <see cref="IEnumerable{Country}"/> that contains a filtered countries sequence.</returns>
        public static IEnumerable<Country> Exclude(this IEnumerable<Country> source, params string[] countries) 
            => source.Where(country => !countries.Contains(country.CCA2));

        public static IEnumerable<Country> Exclude(this IEnumerable<Country> source, params Country[] countries)
            => source.Exclude(countries.Select(country => country.CCA2).ToArray());
    }
}
