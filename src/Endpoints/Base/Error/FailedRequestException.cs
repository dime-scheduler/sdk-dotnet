using System.Text.Json.Serialization;

namespace Dime.Scheduler
{
    internal class FailedRequestException
    {
        [JsonPropertyName("Error")]
        public string Error { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }
    }
}