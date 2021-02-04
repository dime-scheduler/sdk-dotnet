using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Dime.Scheduler.Sdk.Samples
{
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
}