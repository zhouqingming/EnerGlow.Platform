using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 接受对象类型(0:角色 1:用户)
    /// </summary>
    public enum WorkOrderAcceptObjType
    {

        /// <summary>
        /// 角色
        /// </summary>
        [Description("角色")]
        Role = 0,

        /// <summary>
        /// 用户
        /// </summary>
        [Description("用户")]
        User = 1,

    }
}
