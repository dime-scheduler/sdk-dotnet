using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Dime.Scheduler.Sdk.Import
{
    internal static class ImportRequestExtensions
    {
        internal static ImportParameter[] CreateParameters(this IImportRequestable import, TransactionType type)
            => import.CreateParametersCollection(type).ToArray();

        private static IEnumerable<ImportParameter> CreateParametersCollection(this IImportRequestable import, TransactionType type)
        {
            IEnumerable<PropertyInfo> importParameters = import.GetType().GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(ImportParameterAttribute)));
            foreach (PropertyInfo parameter in importParameters)
            {
                ImportParameterAttribute attrs = parameter.GetCustomAttribute<ImportParameterAttribute>();

                if (!attrs.ShouldInclude(type))
                    continue;

                object objValue = parameter.GetValue(import);
                if (objValue != null)
                    yield return new(attrs.Name, Parse(objValue));
            }
        }

        private static string Parse(object objValue)
            => objValue switch
            {
                bool b => b.ToString(),
                DateTime dt => dt.ToString("s"),
                IEnumerable<string> enumerable => string.Join(";", enumerable),
                _ => objValue?.ToString()
            };
    }
}