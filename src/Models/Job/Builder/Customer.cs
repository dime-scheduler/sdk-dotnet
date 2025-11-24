namespace Dime.Scheduler.Entities.Builder
{
    /// <summary>
    /// Represents a customer.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// The customer number.
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// The customer name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The customer address.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// The customer phone number.
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// The customer email address.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// The customer reference.
        /// </summary>
        public string Reference { get; set; }
    }
}