using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 对比方式 1本期 2同比 3环比
    /// </summary>
    public enum ContrastModeEnum
    {
        /// <summary>
        /// 本期
        /// </summary>
        [Description("本期")]
        Current = 1,
        /// <summary>
        /// 同比
        /// </summary>
        [Description("同比")]
        ComparedPrevious =2,
        /// <summary>
        /// 环比
        /// </summary>
        [Description("环比")]
        ChainRatio =3,
    }
}
