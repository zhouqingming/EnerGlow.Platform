using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 库存处理类型（0：入库  1：出库 ）
    /// </summary>
    public enum RepertoryHandleType
    {

        /// <summary>
        /// 入库
        /// </summary>
        [Description("入库")]
        Input = 0,

        /// <summary>
        /// 出库
        /// </summary>
        [Description("出库")]
        Output = 1

    }
}
