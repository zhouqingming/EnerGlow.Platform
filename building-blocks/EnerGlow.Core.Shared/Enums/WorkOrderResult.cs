using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared
{
    /// <summary>
    /// 处理结果（0：正常 1：异常）
    /// </summary>
    public enum WorkOrderResult
    {
        /// <summary>
        /// 正常
        /// </summary>
        [Description("正常")]
        Normal = 0,

        /// <summary>
        /// 异常
        /// </summary>
        [Description("异常")]
        Exception = 1,
    }
}
