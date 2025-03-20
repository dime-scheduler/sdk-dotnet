using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class CaptionTests
    {
        [Fact]
        public async System.Threading.Tasks.Task Captions()
        {
            Caption model = new()
            {
                Context = 1,
                FieldName = "FIELD",
                Language = "LANG",
                SourceTable = "TABLE",
                Text = "TXT"
            };
        }
    }
}