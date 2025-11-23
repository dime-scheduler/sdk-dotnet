namespace Dime.Scheduler.Entities.Builder
{
    /// <summary>
    /// Represents a service.
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Gets or sets the service number.
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// Gets or sets the service serial number.
        /// </summary>
        public string SerialNo { get; set; }
        /// <summary>
        /// Gets or sets the service name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the service group.
        /// </summary>
        public string Group { get; set; }
        /// <summary>
        /// Gets or sets the service class.
        /// </summary>
        public string Class { get; set; }
    }
}