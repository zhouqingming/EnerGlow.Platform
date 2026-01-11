using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 窗帘控制功能类型
    /// </summary>
    public enum CurtainFunctionType
    {
        /// <summary>
        /// 窗帘急停
        /// </summary>
        [Description("急停")]
        CurtainEmergencyStopStateSet = 1,

        /// <summary>
        /// 窗帘模式选择
        /// 0:表示窗帘全开;1:表示窗帘半开;2:表示窗帘全关
        /// </summary>
        [Description("模式选择")]
        CurtainModeSelectionSet = 2,

        /// <summary>
        /// 全开时间
        /// </summary>
        [Description("全开时间")]
        CurtainAllOpenTimeGet = 3,

        /// <summary>
        /// 半开时间
        /// </summary>
        [Description("半开时间")]
        CurtainHalfOpenTimeGet = 4,

        /// <summary>
        /// 全关时间
        /// </summary>
        [Description("全关时间")]
        CurtainAllCloseTimeGet = 5,

        /// <summary>
        /// 半关时间
        /// </summary>
        [Description("半关时间")]
        CurtainHalfCloseTimeSet = 6,

        /// <summary>
        /// 全开标志位
        /// </summary>
        [Description("全开标志位")]
        CurtainAllOpenStateSet = 7,

        /// <summary>
        /// 全关标志位
        /// </summary>
        [Description("全关标志位")]
        CurtainAllCloseStateSet = 8,

        /// <summary>
        /// 半开标志位
        /// </summary>
        [Description("半开标志位")]
        CurtainHalfOpenStateSet = 9,
    }
}
