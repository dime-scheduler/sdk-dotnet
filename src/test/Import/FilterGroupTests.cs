﻿using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.Tests.Import
{
    public partial class FilterGroupTests
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
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Append);

            Assert.True(importRequest.ParameterNames[1] == "GroupName");
            Assert.True(importRequest.ParameterValues[1] == "Group 1");
        }

        [Fact]
        public void FilterGroup_Append_Validate_HasIncompleteRequiredAttributes_ShouldThrowException()
        {
            FilterGroup model = new() { ColumnNo = 1 };
            Assert.Throws<Exception>(() => model.ToImportRequest(TransactionType.Append));
        }

        [Fact]
        public void FilterGroup_Delete_Validate_HasRequiredAttributes_ShouldSucceed()
        {
            FilterGroup model = new() { Name = "Group 1" };
            ImportRequest importRequest = model.ToImportRequest(TransactionType.Delete);

            Assert.True(importRequest.ParameterNames[0] == "GroupName");
            Assert.True(importRequest.ParameterValues[0] == "Group 1");
        }

        [Fact]
        public void FilterGroup_Delete_Validate_MissingRequiredAttributes_ShouldThrowException()
        {
            FilterGroup model = new();
            Assert.Throws<Exception>(() => model.ToImportRequest(TransactionType.Delete));
        }

        [Fact]
        public void FilterGroup_ToImportRequest_InvalidTransactionType_ShouldThrowArgumentOutOfRangeException()
            => ToImportRequestTestUtils.TestToInvalidImportRequest<FilterGroup>();
    }
}