namespace Dime.Scheduler.Entities.Builder
{
    /// <summary>
    /// Represents a site.
    /// </summary>
    public class Site
    {
        /// <summary>
        /// Gets or sets the site number.
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// Gets or sets the site name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the site phone number.
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Gets or sets the site email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the site address.
        /// </summary>
        public Address Address { get; set; }
    }
}