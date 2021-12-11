namespace Countries.NET.Test
{
    using System.Linq;
    using Countries.NET;
    using Countries.NET.Enums;
    using Xunit;

    public class CountriesServiceShould
    {
        public CountriesServiceShould()
        {
            WorldCountriesConfiguration.Reset();
        }

        [Fact]
        public void GetListOfAllCountries()
        {
            // arrange
            var service = new CountriesService();
            var expectedCount = 249;

            // act
            var all = service.GetAll();

            // assert
            Assert.Equal(expectedCount, all.Count());
        }

        [Theory]
        [InlineData("MA", "Kingdom of Morocco")]
        [InlineData("MAR", "Kingdom of Morocco")]
        [InlineData("504", "Kingdom of Morocco")]
        public void FindCountryByCode(string code, string expected)
        {
            // arrange
            var service = new CountriesService();

            // act
            var country = service.FindByCode(code);

            // assert
            Assert.Equal(expected, country.Name);
        }

        [Fact]
        public void FindCountryByCodeReturnNullIfNotExist()
        {
            // arrange
            var service = new CountriesService();
            var code = "not-exist";

            // act
            var country = service.FindByCode(code);

            // assert
            Assert.Null(country);
        }

        [Theory]
        [InlineData("Kingdom of Morocco", "MA")]
        [InlineData("مراکش", "MA")]
        [InlineData("モロッコ", "MA")]
        public void FindCountryByName(string name, string expected)
        {
            // arrange
            var service = new CountriesService();

            // act
            var country = service.FindByName(name);

            // assert
            Assert.Equal(expected, country.CCA2);
        }

        [Fact]
        public void FindCountryByNameReturnNullIfNotExist()
        {
            // arrange
            var service = new CountriesService();
            var name = "not-exist";

            // act
            var country = service.FindByName(name);

            // assert
            Assert.Null(country);
        }

        [Theory]
        [InlineData("Kingdom of Morocco", "eng", "MA")]
        [InlineData("مراکش", "urd", "MA")]
        [InlineData("モロッコ", "jpn", "MA")]
        public void FindCountryByNameAndLanguage(string name, string language, string expected)
        {
            // arrange
            var service = new CountriesService();

            // act
            var country = service.FindByName(name, language);

            // assert
            Assert.Equal(expected, country.CCA2);
        }

        [Fact]
        public void FindCountryByNameAndLanguageReturnNullIfNotExist()
        {
            // arrange
            var service = new CountriesService();
            var name = "not-exist";
            var language = "eng"; 

            // act
            var country = service.FindByName(name, language);

            // assert
            Assert.Null(country);
        }

        [Theory]
        [InlineData(Region.Africa, 58)]
        [InlineData(Region.Americas, 56)]
        [InlineData(Region.Antarctic, 5)]
        [InlineData(Region.Asia, 50)]
        [InlineData(Region.Europe, 53)]
        [InlineData(Region.Oceania, 27)]
        public void FindCountryByRegion(Region region, int expectedCount)
        {
            // arrange
            var service = new CountriesService();

            // act
            var countries = service.FindByRegion(region);

            // assert
            Assert.Equal(expectedCount, countries.Count());
        }

        [Theory]
        [InlineData("ara", 25)]
        [InlineData("fra", 46)]
        public void FindCountryByLanguage(string language, int expectedCount)
        {
            // arrange
            var service = new CountriesService();

            // act
            var countries = service.FindByLanguage(language);

            // assert
            Assert.Equal(expectedCount, countries.Count());
        }

        [Theory]
        [InlineData("CAD", 1)]
        [InlineData("USD", 20)]
        public void FindCountryByCurrencies(string currency, int expectedCount)
        {
            // arrange
            var service = new CountriesService();

            // act
            var countries = service.FindByCurrency(currency).ToArray();

            // assert
            Assert.Equal(expectedCount, countries.Length);
        }
    }
}
