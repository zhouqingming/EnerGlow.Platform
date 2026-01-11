using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 设备分摊类型
    /// </summary>
    public enum DevShareType
    {
        /// <summary>
        /// 静态分配
        /// </summary>
        [Description("静态分配")]
        StaticShare = 1,
        /// <summary>
        /// 按压缩空气用量分配
        /// </summary>
        [Description("按压缩空气用量分配")]
        AirShare = 2,

        /// <summary>
        /// 按冷冻水使用量分配
        /// </summary>
        [Description("按冷冻水使用量分配")]
        FwaterShare = 3,

        /// <summary>
        /// 按水的使用量分配
        /// </summary>
        [Description("按水的使用量分配")]
        WaterShare = 4,
    }
}
