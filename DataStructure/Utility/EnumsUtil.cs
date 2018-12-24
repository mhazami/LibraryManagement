using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;


namespace LibraryManagement.DataStructure.Utility
{
    public static class EnumsUtil
    {
        public static string GetDescription(this Enum enumValue)
        {
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                .GetName();
        }
    }
}
