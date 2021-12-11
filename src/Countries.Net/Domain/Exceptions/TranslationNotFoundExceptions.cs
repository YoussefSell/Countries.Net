namespace Countries.NET.Exceptions
{
    using System;

    /// <summary>
    /// Exceptions thrown when no Translation has been Found for a country name for a given language
    /// </summary>
    [Serializable]
    public class TranslationNotFoundExceptionsException : Exception
    {
        private static readonly string _message = "couldn't locate a country name for the language: {lang}";
        private static readonly string _messageWithCountry = "couldn't locate a name for the language: {lang}, country: {country}";

        /// <summary>
        /// create an instance of <see cref="TranslationNotFoundExceptionsException"/>
        /// </summary>
        /// <param name="language">the language code</param>
        public TranslationNotFoundExceptionsException(string language) 
            : base(_message.Replace("{lang}", language)) { }

        /// <summary>
        /// create an instance of <see cref="TranslationNotFoundExceptionsException"/>
        /// </summary>
        /// <param name="language">the language code</param>
        /// <param name="country">the country</param>
        public TranslationNotFoundExceptionsException(string language, string country)
            : base(_messageWithCountry.Replace("{lang}", language).Replace("{country}", country)) { }

        /// <inheritdoc/>
        protected TranslationNotFoundExceptionsException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
