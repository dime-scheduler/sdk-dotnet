using System.Reflection.Emit;
using System.Text.Json;
using System.Text.Json.Serialization;
using Dime.Scheduler.Entities;

namespace Dime.Scheduler
{
    public class ImportResult
    {
        public string Content { get; set; }

        public string ContentType { get; set; }
        public int StatusCode { get; set; }

        [JsonIgnore]
        public bool IsSuccess => StatusCode == 200;

        public ImportSet GetSuccessContent() => JsonSerializer.Deserialize<ImportSet>(Content);

        public string GetFailedContent()
        {
            FailedRequestException ex = JsonSerializer.Deserialize<FailedRequestException>(Content);
            return ex.Description;
        }
    }
}