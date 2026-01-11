using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EnerGlow.Core.Shared
{

    /// <summary>
    /// 服务状态(0:就绪  1:运行  2:异常  3：停止)
    /// </summary>
    public enum ServiceStatus
    {

        /// <summary>
        /// 就绪
        /// </summary>
        [Description("就绪")]
        Ready = 0,

        /// <summary>
        /// 运行
        /// </summary>
        [Description("运行")]
        Running = 1,

        /// <summary>
        /// 异常
        /// </summary>
        [Description("异常")]
        Exception = 2,

        /// <summary>
        /// 停止
        /// </summary>
        [Description("停止")]
        Stop = 3

    }
}
