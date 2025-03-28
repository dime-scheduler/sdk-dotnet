﻿using System;
using Dime.Scheduler.Entities;
using Xunit;

namespace Dime.Scheduler.Tests.Import
{
    internal static class ToImportRequestTestUtils
    {
        internal static void TestToInvalidImportRequest<T>() where T : IImportEntity, new()
        {
            T model = new();
            Assert.Throws<ArgumentOutOfRangeException>(() => model.ToImportRequest((TransactionType)42));
        }
    }
}