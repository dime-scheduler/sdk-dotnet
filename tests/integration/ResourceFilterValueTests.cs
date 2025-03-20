﻿using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.IntegrationTests
{
    public partial class ResourceFilterValueTests
    {
        [Fact]
        public async System.Threading.Tasks.Task ResourceFilterValue()
        {
            ResourceFilterValue model = new()
            {
                FilterGroup = "GROUP",
                FilterValue = "VALUE",
                ResourceNo = "NO",
                SourceApp = "APP",
                SourceType = "TYPE",
                TransferToTemp = true
            };
        }
    }
}