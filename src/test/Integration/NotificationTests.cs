using System;
using Dime.Scheduler.Sdk.Import;
using Xunit;
using t = System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Tests.Import
{
    public partial class NotificationTests
    {
        [Fact]
        public async t.Task Notification_Append_ShouldSucceed()
        {
            Notification notification = new() { Code = "N001", Date = DateTime.Now, Text = "Hello from SDK" };
            ImportRequest importRequest = notification.ToImportRequest(TransactionType.Append);
            Assert.True(await DimeScheduler.DoImportRequest(importRequest));
        }

        [Fact]
        public async t.Task Notification_Delete_ShouldSucceed()
        {
            Notification notification = new() { Code = "N001", Date = DateTime.Now, Text = "Hello from SDK" };
            ImportRequest importRequest = notification.ToImportRequest(TransactionType.Delete);
            Assert.True(await DimeScheduler.DoImportRequest(importRequest));
        }
    }
}