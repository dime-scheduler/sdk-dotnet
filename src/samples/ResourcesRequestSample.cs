using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace Dime.Scheduler.Sdk.Samples
{
    public enum Operator
    {
        [Description("==")]
        Eq
    }

    public class Filters<T> : List<Filter<T>>
    {
        public override string ToString()
        {
            string filtersString = string.Join(',', this.Select(x => x.ToString()));
            return $"[{filtersString}]";
        }
    }

    public class Filter<T>
    {
        private Operator _oper;
        private object _val;
        private string _property;

        public Filter<T> WithOperator(Operator oper)
        {
            _oper = oper;
            return this;
        }

        public Filter<T> WithValue<TVal>(TVal val)
        {
            _val = val;
            return this;
        }

        public Filter<T> WithProperty<TProperty>(Expression<Func<T, TProperty>> propertyLambda)
        {
            MemberExpression member = (MemberExpression)propertyLambda.Body;
            _property = member.Member.Name;
            return this;
        }

        public override string ToString()
            => $"{{ 'operator':'{_oper.GetDescription()}','value':{_val},'property':'{_property}'}}";
    }

    public static class EnumExtensions
    {
        public static string GetDescription<T>(this T enumerationValue) where T : struct
        {
            Type type = enumerationValue.GetType();
            if (!type.GetTypeInfo().IsEnum)
                throw new ArgumentException($"Value must be of enum type: {enumerationValue}", nameof(enumerationValue));

            // Tries to find a DescriptionAttribute for a potential friendly name for the enum
            MemberInfo[] memberInfo = type.GetMember(enumerationValue.ToString());
            if (memberInfo.Length <= 0)
                return enumerationValue.ToString();

            object[] attributes = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Any()
                ? ((DescriptionAttribute)attributes.ElementAt(0)).Description
                : enumerationValue.ToString();
        }
    }

    public class ResourcesRequestSample
    {
        public async Task Execute()
        {
            try
            {
                IAuthenticator authenticator = new FormsAuthenticator
                (DimeSchedulerCredentials.Uri,
                    DimeSchedulerCredentials.User,
                    DimeSchedulerCredentials.Password);

                DimeSchedulerClient client = new(DimeSchedulerCredentials.Uri, authenticator);

                Filter<Resource> resourceFilter = new Filter<Resource>()
                    .WithOperator(Operator.Eq)
                    .WithProperty(x => x.ExchangeIntegrationEnabled)
                    .WithValue(true);

                string filter = new Filters<Resource> { resourceFilter }.ToString();
                IResourceEndpoint svc = await client.Resources.Request();
                IEnumerable<Resource> resources = await svc.GetAsync(new ResourceRequest { filter = filter });

                foreach (Resource resource in resources)
                    Console.WriteLine(resource.Email);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}