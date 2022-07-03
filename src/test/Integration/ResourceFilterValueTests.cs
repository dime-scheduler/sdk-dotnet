using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class ResourceFilterValueTests
    {
        [Fact]
        public async t.Task ResourceFilterValue_Append_ShouldCreateAppointment()
        {          
            // Ensure resource exists
            ImportRequest resourceBaseRequest = ResourceTests.Test.ToImportRequest(TransactionType.Append);
            await DimeScheduler.DoImportRequest(resourceBaseRequest);

            // Ensure filter group and value exist
            FilterGroup filterGroup = new() { Name = "Certifications" };
            ImportRequest fgRequest = filterGroup.ToImportRequest(TransactionType.Append);
            await DimeScheduler.DoImportRequest(fgRequest);

            FilterValue filterValue = new() { Group = "Certifications", Value = "Forklift level A" };
            ImportRequest fvRequest = filterValue.ToImportRequest(TransactionType.Append);
            await DimeScheduler.DoImportRequest(fvRequest);

            ResourceFilterValue resourceFilterValue = new()
            {
                SourceApp = "POWERAPPS",
                SourceType = "POWERAPPS",
                ResourceNo = ResourceTests.Test.ResourceNo,
                FilterGroup = filterGroup.Name,
                FilterValue = filterValue.Value
            };

            ImportRequest resourceFilterValueRequest = resourceFilterValue.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(resourceFilterValueRequest));
        }
    }
}