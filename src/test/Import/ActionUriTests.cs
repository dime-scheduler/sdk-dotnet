﻿using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.Tests.Import
{
    public partial class ActionUriTests
    {
        [Fact]
        public void ActionUri_ToImportRequest_Append_AllShouldMapParameters()
        {
            ActionUri model = new()
            {
                SourceApp = "BC001",
                SourceType = "BC001",
                UriType = UriType.PlanningBoard,
                Uri = "https://www.google.com",
                Description = "Hello world",
                Default = true
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);

            importRequest.AssertStoredProcedureName("mboc_upsertActionUrl");
            importRequest.AssertEqualParameterCollectionCount();
            importRequest.AssertParameterCount(7);
        }

        [Fact]
        public void ActionUri_ToImportRequest_Delete_ShouldThrowException()
        {
            ActionUri model = new()
            {
                SourceApp = "BC001",
                SourceType = "BC001",
                UriType = UriType.PlanningBoard,
                Uri = "https://www.google.com",
                Description = "Hello world",
                Default = true
            };

            model.ShouldNotCreateImportRequest(TransactionType.Delete);
        }
    }
}