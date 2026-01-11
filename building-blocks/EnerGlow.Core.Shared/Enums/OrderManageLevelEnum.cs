using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 工单级别 1普通2严重
    /// </summary>
    public enum OrderManageLevelEnum
    {
        /// <summary>
        /// 1一般
        /// </summary>
        [Description("一般")]
        Commonly = 1,
        /// <summary>
        /// 2普通
        /// </summary>
        [Description("普通")]
        Ordinary = 2,
        /// <summary>
        ///3严重
        /// </summary>
        [Description("严重")]
        Serious = 3
    }
}
