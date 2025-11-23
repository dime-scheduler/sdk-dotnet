using System;

namespace Dime.Scheduler.Entities.Builder
{
    /// <summary>
    /// Represents a contract.
    /// </summary>
    public class Contract
    {
        /// <summary>
        /// Gets or sets the contract number.
        /// </summary>
        public string No { get; set; }
        /// <summary>
        /// Gets or sets the contract type.
        /// </summary>
        public string Type { get; set; }
        /// <include file='docs.xml' path='docs/members[@name="Common"]/Description/*'/>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the contract start date.
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Gets or sets the contract end date.
        /// </summary>
        public DateTime? EndDate { get; set; }
    }
}