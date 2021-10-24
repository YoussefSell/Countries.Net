namespace Countries.Domain.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// International Direct Dialing info (IDD)
    /// </summary>
    public partial class InternationalDirectDialingInfo
    {
        /// <summary>
        /// create an instance of <see cref="InternationalDirectDialingInfo"/>
        /// </summary>
        /// <param name="root">the root geographical code prefix. e.g. +6 for New Zealand, +4 for UK.</param>
        /// <param name="suffixes">list of all suffixes assigned to this country. 4 for NZ, 809, 829, and 849 for Dominican Republic.</param>
        public InternationalDirectDialingInfo(string root, params string[] suffixes)
        {
            Root = root ?? throw new ArgumentNullException(nameof(root));
            Suffixes = suffixes ?? throw new ArgumentNullException(nameof(suffixes));
        }

        /// <summary>
        /// the root geographical code prefix. e.g. +6 for New Zealand, +4 for UK.
        /// </summary>
        public string Root { get; }

        /// <summary>
        /// list of all suffixes assigned to this country. 4 for NZ, 809, 829, and 849 for Dominican Republic.
        /// </summary>
        public IEnumerable<string> Suffixes { get; }
    }
}
