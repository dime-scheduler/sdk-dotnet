using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Entities.Exchange
{
    public enum ShowAs
    {
        [Description("Free")]
        [Display(Name = "Free")]
        Free = 1,

        [Description("Tentative")]
        [Display(Name = "Tentative")]
        Tentative = 2,

        [Description("Office")]
        [Display(Name = "Office")]
        Office = 3,

        [Description("Out of office")]
        [Display(Name = "Out of office")]
        OutOfOffice = 4,

        [Description("Working elsewhere")]
        [Display(Name = "Working elsewhere")]
        WorkingElsewhere = 5,

        [Description("Unknown")]
        [Display(Name = "Unknown")]
        Unknown = 6
    }
}