﻿using t = System.Threading.Tasks;
using Dime.Scheduler.Sdk.Import;

namespace Dime.Scheduler.Sdk.Tests
{
    internal static class DimeScheduler
    {
        internal const string Url = "http://ds-vnext-test.azurewebsites.net/";
        internal const string User = "hendrik@dimescheduler.com";
        internal const string Password = "Admin!1";


        internal static async t.Task<bool> DoImportRequest(ImportRequest importRequest, TransactionType transaction = TransactionType.Append)
        {
            DimeSchedulerClient client = new(Url, new FormsAuthenticator(Url, User, Password));
            IImportEndpoint importEndpoint = await client.Import.Request();

            ImportSet result = await importEndpoint.ProcessAsync(importRequest, transaction);
            return result.Success;
        }
    }
}