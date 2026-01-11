using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// Code的类型：1：分户；2：负荷类型；3：地铁评价指标；4：工序CODE；5：区域CODE；6:车间
    /// </summary>
    public enum DevRelateType
    {

        /// <summary>
        /// 分户
        /// </summary>
        [Description("分户")]
        FenHu = 1,

        /// <summary>
        /// 负荷类型
        /// </summary>
        [Description("负荷类型")]
        LoadKind = 2,

        /// <summary>
        /// 地铁评价指标
        /// </summary>
        [Description("地铁评价指标")]
        SubwayIndicator = 3,

        /// <summary>
        /// 工序
        /// </summary>
        [Description(" 工序")]
        Workstage = 4,

        /// <summary>
        /// 区域
        /// </summary>
        [Description("区域")]
        Region = 5,

        /// <summary>
        /// 车间
        /// </summary>
        [Description("车间")]
        WorkShop = 6,

    }
}
