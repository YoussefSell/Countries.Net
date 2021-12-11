namespace Countries.NET
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// this class defines the country name
    /// </summary>
    public partial class CountryName : IEquatable<CountryName>, IEquatable<string>
    {
        /// <summary>
        /// the official name of the country
        /// </summary>
        public string Official { get; }

        /// <summary>
        /// the common name of the country
        /// </summary>
        public string Common { get; }
    }

    /// <summary>
    /// partial part for <see cref="CountryName"/>
    /// </summary>
    public partial class CountryName
    {
        /// <summary>
        /// create an instance of <see cref="CountryName"/>
        /// </summary>
        /// <param name="official">the official name of the country</param>
        /// <param name="common">the common name of the country</param>
        public CountryName(string official, string common)
        {
            Official = official ?? throw new ArgumentNullException(nameof(official));
            Common = common ?? throw new ArgumentNullException(nameof(common));
        }

        /// <summary>
        /// return the string representation of the object
        /// </summary>
        /// <returns>the string value of the object</returns>
        public override string ToString()
            => $"{Official} | {Common}";

        /// <summary>
        /// check if the given object is equals to the current instant
        /// </summary>
        /// <param name="obj">the object to check the equality for it</param>
        /// <returns>true if equals, false if not</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj is CountryName CountryName) return Equals(CountryName);
            if (obj is string name) return Equals(name);
            return false;
        }

        /// <summary>
        /// check if the given instant equals this instant,
        /// the two instant are equals if all properties are equals
        /// </summary>
        /// <param name="other">the entity to check the equality for it</param>
        /// <returns>true if equals, false if not</returns>
        public bool Equals(CountryName other)
            => !(other is null) &&
                Official.Equals(other.Official, StringComparison.OrdinalIgnoreCase) &&
                Common.Equals(other.Common, StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// check if the given instant equals this instant,
        /// the two instant are equals if all properties are equals
        /// </summary>
        /// <param name="name">the entity to check the equality for it</param>
        /// <returns>true if equals, false if not</returns>
        public bool Equals(string name) => Equals(name, true);

        /// <summary>
        /// check if the given instant equals this instant,
        /// the two instant are equals if all properties are equals
        /// </summary>
        /// <param name="name">the entity to check the equality for it</param>
        /// <param name="ignoreCase">ignore case when performing the check</param>
        /// <returns>true if equals, false if not</returns>
        public bool Equals(string name, bool ignoreCase)
        {
            // if null return false
            if (name is null) return false;

            // check if should ignore case
            if (ignoreCase)
            {
                var lowerCaseName = name.ToLower();

                return Common.ToLower().Contains(lowerCaseName)
                || Official.ToLower().Contains(lowerCaseName);
            }

            return Common.Contains(name)
                || Official.Contains(name);
        }

        /// <summary>
        /// get the has code of the current instant
        /// </summary>
        /// <returns>the has code</returns>
        public override int GetHashCode()
            => Official.GetHashCode() + Common.GetHashCode();

        /// <summary>
        /// check the equality of the two instants using the "==" operator
        /// </summary>
        /// <param name="left">the left side object</param>
        /// <param name="right">the right side object</param>
        /// <returns>true if they are equals, false if not</returns>
        public static bool operator ==(CountryName left, CountryName right)
            => EqualityComparer<CountryName>.Default.Equals(left, right);

        /// <summary>
        /// check the non equality of the two instants using the "!=" operator
        /// </summary>
        /// <param name="left">the left side object</param>
        /// <param name="right">the right side object</param>
        /// <returns>true if they are not equal, false if they are</returns>
        public static bool operator !=(CountryName left, CountryName right)
            => !(left == right);
    }
}
