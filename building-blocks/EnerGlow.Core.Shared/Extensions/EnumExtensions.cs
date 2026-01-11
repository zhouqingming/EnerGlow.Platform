using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 枚举扩展方法
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// 获取枚举的DescriptionAttribute属性
        /// </summary>
        /// <param name="enumeration"></param>
        /// <returns></returns>
        public static string ToDescriptionName(this Enum enumeration)
        {
            var type = enumeration.GetType();
            var memInfo = type.GetMember(enumeration.ToString());
            if (memInfo.Length > 0)
            {
                var attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }
            return enumeration.ToString();
        }

        public static Dictionary<int, string> ToDictionary(this Enum enumeration)
        {
            var list = (from Enum d in Enum.GetValues(enumeration.GetType())
                        select new
                        {
                            ID = (int)Enum.Parse(enumeration.GetType(), Enum.GetName(enumeration.GetType(), d)),
                            Name = d.ToString()
                        }
                     ).ToList();
            return list.ToDictionary(c => c.ID, c => c.Name);
        }

        public static Dictionary<int, string> ToDictionary(this Type enumType)
        {
            if (enumType.BaseType != typeof(Enum))
            {
                throw new ArgumentOutOfRangeException("T只能是Enum类型");
            }
            var list = (from Enum d in Enum.GetValues(enumType)
                        select new
                        {
                            ID = (int)Enum.Parse(enumType, Enum.GetName(enumType, d)),
                            Name = d.ToDescriptionName()
                        }
                     ).ToList();
            return list.ToDictionary(c => c.ID, c => c.Name);
        }

        public static int GetMax(this Enum enumeration)
        {
            return Enum.GetValues(enumeration.GetType()).Cast<int>().Max();
        }

        /// <summary>
        /// 根据Description获取枚举
        /// </summary>
        /// <typeparam name="T">枚举类型</typeparam>
        /// <param name="description">枚举描述</param>
        /// <returns></returns>
        public static T GetEnum<T>(string description)
        {
            var fields = typeof(T).GetFields();
            foreach (var field in fields)
            {
                var descAarry = field.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
                if (descAarry != null && descAarry.Length > 0)
                {
                    if (descAarry[0].Description == description)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == description)
                        return (T)field.GetValue(null);
                }
            }
            throw new ArgumentException(string.Format("[{0}] 未能找到对应的枚举.", description), "Description");
        }

    }
}
