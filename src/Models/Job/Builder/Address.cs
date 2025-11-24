namespace Dime.Scheduler.Entities.Builder
{
    /// <summary>
    /// Represents an address.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// The full address.
        /// </summary>
        public string FullAddress { get; set; }
        /// <summary>
        /// The region.
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// The street name.
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// The street number.
        /// </summary>
        public string StreetNo { get; set; }
        /// <summary>
        /// The postcode.
        /// </summary>
        public string Postcode { get; set; }
        /// <summary>
        /// The city.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// The county.
        /// </summary>
        public string County { get; set; }
        /// <summary>
        /// The country.
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// The state.
        /// </summary>
        public string State { get; set; }
    }
}