namespace Countries.Domain.Entities
{
    using System;

    /// <summary>
    /// Demonyms gender definition
    /// </summary>
    public class DemonymsGender
    {
        /// <summary>
        /// create an instance of <see cref="DemonymsGender"/>
        /// </summary>
        /// <param name="male">male</param>
        /// <param name="female">female</param>
        public DemonymsGender(string male, string female)
        {
            Male = male ?? throw new ArgumentNullException(nameof(male));
            Female = female ?? throw new ArgumentNullException(nameof(female));
        }

        /// <summary>
        /// male
        /// </summary>
        public string Male { get; }

        /// <summary>
        /// female
        /// </summary>
        public string Female { get; }
    }
}
