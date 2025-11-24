namespace Dime.Scheduler.Entities.Builder
{
    /// <summary>
    /// Represents a site.
    /// </summary>
    public class Site
    {
        /// <summary>
        /// The site number.
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// The site name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The site phone number.
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// The site email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The site address.
        /// </summary>
        public Address Address { get; set; }
    }
}