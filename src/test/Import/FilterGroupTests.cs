using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class FilterGroupTests
    {
        [Fact]
        public void FilterGroup_Append_Validate_HasRequiredAttributes_ShouldSucceed()
        {
            FilterGroup model = new FilterGroup { Name = "Group 1" };
            ImportRequest importRequest = (model as IImportRequestable).ToImportRequest(TransactionType.Append);

            Assert.True(importRequest.ParameterNames[1] == "GroupName");
            Assert.True(importRequest.ParameterValues[1] == "Group 1");
        }

        [Fact]
        public void FilterGroup_Append_Validate_HasIncompleteRequiredAttributes_ShouldThrowException()
        {
            FilterGroup model = new FilterGroup { ColumnNo = 1 };
            Assert.Throws<Exception>(() => (model as IImportRequestable).ToImportRequest(TransactionType.Append));
        }

        [Fact]
        public void FilterGroup_Delete_Validate_HasRequiredAttributes_ShouldSucceed()
        {
            FilterGroup model = new FilterGroup { Name = "Group 1" };
            ImportRequest importRequest = (model as IImportRequestable).ToImportRequest(TransactionType.Delete);

            Assert.True(importRequest.ParameterNames[0] == "GroupName");
            Assert.True(importRequest.ParameterValues[0] == "Group 1");
        }

        [Fact]
        public void FilterGroup_Delete_Validate_MissingRequiredAttributes_ShouldThrowException()
        {
            FilterGroup model = new FilterGroup();
            Assert.Throws<Exception>(() => (model as IImportRequestable).ToImportRequest(TransactionType.Delete));
        }
    }
}