using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 工作流处理类型（0：退回 1：同意）
    /// </summary>
    public enum WorkflowHandleType
    {

        /// <summary>
        /// 退回
        /// </summary>
        [Description("退回")]
        SendBack = 0,

        /// <summary>
        /// 同意
        /// </summary>
        [Description("同意")]
        Agree = 1

    }
}
