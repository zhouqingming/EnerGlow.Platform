using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 处理状态(0: 待处理 1：处理中 2：已处理)
    /// </summary>
    public enum WorkOrderStatus
    {

        /// <summary>
        /// 待处理
        /// </summary>
        [Description("待处理")]
        WaitHandle = 0,

        /// <summary>
        /// 处理中
        /// </summary>
        [Description("处理中")]
        InHand = 1,

        /// <summary>
        /// 已处理
        /// </summary>
        [Description("已处理")]
        Handled = 2

    }
}
