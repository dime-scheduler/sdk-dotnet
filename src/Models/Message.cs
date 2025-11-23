using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler.Entities
{
    [ExcludeFromCodeCoverage]
    public class Message
    {
        /// <summary>
        /// Gets or sets the message text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string User { get; set; }

        /// <summary>
        /// Gets or sets the severity level of the message.
        /// </summary>
        public Severity Severity { get; set; }
    };
}