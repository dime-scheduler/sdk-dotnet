using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.Tests.Import
{
    internal static class ImportRequestableTestHelpers
    {
        internal static ImportRequest ToImportRequest(this IImportRequestable model, TransactionType transactionType)
            => model.ToImportRequest(transactionType);

        internal static void ShouldNotCreateImportRequest(this IImportRequestable model, TransactionType transactionType)
            => Assert.Throws<NotImplementedException>(() => model.ToImportRequest(transactionType));

        internal static void AssertStoredProcedureName(this ImportRequest request, string storedProcedureName)
            => Assert.True(request.StoredProcedureName == storedProcedureName);

        internal static void AssertEqualParameterCollectionCount(this ImportRequest request)
            => Assert.True(request.ParameterNames.Length == request.ParameterValues.Length);

        internal static void AssertParameterCount(this ImportRequest request, int length)
            => Assert.True(request.ParameterNames.Length == length && request.ParameterValues.Length == length);
    }
}