﻿using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.Tests.Import
{
    public partial class TaskLockedTests
    {
        [Fact]
        public void TaskLocked_ToImportRequest_Append_AllShouldMapParameters()
        {
            TaskLocked model = new()
            {
                SentFromBackOffice = true,
                JobNo = "TEXT",
                SourceApp = "TEXT",
                SourceType = "TEXT",
                TaskNo = "TEXT",
                Locked = true
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }
    }
}