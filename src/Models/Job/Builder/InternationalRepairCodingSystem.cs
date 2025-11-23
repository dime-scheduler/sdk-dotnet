namespace Dime.Scheduler.Entities.Builder
{
    /// <summary>
    /// Represents the International Repair Coding System (IRIS) information.
    /// </summary>
    public class InternationalRepairCodingSystem
    {
        /// <summary>
        /// Gets or sets the IRIS fault code.
        /// </summary>
        public string Fault { get; set; }
        /// <summary>
        /// Gets or sets the IRIS symptom code.
        /// </summary>
        public string Symptom { get; set; }
        /// <summary>
        /// Gets or sets the IRIS area code.
        /// </summary>
        public string Area { get; set; }
        /// <summary>
        /// Gets or sets the IRIS reason code.
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// Gets or sets the IRIS resolution code.
        /// </summary>
        public string Resolution { get; set; }
    }
}