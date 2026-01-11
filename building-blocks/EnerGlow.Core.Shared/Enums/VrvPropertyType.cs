using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 中央空调属性类型（0：建造信息 1：电气信息  2：转换  3：蒸发器信息  4：冷凝器信息）
    /// </summary>
    public enum VrvPropertyType
    {

        /// <summary>
        /// 建造信息
        /// </summary>
        [Description("建造信息")]
        BuildInfo = 0,

        /// <summary>
        /// 电气信息
        /// </summary>
        [Description("电气信息")]
        ElecInfo = 1,

        /// <summary>
        /// 转换
        /// </summary>
        [Description("转换")]
        Transform = 2,

        /// <summary>
        /// 蒸发器信息
        /// </summary>
        [Description("蒸发器信息")]
        Evaporator = 3,

        /// <summary>
        /// 冷凝器信息
        /// </summary>
        [Description("冷凝器信息")]
        Condenser = 4,

    }
}
