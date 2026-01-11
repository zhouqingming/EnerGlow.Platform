using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 状态类型(0:正常使用 1:停用)
    /// </summary>
    public enum StatusNType
    {

        /// <summary>
        /// 正常使用
        /// </summary>
        [Description("正常使用")]
        Enabled = 0,

        /// <summary>
        /// 停用
        /// </summary>
        [Description("停用")]
        Disable = 1

    }
}
