using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 区域类型（0：厂区  1：电房  2：车间  3：中央空调）
    /// </summary>
    public enum AreaCategory
    {

        /// <summary>
        /// 厂区
        /// </summary>
        [Description("厂区")]
        Factory = 0,

        /// <summary>
        /// 电房
        /// </summary>
        [Description("电房")]
        ElecRoom = 1,

        /// <summary>
        /// 车间
        /// </summary>
        [Description("车间")]
        Workshop = 2,

        /// <summary>
        /// 空调机房
        /// </summary>
        [Description("空调机房")]
        AirConditioner = 3,

        /// <summary>
        /// 工艺
        /// </summary>
        [Description("工艺")]
        Technology = 4

    }
}
