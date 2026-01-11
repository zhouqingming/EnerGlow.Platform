using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 工作流执行类型（-1：已执行 0：正在执行 1：未执行）
    /// </summary>
    public enum WorkflowExcutiveType
    {

        /// <summary>
        /// 已执行
        /// </summary>
        [Description("已执行")]
        Executed = -1,

        /// <summary>
        /// 正在执行
        /// </summary>
        [Description("正在执行")]
        Executing = 0,

        /// <summary>
        /// 未执行
        /// </summary>
        [Description("未执行")]
        Nonexecution = 1

    }
}
