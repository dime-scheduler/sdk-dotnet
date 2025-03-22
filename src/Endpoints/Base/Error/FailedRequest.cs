using System.Net;
using System.Text.Json.Serialization;

namespace Dime.Scheduler
{
    internal class FailedRequest
    {
        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("statusCode")]
        public HttpStatusCode StatusCode { get; set; }
    }
}