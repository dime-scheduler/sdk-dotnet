namespace Dime.Scheduler.Entities.Builder
{
    /// <summary>
    /// Represents an address.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the full address.
        /// </summary>
        public string FullAddress { get; set; }
        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        public string Region { get; set; }
        /// <summary>
        /// Gets or sets the street name.
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// Gets or sets the street number.
        /// </summary>
        public string StreetNo { get; set; }
        /// <summary>
        /// Gets or sets the postcode.
        /// </summary>
        public string Postcode { get; set; }
        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        public string County { get; set; }
        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        public string Country { get; set; }
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public string State { get; set; }
    }
}