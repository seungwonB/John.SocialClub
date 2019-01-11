// -----------------------------------------------------------------------
// <copyright file="Occupation.cs" company="John">
// Socia Member club Demo ©2013
// </copyright>
// -----------------------------------------------------------------------

namespace John.SocialClub.Data.Enum
{
    using System.ComponentModel;

    /// <summary>
    /// Enumerator for occupation
    /// </summary>
    public enum Occupation
    {
        /// <summary>
        /// Occupation - Doctor
        /// </summary>
        [Description("Doctor")]
        Doctor = 1,

        /// <summary>
        /// Occupation - Engineer
        /// </summary>
        [Description("Engineer")]
        Engineer =2,

        /// <summary>
        /// Occupation - Professor
        /// </summary>
        [Description("Professor")]
        Professor = 3
    }
}
