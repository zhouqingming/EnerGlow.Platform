using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// Rdb数据类型（1: DT_DIGITAL 2：DT_INT32  3：DT_FLOAT32 4：DT_INT64 5：DT_FLOAT64）
    /// </summary>
    public enum RdbDataType
    {
        /// <summary>
        /// 开关量,4字节整数
        /// </summary>
        [Description("开关量")]
        DT_DIGITAL = 1,

        /// <summary>
        /// 4字节整数
        /// </summary>
        [Description("4字节整数")]
        DT_INT32 = 2,

        /// <summary>
        /// 4字节浮点数
        /// </summary>
        [Description("4字节浮点数")]
        DT_FLOAT32 = 3,

        /// <summary>
        /// 8字节整数
        /// </summary>
        [Description("8字节整数")]
        DT_INT64 = 4,

        /// <summary>
        /// 8字节浮点数
        /// </summary>
        [Description("8字节浮点数")]
        DT_FLOAT64 = 5,
    }
}
