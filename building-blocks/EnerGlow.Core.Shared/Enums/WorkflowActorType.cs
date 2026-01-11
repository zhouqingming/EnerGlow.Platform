using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 工作流参与者类型（1：用户 2：角色）
    /// </summary>
    public enum WorkflowActorType
    {

        /// <summary>
        /// 用户
        /// </summary>
        [Description("用户")]
        User = 1,

        /// <summary>
        /// 角色
        /// </summary>
        [Description("角色")]
        Role = 2

    }
}
