using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities.Exchange
{
    /// <summary>
    /// Represents how an Exchange appointment should be displayed.
    /// </summary>
    public enum ShowAs
    {
        /// <summary>
        /// Show as free.
        /// </summary>
        [Description("Free")]
        [Display(Name = "Free")]
        Free = 1,

        /// <summary>
        /// Show as tentative.
        /// </summary>
        [Description("Tentative")]
        [Display(Name = "Tentative")]
        Tentative = 2,

        /// <summary>
        /// Show as in office.
        /// </summary>
        [Description("Office")]
        [Display(Name = "Office")]
        Office = 3,

        /// <summary>
        /// Show as out of office.
        /// </summary>
        [Description("Out of office")]
        [Display(Name = "Out of office")]
        OutOfOffice = 4,

        /// <summary>
        /// Show as working elsewhere.
        /// </summary>
        [Description("Working elsewhere")]
        [Display(Name = "Working elsewhere")]
        WorkingElsewhere = 5,

        /// <summary>
        /// Show as unknown.
        /// </summary>
        [Description("Unknown")]
        [Display(Name = "Unknown")]
        Unknown = 6
    }
}