using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 工作流状态类型（0：起始状态 1：中间状态 2：结束状态）
    /// </summary>
    public enum WorkflowStateType
    {

        /// <summary>
        /// 起始状态
        /// </summary>
        [Description("起始状态")]
        Start = 0,

        /// <summary>
        /// 中间状态
        /// </summary>
        [Description("中间状态")]
        Middle = 1,

        /// <summary>
        /// 结束状态
        /// </summary>
        [Description("结束状态")]
        End = 2

    }
}
