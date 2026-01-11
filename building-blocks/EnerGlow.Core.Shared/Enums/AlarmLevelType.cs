using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    ///  报警级别类型(0:非常严重  1:严重  2:普通  3:轻微  4:正常)
    /// </summary>
    public enum AlarmLevelType
    {

        /// <summary>
        /// 非常严重
        /// </summary>
        [Description("非常严重")]
        VerySerious = 0,

        /// <summary>
        /// 严重
        /// </summary>
        [Description("严重")]
        Serious = 1,

        /// <summary>
        /// 普通
        /// </summary>
        [Description("普通")]
        General = 2,

        /// <summary>
        /// 轻微
        /// </summary>
        [Description("轻微")]
        Slight = 3,

        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")]
        Normal = 4
    }
}
