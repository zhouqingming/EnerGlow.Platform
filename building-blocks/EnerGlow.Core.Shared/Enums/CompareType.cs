using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 比较类型(同比，环比)
    /// </summary>
    public enum CompareType
    {
        /// <summary>
        /// 不比较
        /// </summary>
        [Description("不比较")]
        NoErlier = 0,
        /// <summary>
        /// 同比
        /// </summary>
        [Description("同比")]
        YearErlier = 1,

        /// <summary>
        /// 环比
        /// </summary>
        [Description("环比")]
        MonthErlier = 2,

        /// <summary>
        /// 环比和同比
        /// </summary>
        [Description("环比和同比")]
        AllErlier = 3,
    }
}
