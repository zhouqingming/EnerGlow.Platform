using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 工作流活动类型（0：进入动作 1：退出动作 2：自动流转动作）
    /// </summary>
    public enum WorkflowActionType
    {

        /// <summary>
        /// 进入动作
        /// </summary>
        [Description("进入动作")]
        EntryAction = 0,

        /// <summary>
        /// 退出动作
        /// </summary>
        [Description("退出动作")]
        ExitAction = 1,

        /// <summary>
        /// 自动流转动作
        /// </summary>
        [Description("自动流转动作")]
        AutoFlowAction = 2

    }
}
