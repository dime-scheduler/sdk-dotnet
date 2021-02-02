using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Dime.Scheduler.Sdk.Import
{
    internal static class ImportRequestExtensions
    {
        internal static ImportParameter[] CreateParameters<T>(this IImportRequestable import, TransactionType type) 
            => import.CreateParametersCollection<T>(type).ToArray();

        private static IEnumerable<ImportParameter> CreateParametersCollection<T>(this IImportRequestable import, TransactionType type)
        {
            IEnumerable<PropertyInfo> importParameters = typeof(T).GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(ImportParameterAttribute)));
            foreach (PropertyInfo parameter in importParameters)
            {
                ImportParameterAttribute attrs = parameter.GetCustomAttribute<ImportParameterAttribute>();

                if (!attrs.ShouldInclude(type))
                    continue;

                object objValue = parameter.GetValue(import);
                yield return new(attrs.Name, Parse(objValue));
            }
        }

        private static string Parse(object objValue)
            => objValue switch
            {
                bool b => b.ToBit().ToString(),
                DateTime dt => dt.ToString("s"),
                _ => objValue?.ToString()
            };
    }
}