using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 认证状态类型(-1:认证失败  0:认证中  1:认证通过)
    /// </summary>
    public enum AuthStatusType
    {

        /// <summary>
        /// 认证失败
        /// </summary>
        [Description("认证失败")]
        Failure = -1,

        /// <summary>
        /// 认证中
        /// </summary>
        [Description("认证中")]
        Process = 0,

        /// <summary>
        /// 认证通过
        /// </summary>
        [Description("认证通过")]
        Success = 1,
    }
}
