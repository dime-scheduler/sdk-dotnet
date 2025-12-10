using System.ComponentModel;

namespace Dime.Scheduler.Entities
{
    /// <summary>
    /// Represents the HTTP request type.
    /// </summary>
    public enum HttpRequestType
    {
        /// <summary>
        /// GET request.
        /// </summary>        
        [Description("GET request.")]
        Get = 1,
        /// <summary>
        /// POST request.
        /// </summary>
        [Description("POST request.")]
        Post = 2
    }
}