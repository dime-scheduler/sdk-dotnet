namespace Dime.Scheduler.Entities.Builder
{
    /// <summary>
    /// Represents a service.
    /// </summary>
    public class Service
    {
        /// <summary>
        /// The service number.
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// The service serial number.
        /// </summary>
        public string SerialNo { get; set; }
        /// <summary>
        /// The service name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The service group.
        /// </summary>
        public string Group { get; set; }
        /// <summary>
        /// The service class.
        /// </summary>
        public string Class { get; set; }
    }
}