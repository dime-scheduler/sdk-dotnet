using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Dime.Scheduler.Entities
{
    [ExcludeFromCodeCoverage]
    public class Message
    {
        /// <summary>
        /// the message text.
        /// </summary>
        [Description("The message text.")]
        public string Text { get; set; }

        /// <summary>
        /// the user name.
        /// </summary>
        [Description("The user name.")]
        public string User { get; set; }

        /// <summary>
        /// the severity level of the message.
        /// </summary>
        [Description("The severity level of the message.")]
        public Severity Severity { get; set; }
    };
}