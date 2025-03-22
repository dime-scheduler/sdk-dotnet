using Dime.Scheduler.Requests;
using Xunit;

namespace Dime.Scheduler.Tests
{
    public partial class SorterTests
    {
        [Fact]
        public void Sorter_Asc_Build_ShouldCreateExtSorter()
        {
            string sorter = new Sorter<Customer>()
                .WithProperty(x => x.Name)
                .WithAscendingOrder()
                .ToString();

            string sorterValue = "{'direction':'ASC','property':'Name'}";
            Assert.True(sorter == sorterValue);
        }

        [Fact]
        public void Sorter_Desc_Build_ShouldCreateExtSorter()
        {
            string sorter = new Sorter<Customer>()
                .WithProperty(x => x.Name)
                .WithDescendingOrder()
                .ToString();

            const string sorterValue = "{'direction':'DESC','property':'Name'}";
            Assert.True(sorter == sorterValue);
        }

        [Fact]
        public void Sorters_ToString_ShouldCreateJsonArray()
        {
            Sorter<Customer> sorter1 = new Sorter<Customer>()
                .WithProperty(x => x.Name)
                .WithAscendingOrder();

            Sorter<Customer> sorter2 = new Sorter<Customer>()
                .WithProperty(x => x.Name)
                .WithDescendingOrder();

            Sorters<Customer> sorterList = new() { sorter1, sorter2 };

            const string expectedValue = "[{'direction':'ASC','property':'Name'},{'direction':'DESC','property':'Name'}]";
            string sorterJsonArray = sorterList.ToString();
            Assert.True(sorterJsonArray == expectedValue);
        }
    }
}