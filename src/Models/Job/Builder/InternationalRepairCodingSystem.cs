namespace Dime.Scheduler.Entities.Builder
{
    /// <summary>
    /// Represents the International Repair Coding System (IRIS) information.
    /// </summary>
    public class InternationalRepairCodingSystem
    {
        /// <summary>
        /// The IRIS fault code.
        /// </summary>
        public string Fault { get; set; }
        /// <summary>
        /// The IRIS symptom code.
        /// </summary>
        public string Symptom { get; set; }
        /// <summary>
        /// The IRIS area code.
        /// </summary>
        public string Area { get; set; }
        /// <summary>
        /// The IRIS reason code.
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// The IRIS resolution code.
        /// </summary>
        public string Resolution { get; set; }
    }
}