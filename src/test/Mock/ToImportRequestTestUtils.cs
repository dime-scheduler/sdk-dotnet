using System;
using Dime.Scheduler.Sdk.Models;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    internal static class ToImportRequestTestUtils
    {
        internal static void TestToInvalidImportRequest<T>() where T : IImportRequestable, new()
        {
            T model = new();
            Assert.Throws<ArgumentOutOfRangeException>(() => model.ToImportRequest((TransactionType)42));
        }
    }
}