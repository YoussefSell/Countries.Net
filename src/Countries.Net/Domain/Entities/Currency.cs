namespace Countries.NET
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// a class that represent a currency
    /// </summary>
    public partial class Currency
    {
        /// <summary>
        /// the code of the currency
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// name of the currency
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// the symbol
        /// </summary>
        public string Symbol { get; }
    }

    /// <summary>
    /// partial part for <see cref="Currency"/>
    /// </summary>
    public partial class Currency : IEquatable<Currency>
    {
        /// <summary>
        /// create an instant of <see cref="Currency"/>
        /// </summary>
        /// <param name="code">the code of the currency</param>
        /// <param name="name">the name of the currency</param>
        /// <param name="symbol">the symbol of the currency</param>
        public Currency(string code, string name, string symbol)
        {
            Code = code;
            Name = name;
            Symbol = symbol;
        }

        #region Overrides

        /// <summary>
        /// return the string representation of the object
        /// </summary>
        /// <returns>the string value of the object</returns>
        public override string ToString() => $"{Code} - {Name} - {Symbol}";

        /// <summary>
        /// check if the given object is equals to the current instant
        /// </summary>
        /// <param name="obj">the object to check the equality for it</param>
        /// <returns>true if equals, false if not</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is Currency currency && Equals(currency);
        }

        /// <summary>
        /// check if the given instant equals this instant, the two instant are equals
        /// if they have the same ID and Reason
        /// </summary>
        /// <param name="other">the entity to check the equality for it</param>
        /// <returns>true if equals, false if not</returns>
        public bool Equals(Currency other)
            => !(other is null) &&
                (Code ?? "").Equals(other.Code, StringComparison.OrdinalIgnoreCase) &&
                (Name ?? "").Equals(other.Name, StringComparison.OrdinalIgnoreCase) &&
                (Symbol ?? "").Equals(other.Symbol, StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// get the hash code of the current instant
        /// </summary>
        /// <returns>the hashCode</returns>
        public override int GetHashCode() => Code.GetHashCode();

        /// <summary>
        /// check the equality of the two instants using the "==" operator
        /// </summary>
        /// <param name="left">the left side object</param>
        /// <param name="right">the right side object</param>
        /// <returns>true if they are equals, false if not</returns>
        public static bool operator ==(Currency left, Currency right)
            => EqualityComparer<Currency>.Default.Equals(left, right);

        /// <summary>
        /// check the non equality of the two instants using the "!=" operator
        /// </summary>
        /// <param name="left">the left side object</param>
        /// <param name="right">the right side object</param>
        /// <returns>true if they are not equal, false if they are</returns>
        public static bool operator !=(Currency left, Currency right)
            => !(left == right);

        #endregion
    }
}
