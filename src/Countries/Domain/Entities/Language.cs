namespace Countries.Domain.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// this class defines a language
    /// </summary>
    public partial class Language
    {
        /// <summary>
        /// the 2 chars code of the language
        /// </summary>
        public string ISO6391 { get; }

        /// <summary>
        /// the 3 chars code of the language
        /// </summary>
        public string ISO6392 { get; }

        /// <summary>
        /// name of the language
        /// </summary>
        public string Name { get; }
    }

    /// <summary>
    /// partial part for <see cref="Language"/>
    /// </summary>
    public partial class Language : IEquatable<Language>
    {
        /// <summary>
        /// English language, the default Language
        /// </summary>
        public static Language Default => English;

        /// <summary>
        /// empty language with all props empty
        /// </summary>
        public static Language Empty = new Language("", "", "");

        /// <summary>
        /// English language, the default Language
        /// </summary>
        public static readonly Language English = new Language("English", "en", "eng");

        /// <summary>
        /// the Arabic Language
        /// </summary>
        public static readonly Language Arabic = new Language("Arabic", "ar", "ara");

        /// <summary>
        /// the Arabic Language
        /// </summary>
        public static readonly Language French = new Language("French", "fr", "fra");

        /// <summary>
        /// the Arabic Language
        /// </summary>
        public static readonly Language Spanish = new Language("Spanish", "es", "spa");

        /// <summary>
        /// create an instant of <see cref="Language"/>
        /// </summary>
        /// <param name="name">the name of the language</param>
        /// <param name="iso6391">the 2 chars code of the language</param>
        /// <param name="iso6392">the 3 chars code of the language</param>
        public Language(string name, string iso6391, string iso6392)
        {
            ISO6391 = iso6391 ?? "";
            ISO6392 = iso6392 ?? "";
            Name = name ?? "";
        }

        #region overrides

        /// <summary>
        /// return the string representation of the object
        /// </summary>
        /// <returns>the string value of the object</returns>
        public override string ToString()
            => $"{Name} ({ISO6391} | {ISO6392})";

        /// <summary>
        /// check if the given object is equals to the current instant
        /// </summary>
        /// <param name="obj">the object to check the equality for it</param>
        /// <returns>true if equals, false if not</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is Language language && Equals(language);
        }

        /// <summary>
        /// check if the given instant equals this instant,
        /// the two instant are equals if all properties are equals
        /// </summary>
        /// <param name="other">the entity to check the equality for it</param>
        /// <returns>true if equals, false if not</returns>
        public bool Equals(Language other)
            => !(other is null) &&
                ISO6391.Equals(other.ISO6391, StringComparison.OrdinalIgnoreCase) &&
                ISO6392.Equals(other.ISO6392, StringComparison.OrdinalIgnoreCase) &&
                Name.Equals(other.Name, StringComparison.OrdinalIgnoreCase);

        /// <summary>
        /// get the has code of the current instant
        /// </summary>
        /// <returns>the has code</returns>
        public override int GetHashCode() 
            => Name.GetHashCode() + ISO6391.GetHashCode() + ISO6392.GetHashCode();

        /// <summary>
        /// check the equality of the two instants using the "==" operator
        /// </summary>
        /// <param name="left">the left side object</param>
        /// <param name="right">the right side object</param>
        /// <returns>true if they are equals, false if not</returns>
        public static bool operator ==(Language left, Language right)
            => EqualityComparer<Language>.Default.Equals(left, right);

        /// <summary>
        /// check the non equality of the two instants using the "!=" operator
        /// </summary>
        /// <param name="left">the left side object</param>
        /// <param name="right">the right side object</param>
        /// <returns>true if they are not equal, false if they are</returns>
        public static bool operator !=(Language left, Language right)
            => !(left == right);

        #endregion
    }
}
