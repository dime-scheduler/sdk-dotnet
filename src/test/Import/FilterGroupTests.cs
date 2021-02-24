using System;
using System.Collections.Generic;
using Dime.Scheduler.Sdk.Import;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public class FilterGroupTests
    {
        [Fact]
        public void FilterGroup_ToImportRequest_Append_AllShouldMapParameters()
        {
            FilterGroup model = new()
            {
                Name = "Name",
                ColumnNo = 1,
                DataFilter = true,
                Id = 1
            };

            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);
            importRequest.AssertEqualParameterCollectionCount();
        }

        [Fact]
        public void FilterGroup_Append_Validate_HasRequiredAttributes_ShouldSucceed()
        {
            FilterGroup model = new() { Name = "Group 1" };
            ImportRequest importRequest = ((IImportRequestable)model).ToImportRequest(TransactionType.Append);

            Assert.True(importRequest.ParameterNames[1] == "GroupName");
            Assert.True(importRequest.ParameterValues[1] == "Group 1");
        }

        [Fact]
        public void FilterGroup_Append_Validate_HasIncompleteRequiredAttributes_ShouldThrowException()
        {
            FilterGroup model = new() { ColumnNo = 1 };
            Assert.Throws<Exception>(() => ((IImportRequestable)model).ToImportRequest(TransactionType.Append));
        }

        [Fact]
        public void FilterGroup_Delete_Validate_HasRequiredAttributes_ShouldSucceed()
        {
            FilterGroup model = new() { Name = "Group 1" };
            ImportRequest importRequest = ((IImportRequestable)model).ToImportRequest(TransactionType.Delete);

            Assert.True(importRequest.ParameterNames[0] == "GroupName");
            Assert.True(importRequest.ParameterValues[0] == "Group 1");
        }

        [Fact]
        public void FilterGroup_Delete_Validate_MissingRequiredAttributes_ShouldThrowException()
        {
            FilterGroup model = new();
            Assert.Throws<Exception>(() => ((IImportRequestable)model).ToImportRequest(TransactionType.Delete));
        }
    }
}