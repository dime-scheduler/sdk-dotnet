using System.Collections.Generic;
using Xunit;

namespace Dime.Scheduler.Sdk.Tests
{
    public class FilterTests
    {
        [Fact]
        public void Filter_Build_ShouldCreateExtFilter()
        {
            string filter = new Filter<Customer>()
                .WithOperator(Operator.Eq)
                .WithProperty(x => x.Name)
                .WithValue("Handsome B. Wonderful")
                .ToString();

            string filterValue = "{ 'operator':'==','value':Handsome B. Wonderful,'property':'Name'}";
            Assert.True(filter == filterValue);
        }

        [Fact]
        public void Filters_ToString_ShouldCreateJsonArray()
        {
            Filter<Customer> filter1 = new Filter<Customer>()
                .WithOperator(Operator.Eq)
                .WithProperty(x => x.Name)
                .WithValue("Handsome B. Wonderful");

            Filter<Customer> filter2 = new Filter<Customer>()
                .WithOperator(Operator.Eq)
                .WithProperty(x => x.Name)
                .WithValue("Max Power");

            Filter<Customer> filter3 = new Filter<Customer>()
                .WithOperator(Operator.Eq)
                .WithProperty(x => x.Name)
                .WithValue("Handsome B. Wonderful");

            Filters<Customer> filterList = new Filters<Customer>() { filter1, filter2, filter3 };

            const string expectedValue =
                "[{ 'operator':'==','value':Handsome B. Wonderful,'property':'Name'},{ 'operator':'==','value':Max Power,'property':'Name'},{ 'operator':'==','value':Handsome B. Wonderful,'property':'Name'}]";
            string filterJsonArray = filterList.ToString();
            Assert.True(filterJsonArray == expectedValue);
        }
    }
}