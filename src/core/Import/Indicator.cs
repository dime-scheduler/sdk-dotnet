using System.ComponentModel.DataAnnotations;

namespace Dime.Scheduler.Sdk.Import
{
    public abstract class Indicator
    {
        [Required]
        public string Name { get; set; }

        public string Color { get; set; }
    }
}