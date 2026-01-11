using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 统计类型（0：电度  1：标准煤）
    /// </summary>
    public enum StatisticsType
    {
        /// <summary>
        /// 电度
        /// </summary>
        [Description("电度")]
        ElecDegree = 0,

        /// <summary>
        /// 标准煤
        /// </summary>
        [Description("标准煤")]
        StandardCoal = 1
    }
}
