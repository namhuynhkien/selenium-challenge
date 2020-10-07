using System;
using System.ComponentModel;

namespace SeleniumChallenge.Helpers
{
    public static class EnumExtensions
    {
        public static string GetDescription<T>(this T enumValue)
        {
            var type = enumValue.GetType();
            if (!type.IsEnum)
            {
                throw new ArgumentException(string.Format("{0} must be of Enum type", type.Name));
            }
            var memberInfo = type.GetMember(enumValue.ToString());
            if (memberInfo.Length > 0)
            {
                var attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            return enumValue.ToString();
        }
    }
}