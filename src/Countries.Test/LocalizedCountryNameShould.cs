namespace Countries.Test
{
    using Countries.Domain.Exceptions;
    using System;
    using System.Globalization;
    using Xunit;

    public class LocalizedCountryNameShould
    {
        [Fact]
        public void GetOfficialNameByLanguage()
        {
            // arrange
            WorldCountriesConfiguration.Reset();
            var country = Data.Morocco.Instance;
            var language = "fra";
            var expectedName = "Royaume du Maroc";

            // act
            var name = country.Name.GetName(language);

            // assert
            Assert.Equal(expectedName, name);
        }

        [Fact]
        public void GetOfficialNameByDefaultLanguage()
        {
            // arrange
            WorldCountriesConfiguration.Reset();
            WorldCountriesConfiguration.DefaultLanguage = "fra";
            var country = Data.Morocco.Instance;
            var expectedName = "Royaume du Maroc";

            // act
            var name = country.Name.GetName();

            // assert
            Assert.Equal(expectedName, name);
        }

        [Fact]
        public void GetOfficialNameByCurrentCullture()
        {
            // arrange
            WorldCountriesConfiguration.Reset();
            WorldCountriesConfiguration.UseCurrentCultureInfoForCountryName = true;
            var country = Data.Morocco.Instance;
            var expectedName = "Royaume du Maroc";
            CultureInfo.CurrentCulture = new CultureInfo("fr");

            // act
            var name = country.Name.GetName();

            // assert
            Assert.Equal(expectedName, name);
        }

        [Fact]
        public void GetCommonNameByLanguage()
        {
            // arrange
            WorldCountriesConfiguration.Reset();
            WorldCountriesConfiguration.UserOfficialNameWhenRetrievingCountryName = false;
            var country = Data.Morocco.Instance;
            var language = "fra";
            var expectedName = "Maroc";

            // act
            var name = country.Name.GetName(language);

            // assert
            Assert.Equal(expectedName, name);
        }

        [Fact]
        public void GetCommonNameByDefaultLanguage()
        {
            // arrange
            WorldCountriesConfiguration.Reset();
            WorldCountriesConfiguration.DefaultLanguage = "fra";
            WorldCountriesConfiguration.UserOfficialNameWhenRetrievingCountryName = false;
            var country = Data.Morocco.Instance;
            var expectedName = "Maroc";

            // act
            var name = country.Name.GetName();

            // assert
            Assert.Equal(expectedName, name);
        }

        [Fact]
        public void GetCommonNameByCurrentCullture()
        {
            // arrange
            WorldCountriesConfiguration.Reset();
            WorldCountriesConfiguration.UseCurrentCultureInfoForCountryName = true;
            WorldCountriesConfiguration.UserOfficialNameWhenRetrievingCountryName = false;
            var country = Data.Morocco.Instance;
            var expectedName = "Maroc";
            CultureInfo.CurrentCulture = new CultureInfo("fr");

            // act
            var name = country.Name.GetName();

            // assert
            Assert.Equal(expectedName, name);
        }

        [Fact]
        public void ReturnNullIfNoLanguageIsFound()
        {
            // arrange
            WorldCountriesConfiguration.Reset();
            WorldCountriesConfiguration.ThrowIfNameNotFoundForALanguage = false;
            var country = Data.Morocco.Instance;
            var language = "aaa"; // not exist

            // act
            var name = country.Name.GetName(language);

            // assert
            Assert.Null(name);
        }

        [Fact]
        public void ThrowIfNoLanguageIsFound()
        {
            // arrange
            WorldCountriesConfiguration.Reset();
            var country = Data.Morocco.Instance;
            var language = "aaa"; // not exist

            // assert
            Assert.Throws<TranslationNotFoundExceptionsException>(() =>
            {
                // act
                var name = country.Name.GetName(language);
            });
        }

        [Fact]
        public void ThrowIfLanguageCodeIsNull()
        {
            // arrange
            WorldCountriesConfiguration.Reset();
            var country = Data.Morocco.Instance;
            string language = null;

            // assert
            Assert.Throws<ArgumentNullException>(() =>
            {
                // act
                var name = country.Name.GetName(language);
            });
        }

        [Fact]
        public void ThrowIfLanguageCodeIsEmpty()
        {
            // arrange
            WorldCountriesConfiguration.Reset();
            var country = Data.Morocco.Instance;
            string language = "";

            // assert
            Assert.Throws<ArgumentException>(() =>
            {
                // act
                var name = country.Name.GetName(language);
            });
        }

        [Fact]
        public void ThrowIfLanguageCodeIsNotValid3CharsCode()
        {
            // arrange
            WorldCountriesConfiguration.Reset();
            var country = Data.Morocco.Instance;
            string language = "ee";

            // assert
            Assert.Throws<ArgumentException>(() =>
            {
                // act
                var name = country.Name.GetName(language);
            });
        }

        [Fact]
        public void ReturnTrueForNameEqualityByLanguage()
        {
            // arrange
            WorldCountriesConfiguration.Reset();
            var country = Data.Morocco.Instance;
            var language = "fra";
            var nameToCheck = "Maroc";

            // act
            var equals = country.Name.Equals(nameToCheck, language);

            // assert
            Assert.True(equals);
        }

        [Fact]
        public void ReturnTrueForNameEqualityByLanguageCaseSensitive()
        {
            // arrange
            WorldCountriesConfiguration.Reset();
            WorldCountriesConfiguration.IgnoreCaseOnNameEqualityCheck = false;
            var country = Data.Morocco.Instance;
            var language = "fra";
            var nameToCheck = "maroc";

            // act
            var equals = country.Name.Equals(nameToCheck, language);

            // assert
            Assert.False(equals);
        }

        [Fact]
        public void ReturnTrueForNameEquality()
        {
            // arrange
            WorldCountriesConfiguration.Reset();
            var country = Data.Morocco.Instance;
            var nameToCheck = "Maroc";

            // act
            var equals = country.Name.Equals(nameToCheck);

            // assert
            Assert.True(equals);
        }

        [Fact]
        public void ReturnTrueForNameEqualityByCaseSensitive()
        {
            // arrange
            WorldCountriesConfiguration.Reset();
            WorldCountriesConfiguration.IgnoreCaseOnNameEqualityCheck = false;
            var country = Data.Morocco.Instance;
            var nameToCheck = "maroc";

            // act
            var equals = country.Name.Equals(nameToCheck);

            // assert
            Assert.False(equals);
        }


        [Fact]
        public void ReturnFalseForNameEqualityByCaseSensitive()
        {
            // arrange
            WorldCountriesConfiguration.Reset();
            var country = Data.Morocco.Instance;
            var nameToCheck = "maroc1"; // not exist

            // act
            var equals = country.Name.Equals(nameToCheck);

            // assert
            Assert.False(equals);
        }
    }
}
