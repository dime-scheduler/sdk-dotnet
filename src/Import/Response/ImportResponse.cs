using System.Text.Json;
using System.Text.Json.Serialization;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    public class ImportResponse
    {
        public string Content { get; set; }

        public string ContentType { get; set; }

        public int StatusCode { get; set; }

        [JsonIgnore]
        internal bool IsSuccess => StatusCode == 200;

        internal ImportSet GetSuccessContent() => JsonSerializer.Deserialize<ImportSet>(Content);

        internal string GetFailedContent()
        {
            FailedRequestException ex = JsonSerializer.Deserialize<FailedRequestException>(Content);
            return ex.Description;
        }
    }
}