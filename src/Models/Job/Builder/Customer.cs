namespace Dime.Scheduler.Entities.Builder
{
    /// <summary>
    /// Represents a customer.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets or sets the customer number.
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// Gets or sets the customer name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the customer address.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Gets or sets the customer phone number.
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Gets or sets the customer email address.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Gets or sets the customer reference.
        /// </summary>
        public string Reference { get; set; }
    }
}